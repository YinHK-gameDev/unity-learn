## Occlusion culling
**Occlusion culling** is a process which prevents Unity from performing rendering calculations for GameObjectsthat are completely hidden from view (occluded) by other GameObjects.

Occlusion Culling is a feature that disables rendering of objects when they are not currently seen by the camera because they are obscured (occluded) by other objects.


Every frame, Cameras
 perform culling operations that examine the Renderers in the Scene
 and exclude (cull) those that do not need to be drawn. By default, Cameras perform frustum culling, which excludes all Renderers that do not fall within the Camera’s view frustum. However, frustum culling does not check whether a Renderer is occluded by other GameObjects, and so Unity can still waste CPU and GPU time on rendering operations for Renderers that are not visible in the final frame. Occlusion culling stops Unity from performing these wasted operations.

Occlusion culling generates data about your Scene in the Unity Editor, and then uses that data at runtime to determine what a Camera can see. The process of generating data is known as **baking**.

When you bake occlusion culling data, Unity divides the Scene into cells and generates data that describes the geometry within cells, and the visibility between adjacent cells. Unity then merges cells where possible, to reduce the size of the generated data.

### ref
https://docs.unity3d.com/Manual/OcclusionCulling.html

https://www.youtube.com/watch?v=OmuQmydipGg

