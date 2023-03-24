## Textures

Normally, the mesh geometry of an object only gives a **rough approximation** of the shape while most of the **fine detail is supplied by Textures**. A **texture** is just a **standard bitmap image** that is applied over the **mesh surface**. You can think of a texture image as though it were printed on a rubber sheet that is stretched and pinned onto the mesh at appropriate positions. 
The positioning of the texture is done with the 3D modelling software that is used to create the mesh.


### Textures for use on 3D models

Textures are applied to objects using Materials. Materials use specialised graphics programs called Shaders to render a texture on the mesh surface. Shaders can implement lighting and colouring effects to simulate shiny or bumpy surfaces among many other things. They can also make use of two or more textures at a time, combining them for even greater flexibility.

You should make your textures in **dimensions** that are to the **power of two** (e.g. **32x32, 64x64, 128x128, 256x256**, etc.) Simply placing them in your project’s Assets folder is sufficient, and they will appear in the Project View.

Once your texture has been imported, you should **assign it to a Material**. The **material can then be applied to a mesh**, **Particle System**, or **GUI Texture**. Using the **Import Settings**, it can also be converted to a **Cubemap**
 or **Normalmap** for different types of applications in the game.
 

### 2D graphics

In 2D games, the **Sprites** are implemented using textures applied to flat meshes that approximate the objects’ shapes.

An object in a 2D game may require a set of related graphic images to represent animation frames or different states of a character. Special techniques are available to allow these sets of images to be designed and rendered efficiently.


### GUI

A game’s _graphic user interface_ (GUI) consists of graphics that are not used directly in the game **scene** but are there to allow the player to make choices and see information. For example, the score display and the options menu are typical examples of game GUI. These graphics are clearly very different from the kind used to detail a mesh surface but they are handled using standard Unity textures nevertheless.


### Importing textures
A texture is a **bitmap image**. You can create textures in a digital content creation application, such as Photoshop, and import them into Unity.

In a **3D** Project, Unity imports image and movie files in the Assets folder as **Texture**s. In a **2D** Project, Unity imports image and movie files in the Assets folder as **Sprite**s.


**To import image and movie files as Textures and Sprites in Unity:**

1. Select the image file in the Project window.
2. In the Inspector, set the Texture Import Settings.
3. Click the Apply button to save the changes.
4. To use the imported Assets in your Project:
   - For 3D Projects, **create a Material** and **assign the Texture** to the new Material.
   - For 2D Projects, use the **Sprite Editor**.


### Texture dimension sizes
Ideally, Texture dimension sizes should be powers of two on each side (that is, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048 pixels (px), and so on). The Textures do not have to be square; the width can be different from height.

It is possible to use NPOT (non-power of two) Texture sizes with Unity. However, NPOT Texture sizes generally take slightly more memory and might be slower for the GPU to sample, so it’s better for performance to use power of two sizes whenever you can.

If the platform or GPU does not support NPOT Texture sizes, Unity scales and pads the Texture up to the next power of two size. This process uses more memory and makes loading slower (especially on older mobile devices). In general, you should only use NPOT sizes for GUI purposes.

You can scale up NPOT Texture Assets at import time using the Non Power of 2 option in the Advanced section of the Texture Importer.


### Supported file formats

Unity can read the following file formats:

- BMP
- EXR
- GIF
- HDR
- IFF
- JPG
- PICT
- PNG
- PSD
- TGA
- TIFF




https://docs.unity3d.com/Manual/Textures.html

