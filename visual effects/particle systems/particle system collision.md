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


https://docs.unity3d.com/Manual/PartSysCollisionModule.html


### `MonoBehaviour.OnParticleCollision(GameObject)`

`OnParticleCollision` is called when a particle hits a Collider.

This can be used to apply damage to a GameObject when hit by particles.

Detecting collisions between particles and game objects in Unity involves using Unity's physics system and collision events. Unity's Particle System provides a built-in collision module that allows particles to interact with colliders in the scene. Here's a step-by-step guide on how to achieve collision detection between particles and game objects:

1. Set up Particle System with Collision Module:
Create a particle system by selecting **"GameObject" > "Effects" > "Particle System"** in the Unity editor.

In the Inspector window, find the **"Collision Module"** under the Particle System module.

Enable the **"Collision Module"** by checking the checkbox.

Adjust the settings in the Collision Module according to your requirements. You can specify the type of collision, bounce, and other parameters.

2. Add Collider to Game Object:
Make sure the game object with which you want particles to collide has a collider component attached to it (e.g., Box Collider, Sphere Collider, etc.).
3. Handle Collision Events in Script:
- Create a C# script to handle collision events. Attach this script to the game object that has the collider.

```cs
public class ParticleCollisionHandler : MonoBehaviour
{
    private void OnParticleCollision(GameObject other)
    {
        Debug.Log("Particle collided with: " + other.name);
        
        // Add your custom logic here
    }
}
```
The **`OnParticleCollision`** method is called when a particle collides with the collider attached to the game object.

4. Fine-Tune Collision Events (Optional):
- You can customize the collision events further by using the information provided by the **`OnParticleCollision`** method, such as getting the collision point, normal, and other relevant data.

```cs
private void OnParticleCollision(GameObject other)
{
    ContactPoint[] collisionPoints = new ContactPoint[particleCollisionEvent.intersectionCount];
    int count = particleCollisionEvent.GetContacts(collisionPoints);

    for (int i = 0; i < count; i++)
    {
        ContactPoint contact = collisionPoints[i];
        Debug.Log("Collision Point: " + contact.point);
        Debug.Log("Collision Normal: " + contact.normal);
        
        // Add your custom logic here
    }
}
```



