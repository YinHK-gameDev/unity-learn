## Texture types
Below are the properties available to configure the various Texture types in Unity in the **Texture Inspector** window.
 
 
- **Default** \
  Default is the most common Texture type used for all Textures. It provides access to most of the properties for Texture importing. With this Texture type, you can also change the Texture Shape property to define the Texture Shape.
- **Normal map** \
  Select Normal map
 to turn the color channels into a format suitable for real-time normal mapping. With this Texture type, you can also change the Texture Shape property to define the Texture Shape.
- **Editor GUI and Legacy GUI** \
  Select Editor GUI and Legacy GUI if you are using the Texture on any HUD or GUI controls. The Texture Shape property is always set to 2D for this Texture Type. For more information, see the documentation on Texture Shapes.
- **Sprite (2D and UI)** \
  Select **Sprite (2D and UI)** if you are using the Texture in a 2D game as a **Sprite**
. The Texture Shape property is always set to 2D for this Texture Type. For more information, see the documentation on Texture Shapes.
- **Cursor** \
  Select Cursor to use the Texture as a **custom cursor**. The Texture Shape property is always set to 2D for this Texture Type
- **Cookie** \
  Select **Cookie** to set your Texture up with the basic parameters used for cookies in the **Built-in Render Pipeline**
. With this Texture type, Unity updates the Texture Shapes property automatically based on the selected **Light Type**:
  - **Directional** and **Spotlight** cookies are always **2D Textures** (the 2D shape type).
  - **Point Light cookies** must be **cubemaps** (the Cube shape type).
- **Lightmap** \
  elect Lightmap
 if you are using the Texture as a Lightmap. This option enables encoding into a specific format (RGBM or dLDR, depending on the platform) and a post-processing
 step on Texture data (a push-pull dilation pass). The Texture Shape property is always set to 2D for this Texture Type.
- **Single Channel** \
  Select Single Channel if you only need one channel in the Texture. With this Texture type, you can also change the Texture Shape property to define the Texture Shape.













### ref
https://docs.unity3d.com/Manual/TextureTypes.html

