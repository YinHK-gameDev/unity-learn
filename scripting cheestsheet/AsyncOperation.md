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

### **Events**

| Events | Details |
| --- | --- |
| **`completed`** | Event that is invoked upon operation completion. An event handler that is registered in the same frame as the call that creates it will be invoked next frame, even if the operation is able to complete synchronously. If a handler is registered after the operation has completed and has already invoked the complete event, the handler will be called synchronously. |



### ref
https://docs.unity3d.com/6000.0/Documentation/ScriptReference/AsyncOperation.html



