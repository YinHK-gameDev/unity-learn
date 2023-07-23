## Raycast
The Raycast function is useful for creating connections between objects in Unity.

> **Raycast** in Unity is a Physics function that projects a Ray into the scene, returning a boolean value if a target was successfully hit. When this happens, information about the hit, such as the distance, position or a reference to the object’s Transform, can be stored in a Raycast Hit variable for further use.


- **Raycasting** is the process of shooting an invisible ray from a point, in a specified direction to detect whether any colliders lay in the path of the array.

- A **raycast** sends an imaginary “laser beam” along the ray from its origin until it hits a collider
 in the scene. 

Eg:
```cs

void FireRay()
{
    Ray ray = new Ray(transform.position, transform.forward);
    RaycastHit hitData;
    Physics.Raycast(ray, out hitData);
}
```

### ref
https://learn.unity.com/tutorial/let-s-try-shooting-with-raycasts#

https://gamedevbeginner.com/raycasts-in-unity-made-easy/

https://docs.unity3d.com/ScriptReference/Physics.html

https://docs.unity3d.com/2018.4/Documentation/ScriptReference/Plane.Raycast.html

https://docs.unity3d.com/ScriptReference/Collider.Raycast.html
