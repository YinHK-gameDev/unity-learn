## Mipmap
A **mip or mip level** is a **version of a texture with a specific resolution**. 
**Mips** exist in sets called **mipmaps**. 
**Mipmaps** contain progressively **smaller and lower resolution versions** of a single texture.

**Mipmaps** are commonly used for rendering objects in 3D scenes, where textured objects can vary in distance from the camera. A higher mip level is used for objects closer to the camera, and lower mip levels are used for more distant objects.

Mipmaps can speed up rendering operations and reduce rendering artifacts in situations where the GPU renders a texture at less than its full resolution.

You can create a mipmap for a texture manually, or you can instruct Unity to generate a mipmap for you. To automatically generate a mipmap, ensure that your original texture’s resolution is a power of two value, as shown in the example mipmap image.

You can enable or disable mipmaps for a texture asset in the Texture Import Settings Inspector.

### Mipmap Streaming system
The Mipmap Streaming system gives you control over how Unity loads mipmaps.

This system forces Unity to only load the mip levels needed to render the current Camera
 position, instead of loading all of them by default. It trades a small amount of CPU resources to save a potentially large amount of GPU memory.

You can set a total memory limit for all textures in an application, and the system automatically reduces mip levels to stay within this budget.

### Enabling Mipmap Streaming

To enable **Mipmap Streaming**, go to Unity’s Quality Settings (**Edit > Project Settings > Quality**) and **enable the Texture Streaming checkbox**.

When you enable this setting, the Quality settings window reveals the settings specific to the Mipmap Streaming system.

> By default, this enables Mipmap Streaming for all Cameras in your project.



### ref
https://docs.unity3d.com/Manual/texture-mipmaps-introduction.html
