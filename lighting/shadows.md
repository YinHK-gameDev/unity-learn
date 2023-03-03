## Shadows
In Unity, Lights can cast shadows from a GameObject onto other parts of itself, or onto nearby GameObjects.

Unity uses a technique called **shadow mapping** to render real-time shadows.

### Shadow mapping
Shadow mapping or shadowing projection is a process by which shadows are added to 3D computer graphics.


Shadow mapping uses textures called **shadow maps**. Shadow maps are similar to depth textures. 

A Light generates a shadow map in a similar way to how a Camera generates a depth texture. 

If you imagine a Camera at the same location as the Light, the areas of the Scene that the Camera cannot see are the same areas of the Scene that rays from the Light cannot reach; therefore, they are in shadow.
 

Unity **populates the shadow map with information about how far rays from the Light travel before they hit a surface**, and then **samples the shadow map to calculate real-time shadows for GameObjects that the Light hits**.

https://en.wikipedia.org/wiki/Shadow_mapping





