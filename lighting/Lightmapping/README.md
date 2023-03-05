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





### ref
https://www.youtube.com/watch?v=KJ4fl-KBDR8

https://www.youtube.com/watch?v=okYhs6kQ0xw

https://docs.unity3d.com/Manual/Lightmappers.html


