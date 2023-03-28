## Loading texture and mesh data


Unity can load texture and **mesh**The main graphics primitive of Unity. Meshes make up a large part of your 3D worlds. Unity supports triangulated or Quadrangulated polygon meshes. Nurbs, Nurms, Subdiv surfaces must be converted to polygons. [More info](https://docs.unity3d.com/Manual/LoadingTextureandMeshData.htmlcomp-MeshGroup.html)  
See in [Glossary](https://docs.unity3d.com/Manual/LoadingTextureandMeshData.htmlGlossary.html#Mesh) data from disk and upload it to the GPU in two different ways: synchronously or asynchronously. These two processes are called the synchronous upload pipeline and the asynchronous upload pipeline.

When Unity uses the synchronous upload pipeline, it cannot perform other tasks while it loads and uploads the data. This can cause visible pauses in your application. When Unity uses the asynchronous upload pipeline, it can perform other tasks while it loads and uploads the data in the background.

If a texture or mesh is eligible for the asynchronous upload pipeline, Unity uses the asynchronous upload pipeline automatically. If a texture or mesh is ineligible for the asynchronous upload pipeline, Unity uses the synchronous upload pipeline automatically.


### ref
https://docs.unity3d.com/Manual/LoadingTextureandMeshData.html
