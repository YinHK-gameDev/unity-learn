## Textures

Normally, the mesh geometry of an object only gives a **rough approximation** of the shape while most of the fine detail is supplied by Textures
. A **texture** is just a **standard bitmap image** that is applied over the **mesh surface**. You can think of a texture image as though it were printed on a rubber sheet that is stretched and pinned onto the mesh at appropriate positions. 
The positioning of the texture is done with the 3D modelling software that is used to create the mesh.


### Textures for use on 3D models

Textures are applied to objects using Materials. Materials use specialised graphics programs called Shaders to render a texture on the mesh surface. Shaders can implement lighting and colouring effects to simulate shiny or bumpy surfaces among many other things. They can also make use of two or more textures at a time, combining them for even greater flexibility.

You should make your textures in **dimensions** that are to the **power of two** (e.g. **32x32, 64x64, 128x128, 256x256**, etc.) Simply placing them in your project’s Assets folder is sufficient, and they will appear in the Project View.

Once your texture has been imported, you should **assign it to a Material**. The **material can then be applied to a mesh**, **Particle System**, or **GUI Texture**. Using the **Import Settings**, it can also be converted to a **Cubemap**
 or **Normalmap** for different types of applications in the game


https://docs.unity3d.com/Manual/Textures.html

