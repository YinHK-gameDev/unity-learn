## Loading assets


### `AssetDatabase` class
An Interface for accessing assets and performing operations on assets.

#### `AssetDatabase.LoadAssetAtPath`
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


### ref 
https://docs.unity3d.com/ScriptReference/Resources.Load.html \
https://docs.unity3d.com/ScriptReference/AssetDatabase.html \
https://docs.unity3d.com/ScriptReference/AssetDatabase.LoadAssetAtPath.html
