//***********************************************************************************
// KilnGod.PlotlyCharts
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: PlotlyChart.razor.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See License.txt for details.
//***********************************************************************************

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Buffers;
using System.IO;
using System.Text.Json.Nodes;
using KilnGod.PlotlyCharts.Diagnostics;
using KilnGod.PlotlyCharts.Interop;

namespace KilnGod.PlotlyCharts
{
    public partial class PlotlyChart : IAsyncDisposable
    {
        private const string JavaScriptModulePath = "./_content/KilnGod.PlotlyCharts/PlotlyCharting.js?v=1.0.0";

        private IJSObjectReference? _module;
        private bool _disposed;
        private long _interopRevision;
        private readonly object _updateGate = new();
        private Task _updateWorker = Task.CompletedTask;
        private UpdateRequest? _pendingUpdate;
        private readonly Queue<UpdateRequest> _losslessUpdates = new();
        private long _updateSequence;

        [Inject]
        public IJSRuntime jsRuntime { get; set; } = default!;

        public event Action<PlotlyChart>? PlotlyInitComplete;

        [Parameter]
        public string PlotlyId { get; set; } = Guid.NewGuid().ToString();

        /// <summary>
        /// Optional C#-side instrumentation for calls into the existing JavaScript
        /// module. Leave null for the normal zero-overhead path.
        /// </summary>
        [Parameter]
        public PlotlyInteropDiagnostics? InteropDiagnostics { get; set; }

        protected ElementReference _plotlyChartRef;

        public ElementReference PlotlyChartRef => _plotlyChartRef;

        // Retain the original public spelling for source compatibility.
        public bool IsWebAssembley => jsRuntime is IJSInProcessRuntime;

        public bool IsWebAssembly => IsWebAssembley;

        /// <summary>
        /// Initializes the browser module only after the component has rendered.
        /// OnAfterRenderAsync is not called during prerendering, so this boundary is
        /// safe for both Server and WebAssembly hosting.
        /// </summary>
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await base.OnAfterRenderAsync(firstRender);

            if (!firstRender || _disposed)
            {
                return;
            }

            _module = await jsRuntime.InvokeAsync<IJSObjectReference>(
                "import",
                JavaScriptModulePath);

            await InvokeVoidAsync(
                "initializePlotlyChart",
                PlotlyId,
                IsWebAssembly);

            PlotlyInitComplete?.Invoke(this);
        }

        public ValueTask SetValuePlotlyChart(string valueName, params object?[]? args)
        {
            return InvokeVoidAsync(
                "setValuePlotlyChart",
                PlotlyChartRef,
                valueName,
                args);
        }

        public ValueTask<T> GetValuePlotlyChart<T>(string valueName, params object?[]? args)
        {
            return InvokeAsync<T>(
                "getValuePlotlyChart",
                PlotlyChartRef,
                valueName,
                args);
        }

        /// <summary>
        /// Returns a bounded, read-only rendering snapshot for update-shape audits.
        /// This does not expose the Plotly model as a second C# chart model.
        /// </summary>
        public ValueTask<JsonObject?> GetPlotlyChartAuditState()
        {
            return InvokeAsync<JsonObject?>(
                "getPlotlyChartAuditState",
                PlotlyChartRef);
        }

        /// <summary>
        /// Measures one existing Plotly operation in the browser. This is intended for
        /// audit tooling; normal chart calls continue to use the generic adapter.
        /// </summary>
        public ValueTask<JsonObject?> MeasurePlotlyFunction(
            string functionName,
            params object?[]? args)
        {
            return InvokeAsync<JsonObject?>(
                "measureFunctionPlotlyChart",
                PlotlyChartRef,
                functionName,
                args);
        }

        /// <summary>
        /// Runs bounded browser-side Plotly purge/remove cycles for leak observation.
        /// The temporary plots are fully purged and removed before the call completes.
        /// </summary>
        public ValueTask<JsonObject?> MeasurePlotlyLifecycle(int cycles = 5)
        {
            return InvokeAsync<JsonObject?>(
                "measurePlotlyChartLifecycle",
                PlotlyChartRef,
                cycles);
        }

