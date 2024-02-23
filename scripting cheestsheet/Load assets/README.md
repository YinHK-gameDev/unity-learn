## Loading assets


### `AssetDatabase` class
An Interface for accessing assets and performing operations on assets.

#### `AssetDatabase` class

**`AssetDatabase.LoadAssetAtPath`**, **`AssetDatabase.LoadMainAssetAtPath`**, **`AssetDatabase.LoadAllAssetRepresentationsAtPath`**, **`AssetDatabase.LoadAllAssetsAtPath`** & **`AssetDatabase.ImportAsset`**


Returns the first asset object of type **type** at given path **assetPath**.

Some asset files may contain multiple objects. (such as a Maya file which may contain multiple Meshes and GameObjects). All paths are relative to the project folder, for example: "Assets/MyTextures/hello.png".  
  
**Note:**  
The **assetPath** parameter is not case sensitive.  
**ALL** asset names and paths in Unity use forward slashes, even on Windows.  
This returns only an asset object that is visible in the Project view. If the asset is not found `LoadAssetAtPath` returns Null.

```cs
public static Object LoadAssetAtPath(string assetPath, Type type);
```

Eg:
```cs
using UnityEngine;
using UnityEditor;

public class MyPlayer : MonoBehaviour
{
    [MenuItem("AssetDatabase/LoadAssetExample")]
    static void ImportExample()
    {
        Texture2D t = (Texture2D)AssetDatabase.LoadAssetAtPath("Assets/Textures/texture.jpg", typeof(Texture2D));
    }
}
```

### `Resources` class
The Resources class allows you to find and access Objects including assets.

In the editor, `Resources.FindObjectsOfTypeAll` can be used to locate assets and Scene objects.

#### `Resources.Load`
Loads the asset of the requested type stored at path in a **Resources folder**.

This method returns the asset at path if it can be found, otherwise it returns null.
Note that the path is case insensitive and must not contain a file extension. All asset names and paths in Unity use forward slashes, so using backslashes in the path will not work.

```cs
public static T Load(string path);
```

EG:

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


### ref 
https://docs.unity3d.com/ScriptReference/Resources.html \
https://docs.unity3d.com/ScriptReference/Resources.Load.html \
https://docs.unity3d.com/ScriptReference/AssetDatabase.html \
https://docs.unity3d.com/ScriptReference/AssetDatabase.LoadAssetAtPath.html
