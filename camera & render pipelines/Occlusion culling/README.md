## Occlusion culling
**Occlusion culling** is a process which prevents Unity from performing rendering calculations for GameObjectsthat are completely hidden from view (occluded) by other GameObjects.

Every frame, Cameras
 perform culling operations that examine the Renderers in the Scene
 and exclude (cull) those that do not need to be drawn. By default, Cameras perform frustum culling, which excludes all Renderers that do not fall within the Camera’s view frustum. However, frustum culling does not check whether a Renderer is occluded by other GameObjects, and so Unity can still waste CPU and GPU time on rendering operations for Renderers that are not visible in the final frame. Occlusion culling stops Unity from performing these wasted operations.



### ref
https://docs.unity3d.com/Manual/OcclusionCulling.html
