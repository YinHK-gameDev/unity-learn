## Lightmapping using Enlighten Baked Global Illumination
Enlighten Baked Global Illumination relies on precomputed real-time global illumination data to generate indirect lighting. This can be an advantage, because you can produce new lightmaps fairly quickly after changing the scene’s lighting. However, Enlighten Baked Global Illumination imposes more UV layout limitations than the Progressive Lightmapper.

Enlighten Baked Global Illumination is deprecated (unlike Enlighten Realtime Global Illumination).


### Using the Enlighten lightmapper

To use Enlighten Baked Global Illumination, go to **Window > Rendering > Lighting**, navigate to **Lightmapping Settings**, and **set Lightmapper to Enlighten**.

> You can perform many of the functions available in this window via scripts, using the **`LightingSettings`** API.

### ref

https://docs.unity3d.com/Manual/GI-Enlighten.html

