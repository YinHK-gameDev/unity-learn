## Using meshes with C# scripts in Mesh class

The **Mesh class** gives script access to an object’s mesh geometry, allowing meshes to be created or modified at runtime.

This technique is useful for **graphical effects** (eg, **stretching or squashing an object**) but can also be useful in **level design** and **optimisation**.



The **Mesh class** is the basic script interface to an object’s mesh geometry. It uses arrays to represent the triangles, vertex positions, normals and texture coordinates and also supplies a number of other useful properties and functions to assist mesh generation.
 
 
 ### Accessing an Object’s Mesh
 
 The mesh data is attached to an object using the **Mesh Filter component** (and the object will also need a MeshRenderer to make the geometry visible).
 
 ```cs
 using UnityEngine;
public class ExampleScript : MonoBehaviour
{
    MeshFilter mf;
    void Start()
    {
        //if this gameObject has a MeshFilter, mf will reference the component
        mf = GetComponent<MeshFilter>();    
    }
}
```

### Adding the Mesh Data

The Mesh object has properties for the vertices and their associated data (normals and UV coordinates) and also for the triangle data. The vertices may be supplied in any order but the arrays of normals and UVs must be ordered so that the indices all correspond with the vertices (ie, element 0 of the normals array supplies the normal for vertex 0, etc). The vertices are Vector3s representing points in the object’s local space. The normals are normalised Vector3s representing the directions, again in local coordinates. The UVs are specified as Vector2s, but since the Vector2 type doesn’t have fields called U and V, you must mentally convert them to X and Y respectively.



### Manipulating meshes from a script

There are three common tasks that might want to use the Mesh API for:

1. Building a mesh from scratch: should always be done in the following order:
   
a) Assign vertices \
b) Assign triangles.

```cs

using UnityEngine;

public class Example : MonoBehaviour
{
    Vector3[] newVertices;
    Vector2[] newUV;
    int[] newTriangles;

   void Start()
    {
        Mesh mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
        mesh.vertices = newVertices;
        mesh.uv = newUV;
        mesh.triangles = newTriangles;
    }
}
```

2. Modifying vertex attributes every frame:
   
a) Get vertices \
b) Modify them \
c) Assign them back to the mesh.

```cs
using UnityEngine;

public class Example : MonoBehaviour
{
    void Update()
    {
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        Vector3[] vertices = mesh.vertices;
        Vector3[] normals = mesh.normals;

       for (var i = 0; i < vertices.Length; i++)
        {
            vertices[i] += normals[i] * Mathf.Sin(Time.time);
        }

       mesh.vertices = vertices;
    }
}
```

3. Continously changing the mesh triangles and vertices:

a) Call Clear to start fresh \
b) Assign vertices and other attributes \
c) Assign triangle indices.

> It is important to call Clear before assigning new vertices or triangles. Unity always checks the supplied triangle indices whether they don't reference out of bounds vertices. Calling Clear then assigning vertices then triangles makes sure you never have out of bounds data.

```cs
using UnityEngine;

public class ExampleClass : MonoBehaviour
{
    Vector3[] newVertices;
    Vector2[] newUV;
    int[] newTriangles;

   void Start()
    {
        Mesh mesh = GetComponent<MeshFilter>().mesh;

       mesh.Clear();

       // Do some calculations...
        mesh.vertices = newVertices;
        mesh.uv = newUV;
        mesh.triangles = newTriangles;
    }
}

```



### ref
https://docs.unity3d.com/Manual/UsingtheMeshClass.html

https://docs.unity3d.com/ScriptReference/Mesh.html
