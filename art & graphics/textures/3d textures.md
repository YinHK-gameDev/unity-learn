## 3D textures

A 3D texture is a bitmap image that contains information in three dimensions rather than the standard two. 3D textures are commonly used to simulate volumetric effects such as **fog** or **smoke**, to approximate **a volumetric 3D mesh**
, or to store animated textures and blend between them smoothly.

The maximum resolution of a 3D texture is **2048 x 2048 x 204**8.

> Be aware that the size of a 3D texture in memory and on disk increases quickly as its resolution increases. An **RGBA32** 3D texture with no **mipmaps** and a resolution of **16 x 16 x 16** has a size of **128KB**, but with a resolution of **256 x 256 x 256** it has a size of **512MB**.


### Importing 3D textures

You can import 3D textures from source texture files that are divided into cells. These are called flipbook textures. To do this:

1. Import the source texture into your Unity Project.
2. In your Project view, select the resulting Texture Asset. Unity displays the Texture import settings in the **Inspector**.
3. In the Inspector, set **Texture Shape** to **3D**. Unity displays the Columns and Rows properties.
4. Set **Columns** and **Rows** to the appropriate values for your flipbook texture.
5. Click **Apply**.





### ref
https://docs.unity3d.com/Manual/class-Texture3D.html
