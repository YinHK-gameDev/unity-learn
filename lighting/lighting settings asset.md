## Lighting Settings Asset
A Lighting Settings Asset represents a saved instance of the **`LightingSettings`** class, which stores data for the Baked Global Illumination and the **`Enlighten Realtime Global Illumination systems`**. The Unity Editor uses this data when it **precomputes lighting data for a Scene**
 that uses one or both of these systems.


> You can assign the same **`Lighting Settings Asset`** or **instance of the LightingSettings class to more than one Scene**, which makes it easy to share **`Global Illumination system settings`** across multiple Scenes.


### Creating a Lighting Settings Asset
There are two ways to create a Lighting Settings Asset in the Unity Editor.

To create a Lighting Settings Asset from the Project view:

1. In the Project view, either click the add (+) button, or open the context menu and navigate to Create.
2. Click Lighting Settings. Unity creates a new Lighting Settings Asset in the Project view.


To create and automatically assign Lighting Settings Asset from the Lighting window:

1. Open the Lighting window (menu: Window > Rendering > Lighting).
2. Open the Scene tab.
3. Click **New Lighting Asset**. Unity creates a new Lighting Settings Asset in the Project view, and immediately assigns it to the active Scene.

> You can also create a **Lighting Settings Asset** from a script. To do this, create an instance of the **`LightingSettings`** class and either save it to disk, or assign it to a Scene and save that Scene.


### Assigning a Lighting Settings Asset to a Scene

To assign a Lighting Settings Asset to a Scene in the Unity Editor:

1. Open the Scene that you want to assign the Lighting Settings Asset to.
2. If you have more than one Scene open, ensure that the Scene that you want to assign the Lighting Settings Asset to is the active Scene.
Open the Lighting window (menu: **Window > Rendering > Lighting**).
3. Open the Scene tab.
4. Either drag the Lighting Settings Asset to the **Lighting Settings** field, or click the icon to the right of the **Lighting Settings** field and choose the Lighting Settings Asset from the list.

You can also assign a Lighting Settings Asset to the active Scene from a script. To do this, load the Lighting Settings Asset to obtain an instance of the `LightingSettings` class, then use the `Lightmapping.lightingSettings` API to assign that `LightingSettings` instance to the active Scene.


### Viewing and editing the properties of a Lighting Settings Asset
You can view and edit the properties of Lighting Settings Asset in two places in the Unity Editor:

- In the Project view, if you select a Lighting Settings Asset, you can view and edit its properties in the Inspector.
- If the active Scene has a Lighting Settings Asset assigned to it, you can view and edit the properties of that Lighting Settings Asset in the Lighting Window’s Scene tab.


> You can also read from or write to the properties of a **Lighting Settings Asset** from a script. To do this, load the Lighting Settings Asset to obtain an instance of the `LightingSettings` class, and access its properties.

When a Scene does not have a Lighting Settings Asset assigned to it, Unity uses the **default** **LightingSettings object** for that Scene. The **default LightingSettings object** is an internal, read-only instance of the `LightingSettings` class.

> You **cannot make any changes to the LightingSettings data for a Scene that uses the default LightingSettings, but Unity can perform a bake using its settings.**

To make changes to the **LightingSettings data** for a Scene, you must use the Unity Editor to **create and assign a Lighting Settings Asset, or use a script to create, configure, and assign a `LightingSettings` object.** For more information and code examples, see the LightingSettings API documentation.

Unity automatically generates an ambient probe and a default Reflection Probe to ensure that environment lighting affects your scene and the GameObjects in it by default.


### Properties for Lighting Settings Asset

#### Realtime Lighting

Contains settings related to the **`Enlighten Realtime Global Illumination system`**.
| Property | Function |
| --- | --- |
| Realtime Global Illumination | Enable this property to use the Enlighten Realtime Global Illumination system in Scenes that use this Lighting Settings Asset. |
| Realtime Environment Lighting | Enable this property to use the Enlighten Realtime Global Illumination system to calculate and update ambient light in real-time.This property is only available when both Enlighten Realtime Global Illumination and Baked Global Illumination are enabled in the Scene. |


