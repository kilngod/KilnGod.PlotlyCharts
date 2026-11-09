using System.Buffers;
using System.Diagnostics;
using System.Dynamic;
using System.Text.Json;
using KilnGod.PlotlyCharts.Common;
using KilnGod.PlotlyCharts.Configuration;
using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Layouts;
using KilnGod.PlotlyCharts.Traces;
using KilnGod.PlotlyCharts.Wrappers;

const int warmup = 20;
const int repetitions = 100;
var payload = CreatePayload(10_000);
var reusableWriter = new ArrayBufferWriter<byte>(64 * 1024);
using var reusableJsonWriter = new Utf8JsonWriter(reusableWriter);

var current = Measure(
    "current SerializeToUtf8Bytes",
    repetitions,
    () => JsonSerializer.SerializeToUtf8Bytes<object?[]>(payload).Length);

var reusable = Measure(
    "reusable ArrayBufferWriter",
    repetitions,
    () =>
    {
        reusableWriter.Clear();
        reusableJsonWriter.Reset(reusableWriter);
        JsonSerializer.Serialize(reusableJsonWriter, payload);
        reusableJsonWriter.Flush();
        return reusableWriter.WrittenCount;
    });

var intPayload = CreateNumericPayload<int>(10_000, index => index);
var doublePayload = CreateNumericPayload<double>(10_000, index => index + 0.25);
var integerNumbers = Measure(
    "typed int arrays",
    repetitions,
    () => JsonSerializer.SerializeToUtf8Bytes<object?[]>(intPayload).Length);
var floatingNumbers = Measure(
    "typed double arrays",
    repetitions,
    () => JsonSerializer.SerializeToUtf8Bytes<object?[]>(doublePayload).Length);

var sparsePayload = CreateSparsePayload(10_000);
var optionalPayload = CreateOptionalPayload(10_000);
var sparse = Measure(
    "omitted optional properties",
    repetitions,
    () => JsonSerializer.SerializeToUtf8Bytes<object?[]>(sparsePayload).Length);
var optional = Measure(
    "explicit null optional properties",
    repetitions,
    () => JsonSerializer.SerializeToUtf8Bytes<object?[]>(optionalPayload).Length);

Console.WriteLine("Serialization audit (.NET 10 Release)");
Print(current);
Print(reusable);
Print(integerNumbers);
Print(floatingNumbers);
Print(sparse);
Print(optional);
var currentJson = JsonSerializer.SerializeToUtf8Bytes<object?[]>(payload);
reusableWriter.Clear();
reusableJsonWriter.Reset(reusableWriter);
JsonSerializer.Serialize(reusableJsonWriter, payload);
reusableJsonWriter.Flush();
Console.WriteLine($"equivalence current/reusable: {JsonDocument.Parse(currentJson).RootElement.GetRawText() == JsonDocument.Parse(reusableWriter.WrittenMemory).RootElement.GetRawText()}");
Console.WriteLine($"equivalence sparse/optional: {JsonDocument.Parse(JsonSerializer.SerializeToUtf8Bytes<object?[]>(sparsePayload)).RootElement.GetRawText() == JsonDocument.Parse(JsonSerializer.SerializeToUtf8Bytes<object?[]>(optionalPayload)).RootElement.GetRawText()}");

static object?[] CreatePayload(int count)
{
    var trace = new ScatterTrace
    {
        X = Enumerable.Range(0, count).ToArray(),
        Y = Enumerable.Range(0, count).Select(value => Math.Sin(value / 10d)).ToArray(),
        Mode = [ModeScatterOptions.Lines],
        Name = "audit"
    };
    var traces = new TraceList(trace);
    var layout = new Layout { Title = new TitleLayoutInfo { Text = "Serialization audit" } };
    var config = new ConfigInfo { Responsive = true };
    return new object?[] { traces.Values, layout.ValueItems, config.ValueItems };
}

static object?[] CreateNumericPayload<T>(int count, Func<int, T> valueFactory)
{
    dynamic trace = new ExpandoObject();
    trace.type = "scatter";
    trace.x = Enumerable.Range(0, count).Select(valueFactory).ToArray();
    trace.y = Enumerable.Range(0, count).Select(valueFactory).ToArray();
    return new object?[] { new[] { trace } };
}

static object?[] CreateSparsePayload(int count)
{
    dynamic trace = new ExpandoObject();
    trace.type = "scatter";
    trace.x = Enumerable.Range(0, count).ToArray();
    trace.y = Enumerable.Range(0, count).ToArray();
    return new object?[] { new[] { trace } };
}

static object?[] CreateOptionalPayload(int count)
{
    dynamic trace = new ExpandoObject();
    trace.type = "scatter";
    trace.x = Enumerable.Range(0, count).ToArray();
    trace.y = Enumerable.Range(0, count).ToArray();
    trace.name = null;
    trace.mode = null;
    trace.text = null;
    return new object?[] { new[] { trace } };
}

static Measurement Measure(string name, int repetitions, Func<int> action)
{
    for (var index = 0; index < warmup; index++)
    {
        _ = action();
    }

    var elapsed = new long[repetitions];
    var allocated = new long[repetitions];
    var bytes = 0;
    for (var index = 0; index < repetitions; index++)
    {
        var before = GC.GetAllocatedBytesForCurrentThread();
        var timer = Stopwatch.StartNew();
        bytes = action();
        timer.Stop();
        elapsed[index] = timer.ElapsedTicks;
        allocated[index] = GC.GetAllocatedBytesForCurrentThread() - before;
    }

    Array.Sort(elapsed);
    Array.Sort(allocated);
    return new Measurement(name, bytes, elapsed[repetitions / 2], elapsed[(repetitions * 95) / 100], allocated[repetitions / 2], allocated[(repetitions * 95) / 100]);
}

static void Print(Measurement result)
{
    var tickNanoseconds = 1_000_000_000d / Stopwatch.Frequency;
    Console.WriteLine($"{result.Name}: bytes={result.Bytes}, median_ns={result.MedianTicks * tickNanoseconds:0}, p95_ns={result.P95Ticks * tickNanoseconds:0}, median_alloc={result.MedianAllocated}, p95_alloc={result.P95Allocated}");
}

sealed record Measurement(string Name, int Bytes, long MedianTicks, long P95Ticks, long MedianAllocated, long P95Allocated);
