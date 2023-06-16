## Build & publish

### Reduce project complexity and size
- Only store assets/code in your repository
- Split your assets/code into smaller units, and put them in multiple Git or Nuget packages
- Export the terrain and maps, along with the necessary textures, to your final project.
- You have a huge library of textures and vegetation models and materials.
- you only export those to your level builder project (which may be separated from your prototype mechanics project, and so on).
- 
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



### ref 
https://docs.unity3d.com/Manual/PublishingBuilds.html
