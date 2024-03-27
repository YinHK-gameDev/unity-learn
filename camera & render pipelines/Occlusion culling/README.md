## Occlusion culling
> **Occlusion culling** is a process which **prevents Unity from performing rendering calculations for GameObjectsthat are completely hidden from view** (occluded) by other GameObjects.

> **Occlusion Culling** is a feature that **disables rendering of objects when they are not currently seen by the camera** because they are obscured (occluded) by other objects.


Every frame, Cameras
 perform culling operations that examine the Renderers in the Scene
 and exclude (cull) those that do not need to be drawn. 
 
 By default, Cameras perform **frustum culling**, which excludes all Renderers that do not fall within the Camera’s view frustum. However, **frustum culling** does **not check whether a Renderer is occluded by other GameObject**s, and so Unity can still waste CPU and GPU time on rendering operations for Renderers that are not visible in the final frame. \
**Occlusion culling stops Unity from performing these wasted operations**.

Occlusion culling **generates data about your Scene** in the Unity Editor, and then **uses that data at runtime to determine what a Camera can see**. The **process of generating data** is known as **baking**.

When you **bake occlusion culling data**, Unity **divides the Scene into cells** and **generates data that describes the geometry within cells**, and **the visibility between adjacent cells**. Unity then **merges cells where possible**, to **reduce the size of the generated data**.

> To configure the baking process, you can change parameters in the **Occlusion Culling window**, and use **Occlusion Areas** in your Scene.

### Why use occlusion culling
- Preventing wasted rendering operations can save on both CPU and GPU time. Unity’s built-in occlusion culling performs runtime calculations on the CPU, which can offset the CPU time that it saves. Occlusion culling is therefore most likely to result in performance improvements when a Project is GPU-bound due to overdraw.
- Unity loads occlusion culling data into memory at runtime. You must ensure that you have sufficient memory to load this data.
- Occlusion culling works best in Scenes where small, well-defined areas are clearly separated from one another by solid GameObjects. A common example is rooms connected by corridors.
- You can use occlusion culling to occlude Dynamic GameObjects, but Dynamic GameObjects cannot occlude other GameObjects. If your Project generates Scene geometry at runtime, then Unity’s built-in occlusion culling is not suitable for your Project.


> At runtime, Unity loads this baked data into memory, and for each Camera that has its Occlusion Culling property enabled, it performs queries against the data to determine what that Camera can see. Note that when occlusion culling is enabled, Cameras perform both frustum culling and occlusion culling.

### Occlusion culling and Scene loading
At runtime, Unity loads only one occlusion culling
 data asset at a time, no matter how many Scenes are open. You must therefore prepare your occlusion culling data differently depending on whether you plan to load one Scene
 at a time, or multiple Scenes at a time.


#### Loading one Scene at a time

If you load one Scene at a time with **`LoadSceneMode.Single`**, you must bake the occlusion culling data for each Scene separately, like this:

1.  In the Unity Editor, open a single Scene that you want to bake occlusion culling data for.
2.  Bake the data for the Scene. Unity generates the data and saves it as _Assets/\[Scene name\]/OcclusionCullingData.asset_. Unity adds a reference to this asset to the open Scene.
3.  Save the Scene.
4.  Repeat steps 1, 2, and 3 for each Scene.

At runtime, load your Scenes like this:

1.  Load a Scene as the default Scene of your Project, or using LoadSceneMode.Single. Unity unloads the active Scene if there is one, along with its occlusion data asset if it has one. Unity then loads your Scene along with its occlusion data asset.


#### Loading more than one Scene at a time

If you load multiple Scenes at a time with **`LoadSceneMode.Additive`**, you must bake the data for those Scenes together, like this:

-   In the Unity Editor, open the first Scene of the group that Unity will load at runtime. This becomes the active Scene.
-   Additively open the other Scenes in the group, so that all of them are open in the Unity Editor at the same time.
-   Bake the data for all Scenes. Unity generates the data for all of the open Scenes, and saves it as _Assets/\[active Scene name\]/OcclusionCullingData.asset_. Unity adds a reference to this asset to all of the open Scenes.
-   Save the Scenes.


At runtime, load your Scenes like this:

1. Load the first Scene of the group as the default Scene of your Project, or using **`LoadSceneMode.Single`**. Unity unloads the active Scene if there is one, along with its occlusion data asset if it has one. Unity then loads your Scene along with the shared occlusion data asset.
2. Load other Scenes as required with **`LoadSceneMode.Additive`**. If Unity finds that the the occlusion data of an additively loaded Scene is the same as that of the active Scene, occlusion culling works as intended.

> Note that the shared occlusion data asset has a larger file size. There is no additional runtime CPU impact to using a larger occlusion data asset.

https://docs.unity3d.com/Manual/occlusion-culling-scene-loading.html

### ref
https://docs.unity3d.com/Manual/OcclusionCulling.html

https://www.youtube.com/watch?v=7bZ4OIA0wRQ&t=100s

https://www.youtube.com/watch?v=OmuQmydipGg

https://www.youtube.com/watch?v=JC1kXk-mQHs

https://www.youtube.com/watch?v=20UTQMMZhjI

https://www.youtube.com/watch?v=VqH8kcmD-HI

https://www.youtube.com/watch?v=bylgGoB_PoI

https://blog.unity.com/technology/occlusion-culling-in-unity-4-3-the-basics

https://blog.unity.com/technology/occlusion-culling-in-unity-4-3-best-practices

https://blog.unity.com/technology/occlusion-culling-in-unity-4-3-troubleshooting

https://sites.google.com/view/godninelibrary/unity%E7%9B%B8%E9%97%9C/%E6%95%88%E8%83%BD%E5%84%AA%E5%8C%96/occlusion-culling



