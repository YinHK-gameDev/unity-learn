## Randam
Use to generating random data.(Eg: generate random game object)
  
#### `Random.Range()`

```cs
public static float Range(float minInclusive, float maxInclusive);
```



Returns a random float within **[minInclusive..maxInclusive]** (range is inclusive)

https://docs.unity3d.com/ScriptReference/Random.Range.html


#### `Random.insideUnitSphere`

Returns a random point inside or on a sphere with radius 1.0 (Read Only).

Note that the probability space includes the surface of the sphere because value, which is inclusive to 1.0, is used to acquire a random radius.

```cs
public static Vector3 insideUnitSphere;
```

Eg:
```cs
using UnityEngine;

public class Example : MonoBehaviour
{
    void Start()
    {
        // Sets the position to be somewhere inside a sphere
        // with radius 5 and the center at zero.

        transform.position = Random.insideUnitSphere * 5;
    }
}

```

#### `Random.onUnitSphere`

Returns a random point on the surface of a sphere with radius 1.0 (Read Only).

```cs
public static Vector3 onUnitSphere;
```


```cs
using UnityEngine;

public class Example : MonoBehaviour
{
    void Start()
    {
        // Sets the rigidbody velocity to 10 and in a random direction.

        GetComponent<Rigidbody>().velocity = Random.onUnitSphere * 10;
    }
}

```

#### `Random.rotation`

Returns a random rotation (Read Only).

Randomize the x, y, z, and w of a Quaternion each to [-1.0..1.0] (inclusive) via Range and normalize the result. See also rotationUniform for a slower but higher quality algorithm.





### ref

https://docs.unity3d.com/ScriptReference/Random.html

