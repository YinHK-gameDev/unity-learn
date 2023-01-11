## Layers
Layers are a tool that allows you to separate GameObjects in your scenes.

### Use of layers
Common uses of layers include: 
- **Layer-based rendering**. 
- **Layer-based collision**.

### Camera culling mask with layers
You can render only the objects in a particular layer, or selection of layers, if you use the **Camera’s culling mask**.
To change the culling mask, select the camera you want to use, and select the Culling Mask dropdown in the Inspector window. If you clear the checkbox of a layer, it doesn’t render in the scene.

> Note: UI elements and screen space canvas children are exceptions to this and render regardless.

### Ray cast with layers
Use layers to specify which GameObjects that a ray cast can intersect with.

To make a ray cast ignore a GameObject, you can **assign it to the Ignore Raycast layer**, or pass a **LayerMask** to the ray cast API call.

If you don’t pass a LayerMask to the ray cast API call, Unity uses Physics.DefaultRaycastLayers which matches every layer except Ignore Raycast.

The Physics.Raycast function uses a bitmask, and each bit determines if a layer is ignored by rays or not. If all bits in the layerMask are on, the ray collides against all colliders. If the layerMask = 0, there are no collisions.
