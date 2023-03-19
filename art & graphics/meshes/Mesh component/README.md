## Mesh components

### Mesh Renderer component
A Mesh Renderer component **renders a mesh**. It works with a **Mesh Filter component** on the same GameObject; the Mesh Renderer renders the mesh that the Mesh Filter references.

> To render a **deformable mesh**, use a **Skinned Mesh Renderer** instead.

In C# code, the **MeshRenderer class** represents a **Mesh Renderer** component. The **MeshRenderer class** inherits much of its functionality from the Renderer class. As such, this component has a lot in common with other components that inherit from Renderer, such as **Line Renderer**, and **Trail Renderer**.

https://docs.unity3d.com/Manual/class-MeshRenderer.html


### Skinned Mesh Renderer component
The Skinned Mesh
 Renderer component renders a deformable mesh. Deformable meshes include skinned meshes (meshes that have bones and bind poses), meshes that have blend shapes, and meshes that run cloth simulation.

> To render a regular mesh, use a **Mesh Renderer** and a **Mesh Filter** instead.


When you add a deformable mesh or a model with a deformable mesh to a scene, Unity adds a Skinned Mesh Renderer component to the resulting GameObject.

In C# code, the **SkinnedMeshRenderer class** represents a **Skinned Mesh Renderer component**. The SkinnedMeshRenderer class inherits much of its functionality from the Renderer class. As such, this component has a lot in common with other components that inherit from Renderer, such as **Line Renderer**
, and **Trail Renderer**.

https://docs.unity3d.com/Manual/class-SkinnedMeshRenderer.html


