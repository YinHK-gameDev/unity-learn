## Lightmapping using Enlighten Baked Global Illumination
Enlighten Baked Global Illumination relies on precomputed real-time global illumination data to generate indirect lighting. This can be an advantage, because you can produce new lightmaps fairly quickly after changing the scene’s lighting. However, Enlighten Baked Global Illumination imposes more UV layout limitations than the Progressive Lightmapper.

Enlighten Baked Global Illumination is deprecated (unlike Enlighten Realtime Global Illumination).


### Using the Enlighten lightmapper

To use Enlighten Baked Global Illumination, go to **Window > Rendering > Lighting**, navigate to **Lightmapping Settings**, and **set Lightmapper to Enlighten**.

> You can perform many of the functions available in this window via scripts, using the **`LightingSettings`** API.

### Properties
- Final Gather \
  Calculates the final global illumination light bounce of at the same resolution as the baked lightmap. This improves visual quality, but requires additional time to bake the lighting. If Final Gather is enabled, it exposes the settings Ray Count and Denoising.
  
- Indirect Resolution \
  Use this to specify **the number of samples the lightmapper uses for indirect lighting calculations**. Higher values can improve the quality of the lightmaps, but increase the time it takes to bake them.
  - Ray Count: 	Specifies the number of rays the lightmapper emits for every final gather point.
  - Denoising:  Applies a denoising filter to the final gather output.


  



### ref
https://docs.unity3d.com/Manual/GI-Enlighten.html

