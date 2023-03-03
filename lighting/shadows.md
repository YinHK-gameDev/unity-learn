## Shadows
In Unity, Lights can cast shadows from a GameObject onto other parts of itself, or onto nearby GameObjects.

Unity uses a technique called **shadow mapping** to render real-time shadows.

### Shadow mapping
Shadow mapping or shadowing projection is a process by which shadows are added to 3D computer graphics.


Shadow mapping uses textures called **shadow maps**. Shadow maps are similar to depth textures. 

A Light generates a shadow map in a similar way to how a Camera generates a depth texture. 

If you imagine a Camera at the same location as the Light, the areas of the Scene that the Camera cannot see are the same areas of the Scene that rays from the Light cannot reach; therefore, they are in shadow.
 

Unity **populates the shadow map with information about how far rays from the Light travel before they hit a surface**, and then **samples the shadow map to calculate real-time shadows for GameObjects that the Light hits**.

### Shadow map resolution

To calculate the resolution of a shadow map, Unity:

1. Determines the area of the screen view that the Light can illuminate. For directional lights, the whole screen can be illuminated. For Spot Lights and Point Lights, the area is the onscreen projection of the shape of the light’s extent: a sphere for point lights, or a cone for Spot Lights. The projected shape has a width and height in pixels on the screen; the larger of those two values is then taken. This value is called the Light’s pixel
 size.

2. Determines the shadow quality multiplier. Unity uses the Shadow Resolution setting for this, which is set in the Quality Settings window). The quality settings correspond to the following values:

- Very High: 1.0
- High: 0.5
- Medium: 0.25
- Low: 0.125






https://en.wikipedia.org/wiki/Shadow_mapping





