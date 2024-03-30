## Lights


**GameObject > Light**
 
Place the light object where you want it in the scene. If you enable scene view lighting (the "**lightbulb**" button on the toolbar) then you can see a preview of how the lighting will look as you move light objects and set their parameters.

### Types of light
- Point Light
- Spot Light
- Directional Light
- Area Light

#### Point Lights
![](./img/PointLightDiagram.svg)

![](./img/Light-Point.jpg)

#### Spot Lights

![](./img/SpotLightDiagram.svg)

![](./img/Light-Spot.jpg)

#### Directional Lights
A Directional Light typically simulates sunlight, and a single Directional Light can illuminate the entire Scene.

![](./img/DirectionalLightDiagram.svg)

![](./img/Light-Direct.jpg)

#### Area Lights
![](./img/AreaLightDiagram.svg)


### Light modes
The Modes are:

- **Baked**: \
  Unity **pre-calculates** the illumination from **Baked Lights before runtime**, and **does not include them in any runtime lighting calculations**.
  
  At runtime, Unity loads the **baked lighting data**, and **uses it to light the Scene**. 
  
  Because the complex calculations are performed in advance, Baked Lights **reduce shading cost at runtime**, and **reduce the rendering cost of shadows**.
  
  **Baked Light behavior:**
  - Unity bakes both direct lighting and indirect lighting from **Baked Lights into lightmaps**.
  - Unity bakes both direct and indirect lighting from **Baked Lights into Light Probes**.
  
  **Limitations**:
  - You **cannot change the properties of Baked Lights** at runtime.
  - Baked Lights **do not contribute** to **specular lighting**.
  - **Dynamic GameObjects do not receive light or shadow from Baked Lights**.
  
  
> **Note**: if you disable Baked Global Illumination in your Scene, Unity forces Baked Lights to behave as though you set their Mode to Realtime. When this happens, Unity displays a warning on the Light component Inspector.

- **Realtime**: \
  Unity **calculates and updates the lighting of Realtime Lights every frame at runtime**. Unity does not precompute any calculations for Realtime Lights. 
  
  Unity performs the **lighting calculations for Realtime Lights at runtime, once per frame**. For example  flickering light bulbs, or a torch being carried through a dark room.
  
  Realtime Lights are useful for **lighting and casting shadows on characters or moveable geometry**.
  
  **Realtime Light behavior:**
  - Realtime Lights **cast shadows** up to the **Shadow Distanc**e.
  - By default, **Realtime Lights contribute only realtime direct lighting to a Scene**. If you’re using the **Built-in Render Pipeline**
 and you enable **Enlighten Realtime Global Illumination**
 in your Project, Realtime Lights also contribute realtime indirect lighting to your Scene.

  **Limitations**:
  - Performing runtime calculations for Realtime Lights **might be costly**, especially in complex scenes or on low-end hardware.
  - Because **Realtime Lights only contribute direct lighting to the Scene by default**, shadows appear completely black and there aren’t any indirect lighting effects, such as color bounce. This might cause unrealistic lighting in the Scene.
  
- **Mixed**: \
  Unity **performs some calculations for Mixed Lights in advance, and some calculations at runtime**. Mixed Lights **combine elements of both real-time and baked lighting**. You can use Mixed Lights to **combine dynamic shadows with baked lighting from the same light source**, or when you want **a light to contribute direct real-time lighting and baked indirect lighting**.
  
  > **Note**:  if you disable Baked Global Illumination
 in your Scene, Unity forces Mixed Lights to behave as though you set their Mode to Realtime. When this happens, Unity displays a warning on the Light component Inspector.


### Cookies
> A cookie is a **mask** that you **place on a Light to create a shadow with a specific shape or color**, which **changes the appearance** and **intensity of the Light**. 

To **apply a cookie to a Light** in Unity, **assign a texture to the Cookie field of a a Light component**.

Cookies may support different features depending on the render pipeline you are using.  Cookies are an **efficient way of simulating complex lighting effects** with minimal or **no runtime performance impact**. **Effects** you can **simulate with cookies include caustics, soft shadows, and light shapes**.

#### Enabling and disabling baked cookies
> For Projects created in Unity 2020.1 or above, **baked cookies are enabled for Baked Lights
 and Mixed Lights in the Progressive Lightmapper by default**.
 
You can **toggle whether cookies are enabled for Baked Lights and Mixed Lights in the Progressive Lightmapper** in the Editor settings window.

- Open the Project Settings window (**Edit > Project Settings**).
- Choose Editor to open the Editor settings.
- Navigate to the **Graphics** section.
- Toggle **Enable** **baked cookies support**.

#### Creating cookies for lighting texture
In cookies field, just click to select your texture asset.

> Note: If you are creating a cookie to use with a **Point Light**, lay your texture out as a **cubemap**. If you are creating a cookie to use with a **Spot Light** or **Directional Light**, lay your texture out as a regular **2D texture**.

Example: 

![](./img/Cookie.png)

![](./img/CookieExample.png)

https://docs.unity3d.com/Manual/creating-cookies-built-in-render-pipeline.html

https://medium.com/geekculture/how-to-use-cookies-to-create-realistic-lighting-in-unity-87ef95a94222

https://www.youtube.com/watch?v=0MZZ4seC3ZE

https://www.youtube.com/watch?v=uMUTy7Y14ug

### ref
https://docs.unity3d.com/Manual/Lighting.html


