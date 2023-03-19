## LOD 
**Level of detail (LOD)** is a technique **reduces the number of GPU operations** that 
Unity requires to render distant meshes.


When a GameObjectThe fundamental object in Unity scenes, 
which can represent characters, props, scenery, cameras, waypoints, and more.
A GameObject’s functionality is defined by the Components attached to it. More info
See in Glossary in the Scene is far away from the Camera , you **see less detail compared to when the GameObject is close** to the Camera. 
However, **by default, Unity uses the same number of triangles to render it at both distances**. 
This can result in wasted GPU operations, which can impact performance in your Scene.


The **LOD technique** allows Unity to **reduce the number of triangles it renders** for a GameObject 
**based on its distance** from the Camera.

These meshes are called **LOD levels**. The farther a GameObject is from the Camera, 
the **lower-detail LOD level** Unity renders. 
This technique reduces the load on the hardware for these distant GameObjects, and can therefore improve rendering performance.


### ref
https://docs.unity3d.com/Manual/LevelOfDetail.html


