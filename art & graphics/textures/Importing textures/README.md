## Importing textures

The **Texture Import Settings** window defines how Unity imports images from your project’s Assets folder into the Unity Editor.

To access this window, select the image file in the **Project window**. The **Texture Import Settings** window appears in the **Inspector**.

> **Note**: Some of the less commonly used properties are hidden by default. Expand the Advanced section in the Inspector window to view these properties.

![](../img/class-TextureImporter.png)


There are several sections on the Texture Import Settings window:

**(A)** [Texture Type](https://docs.unity3d.com/Manual/class-TextureImporter.html#texturetype). Select the type of Texture you want to create.

**(B)** [Texture Shape](https://docs.unity3d.com/Manual/class-TextureImporter.html#textureshape). Select the shape and set properties specific to that shape in this area.

**(C)** [Type-specific and advanced settings](https://docs.unity3d.com/Manual/class-TextureImporter.html#advanced). Depending on what **Texture Type** value you select, extra properties might appear in this area. For more information, see the documentation on [Texture types](https://docs.unity3d.com/Manual/class-TextureImporter.htmlTextureTypes.html).

**(D)** [Platform-specific overrides](https://docs.unity3d.com/Manual/class-TextureImporter.html#platform). Use the **Platform-specific overrides** panel to set default options and their overrides for a specific platforms.

**(E)** **Texture preview**. You can preview the Texture and adjust its values here.


### Texture Type

Use the **Texture Type** property to select the type of Texture you want to create from the source image file. The other properties in the Texture Import settings window change depending on the value you set.

For information about specific Texture Types, see the [Texture Types](https://docs.unity3d.com/Manual/class-TextureImporter.htmlTextureTypes.html) documentation.

 
| Property: | Function: |
| --- | --- |
| Default | This is the most common setting used for all Textures. It provides access to most of the properties for Texture importing. For more information, see the Default Texture type. |
| Normal map | Select this to turn the color channels into a format suitable for real-time normal mapping. For more information, see the Normal map Texture type documentation.For more information on normal mapping in general, see Importing Textures. |
| Editor GUI and Legacy GUI | Select this if you are using the Texture on any HUD or GUI controls. For more information, see the Editor GUI and Legacy GUI Texture type documentation. |
| Sprite (2D and UI) | Select this if you are using the Texture in a 2D game as a Sprite. For more information, see the Sprite (2D and UI) Texture type documentation. |
| Cursor | Select this if you are using the Texture as a custom cursor. For more information, see the Cursor Texture type documentation. |
| Cookie | Select this to set your Texture up with the basic parameters used for the Cookies of your Scene’s Lights. For more information, see the Cookie Texture type documentation. |
| Lightmap | Select this if you are using the Texture as a Lightmap. This option enables encoding into a specific format (RGBM or dLDR, depending on the platform) and a post-processing step on Texture data (a push-pull dilation pass). For more information, see the Lightmap Texture type documentation. |
| Single Channel | Select this if you only need one channel in the Texture. For information on the properties available only for the this type |


### Texture Shape

Use the **Texture Shape** property to select and define the shape and structure of the Texture. There are four shape types:

-   **2D** is the most common setting for all Textures; it defines the image file as a 2D Texture. These are used to map Textures to 3D Meshes and GUI elements, among other Project elements.
-   **Cube** defines the Texture as a [cubemap](https://docs.unity3d.com/Manual/class-TextureImporter.htmlclass-Cubemap.html). You could use this for Skyboxes or **Reflection Probes** , for example. This type is only available with the Default, Normal Map, and Single Channel Texture types.
-   **2D Array** defines the Texture as a **2D array texture**. This is commonly used as an optimization for some rendering techniques, where many textures of the same size & format are used.
-   **3D** defines the Texture as a 3D texture. 3D textures are used by some rendering techniques to represent volumetric data.

### ref
https://docs.unity3d.com/Manual/class-TextureImporter.html


