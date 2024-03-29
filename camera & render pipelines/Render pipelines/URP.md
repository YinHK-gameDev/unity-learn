## Universal Render Pipeline(URP) 
The **Universal Render Pipeline (URP)** is a **prebuilt Scriptable Render Pipeline**, made by Unity. **URP** provides artist-friendly workflows that let you quickly and easily create optimized graphics across a range of platforms, from mobile to high-end consoles and PCs.

### Installing URP

1.  In Unity, open your Project.
2.  In the top navigation bar, select **Window** > **Package Manager** to open the **Package Manager** window.
3.  In the **Packages** menu, select **Unity Registry**. This shows the list of available packages for the version of Unity that you are currently running.
4.  Select **Universal RP** from the list of packages.
5.  In the bottom right corner of the Package Manager window, select **Install**. Unity installs URP directly into your Project.


### Creating the Universal Render Pipeline Asset

The **Universal Render Pipeline Asset (URP Asset)** contains the **global rendering** and **quality settings** of your project, and **creates the rendering pipeline instance**. The rendering pipeline instance contains **intermediate resources and the render pipeline implementation**.

To create a Universal Render Pipeline Asset:

1.  In the Editor, go to the Project window.
2.  Right-click in the Project window, and select **Create** > **Rendering** > **URP Asset**. Alternatively, navigate to the menu bar at the top, and select **Assets** > **Create** > **Rendering** > **URP Asset**.

You can either leave the default name for the new Universal Render Pipeline Asset, or type a new one.


### Set URP as the active render pipeline

To set URP as the **active render pipeline**:

1.  In your project, locate the **Render Pipeline Asset** that you want to use.  
    **Tip**: to find all URP Assets in a project, use the following query in the search field: **`t:universalrenderpipelineasset`**.
    
2.  Select **Edit** > **Project Settings** > **Graphics**.
    
3.  In the **Scriptable Render Pipeline Settings** field, **select the URP Asset**. When you select the URP Asset, the **available Graphics settings change immediately**.





### ref
https://docs.unity3d.com/Packages/com.unity.render-pipelines.universal@16.0/manual/index.html

https://www.youtube.com/watch?v=aJ1OpirisGM

https://www.youtube.com/watch?v=m6YqTrwjpP0

