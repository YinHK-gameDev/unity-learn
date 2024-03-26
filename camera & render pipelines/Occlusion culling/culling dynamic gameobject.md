## Occlusion culling with dynamic GameObjects

**Static GameObjects** and **dynamic GameObjects** behave differently in Unity’s occlusion culling system:
- Unity can **bake static GameObjects into the occlusion culling data** as a Static Occluder and/or a Static Occludee.
- Unity **cannot bake dynamic GameObjects into the occlusion culling data**. A **dynamic GameObject can be an occludee at runtime**, but it **cannot be an occluder**.


To determine whether a dynamic GameObject acts as a occludee, you can **set the Dynamic Occlusion property on any type of Renderer component**. When Dynamic Occlusion is enabled, Unity **culls the Renderer when a Static Occluder blocks it from a Camera
’s view**. When Dynamic Occlusion is disabled, Unity does not cull the Renderer when a Static Occluder blocks it from a Camera’s view.

> Dynamic Occlusion is enabled by default. You might want to disable Dynamic Occlusion to achieve specific effects, such as drawing an outline around a character who is behind a wall.

If you are certain that Unity should never apply occlusion culling to a particular GameObject, you can disable Dynamic Occlusion to save on runtime calculations and reduce CPU usage. The per-GameObject impact of these calculations is very small, but at sufficient scale this might benefit performance.
