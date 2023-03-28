## Texture arrays

A **texture array** is a **collection of same size/format/flags 2D textures** that look like a single object to the **GPU**, 
and can be sampled in the **shader** with a **texture element index**. 

They are useful for implementing custom **terrain** rendering systems 
or other special effects where you need an efficient way of accessing many textures of the same size and format.



### Platform Support

**Texture arrays need to be supported by the underlying graphics API and the GPU. They are available on:**

- Direct3D 11/12 (Windows)
- OpenGL Core (Mac OS X, Linux)
- Metal (iOS, Mac OS X)
- OpenGL ES 3.0 (Android, WebGL 2.0)

> Other platforms do not support texture arrays (OpenGL ES 2.0 or WebGL 1.0). Use SystemInfo.supports2DArrayTextures to determine texture array support at runtime.


### ref
https://docs.unity3d.com/Manual/class-Texture2DArray.html

