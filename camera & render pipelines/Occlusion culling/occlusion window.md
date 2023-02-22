## Occlusion window


Before you begin, identify all of the GameObjects in your Scene that you would like to be Static Occluders (GameObjects that do not move, and that block the view of GameObjects that are behind them) and Static Occludees (GameObjects that do not move, and are occluded by Static Occluders). A GameObject can be both a Static Occluder and a Static Occludee.

Good candidates for Static Occluders are medium to large solid GameObjects, such as a wall or a building. To be a Static Occluder, a GameObject must:

- Have a Terrain or Mesh Renderercomponent
- Be opaque
- Not move at runtime

Any GameObject that is likely to be occluded at runtime is a good candidate to be a Static Occludee, including small or transparent GameObjects. To be a Static Occludee, a GameObject must:

- Have any type of Renderer component
- Not move at runtime

When you have identified the GameObjects that you would like to be Static Occluders and Static Occludees, you can set up your Scene.

1. Select all of the GameObjects that you would like to be **Static Occluders**.
2. In the Inspector window, open the **Static Editor Flags** drop-down menu and select **Occluder Static**.
3. Select all of the GameObjects that you would like to be **Static Occludees**.
4. In the Inspector window, open the **Static Editor Flags** drop-down menu and select **Occludee Static**.
5. Add a Camera to your Scene and select it, or select an existing Camera.
6. In the Inspector window, ensure that the **Camera’s Occlusion Culling property is enabled**.

**Static editor flags**: \
![](./static_editor+flag.png)


> Open the Occlusion Culling window by navigating to the top menu and selecting **Window > Rendering > Occlusion Culling**.

### Object tab
Occlusion Culling Window for a Mesh Renderer
In the Object tab, you can click the All, Renderers, and Occlusion Areas buttons to filter the contents of the Hierarchy window.

When the Renderers filter is active, select a Renderer in the Hierarchy window or Scene view to view and change its occlusion culling settings in the Occlusion Culling window.

When the Occlusion Areas filter is active, you can select an Occlusion Area in the Hierarchy window or Scene view to view and change its Is View Volume setting in the Occlusion Culling window. You can also click Create New Occlusion Area to create a new Occlusion Area in the Scene.

> At the bottom of the Bake tab are the Bake and Clear buttons. Click the Bake button to bake occlusion culling data. Click the Clear button to remove previously baked data.

| Setting | Description |
| --- | --- |
| Smallest Occluder | The size of the smallest GameObject that can occlude other GameObjects, in metres. In general, for the smallest file size and fastest bake times, you should choose the highest value that gives good results in your Scene. |
| Smallest Hole | The diameter of the smallest gap through which a Camera can see, in metres. In general, for the smallest file size and fastest bake times, you should choose the highest value that gives good results in your Scene. |
| Backface Threshold | If you need to reduce the size of the baked data, Unity can sample the Scene as it bakes, and exclude parts of the Scene where the visible occluder geometry consists of more than a given percentage of backfaces. An area with a high percentage of backfaces is likely to be underneath or inside geometry, and therefore not likely somewhere the Camera is at runtime. The default value of 100 never removes areas from the data. Lower values result in a smaller file size, but can lead to visual artifacts. |

### Bake data
In the Bake tab, you can fine-tune the parameters of the Occlusion Culling bake process. Configure these settings to find a balance between bake times, data size at runtime, and visual results.

![](./OcclusionCullingInspectorBake.png)

Occlusion culling inspector **bake** tab. 
- In the top menu, select **Window > Rendering > Occlusion Culling** to open the Occlusion Culling window.
- Select the **Bake** tab.
- In the bottom right hand corner of the Inspector window, press the Bake button. Unity generates the occlusion culling data, saves the data as an asset in your Project, and links the asset with the current Scene(s).

### Visualizion
![](./OcclusionCullingInspectorVisualization.png)

Occlusion Culling window **Visualization** tab.
- Ensure that the Occlusion Culling window and the Scene view are both visible. When the Occlusion Culling window is visible, Unity displays occlusion culling data and the Occlusion Culling popup in the Scene view.
- Select a Camera in the Scene.
- Move the Camera around, and observe the Scene view. You should see GameObjects disappear from view when the Camera cannot see them, due to either frustum culling or occlusion culling.
- Use the Occlusion Culling popup in the Scene view to configure the visualization.
- If required, tweak the bake settings in the Bake tab of the Occlusion Culling window, and repeat the baking process.
