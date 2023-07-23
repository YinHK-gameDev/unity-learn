## Application
Access to application runtime data.

### `Application.persistentDataPath`
Contains the path to a persistent data directory (Read Only).

This value is a directory path (notice the difference in slash directions on different operating systems according to Path.DirectorySeparatorChar), where you can store data that you want to be kept between runs. When you publish on iOS and Android, persistentDataPath points to a public directory on the device. Files in this location are not erased by app updates. The files can still be erased by users directly.

When you build the Unity application, a GUID is generated that is based on the Bundle Identifier. This GUID is part of persistentDataPath. If you keep the same Bundle Identifier in future versions, the application keeps accessing the same location on every update.


eg:
```cs
using UnityEngine;

public class Info : MonoBehaviour
{
    void Start()
    {
        Debug.Log(Application.persistentDataPath);
    }
}
```



### ref
https://docs.unity3d.com/ScriptReference/Application.html


