## Render pipelines
A render pipeline performs a series of **operations** that **take the contents of a Scene
, and displays them on a screen**.

These operations are:

- Culling
- Rendering
- Post-processing

In Unity, you can choose between different render pipelines. Unity provides three prebuilt render pipelines with different capabilities and performance characteristics, or you can create your own.


It can be difficult to switch a Project from one render pipeline to another, because different render pipelines use different **shader**
 outputs, and might not have the same features. It is therefore important to understand the different render pipelines that Unity provides
 

**Unity offers the following render pipelines:** 

- The **Built-in Render Pipeline** is Unity’s default render pipeline. It is a general-purpose render pipeline that has limited options for customization.
- The **Universal Render Pipeline (URP)** is a **`Scriptable Render Pipeline`** that is quick and easy to customize, and lets you create optimized graphics across a wide range of platforms.
- The **High Definition Render Pipeline (HDRP)** is a **`Scriptable Render Pipeline`** that lets you create cutting-edge, high-fidelity graphics on high-end platforms.
- You can create your **own custom render pipeline** using Unity’s **Scriptable Render Pipeline API**.


### Render pipeline feature comparison
https://docs.unity3d.com/Manual/render-pipelines-feature-comparison.html

### ref
https://docs.unity3d.com/Manual/render-pipelines.html
