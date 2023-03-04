## Lighting

a Light object is created by attaching a Light component to a GameObject.

Lights can be added to your scene from the **GameObject > Light** menu. You will choose the light format that you want from the sub-menu that appears. Once a light has been added, you can manipulate it like any other GameObject. Additionally, you can add a Light Component to any selected GameObject by using **Component > Rendering > Light**.

Lighting in Unity works by approximating how light behaves in the real world.

- **Direct light**:
  It is light that is emitted, hits a surface once, and is then reflected directly into a sensor (for example, the eye’s retina or a camera).
  
- **Indirect light**:
  It is all other light that is ultimately reflected into a sensor, including light that hits surfaces several times, and sky light. 
  
> To achieve realistic lighting results, you need to simulate both direct and indirect light.

- **Real-time lighting**:
  It is when Unity calculates lighting at runtime.

- **Baked lighting**:
  It is when Unity performs lighting calculations in advance and saves the results as lighting data, which is then applied at runtime.
  
>  In Unity, your Project can use real-time lighting, baked lighting, or a mix of the two (called **mixed lighting**).
  
- **Global illumination**:
  Global illumination is **a group of techniques** that **model both direct and indirect lighting to provide realistic lighting results**. Unity has two global illumination systems, which combine direct and indirect lighting.
  - **Baked Global Illumination system**:
    Consists of lightmappers, Light Probes, and Reflection Probes. There are three options for baking: the Progressive Lightmapper (CPU or GPU), and Enlighten Baked Global Illumination.
  - **Real-time Global Illumination system**: 
    It is Enlighten Realtime Global Illumination.
    
### Lighting window
The Lighting window (menu: **Window > Rendering > Lighting**) is the main control point for Unity’s lighting features.




### ref
https://www.youtube.com/watch?v=DlxuvvYZO4Q

https://www.youtube.com/watch?v=VnG2gOKV9dw
