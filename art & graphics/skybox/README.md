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

#### Creating a skybox Material

To create a new skybox Material:

1.  From the menu bar, click **Assets > Create > Material**.
2.  In the **Shader** drop-down, click **Skybox** then the **skybox Shader** you want to use.
3.  You can now fill out the properties on the Material to set up the skybox. The properties available on the Material depend on the skybox Shader the Material uses.

> **Note**: Each skybox Shader has its own set of prerequisite Textures that differ in number and Texture format.

#### Drawing a skybox in your Scene
After you create a **skybox Material**, you can render it in your Scene. To do this:

-   From the menu bar, click **Window > Rendering > Lighting Settings**.
-   In the window that appears, click the **Environment** tab.
-   Assign the skybox Material to the **Skybox Material** property.

> This draws the skybox in the background of every Camera in your Scene.

#### Using a skybox Material for ambient light settings

After you create a skybox Material, Unity can use it to generate ambient lighting in your Scene. To make Unity do this:

1.  Open the Lighting window (menu: **Window > Rendering > Lighting Settings**).
2.  Assign your chosen skybox to the **Skybox Material** property.
3.  Click the **Source** drop-down and, from the list, click **Skybox**.

You can also specify when Unity updates the ambient lighting. To do this, change the **Ambient Mode**. The two values are:

-   **Realtime**: Unity constantly regenerates ambient lighting for your Scene. This is useful if you alter the skybox at run-time
-   **Baked**: Unity only generates ambient lighting for your Scene when you click the **Generate Lighting** button at the bottom of the Lighting window. This is useful if your skybox does not change during run-time because it saves computational resources.


#### Drawing a skybox for a particular Camera
If you only want to draw a skybox in the background of a **particular Camera**, use the **Skybox component**. When you attach this component to a **GameObject with a Camera**, it **overrides the skybox that the Camera draws**. 

1. Select a **Camera** in your Scene and view it in the **Inspector** window.
2. Click **Add Component > Rendering > Skybox**.
3. On the **Skybox component**, assign the **skybox Material** to the **Custom Skybox property**.

https://docs.unity3d.com/Manual/skyboxes-using.html

### Skybox shaders
Unity provides multiple **Skybox Shaders** for you to use. Each **Shader** uses a different set of properties and generation techniques. Each Shader falls into one of the following two categories:

1. **Textured**: Generates a skybox from **one or multiple textures**. The source textures represent the view of the background from all directions. The Skybox Shaders in this category are:
   -   [6 Sided](https://docs.unity3d.com/Manual/skybox-shaders.htmlshader-skybox-6sided.html)
   -   [Cubemap](https://docs.unity3d.com/Manual/skybox-shaders.htmlshader-skybox-cubemap.html)
   -   [Panoramic](https://docs.unity3d.com/Manual/skybox-shaders.htmlshader-skybox-panoramic.html)
2. **Procedural**: Does not use textures and instead uses properties on the Material to generate a skybox. The Skybox Shader in this category is: [Procedural](https://docs.unity3d.com/Manual/skybox-shaders.htmlshader-skybox-procedural.html).

https://docs.unity3d.com/Manual/skybox-shaders.html

### ref 
https://docs.unity3d.com/Manual/skyboxes.html

https://www.youtube.com/watch?v=anYBZzxy1FA
