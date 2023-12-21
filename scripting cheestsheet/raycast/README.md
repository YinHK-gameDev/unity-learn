## `Raycast`
The **`Raycast` function** is useful for **creating connections between objects** in Unity.

> **Raycast** in Unity is a Physics function that **projects a Ray into the scene**, **returning a boolean value if a target was successfully hit**. When this happens, information about the hit, such as the distance, position or a reference to the object’s Transform, can be stored in a **Raycast Hit variable** for further use.


- **Raycasting** is the process of **shooting an invisible ray from a point**, in a **specified direction** to detect **whether any colliders lay in the path of the array.**
- A **raycast** sends an imaginary **"laser beam"** along the ray from its origin until it **hits a collider**
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
A **Ray** is simply a **data struc**t in Unity that represents **a point of origin** and **a direction** for the **Ray to travel**.

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


#### Use the Raycast Hit variable
The **Raycast Hit** variable is a **data struct** that **stores information about Ray’s collision**.
It records information like where the hit happened in the world, what object did the Ray collide with and how far away it was from the origin of the Ray.

```cs
// Container for hit data
RaycastHit hit;

```
You can get **the position of the hit** in the world using **`RaycastHit.point`**:
```cs
Vector3 hitPosition = hit.point;
```

You also can get **the distance from the Ray’s origin to the point of impact** using **`RaycastHit.distance`**:
```cs
float hitDistance = hit.distance;
```

You can also get information about the **Collider that was hit**, such as its **`Tag`**.
```cs
// Reads the Collider tag
string tag = hit.collider.tag;
```

You could even use Raycast Hit to get a **reference** to an object’s **Transform**:
```cs
// Gets a Game Object reference from its Transform
GameObject hitObject = hit.transform.gameObject;
```

> Using a **Raycast Hit variable** with Raycast will store information about the first object that is hit by the Ray.

https://docs.unity3d.com/ScriptReference/RaycastHit.html

#### Use the Raycast function
While the **Ray** and **Raycast Hit variables** define where a Ray will go and how information from hits will be stored, they don’t do anything on their own.

To fire Rays into the scene, and check if they hit anything, you need **Raycast function** for help.


Raycast function:

- **`Physics.Raycast`**: \
  https://docs.unity3d.com/ScriptReference/Physics.Raycast.html
- **`Plane.Raycast`**: \
  https://docs.unity3d.com/2018.4/Documentation/ScriptReference/Plane.Raycast.html
- **`Collider.Raycast`**: \
  https://docs.unity3d.com/ScriptReference/Collider.Raycast.html



### Visualise Raycast in the scene
> The **Debug** Class includes a function, **`Draw Ray`**, that allows you to **render a Ray** in the world.

```cs
Ray ray = new Ray(transform.position, transform.forward);

// Render a visible line using Draw Ray, passing in the same value
Debug.DrawRay(ray.origin, ray.direction * 10);
```

#### `RaycastHit`
Structure used to **get information** back from a **raycast**.


#### `Ray`
Representation of **rays**.

A **ray** is an **infinite line** starting at **origin and going in some direction**.


### ref
https://learn.unity.com/tutorial/let-s-try-shooting-with-raycasts#

https://gamedevbeginner.com/raycasts-in-unity-made-easy/

https://www.youtube.com/watch?v=B34iq4O5ZYI

https://learn.unity.com/tutorial/let-s-try-shooting-with-raycasts#

https://www.youtube.com/watch?v=EINgIoTG8D4

https://docs.unity3d.com/ScriptReference/Physics.html

https://docs.unity3d.com/2018.4/Documentation/ScriptReference/Plane.Raycast.html

https://docs.unity3d.com/ScriptReference/Collider.Raycast.html

https://docs.unity3d.com/ScriptReference/RaycastHit.html

https://docs.unity3d.com/ScriptReference/Ray.html


