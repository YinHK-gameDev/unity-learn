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

- Multiple Importance Sampling
  Enable this to use multiple importance sampling for sampling the environment. This generally leads to faster convergence when generating lightmaps, but can lead to noisier results in certain low frequency environments. This is disabled by default.
  
- Direct Samples
  The number of samples (paths) shot from each texel. This setting controls the number of samples Progressive Lightmapper uses for direct lighting calculations. Increasing this value can improve the quality of lightmaps, but increases the baking time.
  
- Indirect Samples
  The number of samples (paths) shot from each texel. This setting controls the number of samples Progressive Lightmapper uses for indirect lighting calculations. For some Scenes, especially outdoor Scenes, 100 samples should be enough. For indoor Scenes with emissive geometry, increase the value until you see the result you want.
  
- Environment Samples
  The Environment Samples property determines the total number of environment rays that Unity fires toward the skybox to gather light directly. Unity fires these rays from the lightmap texel or light probe position depending on the context. The default value is 500. Higher values might yield smoother results, but at the cost of increased bake times.

In Scenes with HDR skyboxes, more samples are often needed to reduce noise in the final lightmap or probe. Scenes with skyboxes that include bright singularities (such as the sun) or high-frequency details with significant contrast (such as backlit clouds) also benefit from a higher number of samples.\



  
  
  
  
  
  


### ref
https://docs.unity3d.com/Manual/progressive-lightmapper.html

