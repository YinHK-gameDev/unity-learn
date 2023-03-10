## Realtime Global Illumination
> Unity uses a **middleware solution** called **Enlighten** for **Realtime Global Illumination**.

By default, Realtime Lights contribute only direct lighting to a Scene. If you enable **Realtime Global Illumination (Enlighten Realtime Global Illumination)** in your Scene, Realtime Lights also **contribute indirect lighting** to a Scene.


### When to use?

Enlighten Realtime Global Illumination (Realtime GI) is useful for Lights that change slowly and have a significant visual impact on your Scene, such as the sun moving across the sky, or a slowly pulsating light in a closed corridor. This feature is not intended for special effects or Lights that change quickly, because latency and the number of CPU cycles needed make that sort of application impractical. Enlighten Realtime Global Illumination
 is suitable for games targeting mid-level to high-end PC systems and consoles. Some high-end mobile devices may also be powerful enough to make use of this feature, but you should keep Scenes small and the resolution for real-time lightmaps low to ensure acceptable performance.
 
 
 




https://docs.unity3d.com/Manual/realtime-gi-using-enlighten.html

