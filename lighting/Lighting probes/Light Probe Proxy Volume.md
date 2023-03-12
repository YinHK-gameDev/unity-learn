## Light Probe Proxy Volume component
![](../img/LPPV.png)

The **Light Probe Proxy Volume (LPPV)** component allows you to use more lighting information **for large dynamic GameObjects** that cannot use baked lightmaps (for example, **large Particle Systems** or **skinned Meshes**).

By default, **a probe-lit Renderer receives lighting from a single Light Probe that is interpolated between the surrounding Light Probes in the Scene**.

Because of this, GameObjects have constant ambient lighting across the surface. This lighting has a rotational gradient because it is using spherical harmonics, but it lacks a spatial gradient. This is more noticeable on larger GameObjects or Particle Systems. The lighting across the GameObject matches the lighting at the anchor point, and if the GameObject straddles a lighting gradient, parts of the GameObject may look incorrect.

The **Light Probe Proxy Volume** component generates a **3D grid of interpolated Light Probes** inside a **Bounding Volume**. 

You can specify the resolution of this grid in the UI of the component. The **spherical harmonics (SH) coefficients** of the interpolated Light Probes are uploaded into **3D textures**. The 3D textures containing **SH coefficients** are then sampled at render time to **compute the contribution to the diffuse ambient lighting**. This adds a **spatial gradient** to probe-lit GameObjects.


The **Standard Shader** supports this feature. To add this to a custom shader, use the **`ShadeSHPerPixel`** function.


 > When you set the **Light Probes** property in the Mesh Renderer component to **Use Proxy Volume**, the GameObject must have a **Light Probe Proxy Volume (LPPV)** component attached.

You can add a **LPPV component** on the same GameObject, or you can use (borrow) a **LPPV component** from another GameObject using the **Proxy Volume Override** property. If Unity cannot find a **LPPV component** in the current GameObject or in the Proxy Volume Override GameObject, a warning message is displayed at the bottom of the Renderer.


### ref 

https://docs.unity3d.com/Manual/class-LightProbeProxyVolume.html






