## Lightmap UVs

Texture coordinates, commonly called UVs, describe how to "**wrap**" a texture around geometry. Lightmaps
 are textures, so Unity needs UVs to correctly use them in your scene.


Both the Realtime Global Illumination
 system and the Baked Global Illumination system use lightmaps, and therefore need lightmap
 UVs.
 
 
Unity uses separate sets of lightmap UVs for the Realtime Global Illumination system and the Baked Global Illumination system. There are two reasons for this:

- There is no direct correspondence in the grouping of instances between real-time and baked lightmaps; instances that are in the same real-time lightmap may be in two different baked lightmaps, and vice versa.
- Meshes that appear at different scales share lightmap UVs in baked lightmaps, but do not share UVs in real-time lightmaps.