        /// <summary>
        /// Calls a Plotly chart function through the thin JavaScript adapter.
        /// </summary>
        public ValueTask SetFunctionPlotlyChart(string functionName, params object?[]? args)
        {
            if (IsCoalescedUpdate(functionName))
            {
                return EnqueueLatestChartUpdate(
                    "setFunctionPlotlyChart",
                    PlotlyChartRef,
                    functionName,
                    args);
            }

            if (IsLosslessUpdate(functionName))
            {
                return EnqueueLosslessChartUpdate(
                    "setFunctionPlotlyChart",
                    PlotlyChartRef,
                    functionName,
                    args);
            }

            return InvokeVoidAsync(
                "setFunctionPlotlyChart",
                PlotlyChartRef,
                functionName,
                args);
        }

        public ValueTask<T> GetFunctionPlotlyChart<T>(string functionName, params object?[]? args)
        {
            return InvokeAsync<T>(
                "getFunctionPlotlyChart",
                PlotlyChartRef,
                functionName,
                args);
        }

        /// <summary>
        /// Requests a Plotly resize through the existing adapter. Resize requests are
        /// latest-wins so responsive layouts cannot accumulate hidden asynchronous work.
        /// </summary>
        public ValueTask ResizePlotlyChart()
        {
            return EnqueueLatestChartUpdate(
                "resizePlotlyChart",
                PlotlyChartRef);
        }

        /// <summary>
        /// Calls a function on the browser-owned PlotlyBasis object.
        /// </summary>
        public ValueTask SetFunctionPlotlyBasis(string functionName, params object?[]? args)
        {
            return InvokeVoidAsync(
                "setFunctionPlotlyBasis",
                PlotlyChartRef,
                functionName,
                args);
        }

        public ValueTask<T> GetFunctionPlotlyBasis<T>(string functionName, params object?[]? args)
        {
            return InvokeAsync<T>(
                "getFunctionPlotlyBasis",
                PlotlyChartRef,
                functionName,
                args);
        }

        /// <summary>
        /// Sends numeric trace arrays as byte arrays through the adapter. The adapter
        /// reconstructs JavaScript typed arrays and invokes Plotly's existing restyle
        /// operation without creating one JavaScript number per point.
        /// </summary>
        public ValueTask RestyleNumericArrays(
            int traceIndex,
            PlotlyNumericArray? x = null,
            PlotlyNumericArray? y = null)
        {
            if (x is null && y is null)
            {
                throw new ArgumentException("At least one numeric array is required.");
            }

            if (x is not null && y is null)
            {
                // The JavaScript adapter treats missing trailing arguments as an
                // absent optional y field, so do not serialize three null/zero values.
                return EnqueueLatestChartUpdate(
                    "setFunctionPlotlyChartNumericArrays",
                    PlotlyChartRef,
                    traceIndex,
                    x.Bytes,
                    x.ElementType.ToString(),
                    x.ElementCount);
            }

            return EnqueueLatestChartUpdate(
                "setFunctionPlotlyChartNumericArrays",
                PlotlyChartRef,
                traceIndex,
                x?.Bytes,
                x?.ElementType.ToString(),
                x?.ElementCount ?? 0,
                y?.Bytes,
                y?.ElementType.ToString(),
                y?.ElementCount ?? 0);
        }

        /// <summary>
        /// Sends multiple one-dimensional numeric fields in one byte-oriented restyle
        /// call. This supports fields such as x/y/z, u/v, open/high/low/close, and
        /// scientific-series arrays without boxing each point as a JavaScript number.
        /// </summary>
        public ValueTask RestyleNumericFields(
            int traceIndex,
            IReadOnlyDictionary<string, PlotlyNumericArray> fields)
        {
            ArgumentNullException.ThrowIfNull(fields);
            if (fields.Count == 0)
            {
                throw new ArgumentException("At least one numeric field is required.", nameof(fields));
            }

            var payload = new Dictionary<string, PlotlyNumericArrayPayload>(
                fields.Count,
                StringComparer.Ordinal);
            foreach (var pair in fields)
            {
                ArgumentNullException.ThrowIfNull(pair.Value);
                payload.Add(pair.Key, pair.Value.ToPayload());
            }

            return EnqueueLatestChartUpdate(
                "setFunctionPlotlyChartNumericFields",
                PlotlyChartRef,
                traceIndex,
                payload);
        }

