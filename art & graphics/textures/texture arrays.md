## Texture arrays

A **texture array** is a **collection of same size/format/flags 2D textures** that look like a single object to the **GPU**, 
and can be sampled in the **shader** with a **texture element index**. 

They are useful for implementing custom **terrain** rendering systems 
or other special effects where you need an efficient way of accessing many textures of the **same size and format**.


### Platform Support

**Texture arrays need to be supported by the underlying graphics API and the GPU. They are available on:**

- Direct3D 11/12 (Windows)
- OpenGL Core (Mac OS X, Linux)
- Metal (iOS, Mac OS X)
- OpenGL ES 3.0 (Android, WebGL 2.0)

> Other platforms do not support texture arrays (OpenGL ES 2.0 or WebGL 1.0). Use SystemInfo.supports2DArrayTextures to determine texture array support at runtime.


### Importing texture arrays

You can import texture arrays from source texture files that are divided into cells. These are called flipbook textures. To do this:


1. Import the source texture into your Unity Project.
2. In your **Project view**, select the resulting Texture Asset. Unity displays the Texture import settings in the Inspector.
3. In the Inspector, set Texture Shape to 2D Array. Unity displays the Columns and Rows properties.
4. Set Columns and Rows to the appropriate values for your flipbook texture.
5. Click Apply.


### Creating and manipulating texture arrays using scripts

To create a **texture array** from a C# script, use the **`Texture2DArray`** class to **initialize the texture** and set **pixel** **data**, and save the object as an asset file using **AssetDatabase.CreateAsset**.

Normally, texture arrays are used purely within GPU memory, but you can use **`Graphics.CopyTexture`**, **`Texture2DArray.GetPixels`** and **`Texture2DArray.SetPixels`** to transfer pixels to and from system memory.



### ref
https://docs.unity3d.com/Manual/class-Texture2DArray.html

