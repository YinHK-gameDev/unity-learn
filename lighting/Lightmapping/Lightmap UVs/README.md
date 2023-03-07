## Lightmap UVs

**Texture coordinates, commonly called UVs**, describe how to "**wrap**" **a texture around geometry**. **Lightmaps
 are textures**, so Unity needs UVs to correctly use them in your scene.


Both the Realtime Global Illumination
 system and the Baked Global Illumination system use lightmaps, and therefore need lightmap
 UVs.
 
 
Unity uses separate sets of lightmap UVs for the **Realtime Global Illumination system** and the **Baked Global Illumination system**. There are two reasons for this:

- There is no direct correspondence in the grouping of instances between real-time and baked lightmaps; instances that are in the same real-time lightmap may be in two different baked lightmaps, and vice versa.
- Meshes that appear at different scales share lightmap UVs in baked lightmaps, but do not share UVs in real-time lightmaps.


### Baked lightmap UVs
**Baked lightmap UVs** are **per-mesh**: all instances of the **same mesh share the same baked lightmap UVs**. **Unity can calculate the UVs for baked lightmaps when you import a model**, or you can provide your own data.

Unity stores baked lightmap UVs in its mesh in the **`Mesh.uv2`** channel. This channel maps to the **TEXCOORD1 shader semantic**, and is commonly called **"UV1"**.

If Baked Global Illumination is enabled and a given MeshRenderer receives its global illumination from lightmaps, Unity uses the data in the Mesh.uv2 channel to correctly map the baked lightmaps to the mesh.

> **Note**: If you want to use **`Mesh.uv2`** for another purpose in a given mesh, you must ensure that all MeshRenderer components that use the mesh receive global illumination from **Light Probes** rather than lightmaps. Change this with the Mesh Renderer component Inspector, or the **`MeshRenderer.receiveGI API`**.
 

### Real-time lightmap UVs
**Real-time lightmap UVs** are **per-Mesh Renderer**: 
All instances of the **same mesh share the same input data**, but different instances of **Mesh Renderers** can **use different real-time lightmap UVs at runtime**. 

Unity calculates the UVs for the **Realtime Global Illumination system** during the **precompute stage**. This calculation takes per-mesh UVs as its input, and uses that data to create per-Mesh Renderer UVs. Unity can generate the input per-mesh UVs when you import a model, or you can provide your own data.
 
- Unity can use data in the Mesh.uv3 channel as input for the real-time lightmap UV calculations. Mesh.uv3 maps to the TEXCOORD2 shader semantic, and is commonly called “UV2”.
- If there is no data in Mesh.uv3 but there is data in Mesh.uv2 , Unity falls back to using the data in Mesh.uv2 as input for the real-time lightmap UV calculations. Mesh.uv2 is used for baked lightmap UVs. It is common to use the baked lightmap UVs as input data for the real-time lightmap UVs.
- The results of the calculations are stored per-MeshRenderer, in **`MeshRenderer.enlightenVertexStream`**. If Realtime Global Illumination is enabled and a given MeshRenderer component contributes to global illumination and receives its global illumination from lightmaps, Unity automatically passes the data in **`MeshRenderer.enlightenVertexStream`** to **`TEXCOORD2`** in shaders, instead of the data in **`Mesh.uv3`**.


> **Note**: If you want to use Mesh.uv3 for another purpose in a mesh that uses Realtime Global Illumination, you must ensure that all MeshRenderer components that use the mesh receive global illumination from Light Probes rather than lightmaps. Change this with the Mesh Renderer component Inspector, or the MeshRenderer.receiveGI API.




https://docs.unity3d.com/Manual/LightingGiUvs.html



 