#### Mixed Lighting

Contains settings that affect the behavior of Baked Lights and Mixed Lights in Scenes that use this Lighting Settings Asset.

**Baked Global Illumination:** 
When this setting is enabled, Unity enables the Baked Global Illumination system for the Scenes that use this Lighting Settings Asset. When this setting is disabled, Unity disables the Baked Global Illumination system for the Scenes that use this Lighting Settings Asset.

When the Baked Global Illumination system is enabled, Unity uses Baked lights in the Scene for lightmapping only, and Mixed lights behave according to the Lighting Mode setting. When the Baked Global Illumination system is disabled, Unity forces all Baked and Mixed lights in the Scene to act as though they were Realtime Lights.

**Lighting Mode** 
- Baked Indirect: Use Baked Indirect Lighting Mode for all Mixed Lights in the Scenes that use this Lighting Settings Asset.
- Subtractive: Use Subtractive Lighting Mode for all Mixed Lights in the Scenes that use this Lighting Settings Asset.
- Shadowmask: Use Shadowmask Lighting Mode for all Mixed Lights in the Scenes that use this Lighting Settings Asset.




#### Lightmapping Settings

| Property | Function |
| --- | --- |
| Lightmap Resolution | Specifies the number of texels per unit to use for lightmaps. Increasing this value improves lightmap quality, but also increases bake times. Note that doubling this value causes the number of texels to quadruple because it determines both the height and width of the lightmap. See the Occupied texels count in the statistics area of the Lighting window. |
| Lightmap Padding | Determines the separation (in texel units) between separate shapes in the baked lightmap. The default is 2. |
| Max Lightmap Size | Specifies the size (in pixels) of the full lightmap texture, which incorporates a separate region for each included GameObject. The default value is 1024. |
| Lightmap compression | The level of compression the Editor uses for lightmaps.- None: Does not compress lightmaps.- Low Quality: This may use less memory and storage than Normal Quality, but can also introduce visual artifacts.- Normal Quality: This is a good trade-off between memory usage and visual quality.- High Quality: Requires more memory and storage than Normal Quality, but provides better visual results. |
| Ambient Occlusion | Controls the relative brightness of surfaces in baked ambient occlusion. This only applies to the indirect lighting calculated by the lightmapper you are using to bake your lighting. Enabled by default. If Ambient Occlusion is enabled, it exposes three settings: Max Distance, Indirect Contribution, and Direct Contribution. For all three settings, higher values indicate a greater contrast between occluded and fully lit areas. |
| Max Distance | Specifies how far the lighting system casts rays in order to determine whether or not to apply occlusion to an object. A higher value produces longer rays and contributes more shadows to the lightmap, while a lower value produces shorter rays that contribute shadows only when objects are very close to one another. A value of 0 casts an infinitely long ray that has no maximum distance. The default value is 1. |
| Indirect Contribution | Scales the brightness of indirect ambient light bounced and emitted from objects in the final lightmap. This is a value between 0 and 10. The default value is 1. Values less than 1 reduce the intensity, while values greater than 1 increase it. |
| Direct Contribution | Scales the brightness of direct light. This is a value between 0 and 10. The default value is 0. The higher this value is, the greater the contrast the Editor applies to the direct lighting. |
| Directional Mode | Enables the lightmap to store information about the characteristics of the dominant incoming light at each point on an object’s surface. See Directional Lightmapping for more information. The default mode is Directional. |
| Directional | In Directional mode, , Unity generates a second lightmap to store the dominant direction of incoming light. This makes it possible for diffuse normal mapped materials to work with the global illumination system. Shaders sample both lightmap textures during rendering. As a result, directional mode requires about twice as much video memory as non-directional mode for the additional lightmap data. Generating the additional directionality texture has an impact on baking performance. Directional lightmaps cannot be decoded on SM2.0 hardware or when using GLES2.0. |
| Non-directional | Non-directional mode lightmaps only include a single texture. As a result, they require less video memory and less storage than directional lightmaps, and are faster to decode in shaders. These optimizations reduce visual quality. |
| Indirect Intensity | Determines the brightness of indirect light stored in real-time and baked lightmaps. This is a value between 0 and 5. A value above 1 increases the intensity of indirect light while a value of less than 1 reduces indirect light intensity. The default value is 1. |
| Albedo Boost | Specifies the amount of light Unity bounces between surfaces. This value is between 1 and 10. Increasing this value pulls the albedo value towards white for indirect light computation. The default value of 1 is physically accurate. |
| Lightmap Parameters | A Lightmap Parameters Asset stores values for settings relevant to Baked Global Illumination. The Editor provides several default Lightmap Parameters Assets to choose from, but you can also create your own lightmap parameters file using the Create New option. See Lightmap Parameters for more information. The default value is Default-Medium. The options are Default-Medium, Default-HighResolution, Default-LowResolution, and Default-VeryLowResolution. |


