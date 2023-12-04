## Particle system collision

### Collision module

This module controls how particles **collide with GameObjects in the Scene**. Use the first drop-down to define whether your collision settings apply to Planes or to the World
. If you choose World, use the Collision Mode drop-down to define whether your collision settings apply for a 2D or 3D world.

-   Click **GameObject** > **Effects** > **Particle System**.
-   In the **Inspector**, find the Particle System component.
-   In the Particle System component, find the Collision module fold-out.
-   To the left of the fold-out header, enable the checkbox.


When other objects surround a Particle System, the effect is often more convincing when the particles interact with those objects. For example, water or debris should be obstructed by a solid wall rather than simply passing through it

With the Collision module enabled, particles can collide with objects in the Scene.

A Particle System can be set so its particles collide with any Collider in the scene by selecting **World** mode from the pop-up. Colliders can also be disabled according to the layer they are on by using the **Collides With** property. The pop-up also has a **Planes** mode option which allows you to add a set of planes to the Scene that don’t need to have Colliders. This option is useful for simple floors, walls and similar objects, and has a lower processor overhead than **World** mode.

### ref 
https://docs.unity3d.com/Manual/PartSysCollisionModule.html

