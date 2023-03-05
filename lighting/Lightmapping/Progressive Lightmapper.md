## Progressive Lightmapper

The Progressive Lightmapper is a **fast path-tracing-based lightmapper system** that provides **baked lightmaps** and **Light Probes**
 with progressive updates in the Editor. It requires non-overlapping UVs with small area and angle errors, and sufficient padding between the charts.
 
 
The default value is Progressive CPU, because Enlighten Baked Global Illumination is deprecated (unlike Enlighten Realtime Global Illumination).


### Using the Progressive Lightmapper
To use the Progressive Lightmapper:

- Go to **Window > Rendering > Lighting**
- Navigate to **Lightmapping Settings**
- Set Lightmapper to **Progressive CPU** or **Progressive GPU**


### Settings
- Lightmapper \
  Use this to specify **which internal lighting calculation software** to use to calculate lightmaps in the Scene. The options are:
  - Progressive CPU
  - Progressive GPU
  - Enlighten

  > The default value is Progressive CPU

- Progressive Updates \
  Enable this to make the Progressive Lightmapper apply changes to the **texels** that are currently visible in the Scene View, then apply changes to the **out-of-view texels**.



### ref
https://docs.unity3d.com/Manual/progressive-lightmapper.html

