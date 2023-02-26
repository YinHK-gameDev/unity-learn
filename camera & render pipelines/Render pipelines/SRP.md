## Scriptable Render Pipeline

The **Scriptable Render Pipeline** is a thin API layer that lets you schedule and configure rendering commands using C# scripts
. Unity passes these commands to its low-level graphics architecture, which then sends instructions to the graphics API.

**URP** and **HDRP** are built on top of **SRP**. You can also create your own custom render pipeline on top of **SRP**.

**Every render pipeline based on SRP has two key customized elements:**

### Render Pipeline Instance and Render Pipeline Asset
- A **Render Pipeline Instance**. 
  This is an instance of a class defines the functionality of your render pipeline. Its script inherits from **`RenderPipeline`**, and overrides its **`Render()`** method.
- A **Render Pipeline Asset**. This is an asset in your Unity Project that stores data about which Render Pipeline Instance to use, and how to configure it. Its script inherits from **`RenderPipelineAsset`** and overrides its **`CreatePipeline()`** method.


###  `ScriptableRenderContext`
**`ScriptableRenderContext`** is a class that acts as an interface between the custom C# code in the render pipeline and Unity’s low-level graphics code.





https://docs.unity3d.com/Manual/scriptable-render-pipeline-introduction.html