### Auto Generation
When you view a Lighting Settings Asset in the Inspector, this property is at the top of the Inspector. When you view a Lighting Settings Asset in the Lighting window, this property is at the bottom of the Lighting window, near the Generate Lighting button.

| Property | Function: |
| --- | --- |
| Auto Generate | If Auto Generate is enabled, Unity precomputes lighting data automatically when you make changes to the Scene.This data includes lightmaps for the Baked Global Illumination system, data for the Enlighten Realtime Global Illumination system, Light Probes, and Reflection Probes.Unity usually begins the bake a few seconds after you make a change to the Scene. If Auto Generate is disabled, you must manually invoke a bake yourself, using the Generate Lighting button in the Lighting window, or the Lightmapping.Bake or Lightmapping.BakeAsync APIs.Note that when you precompute lighting data using Auto Generate, the precomputed lighting data is not stored as Assets in your Project. It is instead stored in memory, and serialized as part of the Scene. |



https://docs.unity3d.com/Manual/class-LightingSettings.html


### Lighting Mode

The **Lighting Mode** determines the **behavior of all Mixed Lights in all Scenes** that use the Lighting Settings Asset. 

- **Baked Indirect**
- **Shadowmask**
- **Subtractive** 
 
#### Baked Indirect
When you set a Scene’s Lighting Mode to Baked Indirect, **Mixed Lights behave like Realtime Lights**, with the additional benefit of baking indirect lighting into lightmaps. GameObjects lit by Mixed Lights cast real-time shadows up to the Shadow Distance you define in the Project.

When you set a Scene’s Lighting Mode to Baked Indirect, Mixed Lights behave as follows:

- Dynamic GameObjects lit by Mixed Lights receive:
  - Real-time direct lighting.
  - Baked indirect lighting, using Light Probes.
  - Shadows from dynamic GameObjects, using the shadow map, up to the Shadow Distance.
  - Real-time shadows from static GameObjects, using the shadow map, up to the Shadow Distance.
- Static GameObjects lit by Mixed Lights receive:
  - Real-time direct lighting.
  - Baked indirect lighting, using lightmaps.
  - Real-time shadows from static GameObjects, using the shadow map, up to the Shadow Distance.
  - Real-time shadows from dynamic GameObjects, using the shadow map, up to the Shadow Distance.

#### Shadowmask
Similar to Baked Indirect Lighting Mode, Shadowmask Lighting Mode combines real-time direct lighting with baked indirect lighting. However, Shadowmask Lighting Mode differs from Baked Indirect Lighting Mode in the way that it renders shadows. Shadowmask Lighting Mode allows Unity to combine baked and real-time shadows at runtime, and to render shadows in the far distance. It does this by using an additional lightmap Texture known as a shadow mask, and by storing additional information in Light Probes.

Shadowmask Lighting Mode provides the highest fidelity shadows among all the Lighting Modes, but has the highest performance cost and memory requirements. It is suitable for rendering realistic scenes where distant GameObjects are visible, such as open worlds, on high-end or mid-range hardware.

https://docs.unity3d.com/Manual/LightMode-Mixed-Shadowmask.html





