## Blending

To enable **Reflection Probe blending** navigate to **Graphic Settings > Tier settings**. 

> Tier settings are only available in Unity’s Built-in Render Pipeline. When blending is enabled,

Unity gradually **fades out one probe’s cubemap** while **fading in the other’s as the reflective object passes from one zone to the other**. This gradual transition avoids the situation where a distinctive object suddenly “pops” into the reflection as an object crosses the zone boundary.

> Blending is controlled using the **Reflection Probes** property of the **Mesh Renderer** component.
  
  
**Four blending options are available:**
- **Off** - Reflection probe blending is disabled. Only the skybox will be used for reflection.
- **Blend Probes** - Blends only **adjacent probes** and ignores the skybox. You should use this for objects that are **"indoors**" or in **covered parts of the scene (eg, caves and tunnels)** since the sky is not visible from these place and so should never appear in the reflections.
- **Blend Probes and Skybox** - Works like **Blend Probes** but also allows the skybox to be used in the blending. You should use this option for objects in the open air, where the sky would always be visible.
- **Simple** - **Disables blending between probes** when there are two **overlapping** reflection probe volumes.



### ref
https://docs.unity3d.com/Manual/UsingReflectionProbes.html

