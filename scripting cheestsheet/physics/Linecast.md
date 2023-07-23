## Linecast
Returns true if there is any collider intersecting the line between start and end.

### `Physics.Linecast`
```cs
public static bool Linecast(Vector3 start, Vector3 end, int layerMask = DefaultRaycastLayers, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal);
```
Eg:
```cs
using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour
{
    public Transform target;
    void Update()
    {
        if (Physics.Linecast(transform.position, target.position))
        {
            Debug.Log("blocked");
        }
    }
}


```

### `Physics2D.Linecast`
```cs

public static RaycastHit2D Linecast(Vector2 start, Vector2 end, int layerMask = DefaultRaycastLayers, float minDepth = -Mathf.Infinity, float maxDepth = Mathf.Infinity);
```



### ref
https://docs.unity3d.com/2020.1/Documentation/ScriptReference/Physics.Linecast.html

https://docs.unity3d.com/2020.1/Documentation/ScriptReference/Physics2D.Linecast.html

