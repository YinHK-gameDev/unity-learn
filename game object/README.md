## GameObject

If a GameObject does not move at runtime, it is known as a static GameObject. If a GameObject moves at runtime, it is known as a dynamic GameObject.
 
Many systems in Unity can precompute information about static GameObjects in the Editor. Because the GameObjects do not move, the results of these calculations are still valid at runtime. This means that Unity can save on runtime calculations, and potentially improve performance. So check the **static** box to indicate the GameObject is static.


### Static GameObjects
If a GameObject does not move at runtime, it is known as a static GameObject. If a GameObject moves at runtime, it is known as a dynamic GameObject.

Many systems in Unity can precompute information about static GameObjects in the Editor. Because the GameObjects do not move, the results of these calculations are still valid at runtime. This means that Unity can save on runtime calculations, and potentially improve performance.


The Static Editor Flags checkbox and drop-down menu, as seen when viewing a GameObject in the Inspector

![](./GameObjectStaticDropDownMenu1.png)

> You can also set the Static Editor Flags property in code, using the `GameObjectUtility.SetStaticEditorFlags` API, and the `GameObject.isStatic`.


| Property: | Function: |
| --- | --- |
| Nothing | Do not include the GameObject in precomputations for any systems. |
| Everything | Include the GameObject in precomputations for all systems below. |
| Contribute GI | When you enable this property, Unity includes the target Mesh Renderer in global illumination calculations. These calculations take place while precomputing lighting data at bake time. The ContributeGI property exposes the ReceiveGI property. The ContributeGI property only takes effect if you enable a global illumination setting such as Baked Global Illumination or Enlighten Realtime Global Illumination for the target Scene. A Unity Blog post about static lighting with Light Probes provides guidance for using this flag. For additional context, see this tutorial for setting up the Built-in Render Pipeline and lighting in Unity. |
| Occluder Static | Mark the GameObject as a Static Occluder in the occlusion culling system. For more information, see the documentation on the Occlusion Culling system. |
| Occludee Static | Mark the GameObject as a Static Occludee in the occlusion culling system. For more information, see the documentation on the Occlusion Culling system. |
| Batching Static | Combine the GameObject’s Mesh with other eligible Meshes, to potentially reduce runtime rendering costs. For more information, see the documentation on Static Batching. |
| Navigation Static | Include the GameObject when precomputing navigation data. For more information, see the documentation on the Navigation system. |
| Off Mesh Link Generation | Attempt to generate an OffMesh Link that starts from this GameObject when precomputing navigation data. For more information, see the documentation on automatically building OffMesh Links. |
| Reflection Probe | Include this GameObject when precomputing data for Reflection Probes whose Type property is set to Baked. For more information, see the documentation on Reflection Probes. |
