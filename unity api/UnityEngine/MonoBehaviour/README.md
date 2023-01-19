## MonoBehaviour
MonoBehaviour is the base **class from which every Unity script derives**. When you use C#, you must explicitly derive from MonoBehaviour.

`Start()`
`Update()`
`FixedUpdate()`
`LateUpdate()`
`OnGUI()`
`OnDisable()`
`OnEnable()`

### `Awake()`
Awake is called when the script instance is being loaded.Awake is used to initialize any variables or game state before the game starts. Awake is called when the script object is initialised, regardless of whether or not the script is enabled. Start may not be called on the same frame as Awake if the script is not enabled at initialisation time.

### `Start()`
Start is called on the frame when a script is enabled just before any of the Update methods are called the first time. Difference between start () and awake(): However, Awake is called when the script object is initialised, regardless of whether or not the script is enabled. Start may not be called on the same frame as Awake if the script is not enabled at initialisation time.

### `Update()`
Update is called every frame, if the MonoBehaviour is enabled.

### `Fixedupdate()`
`FixedUpdate`是在固定的時間間隔執行，不受遊戲frame的影響, (used especially in calculating any physics or movement).

> **FixedUpdate**  is used for being in-step with the physics engine, so anything that needs to be applied to a rigidbody should happen in FixedUpdate.









https://docs.unity3d.com/ScriptReference/MonoBehaviour.html
