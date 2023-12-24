## Scene
Run-time data structure for `*.unity` file.


### SceneManager
Use this class for Scene management at run-time.
Using SceneManagement to transition scene in the game.


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


### ref
https://docs.unity3d.com/2018.4/Documentation/ScriptReference/SceneManagement.Scene.html

https://docs.unity3d.com/2018.4/Documentation/ScriptReference/SceneManagement.SceneManager.html

