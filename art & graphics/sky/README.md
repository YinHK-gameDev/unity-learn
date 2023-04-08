## Sky
### Sky and render pipelines
The sky solutions you can use depend on which render pipeline your Project uses.
 
 
| Render pipeline | Sky Solution |
| --- | --- |
| Built-in Render Pipeline | The Built-in Render Pipeline uses a skybox Material to define a sky for Cameras to draw. You can specify the sky on a per-Scene basis and also override the sky for an individual Camera.• For information on how to set the sky on a per-Scene basis, see the Lighting window documentation.• For information on how to override the sky for a specific Camera, see the Skybox component documentation. |
| Universal Render Pipeline (URP) | URP uses the same sky solution as the Built-in Render Pipeline and allows you to specify the sky on a per-Scene basis and override the sky for an individual Camera.• For information on how to set the sky on a per-Scene basis, see the Lighting window documentation.• For information on how to override the sky for a specific Camera, see the Skybox component documentation. |
| High Definition Render Pipeline (HDRP) | HDRP includes its own sky solution that uses the Volume system. Each Volume can include an override to specify a type of sky to draw. Each Camera interpolates between the sky settings for every Volume that affects it and draws the result.For information on how to create a sky in HDRP, see the Visual Environment documentation. |

### SkyManager

Unity includes a dedicated manager—the **SkyManager**—to ensure that environment lighting affects your scene **by default**.
 
The **SkyManager** automatically generates an **ambient probe** and default **reflection probe** to capture environment lighting.


Unity updates these probes each time environment lighting in your scene changes, until the moment you generate lighting. After you generate lighting, Unity bakes the current environment light values into the probes.


When you specifically use the Generate Lighting control to manually bake your lighting, Unity stops updating the probes from that point onward and only updates them again at the next bake. If you want Unity to continue to update the probes each time the environment lighting changes, enable the Auto Generate option.

If you remove the Lighting Data Asset from your project, Unity continues to update the probes each time the environment lighting changes.


#### Disabling the SkyManager

To prevent the environment contribution from automatically affecting the lighting result for a scene or GameObject
 that does not have manually created light maps and Light Probes, **disable the default Reflection Probe and the ambient probe**.
 
 
 To disable these probes, navigate to **Window** > **Rendering** > **Lighting Settings** > **Environment**, then make one of the following changes:

-   Option 1: Set **Intensity Multiplier** to 0.
-   Option 2: Use a black **Skybox** 
-   Option 3: Set either the **Color** or **Gradient** for the **Source** to black.

#### Disable the SkyManager for all scenes

To prevent the environment contribution from automatically affecting the lighting result for all scenes, navigate to **Window** > **Rendering** > **Lighting Settings** > **Scene**, then disable **Recalculate Environment Lighting**.


### Skybox
A skybox is a cube with a different texture on each face. When you use a skybox to render a sky, Unity essentially places your Scene inside the skybox cube. Unity renders the skybox first, so the sky always renders at the back.
 
Similar to other sky implementations, you can use a skybox to do the following:

- Render a skybox around your Scene.
- Configure your lighting settings to create realistic ambient lighting based on the skybox.
- Override the skybox that an individual Camera uses, using the **skybox component**. 
 
**Notes:**

1. The **Built-in Render Pipelin**, and the **Universal Render Pipeline (URP)** both exclusively use skyboxes to render a sky. These skyboxes are Materials that use a skybox Shader.
2. The **High Definition Render Pipeline (HDRP)** does not support skybox Materials and instead includes multiple sky generation solutions.


> In Unity, a **skybox** is a Material that uses a **skybox Shader**.

**Notes:**

1. The **Built-in Render Pipeline**, and the **Universal Render Pipeline (URP)** both exclusively use skyboxes to render a sky. These skyboxes are Materials that use a skybox Shader.
2. The **High Definition Render Pipeline (HDRP)** does not support skybox Materials and instead includes multiple sky generation solutions.


### Creating a skybox Material
To create a new **skybox Material**:

1. From the menu bar, click **Assets > Create > Material**.
2. In the **Shader** drop-down, click **Skybox** then the **skybox Shader** you want to use.
3. You can now **fill out the properties on the Material** to set up the skybox. The properties available on the Material depend on the skybox Shader the Material uses.

> **Note**: Each skybox Shader has its own set of prerequisite Textures that differ in number and Texture format
. For information on the Textures a particular skybox Shader requires, see the documentation for that skybox Shader.


### Drawing a skybox in your Scene

After you create a **skybox Material**, you can render it in your **Scene**. To do this:

1. From the menu bar, click **Window > Rendering > Lighting** Settings.
2. In the window that appears, click the **Environment** tab.
3. Assign the skybox Material to the **Skybox Material** property.

> **Note**: This draws the skybox in the background of every Camera
 in your Scene. If you instead only want to draw the skybox for a particular Camera.
 
### Drawing a skybox for a particular Camera

If you only want to draw a skybox in the background of a particular Camera, use the **Skybox component**. When you **attach this component to a GameObject with a Camera**, it **overrides the skybox that the Camera draws**. To attach and set up the **Skybox component**:
 
1. Select a Camera in your Scene and view it in the **Inspector** window.
2. Click **Add Component > Rendering > Skybox**.
3. On the Skybox component, assign the skybox Material to the **Custom Skybox** property.
 

 
 
