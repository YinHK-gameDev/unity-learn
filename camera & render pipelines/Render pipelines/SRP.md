## Scriptable Render Pipeline

The **Scriptable Render Pipeline** is a thin API layer that lets you **schedule and configure rendering commands using C# scripts**. Unity passes these commands to its low-level graphics architecture, which then sends instructions to the graphics API.

Unity provides two prebuilt render pipelines based on the **Scriptable Render Pipeline (SRP)**: the **High Definition Render Pipeline (HDRP)**, and the **Universal Render Pipeline (URP)**. 

**URP** and **HDRP** are built on top of **SRP**. You can also create your own custom render pipeline on top of **SRP**.

**Every render pipeline based on SRP has two key customized elements:**


In **SRP**, you use C# scripts to configure and schedule rendering commands. You then tell Unity’s low-level graphics architecture to execute them, which sends instructions to the graphics API.

The main way of doing this is by making API calls to the `ScriptableRenderContext`, but you can also execute **CommandBuffers** immediately.

### Render Pipeline Instance and Render Pipeline Asset
- A **Render Pipeline Instance**. 
  This is an instance of a class defines the functionality of your render pipeline. Its script inherits from **`RenderPipeline`**, and overrides its **`Render()`** method.
- A **Render Pipeline Asset**. This is an asset in your Unity Project that stores data about which Render Pipeline Instance to use, and how to configure it. Its script inherits from **`RenderPipelineAsset`** and overrides its **`CreatePipeline()`** method.


###  `ScriptableRenderContext`
In SRP, the **`ScriptableRenderContext`** class acts as an interface between the C# render pipeline code and Unity’s low-level graphics code. **SRP** rendering works using delayed execution; you use the **`ScriptableRenderContext`** to build up a list of rendering commands, and then you tell Unity to execute them. Unity’s low-level graphics architecture then **sends instructions** to the graphics API.

**`ScriptableRenderContext`** is a class that acts as an interface between the custom C# code in the render pipeline and Unity’s low-level graphics code.

To schedule rendering commands, you can:

- Pass **`CommandBuffers`** to the **`ScriptableRenderContext`**, using **`ScriptableRenderContext.ExecuteCommandBuffer`**
- Make direct API calls to the **Scriptable Render Context**, such as **`ScriptableRenderContext.Cull`** or **`ScriptableRenderContext.DrawRenderers`**

To tell Unity to perform the commands that you have scheduled, call **`ScriptableRenderContext.Submit`**. Note that it does not matter whether you used a **`CommandBuffer`** to schedule the command, or whether you scheduled the command by calling an API; Unity schedules all rendering commands on the **`ScriptableRenderContext`** in the same way, and does not execute any of them until you call **`Submit()`**.


Eg:
```cs
using UnityEngine;
using UnityEngine.Rendering;

public class ExampleRenderPipeline : RenderPipeline
{
        public ExampleRenderPipeline() {
        }

    protected override void Render(ScriptableRenderContext context, Camera[] cameras) {
        // Create and schedule a command to clear the current render target
        var cmd = new CommandBuffer();
        cmd.ClearRenderTarget(true, true, Color.red);
        context.ExecuteCommandBuffer(cmd);
        cmd.Release();

         // Tell the Scriptable Render Context to tell the graphics API to perform the scheduled commands
        context.Submit();
    }
}
```

### Executing CommandBuffers immediately
You can execute CommandBuffers immediately without using the ScriptableRenderContext, by calling **`Graphics.ExecuteCommandBuffer`**. Calls to this API take place outside of the render pipeline.

### Entry points and callbacks
When working with **SRP**, use these to make Unity call your C# code at specific times.

- **`RenderPipeline.Render`** is the main entry point to the SRP. Unity calls this method automatically. If you are writing a custom render pipeline, this is where you begin to write your code.
- The **`RenderPipelineManager`** class has the following events that you can subscribe to, so that you can execute custom code at **specific points** in the render loop:
  - **`beginFrameRendering`** - **Note**: This can generate garbage. Use **`beginContextRendering`** instead.
  - **`endFrameRendering`** - **Note**: This can generate garbage. Use **`endContextRendering`** instead.
- **`beginContextRendering`**
- **`endContextRendering`**
- **`beginCameraRendering`**
- **`endCameraRendering`**



https://docs.unity3d.com/Manual/scriptable-render-pipeline-introduction.html


