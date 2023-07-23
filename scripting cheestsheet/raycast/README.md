## Raycast
The Raycast function is useful for creating connections between objects in Unity.

> **Raycast** in Unity is a Physics function that projects a Ray into the scene, returning a boolean value if a target was successfully hit. When this happens, information about the hit, such as the distance, position or a reference to the object’s Transform, can be stored in a **Raycast Hit variable** for further use.


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


### How to use Raycast
The basic version of Raycast is made up of three different parts:
-   A **Ray** variable
-   A **Raycast Hit** variable
-   The **Raycast** function

#### Create a ray
A **Ray** is simply a data struct in Unity that represents a point of origin and a direction for the Ray to travel.

The **origin** is the position in the world that the Ray will start from. \
The direction property takes a trajectory in the form of a normalised Vector 3.

Eg:
```cs
// Creates a Ray from this object, moving forward
Ray ray = new Ray(transform.position, transform.forward);
```

```cs
// Creates a Ray from the center of the viewport
Ray ray = Camera.main.ViewportPointToRay(new Vector3 (0.5f, 0.5f, 0));
```

```cs
// Creates a Ray from the mouse position
Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
```

```cs
Ray ray;
void Update()
{
    ray = transform.position, transform.forward;
}
```





### Visualise Raycast in the scene
> The **Debug** Class includes a function, **`Draw Ray`**, that allows you to **render a Ray** in the world.

```cs
Ray ray = new Ray(transform.position, transform.forward);

// Render a visible line using Draw Ray, passing in the same value
Debug.DrawRay(ray.origin, ray.direction * 10);
```


### ref
https://learn.unity.com/tutorial/let-s-try-shooting-with-raycasts#

https://gamedevbeginner.com/raycasts-in-unity-made-easy/

https://www.youtube.com/watch?v=B34iq4O5ZYI

https://learn.unity.com/tutorial/let-s-try-shooting-with-raycasts#

https://www.youtube.com/watch?v=EINgIoTG8D4

https://docs.unity3d.com/ScriptReference/Physics.html

https://docs.unity3d.com/2018.4/Documentation/ScriptReference/Plane.Raycast.html

https://docs.unity3d.com/ScriptReference/Collider.Raycast.html
