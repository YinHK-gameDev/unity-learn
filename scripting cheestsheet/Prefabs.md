## Prefabs


### Instantiating Prefabs at run time

Eg:
```cs
using UnityEngine;
public class InstantiationExample : MonoBehaviour 
{
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject myPrefab;

    // This script will simply instantiate the Prefab when the game starts.
    void Start()
    {
        // Instantiate at position (0, 0, 0) and zero rotation.
        Instantiate(myPrefab, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
```

> Create any Prefab, and drag it from the Project window into the My Prefab field in the script component.

### ref
https://docs.unity3d.com/Manual/InstantiatingPrefabs.html
