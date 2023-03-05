## Lightmapping

Lightmapping is the **process of pre-calculating the brightness of surfaces in a Scene** , and **storing the result in a Texture** called a **lightmap** for later use.



> The data baked into **lightmaps cannot change at runtime**. Real-time lights can be overlaid and used additively on top of a lightmapped scene, but cannot interactively change the lightmaps themselves.

**Unity provides the following lightmappers for generating lightmaps:**

- **Progressive Lightmapper**
- **Enlighten Baked Global Illumination**

### Preparing the Scene and baking the lightmaps

Select **Window > Rendering > Lighting** from the Unity Editor menu to open the Lighting window. Make sure any Mesh you want to apply a lightmap to has proper UVs for lightmapping. The easiest way to do this is to open the Mesh import settings and enable the **Generate Lightmap UVs setting**.

Next, to control the resolution of the **lightmaps**, go to the **Lightmapping Settings** section and adjust the **Lightmap Resolution** value.

To be included in your lightmap, Renderers must meet the following criteria:

- Have a **Mesh Renderer** or **Terrain component**
- Be marked as **Contribute GI**
- Use a built-in Unity Material, the **Standard Shader**, or a Shader with a **Meta Pass**

You can adjust settings for Lights in the **Light Explorer**. To open the Light Explorer, go to **Window > Rendering > Light Explorer**.

To **generate lightmaps** for your Scene:

- Open the Lighting window (menu: **Window > Rendering > Lighting**)
- At the bottom of the **Scene** tab on the Lighting window, select **Generate Lighting** (or ensure that Auto Generate is enabled).
- A progress bar appears in Unity Editor’s status bar, in the bottom-right corner.


When lightmapping is complete, Unity’s Scene and Game views update automatically and you can view the resulting lightmaps by going to the **Baked Lightmaps** tab in the Lighting Window.

> When you manually generate lighting, Unity adds Lighting Data Assets, baked lightmaps and Reflection Probes
 to the Assets folder.


To create a new Lightmap Parameters Asset, right-click in the Project window and go to Create > New Parameters Asset. Unity stores this in your Project folder.

### Lightmap Parameters Asset

A LightmapParameters Asset contains a set of values for the parameters that control Unity’s lighting features. These Assets allow you to define and save different sets of values for lighting, for use in different situations.

Lightmap Parameters Assets allow you to quickly create presets optimized for different types of GameObjects
, or for different platforms and different Scene types (for example, indoor or outdoor Scenes).


To create a new Lightmap Parameters Asset, right-click in the **Project window** and go to** Create > Lightmap Parameters**. Unity stores this in your Project folder. Or **Assets > Create > Lightmap Parameters**.

### Assigning Lightmap Parameters Assets

#### Scenes
To assign a **Lightmap Parameters Asset** **to the whole Scene**:

- Open the Lighting window (**Window > Rendering > Lighting**)
- Click the **Scene** tab
- Navigate to the **Lightingmapping Settings**.
- Use the **Lightmap Parameters** drop-down to assign a default Lightmap Parameters Asset. This drop-down lists all available Lightmap Parameters Assets.

#### GameObjects
To assign a **Lightmap Parameters Asset** to a single **GameObject**, ensure the GameObject has a **Mesh Renderer** or **Terrain component** attached.

To assign a Lightmap Parameters Asset to a **Mesh Renderer** component:

- In the Inspector, go to **Mesh Renderer > Lighting**
- Enable **Contribute Global Illumination**
- In the mesh Renderer component, go to **Lightmapping > Lightmap Parameters**.
- Select an option from the menu. Select **Scene Default Parameter** to use the same Lightmap Parameters Asset that’s assigned to the whole Scene.

To assign a Lightmap Parameters Asset to a **Terrain** component:

- In the Inspector, go to **Terrain > Terrain Settings > Lighting**
- Enable **Contribute Global Illumination**
- In **Terrain Settings**, go to **Lightmapping > Lightmap Parameters.**
- Select an option from the menu. Select **Scene Default Parameter** to use the same Lightmap Parameters Asset that’s assigned to the whole Scene.

### Directional Mode
There are two Directional Modes for lightmaps: 
- **Directional** 
- **Non-Directional**. 

 Both modes are compatible with real-time lightmaps from Unity’s **Enlighten Realtime Global Illumination
 system**, and **baked lightmaps from Unity’s Progressive Lightmapper**.

> The default mode is Directional

![](./img/DirectionalLightmapping1.jpg)
![](./img/DirectionalLightmapping2.jpg)




### ref
https://www.youtube.com/watch?v=KJ4fl-KBDR8

https://www.youtube.com/watch?v=okYhs6kQ0xw

https://docs.unity3d.com/Manual/Lightmappers.html


