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


![](../img/tAQNN.png)


Every **vertex** can have the following attributes:

- **Position** \
  The vertex position represents the position of the vertex in object space. Unity uses this value to determine the surface of the mesh. In the **Mesh class**, the simplest way to access this data is with **`Mesh.GetVertices`** and **`Mesh.SetVertices`**. Unity also stores this data in **`Mesh.vertices`**, but this older property is less efficient and user-friendly.
  > This vertex attribute is **required** for all meshes.
- **Normal** \
  The vertex normal represents the **direction** that points directly **"out"** from the surface at the position of the vertex. 
  In the **Mesh class**, the simplest way to access this data is with **`Mesh.GetNormals`** and **`Mesh.SetNormals`**. Unity also stores this data in **`Mesh.normals`**, but this older property is less efficient and user-friendly.
  > Unity uses this value to calculate the way that **light reflects off the surface of a mesh**.
  > > However, this vertex attribute is **optional**.
- **Tangent** \
  The vertex tangent represents the **direction that points along the "u"** (horizontal texture) axis of the surface at the position of the vertex.
  
  Unity stores the **vertex tangent** with an additional piece of data, in a **four-component vector**. The x,y,z components of the vector describe the tangent, and the w component of the vector describes its orientation. Unity uses the **w** value to compute the **binormal**, which is the **cross-product of the tangent and normal**.
  
  ![](../img/unit-tangent-normal-and-binormal-vectors.png)
  
  > Unity uses the tangent and binormal values in **normal mapping**.
  > > However, this vertex attribute is **optional**.

  In the **Mesh class**, the simplest way to access this data is with **`Mesh.GetTangents`** and **`Mesh.SetTangents`**. Unity also stores this data in **`Mesh.tangents`**, but this older property is less efficient and user-friendly.
- **Color** \
  The vertex color represents the **base color** of a vertex, if any.
  
  This color exists independently of any textures that the mesh may use.
  > This vertex attribute is **optional**.

  In the **Mesh class**, the simplest way to access this data is with **`Mesh.GetColors`** and **`Mesh.SetColors`**. Unity also stores this data in **Mesh.colors**, but this older property is less efficient and user-friendly.
  
- **Up to 8 texture coordinates**
- **Bone weights and blend indices (skinned meshes only)**

> Internally, all vertex data is stored in separate arrays of the same size. If your mesh contains an array with 10 vertex positions, it also has arrays with 10 elements for each other vertex attribute that it uses.

> In C#, Unity describes the available vertex attributes with the **`VertexAttribute`** enum. You can check whether an instance of the **Mesh class** has a given **vertex attribute** with the **`Mesh.HasVertexAttribute`** function.







### ref

https://docs.unity3d.com/Manual/AnatomyofaMesh.html

https://gamedev.stackexchange.com/questions/51399/what-are-normal-tangent-and-binormal-vectors-and-how-are-they-used


