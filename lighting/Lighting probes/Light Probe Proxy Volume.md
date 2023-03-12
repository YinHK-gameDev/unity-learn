## Light Probe Proxy Volume component
![](../img/LPPV.png)

The **Light Probe Proxy Volume (LPPV)** component allows you to use more lighting information **for large dynamic GameObjects** that cannot use baked lightmaps(for example, **large Particle Systems** or **skinned Meshes**).

By default, **a probe-lit Renderer receives lighting from a single Light Probe that is interpolated between the surrounding Light Probes in the Scene**.

Because of this, GameObjects have constant ambient lighting across the surface. This lighting has a rotational gradient because it is using spherical harmonics, but it lacks a spatial gradient. This is more noticeable on larger GameObjects or Particle Systems. The lighting across the GameObject matches the lighting at the anchor point, and if the GameObject straddles a lighting gradient, parts of the GameObject may look incorrect.

The Standard Shader supports this feature. To add this to a custom shader, use the ShadeSHPerPixel function.


 > When you set the **Light Probes** property in the Mesh Renderer component to **Use Proxy Volume**, the GameObject must have a **Light Probe Proxy Volume (LPPV)** component attached.


### ref 

https://docs.unity3d.com/Manual/class-LightProbeProxyVolume.html