        /// <summary>
        /// Selects the measured numeric transport for the current host: the byte-field
        /// path for WebAssembly and the binary stream path for Server. The Server stream
        /// remains opt-in until its latest-wins queue integration is completed.
        /// </summary>
        public async ValueTask<int> RestyleNumericFieldsForHost(
            int traceIndex,
            IReadOnlyList<PlotlyNumericBinaryField> fields)
        {
            ArgumentNullException.ThrowIfNull(fields);
            if (fields.Count == 0)
            {
                throw new ArgumentException("At least one numeric field is required.", nameof(fields));
            }

            if (!IsWebAssembly)
            {
                return await RestyleNumericStream(traceIndex, fields);
            }

            var numericFields = new Dictionary<string, PlotlyNumericArray>(
                fields.Count,
                StringComparer.Ordinal);
            foreach (var field in fields)
            {
                ArgumentNullException.ThrowIfNull(field);
                numericFields.Add(field.Name, field.Values);
            }

            await RestyleNumericFields(traceIndex, numericFields);
            return -1;
        }

        /// <summary>
        /// Sends a row-major numeric matrix, such as heatmap or surface z values,
        /// through the byte-oriented restyle path.
        /// </summary>
        public ValueTask RestyleNumericMatrix(
            int traceIndex,
            string fieldName,
            PlotlyNumericArray values,
            int rows,
            int columns)
        {
            ArgumentException.ThrowIfNullOrEmpty(fieldName);
            ArgumentNullException.ThrowIfNull(values);
            if (rows <= 0 || columns <= 0 || checked(rows * columns) != values.ElementCount)
            {
                throw new ArgumentException("Matrix dimensions must match the numeric element count.");
            }

            var payload = new Dictionary<string, PlotlyNumericArrayPayload>(
                1,
                StringComparer.Ordinal)
            {
                [fieldName] = values.ToPayload()
            };

            return EnqueueLatestChartUpdate(
                "setFunctionPlotlyChartNumericFields",
                PlotlyChartRef,
                traceIndex,
                payload,
                fieldName,
                rows,
                columns);
        }

        /// <summary>
        /// Sends all numeric fields in one binary stream. This is an opt-in transport
        /// experiment for comparing stream-based interop with JSON and byte-array paths.
        /// The returned task owns the stream until JavaScript has consumed it.
        /// </summary>
        public ValueTask<int> RestyleNumericStream(
            int traceIndex,
            IReadOnlyList<PlotlyNumericBinaryField> fields)
        {
            var packetLength = PlotlyNumericBinaryPacket.GetByteCount(fields);
            var packet = ArrayPool<byte>.Shared.Rent(packetLength);
            try
            {
                PlotlyNumericBinaryPacket.Write(fields, packet.AsSpan(0, packetLength));
                var completion = EnqueueLatestChartUpdate(
                    () => InvokeNumericStreamAsync(traceIndex, packet, packetLength),
                    () => ArrayPool<byte>.Shared.Return(packet));
                return AwaitStreamCompletionAsync(completion, packetLength);
            }
            catch
            {
                ArrayPool<byte>.Shared.Return(packet);
                throw;
            }
        }

        private async ValueTask<int> AwaitStreamCompletionAsync(
            ValueTask completion,
            int packetLength)
        {
            await completion.ConfigureAwait(false);
            return packetLength;
        }

        private async ValueTask InvokeNumericStreamAsync(
            int traceIndex,
            byte[] packet,
            int packetLength)
        {
            using var stream = new MemoryStream(packet, 0, packetLength, writable: false, publiclyVisible: true);
            using var streamReference = new DotNetStreamReference(stream, leaveOpen: true);
            var diagnostics = InteropDiagnostics;
            var revision = Interlocked.Increment(ref _interopRevision);
            var allocatedBefore = PlotlyInteropMeasurementHelper.GetAllocatedBytes();
            var timer = PlotlyInteropMeasurementHelper.StartTimer();
            Exception? exception = null;
            try
            {
                await Module.InvokeVoidAsync(
                    "setFunctionPlotlyChartNumericStream",
                    PlotlyChartRef,
                    traceIndex,
                    streamReference);
            }
            catch (Exception ex)
            {
                exception = ex;
                throw;
            }
            finally
            {
                timer.Stop();
                if (diagnostics is { IsEnabled: true })
                {
                    diagnostics.Record(new PlotlyInteropMeasurement(
                        diagnostics.RunId,
                        PlotlyId,
                        revision,
                        "setFunctionPlotlyChartNumericStream",
                        PlotlyInteropCallKind.ChartUpdate,
                        3,
                        -1,
                        PlotlyInteropMeasurementHelper.GetAllocatedBytes() - allocatedBefore,
                        timer.Elapsed,
                        exception is null,
                        exception?.GetType().Name));
                }
            }
        }

