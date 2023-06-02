## Skybox
A skybox is a cube with a different texture on each face. When you use a skybox to render a sky, Unity essentially places your Scene
 inside the skybox cube. Unity renders the skybox first, so the sky always renders at the back.


Similar to other sky implementations, you can use a skybox to do the following:

- Render a **skybox** around your Scene.
- Configure your lighting settings to create **realistic ambient lighting** based on the **skybox**.
- Override the skybox that an individual **Camera** uses, using the **skybox component**.

> **Notes**: The **Built-in Render Pipeline**, and the **Universal Render Pipeline (URP)** both exclusively use skyboxes to render a sky. These skyboxes are Materials that use a skybox Shader.
The **High Definition Render Pipeline (HDRP)** does not support skybox Materials and instead includes multiple sky generation solutions.

### using skyboxes
https://docs.unity3d.com/Manual/skyboxes-using.html

### ref 
https://docs.unity3d.com/Manual/skyboxes.html

