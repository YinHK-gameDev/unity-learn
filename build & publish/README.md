## Build & publish

### Reduce project complexity and size
- Only store assets/code in your repository
- Split your assets/code into smaller units, and put them in multiple Git or Nuget packages
- Export the terrain and maps, along with the necessary textures, to your final project.
- You have a huge library of textures and vegetation models and materials.
- you only export those to your level builder project (which may be separated from your prototype mechanics project, and so on).

https://forum.unity.com/threads/how-do-you-organize-your-project-to-reduce-its-complexity-and-size.526687/

### Reducing the file size of your build
https://docs.unity3d.com/Manual/ReducingFilesize.html

### Managing scenes in a build
When you build your application, Unity builds all selected scenes in the **Scenes In Build** pane. Unity builds scenes in the order in which they appear in the list.

You can add, exclude, remove, and reorder scenes in the list:

-   **To add all currently open scenes to the list**: Select **Add Open Scenes**. You can also drag scenes from your **Project** window into the list.
-   **To exclude a scene in the list from the build**: Clear the checkbox next to that scene. This removes the scene from the build, but not from the list.
-   **To remove a scene from the list**: Select the scene and press **Delete**.
-   **To adjust the scene order**: Drag and drop scenes in the list to reorder them.

### Change scene order
With the smallest number, the scene will be defult display during the game. You can change the ordering of scenes in your project:


-   Go to `File > Build Settings`
-   Find the `Scenes in Build` section - this will contain all of the scenes in your project that have been added to the build.
-   Next to each listed scene, you should see a number which indicates its build index which is the order in which the scene will appear in the build. Note that after 0 (the first scene), this doesn't really matter as you'll likely have a controller script in your game that handles scene switching for the lifespan of the process.
-   Find the scene you want to move and drag and drop it to the desired index.

### Remove Unity Splash Screen ("Made with Unity" logo)
https://moddingcommunity.com/topic/108-tutorial-a-complete-guide-to-remove-unity-splash-screen/

https://github.com/kiraio-moe/remove-unity-splash-screen

#### Customize and change your Unity splash screen in personal edition
https://www.youtube.com/watch?v=BY40xbA5qYQ

https://www.youtube.com/watch?v=05ymbWXdZ-8

### ref 
https://docs.unity3d.com/Manual/PublishingBuilds.html
