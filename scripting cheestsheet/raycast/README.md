## Raycast
Raycasting is the process of shooting an invisible ray from a point, in a specified direction to detect whether any colliders lay in the path of the array.

```cs

void FireRay()
{
    Ray ray = new Ray(transform.position, transform.forward);
    RaycastHit hitData;
    Physics.Raycast(ray, out hitData);
}
```


https://learn.unity.com/tutorial/let-s-try-shooting-with-raycasts#

https://gamedevbeginner.com/raycasts-in-unity-made-easy/
