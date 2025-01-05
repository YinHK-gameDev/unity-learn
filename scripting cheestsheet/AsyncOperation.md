## AsyncOperation
Asynchronous operation coroutine.

You can yield until asynchronous operation **continues**, 
or manually check whether it's **done (isDone) or progress (progress)**.

Mostly use in:

- **`SceneManager.LoadSceneAsync`**
- **`AssetBundle.LoadAssetAsync`**
- **`Resources.LoadAsync`**

| Properties | Details |
| --- | --- |
| **`allowSceneActivation`** | Allow Scenes to be activated as soon as it is ready. |
| **`isDone`**| Has the operation finished? (Read Only) |
| **`priority`** | Priority lets you tweak in which order async operation calls will be performed. |
| **`progress`** | What's the operation's progress. (Read Only) |

### ref
https://docs.unity3d.com/6000.0/Documentation/ScriptReference/AsyncOperation.html



