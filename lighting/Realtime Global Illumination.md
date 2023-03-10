## Realtime Global Illumination
> Unity uses a **middleware solution** called **Enlighten** for **Realtime Global Illumination**.

By default, Realtime Lights contribute only direct lighting to a Scene. If you enable **Realtime Global Illumination (Enlighten Realtime Global Illumination)** in your Scene, Realtime Lights also **contribute indirect lighting** to a Scene.


### When to use?

Enlighten Realtime Global Illumination (Realtime GI) is useful for Lights that change slowly and have a significant visual impact on your Scene, such as the sun moving across the sky, or a slowly pulsating light in a closed corridor. This feature is not intended for special effects or Lights that change quickly, because latency and the number of CPU cycles needed make that sort of application impractical. Enlighten Realtime Global Illumination
 is suitable for games targeting mid-level to high-end PC systems and consoles. Some high-end mobile devices may also be powerful enough to make use of this feature, but you should keep Scenes small and the resolution for real-time lightmaps low to ensure acceptable performance.
 
 
 ### Using Enlighten Realtime Global Illumination
 To enable Enlighten Realtime Global Illumination in your Scene, open the **Lighting window** (menu: **Window > Rendering > Lighting**) and **enable Realtime Global Illumination**.
 
To disable the effect of **Realtime GI** on a specific Light, select the Light GameObject
 and, in the Light component, set the **Indirect Multiplier** to 0. This means that the Light doesn’t contribute any indirect light to the Scene.
 
To **disable Realtime GI** altogether, open the Lighting window (menu: **Window > Rendering > Lighting**) and uncheck Realtime Global Illumination.
 
 
### Light Probes and Enlighten Realtime Global Illumination
> **Note**: Light Probes
 behave differently when you enable Enlighten Realtime Global Illumination.
 
 In order to react to runtime changes in Scene lighting, they sample lighting iteratively at runtime.

When you disable Enlighten Realtime Global Illumination in a Scene, Light Probes only use baked lighting data. This means that they don’t react to runtime changes in Scene lighting.

 
https://learn.unity.com/project/lighting-optimization-with-precomputed-realtime-gi

https://docs.unity3d.com/Manual/realtime-gi-using-enlighten.html

