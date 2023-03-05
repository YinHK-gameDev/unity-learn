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

- Light Probe Sample Multiplier
  Controls how many samples are used for Light Probes as a multiplier of the sample values above. Higher values improve the quality of Light Probes, but they will take longer to bake. To enable this feature, go to Project Settings > Editor and disable Use legacy Light Probe sample counts. The default value is 4.
  
  
- Bounces
  Use this value to specify the number of indirect bounces to do when tracing paths. For most Scenes, two bounces is enough. For some indoor Scenes, more bounces might be necessary.
  
- Min Bounces
  The minimum number of bounces you are willing for the Progressive Lightmapper to include in indirect lighting calculations.

  Lower values reduce bake times, but might increase lightmap noise. To improve performance during bakes, the Lightmapper terminates light paths that contribute little to the appearance of the Scene using a technique called Russian Roulette.

  **Default value: 2. Range: 0–100**
  
- Max Bounces
  The maximum number of bounces you want the Progressive Lightmapper to include in indirect lighting calculations.

  **Default value: 2. Range: 0–100.**

  Values of up to 10 are suitable for most Scenes. Values higher than 10 might lead to significantly longer bake times.

  Each bounce increases the computational resources needed to bake your scene. Use higher bounce values for indoor Scenes, and lower bounce values for outdoor Scenes and those with many bright surfaces.

  As the range between Min Bounces and Max Bounces broadens, the amount of noise visible in your lightmaps increases.
  
- Filtering
  - None: Select this to use no filter or denoising for the lightmap.
  - Auto: Select this to use a platform-dependent preset for post-processing the lightmap.
If your development machine fulfils the requirements to run OptiX (the NVIDIA OptiX AI-Accelerated Denoiser), the Progressive Lightmapper uses the denoiser with a Gaussian filter that has a 1-texel radius for all targets.
If your development machine cannot run OptiX, the Progressive Lightmapper uses a Gaussian filter that has a 1-texel radius for Direct, 5-texel radius for Indirect, and 2-texel radius for Ambient Occlusion.
  - Advanced: Select Advanced to manually configure options for each type of lightmap target. The targets types are Direct, Indirect and Ambient Occlusion
. For more information, see Advanced Filtering settings, below.
  
  
###  The Progressive GPU Lightmapper
The Progressive GPU Lightmapper is a backend for the Progressive Lightmapper which uses your computer’s GPU and Dedicated Video Ram (VRAM) to generate baked lightmaps and Light Probes
  
The Progressive GPU Lightmapper bakes faster than the Progressive CPU Lightmapper, unless lightmapper tiling is active.

Other applications competing for GPU resources also have an impact on baking performance. Depending on your hardware vendor, reductions in the amount of VRAM available to Unity can slow down the bake, cause it to fail, or even result in the Progressive GPU Lightmapper falling back to the CPU if the GPU cannot meet minimum memory requirements. Closing other applications while you are working with this functionality can improve stability and performance.

https://docs.unity3d.com/Manual/GPUProgressiveLightmapper.html  


### The Progressive CPU Lightmapper and the Progressive GPU Lightmapper 

You can choose between two backends for the Progressive Lightmapper. 
- The **Progressive CPU Lightmapper** backend is a backend for the Progressive Lightmapper that uses your **computer’s CPU and system RAM**.  
- The **Progressive GPU Lightmapper** is a backend for the Progressive Lightmapper that uses your **computer’s GPU and VRAM**.



### ref
https://docs.unity3d.com/Manual/progressive-lightmapper.html

