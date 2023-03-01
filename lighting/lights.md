## Lights


**GameObject > Light**
 
Place the light object where you want it in the scene. If you enable scene view lighting (the "**lightbulb**" button on the toolbar) then you can see a preview of how the lighting will look as you move light objects and set their parameters.

### Types of light
- Point Light
- Spot Light
- Directional Light
- Area Light

![](./img/PointLightDiagram.svg)

![](./img/Light-Point.jpg)

![](./img/SpotLightDiagram.svg)

![](./img/Light-Spot.jpg)

![](./img/DirectionalLightDiagram.svg)

![](./img/Light-Direct.jpg)

![](./img/AreaLightDiagram.svg)


### Light modes
The Modes are:

- **Baked**: \
  Unity **pre-calculates** the illumination from **Baked Lights before runtime**, and **does not include them in any runtime lighting calculations**.
  
- **Realtime**: \
  Unity **calculates and updates the lighting of Realtime Lights every frame at runtime**. Unity does not precompute any calculations for Realtime Lights.
  
- **Mixed**: \
  Unity **performs some calculations for Mixed Lights in advance, and some calculations at runtime**. 

### ref
https://docs.unity3d.com/Manual/Lighting.html


