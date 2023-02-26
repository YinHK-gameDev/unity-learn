## Render pipelines
A render pipeline performs a series of **operations** that **take the contents of a Scene
, and displays them on a screen**.

These operations are:

- Culling
- Rendering
- Post-processing

In Unity, you can choose between different render pipelines. Unity provides three prebuilt render pipelines with different capabilities and performance characteristics, or you can create your own.

To render content, Unity can either use the **Built-in Render Pipeline** or a render pipeline based on the **Scriptable Render Pipeline (SRP)**, which includes the **Universal Render Pipeline (URP)** and the **High Definition Render Pipeline (HDRP)**.

It can be difficult to switch a Project from one render pipeline to another, because different render pipelines use different **shader**
 outputs, and might not have the same features. It is therefore important to understand the different render pipelines that Unity provides
 

**Unity offers the following render pipelines:** 

- The **Built-in Render Pipeline** is Unity’s default render pipeline. It is a general-purpose render pipeline that has limited options for customization.
- The **Universal Render Pipeline (URP)** is a **`Scriptable Render Pipeline`** that is quick and easy to customize, and lets you create optimized graphics across a wide range of platforms.
- The **High Definition Render Pipeline (HDRP)** is a **`Scriptable Render Pipeline`** that lets you create cutting-edge, high-fidelity graphics on high-end platforms.
- You can create your **own custom render pipeline** using Unity’s **Scriptable Render Pipeline API**.


> When you change the active render pipeline, you must ensure that the assets and code in your project are compatible with the new render pipeline; otherwise, you might experience errors or unintended visual effects.

### Render pipeline feature comparison
https://docs.unity3d.com/Manual/render-pipelines-feature-comparison.html


### Determining the active render pipeline
To get or set the default render pipeline, use **Edit > Project Setting > Graphics Settings > Scriptable Render Pipeline Setting** (or its equivalent API, `GraphicsSettings.defaultRenderPipeline`). To get or set the render pipeline that overrides the default for a given quality level, **Edit > Project Setting > Quality Settings > Render Pipeline** (or its equivalent API, `QualitySettings.renderPipeline`).

Unity determines the active render pipeline like this:

- If the current **Quality Settings > Render Pipeline** references a Render Pipeline Asset, Unity uses that value.
- Otherwise:
  - If **Graphics Settings** > **Scriptable Render Pipeline** Setting references a Render Pipeline Asset, Unity uses that value.
  - Otherwise, Unity uses the **Built-in Render Pipeline**.

### Activating the Built-in Render Pipeline
To set the active render pipeline to the Built-in Render Pipeline, remove any Render Pipeline Assets from Graphics Settings and Quality Settings.

= **Select Edit > Project Settings > Quality**.
- For each quality level, if a **Render Pipeline Asset** is assigned to the **Render Pipeline field**, unassign it.
Select **Edit > Project Settings > Graphics**.
- If a Render Pipeline Asset is assigned t**o the **Scriptable Render Pipeline Setting** field, unassign it.


### Activating URP, HDRP, or a custom render pipeline
- In your Project folder, locate the **Render Pipeline Asset(s)** that you want to use.
- Set the default render pipeline, which Unity uses when there is no override for a given quality level. If you do not set this, Unity uses the Built-in Render Pipeline when no override applies.
  1. **Select Edit > Project Settings > Graphics**.
  2. Drag the Render Pipeline Asset on to the **Scriptable Render Pipeline** Setting field.
- Optional: Set override Render Pipeline Assets for different quality levels.
  1. Select **Edit > Project Settings > Quality**.
  2. Drag the Render Pipeline Asset on to the **Render Pipeline** field.


###  Get and set the active render pipeline in C# scripts
In C# scripts, you can get and set the active render pipeline and receive a callback when the active render pipeline changes.

- There are several ways to get the active render pipeline:
  - To get a reference to the Render Pipeline Asset that defines the active render pipeline, use `GraphicsSettings.currentRenderPipeline`.
  - To get a reference to the Render Pipeline Asset that defines the active render pipeline and to determine whether Unity is using the default value or an override value, get the values of `GraphicsSettings.defaultRenderPipeline` and `QualitySettings.renderPipeline`. 
  - To get the RenderPipeline instance for the active render pipeline, use RenderPipelineManager.currentPipeline. **Note: Unity updates this property only after it has rendered at least one frame with the active render pipeline.**
- To set the active render pipeline, set the values of `GraphicsSettings.defaultRenderPipeline` and `QualitySettings.renderPipeline`. 
- To detect and execute code when the type of the active render pipeline changes, use `RenderPipelineManager.activeRenderPipelineTypeChanged`.


### ref
https://docs.unity3d.com/Manual/render-pipelines.html
