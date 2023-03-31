## Shader
A **shader program**, commonly referred to as a **shader**, is a program that **runs on a GPU**.
 
In computer graphics, a shader is a **computer program** that calculates the appropriate levels of **light, darkness, and color during the rendering of a 3D scene** - a process known as shading.


**Materials** use specialised **graphics programs** called **Shaders** to render a texture on the mesh surface. **Shaders** can **implement lighting and colouring effects** to simulate shiny or bumpy surfaces.

> **Materials** and **shaders** are closely linked, work together to define the **appearance of surface** in an gameobject




- **shader or shader program** - **a program that runs on a GPU**. Unless otherwise specified, this means shader programs that are part of the **graphics pipeline**.
- **Shader object** - an instance of the **Shader** class. A Shader object is a wrapper for shader programs and other information.
- **ShaderLab** - a Unity-specific language for writing shaders.
- **Shader Graph** - a tool for creating shaders without writing code.
- **shader asset** - a file with the **`.shader`** extension in your Unity project. It defines a Shader object.
- **Shader Graph asset** - a file in your Unity project. It defines a Shader object.


### Types of shader
In Unity, shaders are divided into **three broad categories**. You use each category for different things, and work with them differently.

- Shaders that are part of the graphics pipeline are the most common type of shader. They perform calculations that determine the color of pixels on the screen. In Unity, you usually work with this type of shader by using Shader objects.
- Compute shaders perform calculations on the GPU, outside of the regular graphics pipeline.
- Ray tracing shaders perform calculations related to ray tracing.

### Shader assets
A **shader asset** is an asset in your Unity project that defines a Shader object. It is a text file with a **`.shader`** extension. It contains **shader code**.


### ref
https://docs.unity3d.com/Manual/ShadersOverview.html

https://www.youtube.com/watch?v=fhmf5PacfVg

https://kendevlog.wordpress.com/2017/08/12/unity%E9%96%8B%E7%99%BC%E7%AD%86%E8%A8%984-%E5%AF%AB%E5%80%8B%E7%B0%A1%E5%96%AEshader/

https://www.arkaistudio.com/blog/2016/10/04/%E4%B8%80%E8%B5%B7%E5%AD%B8-unity-shader-%E4%B8%80%EF%BC%9A%E6%96%B0%E6%89%8B%E5%85%A5%E9%96%80/

https://medium.com/ericzhan-publication/shader%E7%AD%86%E8%A8%98-shader-development-using-unity-01-b1cde1f23adf

https://kendevlog.wordpress.com/2017/08/12/unity%E9%96%8B%E7%99%BC%E7%AD%86%E8%A8%984-%E5%AF%AB%E5%80%8B%E7%B0%A1%E5%96%AEshader/

