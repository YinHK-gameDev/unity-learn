## Resources class

The Resources class allows you to find and access Objects including assets.

All assets that are in a folder named "Resources" anywhere in the Assets folder can be accessed via the `Resources.Load` functions. Multiple **"Resources"** folders may exist and when loading objects each will be examined.



### `Resources.Load`
Loads the asset of the requested type stored at path in a Resources folder.

```cs
public static T Load(string path);
```
```cs
Resources.Load(string path);
```
eg:

```cs
// Loading assets from the Resources folder using the generic Resources.Load<T>(path) method
using UnityEngine;

public class ExampleClass : MonoBehaviour
{
    void Start()
    {
        //Load a text file (Assets/Resources/Text/textFile01.txt)
        var textFile = Resources.Load<TextAsset>("Text/textFile01");

        //Load text from a JSON file (Assets/Resources/Text/jsonFile01.json)
        var jsonTextFile = Resources.Load<TextAsset>("Text/jsonFile01");
        //Then use JsonUtility.FromJson<T>() to deserialize jsonTextFile into an object

        //Load a Texture (Assets/Resources/Textures/texture01.png)
        var texture = Resources.Load<Texture2D>("Textures/texture01");

        //Load a Sprite (Assets/Resources/Sprites/sprite01.png)
        var sprite = Resources.Load<Sprite>("Sprites/sprite01");

        //Load an AudioClip (Assets/Resources/Audio/audioClip01.mp3)
        var audioClip = Resources.Load<AudioClip>("Audio/audioClip01");
    }
}
```


### `Resources.UnloadAsset`
```cs
public static void UnloadAsset(Object assetToUnload);
```
The referenced asset (assetToUnload) will be unloaded from memory. The object will become invalid and can't be loaded back from disk. Any subsequently loaded Scenes or assets that reference the asset on disk will cause a new instance of the object to be loaded from disk. This new instance will not be connected to the previously unloaded object.

### `Resources.UnloadUnusedAssets`

```cs
public static AsyncOperation UnloadUnusedAssets();
```

Unloads assets that are not used.

An asset is deemed to be unused if it isn't reached after walking the whole game object hierarchy, including script components. Static variables are also examined.


### ref 
https://docs.unity3d.com/ScriptReference/Resources.html \
https://docs.unity3d.com/Manual/LoadingResourcesatRuntime.html



