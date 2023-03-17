## Mesh data

A **mesh** is defined by these properties:

- **Vertices**: **A collection of positions** in 3D space, with optional additional attributes.
- **Topology**: **The type of structure** that defines each face of the surface.
- **Indices**: **A collection of integers** that describe how the vertices combine to create the surface, based on the topology.


In addition to this, **deformable meshes** contain either:

- **Blend shapes**: Data that describes different **deformed versions of the mesh**, for use with animation.
- **Bind poses**: Data that describes the **"base" pose** of the **skeleton** in a **skinned mesh**.


### Vertex data
The elements of vertex data are called **vertex attributes**.

Every **vertex** can have the following attributes:

- **Position** \
  The vertex position represents the position of the vertex in object space. Unity uses this value to determine the surface of the mesh. In the **Mesh class**, the simplest way to access this data is with **`Mesh.GetVertices`** and **`Mesh.SetVertices`**. Unity also stores this data in **`Mesh.vertices`**, but this older property is less efficient and user-friendly.
  > This vertex attribute is **required** for all meshes.
- **Normal**
- **Tangent**
- **Color**
- **Up to 8 texture coordinates**
- **Bone weights and blend indices (skinned meshes only)**

> Internally, all vertex data is stored in separate arrays of the same size. If your mesh contains an array with 10 vertex positions, it also has arrays with 10 elements for each other vertex attribute that it uses.

> In C#, Unity describes the available vertex attributes with the **`VertexAttribute`** enum. You can check whether an instance of the **Mesh class** has a given **vertex attribute** with the **`Mesh.HasVertexAttribute`** function.









https://docs.unity3d.com/Manual/AnatomyofaMesh.html




