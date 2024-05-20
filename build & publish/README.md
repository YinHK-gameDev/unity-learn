## Build & publish

### Reduce project complexity and size
- Only **store assets/code in your repository**
- **Split your assets/code into smaller units**, and put them in multiple Git or Nuget packages
- **Export the terrain and maps**, along with the necessary textures, to your final project.
- You have a huge library of textures and vegetation models and materials.
- you **only export those to your level builder project** (which may be separated from your prototype mechanics project, and so on).

https://forum.unity.com/threads/how-do-you-organize-your-project-to-reduce-its-complexity-and-size.526687/

### Reducing the file size of your build

#### Suggestions for reducing build size

**Textures** \
Textures usually take up the most space in the build. The first solution to this is to use compressed Texture formats. 

If that doesn’t reduce the file size enough, try to reduce the physical size (in pixels) of the Texture images. To do this without modifying the actual source content, select the Texture in the Project view, and in the Inspector window reduce the Max Size. 
 
**Meshes and Animations** \

You can compress Meshes and imported Animation Clips so that they take up less space in your game file. To enable Mesh compression, select the Mesh, then in the Inspector window set the Mesh Compression to Low, Medium or High. Mesh and Animation compression uses quantization, which means it takes less space, but the compression can introduce some inaccuracies. Experiment with what level of compression is acceptable for your models.

> Note that Mesh compression only produces smaller data files, and does not use less memory at run time. Animation keyframe reduction produces smaller data files and uses less memory at run time; generally you should always have it enabled. See documentation on Animation Clips for more information about this.


**Reducing .NET library size** \

Unity supports two .NET API compatibility levels.: .NET 4.x and .NET Standard 2.0. The .NET Standard 2.0 restricts you to a smaller subset of the .NET API, which can help keep size down.


![](./img/FileSizeOptimizationTexture.png)


https://docs.unity3d.com/Manual/ReducingFilesize.html

### Managing scenes in a build
When you build your application, Unity builds all selected scenes in the **Scenes In Build** pane. Unity builds scenes in the order in which they appear in the list.

You can add, exclude, remove, and reorder scenes in the list:

-   **To add all currently open scenes to the list**: Select **Add Open Scenes**. You can also drag scenes from your **Project** window into the list.
-   **To exclude a scene in the list from the build**: Clear the checkbox next to that scene. This removes the scene from the build, but not from the list.
-   **To remove a scene from the list**: Select the scene and press **Delete**.
-   **To adjust the scene order**: Drag and drop scenes in the list to reorder them.

### Change scene order
With the **smallest number**, the scene will be defult display during the game. You can change the ordering of scenes in your project:

-   Go to **`File > Build Settings`**
-   Find the `Scenes in Build` section - this will contain all of the scenes in your project that have been added to the build.
-   Next to each listed scene, you should see a number which indicates its build index which is the order in which the scene will appear in the build. Note that after 0 (the first scene), this doesn't really matter as you'll likely have a controller script in your game that handles scene switching for the lifespan of the process.
-   Find the scene you want to move and drag and drop it to the desired index.


### Build settings
When you select a platform, Unity displays a list of options that you can adjust for the build. Some settings apply to all platforms, and some are platform-specific.


The following settings apply to all platforms.

| Setting: | Function: |
| --- | --- |
| Development Build | Include scripting debug symbols and the Profiler in your build. You should use this setting when you want to test your application.When you select this option, Unity sets the DEVELOPMENT_BUILD scripting define. Your build then includes preprocessor directives that set DEVELOPMENT_BUILD as a condition (see Platform-dependent compilations). |
| Autoconnect Profiler | Automatically connect the Unity Profiler to your build.This option is only available if you selected Development Build. |
| Deep Profiling Support | Turn on Deep Profiling in the Profiler. This makes the Profiler instrument every function call in your application so it returns more detailed profiling data. This option might slow down script execution.This option is only available if you selected Development Build. |
| Script Debugging | Allow your script code to be debugged.This option is only available if you selected Development Build.This option is not available for WebGL. |
| Wait for Managed Debugger | Make the Player wait for a debugger to be attached before it executes any script code.This option is only available if you selected Script Debugging. |

https://docs.unity3d.com/Manual/BuildSettings.html

### Remove Unity Splash Screen ("Made with Unity" logo)
https://moddingcommunity.com/topic/108-tutorial-a-complete-guide-to-remove-unity-splash-screen/

https://github.com/kiraio-moe/remove-unity-splash-screen

#### Customize and change your Unity splash screen in personal edition
https://www.youtube.com/watch?v=BY40xbA5qYQ

https://www.youtube.com/watch?v=05ymbWXdZ-8

### ref 
https://docs.unity3d.com/Manual/PublishingBuilds.html \
https://docs.unity3d.com/Manual/BuildSettings.html
