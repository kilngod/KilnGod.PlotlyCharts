# Blazor WebGPU viewport implementation outline

## Goal

Migrate the existing Blazor WebGL control to a reusable `<MathViewport />` for interactive math and graph visualization. Keep the public scene API in C#. Use browser WebGPU for inline Razor layouts and native WebGPU for a desktop viewport. Preserve the option to run compute-generated geometry directly through the render pipeline.

Start by inspecting the old WebGL control and repository instructions. Trace a representative mesh from C# through interop to the upload call. Record marshaling, allocations, copies, draw calls, and how often the geometry is rebuilt. Use this as the baseline for the migration.

## Host configurations

| Configuration | Surface and GPU ownership | Performance customization |
|---|---|---|
| Blazor Interactive Server | Inline canvas. Browser module owns the WebGPU device, input loop, and frame scheduling. Server owns Razor state and server-side solvers. | Keep camera motion, picking, and animation local. Send parameters and coarse scene changes. Use packed binary for computed geometry and stream large updates with backpressure when necessary. |
| Blazor Interactive WebAssembly | Inline canvas. C# runs in the browser and calls browser WebGPU through a binding or thin JavaScript module. | Use coarse calls and reusable binary buffers. Compare typed-array marshaling with a view-based path if supported. Keep UI updates and expensive CPU work off the render loop. |
| Blazor Interactive Auto | Browser canvas with the same JavaScript GPU backend. Razor execution may be server-side or client-side depending on the visit and hosting state. | Keep the fast path browser-local in either mode. Initialize only after the canvas is interactive. Make initialization and teardown safe on navigation and reconnect. |
| Blazor Hybrid with a browser canvas | Inline canvas in the platform WebView. Razor C# runs in the native process. | Reuse the browser renderer where the actual WebView exposes WebGPU. Probe the device at runtime. Measure WebView interop separately from browser WASM. |
| Blazor Hybrid with a native desktop viewport | SDL3 creates a separate window and handles input. C# calls native WebGPU through a .NET binding. | Keep command encoding, input, and presentation local. Share scene commands with Razor. Native inline composition is a separate platform-specific project. |
| iOS option | Try the inline WebView canvas if WebGPU is available. For a native viewport, evaluate a system Metal view through .NET bindings. | A system Metal view can avoid third-party native binaries. It needs a Metal shader path. SDL3 and native WebGPU bindings introduce native packaging if used on iOS. |

## 1. Define the shared control contract

- Create a Razor component that accepts scene changes and view parameters and reports selection and renderer status. Keep platform window handles, browser objects, and binding-specific types private to each backend.
- Share scene descriptions, picking IDs, WGSL, and explicit vertex, index, uniform, and storage-buffer layouts. Keep resource ownership, surface creation, and frame scheduling in each backend.
- Use separate channels for small commands and bulk binary data. Include scene revision IDs so stale uploads or pick results can be discarded. Coalesce frequent changes to the newest state.
- Give each backend explicit initialization, resize, suspend, recovery, and disposal behavior. Cancel work and release device resources when the component closes or navigates away.

## 2. Build the inline WebGPU canvas first

- Start with one existing mesh and preserve the Razor UI around it. Let the browser module own canvas sizing, device and pipeline initialization, input, and requestAnimationFrame scheduling. Match render resolution to device pixel ratio within an explicit pixel budget.
- Pack geometry directly into reusable binary buffers in C#. Send optimized byte-array interop payloads where appropriate. The browser should receive a Uint8Array and pass it directly to queue.writeBuffer. Avoid ordinary JS number arrays, per-element conversions, and redundant typed-array copies. Browser upload and Server network transfer still have a cost.
- For large Server transfers, evaluate bounded streaming or a dedicated binary endpoint. Upload changed ranges, apply backpressure, and measure round-trip time separately from GPU work. A camera-only frame should issue zero geometry bytes over the network.
- For WebAssembly, use a C# binding or a small JS module. Verify actual copies and allocations instead of assuming the wrapper provides a zero-copy path. If using a short-lived view over WASM memory, consume it within its valid lifetime and reacquire it after memory growth as required by the binding.
- Cache pipelines and bind groups, reuse buffers, and batch draws or use instancing where the scene benefits. Avoid GPU readback during normal rendering. If GPU picking is needed, read back only the small result asynchronously.
- Probe for adapter availability, requested features, and limits. Handle device loss and expose a clear unsupported state. Retain the old WebGL path during comparison if it provides a practical fallback.

## 3. Keep math-generated geometry on the GPU

1. Send formula parameters and the sampling domain when they change.
2. Run a WGSL compute pass that writes positions or instances into a buffer declared with both storage and vertex usage, or read the result as storage in the render pass.
3. Draw from that same buffer after compute. Camera movement updates camera state only. Recompute geometry when the formula, its parameters, or its sampling domain changes.
4. Establish a CPU reference and validate precision and edge cases. For workloads that need double precision beyond the shader's numeric model, use CPU evaluation and packed result updates, or validate a suitable GPU approximation.
5. Treat ILGPU-to-WGSL as a later producer of shader code and binding metadata. First prove the buffer ABI and compute-to-render path with a small handwritten kernel. Then compare the generated shader against that reference on both hosts.

## 4. Add the native desktop host

- Use SDL3 for the window, event loop, and input. Use a .NET binding to wgpu-native for both compute and rendering so browser and desktop can share WGSL. SDL GPU is a separate API with its own shader build path.
- Pin a compatible managed binding and native runtime pair. Start by testing Silk.NET.WebGPU. Compare CodeBrix or Alimer if deployment or API compatibility warrants it. Confirm the actual binaries and surface support before selecting a package.
- Validate macOS, Windows, and the intended Linux window systems. Test native surface lifetime, resize, high DPI, minimized windows, input, and device loss. Follow platform main-thread rules for window operations.
- Keep desktop GPU resources on the native path. Exchange application-level scene commands and selection events with Blazor. Keep the renderer backend independent of the Razor host and of native library types exposed by the binding.

## 5. Measure each stage

| Scenario | Measurements and acceptance |
|---|---|
| Initial scene upload | Bytes sent, CPU allocations and copies, time to first frame. Compare old WebGL and new WebGPU on the same workload. |
| Camera movement | Median and tail frame times, input-to-frame latency, and zero geometry reuploads. On Server, camera motion should not depend on network round trips. |
| Small scene edit | Bytes updated and frame impact. Confirm unchanged ranges stay resident. |
| Compute-driven surface | CPU reference agreement, dispatch and render timings where available, and no full geometry readback or reupload. |
| Host lifecycle | Correct behavior through resize, reconnect or navigation, device loss, and repeated open/close. |
| Desktop distribution | Run the packaged app on clean target machines. Verify the actual native dependencies load and the same WGSL smoke test succeeds. |

Suggested sequence: profile WebGL, migrate one inline browser mesh, optimize the Server data path, prove compute-to-render, then reuse the shader and scene API in the desktop host. Add WebAssembly-specific interop tuning and iOS support as their respective workloads justify them.

## Reference links

- [Blazor render modes](https://learn.microsoft.com/en-us/aspnet/core/blazor/components/render-modes)
- [Blazor byte-array interop](https://learn.microsoft.com/en-us/aspnet/core/breaking-changes/6/byte-array-interop)
- [WebGPU queue.writeBuffer](https://developer.mozilla.org/en-US/docs/Web/API/GPUQueue/writeBuffer)
- [wgpu-native](https://github.com/gfx-rs/wgpu-native)
- [SDL3 iOS integration](https://wiki.libsdl.org/SDL3/README-ios)
