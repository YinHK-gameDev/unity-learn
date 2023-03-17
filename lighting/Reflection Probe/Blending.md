## Blending

To enable **Reflection Probe blending** navigate to **Graphic Settings > Tier settings**. 

> Tier settings are only available in Unity’s Built-in Render Pipeline. When blending is enabled,

Unity gradually **fades out one probe’s cubemap** while **fading in the other’s as the reflective object passes from one zone to the other**. This gradual transition avoids the situation where a distinctive object suddenly “pops” into the reflection as an object crosses the zone boundary.

> Blending is controlled using the Reflection Probes property of the Mesh Renderer
 component.
  
  