        public async ValueTask DisposeAsync()
        {
            Task updateWorker;
            lock (_updateGate)
            {
                if (_disposed)
                {
                    return;
                }

                _disposed = true;
                _pendingUpdate?.TrySetCanceled();
                _pendingUpdate = null;
                while (_losslessUpdates.Count > 0)
                {
                    _losslessUpdates.Dequeue().TrySetCanceled();
                }
                updateWorker = _updateWorker;
            }

            // An update already executing in JavaScript cannot be forcefully stopped
            // by Blazor. Wait for it before purging the chart; pending superseded
            // updates have already been canceled and removed from the queue.
            await updateWorker.ConfigureAwait(false);

            if (_module is null)
            {
                return;
            }

            try
            {
                await InvokeVoidAsync("disposePlotlyChart", PlotlyChartRef);
            }
            catch (JSDisconnectedException)
            {
                // Expected when a Server circuit disconnects during teardown.
            }
            finally
            {
                try
                {
                    await _module.DisposeAsync();
                }
                catch (JSDisconnectedException)
                {
                    // Expected when the browser connection is already gone.
                }

                _module = null;
            }

            // Do not retain parent/component event subscribers after route navigation.
            PlotlyInitComplete = null;
        }

        private IJSObjectReference Module =>
            _module ?? throw new InvalidOperationException(
                "PlotlyChart JavaScript interop is not available until the component has rendered.");

        private ValueTask InvokeVoidAsync(string operation, params object?[] arguments)
        {
            var diagnostics = InteropDiagnostics;
            if (diagnostics is null || !diagnostics.IsEnabled)
            {
                return Module.InvokeVoidAsync(operation, arguments);
            }

            return InvokeMeasuredVoidAsync(diagnostics, operation, arguments);
        }

        private ValueTask EnqueueLatestChartUpdate(string operation, params object?[] arguments)
            => EnqueueChartUpdate(operation, coalescible: true, arguments);

        private ValueTask EnqueueLatestChartUpdate(
            Func<ValueTask> execute,
            Action release)
        {
            var request = new UpdateRequest(
                execute,
                release,
                Interlocked.Increment(ref _updateSequence));
            return EnqueueChartRequest(request, coalescible: true);
        }

        private ValueTask EnqueueLosslessChartUpdate(string operation, params object?[] arguments)
            => EnqueueChartUpdate(operation, coalescible: false, arguments);

        private ValueTask EnqueueChartUpdate(
            string operation,
            bool coalescible,
            params object?[] arguments)
        {
            var request = new UpdateRequest(
                operation,
                arguments,
                Interlocked.Increment(ref _updateSequence));
            return EnqueueChartRequest(request, coalescible);
        }

        private ValueTask EnqueueChartRequest(UpdateRequest request, bool coalescible)
        {
            lock (_updateGate)
            {
                if (_disposed)
                {
                    request.TrySetException(new ObjectDisposedException(nameof(PlotlyChart)));
                    return new ValueTask(request.Completion.Task);
                }

                if (coalescible)
                {
                    // Only one not-yet-started supersedable update is retained.
                    // Replacing it is safe because it has not crossed the JS boundary.
                    _pendingUpdate?.TrySetCanceled();
                    _pendingUpdate = request;
                }
                else
                {
                    // Trace-structure operations are lossless and must execute FIFO.
                    _losslessUpdates.Enqueue(request);
                }

                if (_updateWorker.IsCompleted)
                {
                    _updateWorker = DrainUpdatesAsync();
                }
            }

            return new ValueTask(request.Completion.Task);
        }

        private static bool IsCoalescedUpdate(string functionName) => functionName switch
        {
            "newPlot" or "react" or "update" or "restyle" or "relayout" or "animate" or
                "resizePlotlyChart" => true,
            _ => false
        };

        private static bool IsLosslessUpdate(string functionName) => functionName switch
        {
            "addTraces" or "deleteTraces" or "extendTraces" or "prependTraces" or
                "moveTrace" => true,
            _ => false
        };

        private async Task DrainUpdatesAsync()
        {
            while (true)
            {
                UpdateRequest? request;
                lock (_updateGate)
                {
                    var lossless = _losslessUpdates.Count > 0
                        ? _losslessUpdates.Peek()
                        : null;
                    if (_pendingUpdate is not null &&
                        (lossless is null || _pendingUpdate.Sequence < lossless.Sequence))
                    {
                        request = _pendingUpdate;
                        _pendingUpdate = null;
                    }
                    else if (lossless is not null)
                    {
                        request = _losslessUpdates.Dequeue();
                    }
                    else
                    {
                        request = null;
                    }
                }

                if (request is null)
                {
                    return;
                }

                try
                {
                    if (request.Execute is not null)
                    {
                        await request.Execute().ConfigureAwait(false);
                    }
                    else
                    {
                        await InvokeVoidAsync(request.Operation!, request.Arguments!)
                            .ConfigureAwait(false);
                    }
                    request.TrySetResult();
                }
                catch (Exception exception)
                {
                    request.TrySetException(exception);
                }
                finally
                {
                    request.ReleaseResources();
                }
            }
        }

