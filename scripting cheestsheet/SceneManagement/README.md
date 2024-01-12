## SceneManagement

### Scene
Run-time **data structure** for **`*.unity`** file.

```cs
 Scene newScene = SceneManager.CreateScene("New Scene");
```

#### Properties

<table class="list"><tbody><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/SceneManagement.Scene.htmlSceneManagement.Scene-buildIndex.html">buildIndex</a></td><td class="desc">Return the index of the Scene in the Build Settings.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/SceneManagement.Scene.htmlSceneManagement.Scene-isDirty.html">isDirty</a></td><td class="desc">Returns true if the Scene is modified.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/SceneManagement.Scene.htmlSceneManagement.Scene-isLoaded.html">isLoaded</a></td><td class="desc">IsLoaded is set to true after loading has completed and objects have been enabled.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/SceneManagement.Scene.htmlSceneManagement.Scene-name.html">name</a></td><td class="desc">Returns the name of the Scene that is currently active in the game or app.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/SceneManagement.Scene.htmlSceneManagement.Scene-path.html">path</a></td><td class="desc">Returns the relative path of the Scene. For example: "Assets/MyScenes/MyScene.unity".</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/SceneManagement.Scene.htmlSceneManagement.Scene-rootCount.html">rootCount</a></td><td class="desc">The number of root transforms of this Scene.</td></tr></tbody></table>

#### Public Methods

<table class="list"><tbody><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/SceneManagement.Scene.htmlSceneManagement.Scene.GetRootGameObjects.html">GetRootGameObjects</a></td><td class="desc">Returns all the root game objects in the Scene.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/SceneManagement.Scene.htmlSceneManagement.Scene.IsValid.html">IsValid</a></td><td class="desc">Whether this is a valid Scene. A Scene may be invalid if, for example, you tried to open a Scene that does not exist. In this case, the Scene returned from EditorSceneManager.OpenScene would return False for IsValid.</td></tr></tbody></table>


### SceneManager
Use this class for Scene management at run-time.
Using SceneManagement to **transition scene** in the game.


### `SceneManager.LoadScene`
Loads the Scene by its name or index in Build Settings.

```cs
public static void LoadScene(int sceneBuildIndex, SceneManagement.LoadSceneMode mode = LoadSceneMode.Single);
```

```cs
public static void LoadScene(string sceneName, SceneManagement.LoadSceneMode mode = LoadSceneMode.Single);
```

Eg:
```cs
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExampleClass : MonoBehaviour
{
    void Start()
    {
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        SceneManager.LoadScene("OtherSceneName", LoadSceneMode.Additive);
    }
}


```

```cs
// Load an assetbundle which contains Scenes.
// When the user clicks a button the first Scene in the assetbundle is
// loaded and replaces the current Scene.

using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    private AssetBundle myLoadedAssetBundle;
    private string[] scenePaths;

    // Use this for initialization
    void Start()
    {
        myLoadedAssetBundle = AssetBundle.LoadFromFile("Assets/AssetBundles/scenes");
        scenePaths = myLoadedAssetBundle.GetAllScenePaths();
    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 100, 30), "Change Scene"))
        {
            Debug.Log("Scene2 loading: " + scenePaths[0]);
            SceneManager.LoadScene(scenePaths[0], LoadSceneMode.Single);
        }
    }
}

```

```cs
// SceneA.
// SceneA is given the sceneName which will
// load SceneB from the Build Settings

using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenesA : MonoBehaviour
{
    void Start()
    {
        Debug.Log("LoadSceneA");
    }

    public void LoadA(string scenename)
    {
        Debug.Log("sceneName to load: " + scenename);
        SceneManager.LoadScene(scenename);
    }
}
```

```cs
// SceneB.
// SceneB is given the sceneBuildIndex of 0 which will
// load SceneA from the Build Settings

using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenesB : MonoBehaviour
{
    void Start()
    {
        Debug.Log("LoadSceneB");
    }

    public void LoadB(int sceneANumber)
    {
        Debug.Log("sceneBuildIndex to load: " + sceneANumber);
        SceneManager.LoadScene(sceneANumber);
    }
}

```

**Loads the Scene by its name or index in Build Settings.**
```cs
public static SceneManagement.Scene LoadScene(int sceneBuildIndex, SceneManagement.LoadSceneParameters parameters);
```


Scene 1:
```cs
using UnityEngine;
using UnityEngine.SceneManagement;

// This is scene1.  It loads 3 copies of scene2.
// Each copy has the same name.

public class ExampleScript1 : MonoBehaviour
{
    private Scene scene;

    private void Start()
    {
        var parameters = new LoadSceneParameters(LoadSceneMode.Additive);

        scene = SceneManager.LoadScene("scene2", parameters);
        Debug.Log("Load 1 of scene2: " + scene.name);
        scene = SceneManager.LoadScene("scene2", parameters);
        Debug.Log("Load 2 of scene2: " + scene.name);
        scene = SceneManager.LoadScene("scene2", parameters);
        Debug.Log("Load 3 of scene2: " + scene.name);
    }
}
```

Scene2:

```cs
using UnityEngine;// create a randomly placed cubepublic class ExampleScript2 : MonoBehaviour
{
    private void Start()
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(Random.Range(-5.0f, 5.0f), 0.0f, Random.Range(-5.0f, 5.0f));
    }
}
```

#### Static Properties

