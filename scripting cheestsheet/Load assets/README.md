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

> **Note**: `AssetDatabase` class cannot be used at runtime. The `AssetDatabase` is part of Unity’s **Editor-only API** within the `UnityEditor` namespace, meaning it is designed specifically for working within the Unity Editor and is not available or functional in a runtime build (such as on a standalone, mobile, or web platform).

### `Resources` class
The Resources class allows you to find and access Objects including assets.

In the editor, **`Resources.FindObjectsOfTypeAll`** can be used to **locate assets and Scene objects**.

#### `Resources.Load`
Loads the asset of the requested type stored at path in a **Resources folder**.

This method returns the asset at path if it can be found, otherwise it returns `null`.
Note that the path is **case insensitive and must not contain a file extension**. All asset names and paths in Unity use **forward slashes**, so using **backslashes** in the path will not work.

Specify the path inside **`Resources` folder**.

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
        var textFile = Resources.Load("Text/textFile01") as TextAsset;

        //Load text from a JSON file (Assets/Resources/Text/jsonFile01.json)
        var jsonTextFile = Resources.Load<TextAsset>("Text/jsonFile01");
        var jsonTextFile = Resources.Load("Text/jsonFile01") as TextAsset;
        //Then use JsonUtility.FromJson<T>() to deserialize jsonTextFile into an object

        //Load a Texture (Assets/Resources/Textures/texture01.png)
        var texture = Resources.Load<Texture2D>("Textures/texture01");
        var texture = Resources.Load("Textures/texture01") as Texture2D;

        //Load a Sprite (Assets/Resources/Sprites/sprite01.png)
        var sprite = Resources.Load<Sprite>("Sprites/sprite01");
        var sprite = Resources.Load("Sprites/sprite01") as Sprite;

        //Load an AudioClip (Assets/Resources/Audio/audioClip01.mp3)
        var audioClip = Resources.Load<AudioClip>("Audio/audioClip01");
        var audioClip = Resources.Load("Audio/audioClip01") as AudioClip;
    }
}
```

### Addressable package & API

**`Addressables.LoadAssetAsync<GameObject>("AssetAddress");`**

or

**`Addressables.InstantiateAsync("AssetAddress");`**


> **Note**: Both **`LoadAssetAsync`** and **`InstantiateAsync`** are **asynch operations**. You may provide a callback(Just like event handler) to work with the asset once it is loaded.

```cs
// Load a single asset, IResourceLocation: The location of the asset.
public static AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(IResourceLocation location)

// Load a single asset, The key of the location of the asset.
public static AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(object key)

// Load mutliple assets
public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IList<object> keys, Action<TObject> callback, Addressables.MergeMode mode)

public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(object key, Action<TObject> callback)
```


Use Struct **`AsyncOperationHandle<TObject>`** for handle **asynch operations**. And 
**`AsyncOperationHandle<TObject>.Completed`** to raise an event. 

```cs
public event Action<AsyncOperationHandle<TObject>> Completed
```

Eg:

```cs
void Update()
{
    if(Input.GetKeyDown(KeyCode.T))
    {
      AsyncOperationHandle<GameObject> asyncOperationHandle =
          Addressables.LoadAssetAsync<GameObject>("AssetAddress");

      asyncOperationHandle.Completed += AsyncOperationHandle_Completed;
    }
}


void AsyncOperationHandle_Completed(AsyncOperationHandle<GameObject> asyncOperationHandle)
{
  if(asyncOperationHandle.Status == AsyncOperationStatus.Succeeded)
  {
    Instantiate(asyncOperationHandle.Result);
  } else
    {
       Debug.Log("failed to load");
    }

}

```

```cs
AsyncOperationHandle<Texture2D> textureHandle = Addressables.LoadAsset<Texture2D>("mytexture");

// Convert the AsyncOperationHandle<Texture2D> to an AsyncOperationHandle
AsyncOperationHandle nonGenericHandle = textureHandle;

// Convert the AsyncOperationHandle to an AsyncOperationHandle<Texture2D>
AsyncOperationHandle<Texture2D> textureHandle2 = nonGenericHandle.Convert<Texture2D>();

// The exact type is required. This will throw and exception because Texture2D is required
AsyncOperationHandle<Texture> textureHandle3 = nonGenericHandle.Convert<Texture>();


private void TextureHandle_Completed(AsyncOperationHandle<Texture2D> handle)
{
    if (handle.Status == AsyncOperationStatus.Succeeded)
    {
        Texture2D result = handle.Result;
        // Texture ready for use
    }
}

void Start()
{
    AsyncOperationHandle<Texture2D> textureHandle = Addressables.LoadAsset<Texture2D>("mytexture");
    textureHandle.Completed += TextureHandle_Completed;
}


public IEnumerator Start()
{
    AsyncOperationHandle<Texture2D> handle = Addressables.Load<Texture2D>("mytexture");
    yield return handle;
    if (handle.Status == AsyncOperationStatus.Succeeded)
    {
        Texture2D texture = handle.Result;
        // Texture ready for use...

        // Done. Release resource
        Addressables.ReleaseHandle(handle);
    }
}


public async Start()
{
    AsyncOperationHandle<Texture2D> handle = Addressables.Load<Texture2D>("mytexture");
    await handle.Task;
    // Task has completed. Be sure to check the Status has succeeded before getting the Result
}

```


**`AsyncOperationHandle`** & **`AsyncOperationHandle<TObject>`** Struct: \
https://docs.unity3d.com/Packages/com.unity.addressables@1.1/api/UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle.html \
https://docs.unity3d.com/Packages/com.unity.addressables@0.7/manual/AddressableAssetsAsyncOperationHandle.html \
https://docs.unity3d.com/Packages/com.unity.addressables@1.1/api/UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle-1.html


**`Addressables`** Class: \
https://docs.unity3d.com/Packages/com.unity.addressables@1.1/api/UnityEngine.AddressableAssets.Addressables.html


https://z0935323866.medium.com/unity-%E5%B0%8B%E5%9D%80%E5%BC%8F%E8%B3%87%E6%BA%90%E7%AE%A1%E7%90%86%E7%B3%BB%E7%B5%B1addressable-assets-system-%E4%B8%80-bb1e99014a88 \
https://www.youtube.com/watch?v=C6i_JiRoIfk \
https://www.youtube.com/watch?v=bCObS3teFGM


### ref 
https://docs.unity3d.com/ScriptReference/Resources.html \
https://docs.unity3d.com/ScriptReference/Resources.Load.html \
https://docs.unity3d.com/ScriptReference/AssetDatabase.html \
https://docs.unity3d.com/ScriptReference/AssetDatabase.LoadAssetAtPath.html \
https://docs.unity3d.com/Packages/com.unity.addressables@1.21/api/index.html