        private ValueTask<T> InvokeAsync<T>(string operation, params object?[] arguments)
        {
            var diagnostics = InteropDiagnostics;
            if (diagnostics is null || !diagnostics.IsEnabled)
            {
                return Module.InvokeAsync<T>(operation, arguments);
            }

            return InvokeMeasuredAsync<T>(diagnostics, operation, arguments);
        }

        private async ValueTask InvokeMeasuredVoidAsync(
            PlotlyInteropDiagnostics diagnostics,
            string operation,
            object?[] arguments)
        {
            var revision = Interlocked.Increment(ref _interopRevision);
            var payloadBytes = PlotlyInteropMeasurementHelper.GetPayloadBytes(arguments);
            var allocatedBefore = PlotlyInteropMeasurementHelper.GetAllocatedBytes();
            var timer = PlotlyInteropMeasurementHelper.StartTimer();
            Exception? exception = null;

            try
            {
                await Module.InvokeVoidAsync(operation, arguments);
            }
            catch (Exception ex)
            {
                exception = ex;
                throw;
            }
            finally
            {
                timer.Stop();
                RecordMeasurement(diagnostics, operation, revision, arguments, payloadBytes,
                    allocatedBefore, timer.Elapsed, exception);
            }
        }

        private async ValueTask<T> InvokeMeasuredAsync<T>(
            PlotlyInteropDiagnostics diagnostics,
            string operation,
            object?[] arguments)
        {
            var revision = Interlocked.Increment(ref _interopRevision);
            var payloadBytes = PlotlyInteropMeasurementHelper.GetPayloadBytes(arguments);
            var allocatedBefore = PlotlyInteropMeasurementHelper.GetAllocatedBytes();
            var timer = PlotlyInteropMeasurementHelper.StartTimer();
            Exception? exception = null;

            try
            {
                return await Module.InvokeAsync<T>(operation, arguments);
            }
            catch (Exception ex)
            {
                exception = ex;
                throw;
            }
            finally
            {
                timer.Stop();
                RecordMeasurement(diagnostics, operation, revision, arguments, payloadBytes,
                    allocatedBefore, timer.Elapsed, exception);
            }
        }

        private void RecordMeasurement(
            PlotlyInteropDiagnostics diagnostics,
            string operation,
            long revision,
            object?[] arguments,
            long payloadBytes,
            long allocatedBefore,
            TimeSpan elapsed,
            Exception? exception)
        {
            var allocatedAfter = PlotlyInteropMeasurementHelper.GetAllocatedBytes();
            diagnostics.Record(new PlotlyInteropMeasurement(
                diagnostics.RunId,
                PlotlyId,
                revision,
                operation,
                PlotlyInteropMeasurementHelper.Classify(operation, arguments),
                arguments.Length,
                payloadBytes,
                Math.Max(0, allocatedAfter - allocatedBefore),
                elapsed,
                exception is null,
                exception?.GetType().Name));
        }

        private sealed class UpdateRequest
        {
            internal UpdateRequest(string operation, object?[] arguments, long sequence)
            {
                Operation = operation;
                Arguments = arguments;
                Sequence = sequence;
            }

            internal UpdateRequest(Func<ValueTask> execute, Action release, long sequence)
            {
                Execute = execute;
                _release = release;
                Sequence = sequence;
            }

            internal string? Operation { get; }

            internal object?[]? Arguments { get; }

            internal Func<ValueTask>? Execute { get; }

            private Action? _release;

            internal long Sequence { get; }

            internal TaskCompletionSource Completion { get; } =
                new(TaskCreationOptions.RunContinuationsAsynchronously);

            internal void TrySetResult() => Completion.TrySetResult();

            internal void TrySetCanceled()
            {
                if (Completion.TrySetCanceled())
                {
                    ReleaseResources();
                }
            }

            internal void TrySetException(Exception exception)
            {
                if (Completion.TrySetException(exception))
                {
                    ReleaseResources();
                }
            }

            internal void ReleaseResources() => Interlocked.Exchange(ref _release, null)?.Invoke();
        }
    }
}