<table class="list"><tbody><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.htmlSceneManagement.SceneManager-loadedSceneCount.html">loadedSceneCount</a></td><td class="desc">The number of loaded Scenes.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.htmlSceneManagement.SceneManager-sceneCount.html">sceneCount</a></td><td class="desc">The current number of Scenes.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.htmlSceneManagement.SceneManager-sceneCountInBuildSettings.html">sceneCountInBuildSettings</a></td><td class="desc">Number of Scenes in Build Settings.</td></tr></tbody></table>

#### Static Methods

<table class="list"><tbody><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.htmlSceneManagement.SceneManager.CreateScene.html">CreateScene</a></td><td class="desc">Create an empty new Scene at runtime with the given name.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.htmlSceneManagement.SceneManager.GetActiveScene.html">GetActiveScene</a></td><td class="desc">Gets the currently active Scene.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.htmlSceneManagement.SceneManager.GetSceneAt.html">GetSceneAt</a></td><td class="desc">Get the Scene at index in the SceneManager's list of loaded Scenes.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.htmlSceneManagement.SceneManager.GetSceneByBuildIndex.html">GetSceneByBuildIndex</a></td><td class="desc">Get a Scene struct from a build index.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.htmlSceneManagement.SceneManager.GetSceneByName.html">GetSceneByName</a></td><td class="desc">Searches through the Scenes loaded for a Scene with the given name.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.htmlSceneManagement.SceneManager.GetSceneByPath.html">GetSceneByPath</a></td><td class="desc">Searches all Scenes loaded for a Scene that has the given asset path.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.htmlSceneManagement.SceneManager.LoadScene.html">LoadScene</a></td><td class="desc">Loads the Scene by its name or index in Build Settings.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.htmlSceneManagement.SceneManager.LoadSceneAsync.html">LoadSceneAsync</a></td><td class="desc">Loads the Scene asynchronously in the background.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.htmlSceneManagement.SceneManager.MergeScenes.html">MergeScenes</a></td><td class="desc">This will merge the source Scene into the destinationScene.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.htmlSceneManagement.SceneManager.MoveGameObjectsToScene.html">MoveGameObjectsToScene</a></td><td class="desc">Move multiple GameObjects, represented by a NativeArray of instance IDs, from their current Scene to a new Scene.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.htmlSceneManagement.SceneManager.MoveGameObjectToScene.html">MoveGameObjectToScene</a></td><td class="desc">Move a GameObject from its current Scene to a new Scene.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.htmlSceneManagement.SceneManager.SetActiveScene.html">SetActiveScene</a></td><td class="desc">Set the Scene to be active.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.htmlSceneManagement.SceneManager.UnloadSceneAsync.html">UnloadSceneAsync</a></td><td class="desc">Destroys all GameObjects associated with the given Scene and removes the Scene from the SceneManager.</td></tr></tbody></table>

#### Events

<table class="list"><tbody><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.htmlSceneManagement.SceneManager-activeSceneChanged.html">activeSceneChanged</a></td><td class="desc">Subscribe to this event to get notified when the active Scene has changed.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.htmlSceneManagement.SceneManager-sceneLoaded.html">sceneLoaded</a></td><td class="desc">Add a delegate to this to get notifications when a Scene has loaded.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.htmlSceneManagement.SceneManager-sceneUnloaded.html">sceneUnloaded</a></td><td class="desc">Add a delegate to this to get notifications when a Scene has unloaded.</td></tr></tbody></table>

### Enumerations

#### `LoadSceneMode`

- `Single`: Closes all current loaded Scenes and loads a Scene.
- `Additive`: Adds the Scene to the current loaded Scenes.


```cs
using UnityEngine;
using UnityEngine.SceneManagement;

public class Example : MonoBehaviour
{
    void OnGUI()
    {
        //This displays a Button on the screen at position (20,30), width 150 and height 50. The button’s text reads the last parameter. Press this for the SceneManager to load the Scene.
        if (GUI.Button(new Rect(20, 30, 150, 30), "Other Scene Single"))
        {
            //The SceneManager loads your new Scene as a single Scene (not overlapping). This is Single mode.
            SceneManager.LoadScene("YourScene", LoadSceneMode.Single);
        }

        //Whereas pressing this Button loads the Additive Scene.
        if (GUI.Button(new Rect(20, 60, 150, 30), "Other Scene Additive"))
        {
            //SceneManager loads your new Scene as an extra Scene (overlapping the other). This is Additive mode.
            SceneManager.LoadScene("YourScene", LoadSceneMode.Additive);
        }
    }
}
```

#### `LocalPhysicsMode`
Provides options for 2D and 3D local physics.

By default, when a Scene is created or loaded, any 2D or 3D physics component added to a GameObject within the Scene is added to the default physics Scene. Each Scene however has the ability to create and own its own (local) 2D and/or 3D physics Scene. This option can be used when creating or loading a Scene to specify whether a 2D and/or 3D physics Scene should be created.


- **`None`**: No local 2D or 3D physics Scene will be created.
- **`Physics2D`**: A local 2D physics Scene will be created and owned by the Scene.
- **`Physics3D`**: A local 3D physics Scene will be created and owned by the Scene.


### ref
https://docs.unity3d.com/2018.4/Documentation/ScriptReference/SceneManagement.Scene.html

https://docs.unity3d.com/2018.4/Documentation/ScriptReference/SceneManagement.SceneManager.html

