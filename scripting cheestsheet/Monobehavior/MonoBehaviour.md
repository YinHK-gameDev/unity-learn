

### Properties

| Properties | Descriptions |
| --- | --- |
| `destroyCancellationToken` | Cancellation token raised when the MonoBehaviour is destroyed (Read Only). |
| `runInEditMode` | Allow a specific instance of a MonoBehaviour to run in edit mode (only available in the editor). **By default, script components are only executed in play mod**e. By setting this property, the MonoBehaviour will have its callback functions executed while the Editor is **not in playmode**.|
| `useGUILayout` | Disabling this lets you skip the GUI layout phase. |


### Public Methods

| Public Methods | Descriptions |
| --- | --- |
| `CancelInvoke` | Cancels all Invoke calls on this MonoBehaviour. |
| `Invoke` | Invokes the method methodName in time seconds. |
| `InvokeRepeating` | Invokes the method methodName in time seconds, then repeatedly every repeatRate seconds. |
| `IsInvoking` | Is any invoke on methodName pending? |
| `StartCoroutine` | Starts a Coroutine. |
| `StopAllCoroutines` | Stops all coroutines running on this behaviour. |
| `StopCoroutine` | Stops the first coroutine named methodName, or the coroutine stored in routine running on this behaviour. |


### Static Methods

| Static Methods | Descriptions |
| --- | --- |
| `print` | Logs message to the Unity Console (identical to Debug.Log). |

### Messages

| Messages | Descriptions |
| --- | --- |
| `Awake` | Unity calls Awake when an enabled script instance is being loaded. |
| `FixedUpdate` | Frame-rate independent MonoBehaviour.FixedUpdate message for physics calculations. |
| `LateUpdate` | LateUpdate is called every frame, if the Behaviour is enabled. |
| `OnAnimatorIK` | Callback for setting up animation IK (inverse kinematics). |
| `OnAnimatorMove` | Callback for processing animation movements for modifying root motion. |
| `OnApplicationFocus` | Sent to all GameObjects when the player gets or loses focus. OnApplicationFocus is called when the application loses or gains focus. |
| `OnApplicationPause` | Sent to all GameObjects when the playing application pauses or resumes on losing or regaining focus. |
| `OnApplicationQuit` | Sent to all GameObjects before the application quits. |
| `OnAudioFilterRead` | If OnAudioFilterRead is implemented, Unity will insert a custom filter into the audio DSP chain. |
| `OnBecameInvisible` | OnBecameInvisible is called when the renderer is no longer visible by any camera. |
| `OnBecameVisible` | OnBecameVisible is called when the renderer became visible by any camera. |
| `OnCollisionEnter` | OnCollisionEnter is called when this collider/rigidbody has begun touching another rigidbody/collider. |
| `OnCollisionEnter2D` | Sent when an incoming collider makes contact with this object's collider (2D physics only). |
| `OnCollisionExit` | OnCollisionExit is called when this collider/rigidbody has stopped touching another rigidbody/collider. |
| `OnCollisionExit2D` | Sent when a collider on another object stops touching this object's collider (2D physics only). |
| `OnCollisionStay` | OnCollisionStay is called once per frame for every Collider or Rigidbody that touches another Collider or Rigidbody. |
| `OnCollisionStay2D` | Sent each frame where a collider on another object is touching this object's collider (2D physics only). |
| `OnConnectedToServer` | Called on the client when you have successfully connected to a server. |
| `OnControllerColliderHit` | OnControllerColliderHit is called when the controller hits a collider while performing a Move. |
| `OnDestroy` | Destroying the attached Behaviour will result in the game or Scene receiving OnDestroy. |
| `OnDisable` | This function is called when the behaviour becomes disabled. |
| `OnDisconnectedFromServer` | Called on the client when the connection was lost or you disconnected from the server. |
| `OnDrawGizmos` | Implement OnDrawGizmos if you want to draw gizmos that are also pickable and always drawn. |
| `OnDrawGizmosSelected` | Implement OnDrawGizmosSelected to draw a gizmo if the object is selected. |
| `OnEnable` | This function is called when the object becomes enabled and active. |
| `OnFailedToConnect` | Called on the client when a connection attempt fails for some reason. |
| `OnFailedToConnectToMasterServer` | Called on clients or servers when there is a problem connecting to the MasterServer. |
| `OnGUI` | OnGUI is called for rendering and handling GUI events. |
| `OnJointBreak` | Called when a joint attached to the same game object broke. |
| `OnJointBreak2D` | Called when a Joint2D attached to the same game object breaks. |
| `OnMasterServerEvent` | Called on clients or servers when reporting events from the MasterServer. |
| `OnMouseDown` | OnMouseDown is called when the user has pressed the mouse button while over the Collider. |
| `OnMouseDrag` | OnMouseDrag is called when the user has clicked on a Collider and is still holding down the mouse. |
| `OnMouseEnter` | Called when the mouse enters the Collider. |
| `OnMouseExit` | Called when the mouse is not any longer over the Collider. |
| `OnMouseOver` | Called every frame while the mouse is over the Collider. |
| `OnMouseUp` | OnMouseUp is called when the user has released the mouse button. |
| `OnMouseUpAsButton` | OnMouseUpAsButton is only called when the mouse is released over the same Collider as it was pressed. |
| `OnNetworkInstantiate` | Called on objects which have been network instantiated with Network.Instantiate. |
| `OnParticleCollision` | OnParticleCollision is called when a particle hits a Collider. |
| `OnParticleSystemStopped` | OnParticleSystemStopped is called when all particles in the system have died, and no new particles will be born. New particles cease to be created either after Stop is called, or when the duration property of a non-looping system has been exceeded. |
| `OnParticleTrigger` | OnParticleTrigger is called when any particles in a Particle System meet the conditions in the trigger module. |
| `OnParticleUpdateJobScheduled` | OnParticleUpdateJobScheduled is called when a Particle System's built-in update job has been scheduled. |
| `OnPlayerConnected` | Called on the server whenever a new player has successfully connected. |
| `OnPlayerDisconnected` | Called on the server whenever a player disconnected from the server. |
| `OnPostRender` | Event function that Unity calls after a Camera renders the scene. |
| `OnPreCull` | Event function that Unity calls before a Camera culls the scene. |
| `OnPreRender` | Event function that Unity calls before a Camera renders the scene. |
| `OnRenderImage` | Event function that Unity calls after a Camera has finished rendering, that allows you to modify the Camera's final image. |
| `OnRenderObject` | OnRenderObject is called after camera has rendered the Scene. |
| `OnSerializeNetworkView` | Used to customize synchronization of variables in a script watched by a network view. |
| `OnServerInitialized` | Called on the server whenever a Network.InitializeServer was invoked and has completed. |
| `OnTransformChildrenChanged` | This function is called when the list of children of the transform of the GameObject has changed. |
| `OnTransformParentChanged` | This function is called when a direct or indirect parent of the transform of the GameObject has changed. |
| `OnTriggerEnter` | When a GameObject collides with another GameObject, Unity calls OnTriggerEnter. |
| `OnTriggerEnter2D` | Sent when another object enters a trigger collider attached to this object (2D physics only). |
| `OnTriggerExit` | OnTriggerExit is called when the Collider other has stopped touching the trigger. |
| `OnTriggerExit2D` | Sent when another object leaves a trigger collider attached to this object (2D physics only). |
| `OnTriggerStay` | OnTriggerStay is called once per physics update for every Collider other that is touching the trigger. |
| `OnTriggerStay2D` | Sent each frame where another object is within a trigger collider attached to this object (2D physics only). |
| `OnValidate` | Editor-only function that Unity calls when the script is loaded or a value changes in the Inspector. |
| `OnWillRenderObject` | OnWillRenderObject is called for each camera if the object is visible and not a UI element. |
| `Reset` | Reset to default values. |
| `Start` | Start is called on the frame when a script is enabled just before any of the Update methods are called the first time. |
| `Update` | Update is called every frame, if the MonoBehaviour is enabled. |


### Inherited Members

### Properties

| Properties | Descriptions |
| --- | --- |
| `enabled` | Enabled Behaviours are Updated, disabled Behaviours are not. |
| `isActiveAndEnabled` | Reports whether a GameObject and its associated Behaviour is active and enabled. |
| `gameObject` | The game object this component is attached to. A component is always attached to a game object. |
| `tag` | The tag of this game object. |
| `transform` | The Transform attached to this GameObject. |
| `hideFlags` | Should the object be hidden, saved with the Scene or modifiable by the user? |
| `name` | The name of the object. |

### Public Methods

| Public Methods | Descriptions |
| --- | --- |
| `BroadcastMessage` | Calls the method named methodName on every MonoBehaviour in this game object or any of its children. |
| `CompareTag` | Checks the GameObject's tag against the defined tag. |
| `GetComponent` | Gets a reference to a component of type T on the same GameObject as the component specified. |
| `GetComponentInChildren` | Gets a reference to a component of type T on the same GameObject as the component specified, or any child of the GameObject. |
| `GetComponentInParent` | Gets a reference to a component of type T on the same GameObject as the component specified, or any parent of the GameObject. |
| `GetComponents` | Gets references to all components of type T on the same GameObject as the component specified. |
| `GetComponentsInChildren` | Gets references to all components of type T on the same GameObject as the component specified, and any child of the GameObject. |
| `GetComponentsInParent` | Gets references to all components of type T on the same GameObject as the component specified, and any parent of the GameObject. |
| `SendMessage` | Calls the method named methodName on every MonoBehaviour in this game object. |
| `SendMessageUpwards` | Calls the method named methodName on every MonoBehaviour in this game object and on every ancestor of the behaviour. |
| `TryGetComponent` | Gets the component of the specified type, if it exists. |
| `GetInstanceID` | Gets the instance ID of the object. |
| `ToString` | Returns the name of the object. |


### Static Methods

<table class="list"><tbody><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/MonoBehaviour.htmlObject.Destroy.html">Destroy</a></td><td class="desc">Removes a GameObject, component or asset.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/MonoBehaviour.htmlObject.DestroyImmediate.html">DestroyImmediate</a></td><td class="desc">Destroys the object obj immediately. You are strongly recommended to use Destroy instead.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/MonoBehaviour.htmlObject.DontDestroyOnLoad.html">DontDestroyOnLoad</a></td><td class="desc">Do not destroy the target Object when loading a new Scene.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/MonoBehaviour.htmlObject.FindAnyObjectByType.html">FindAnyObjectByType</a></td><td class="desc">Retrieves any active loaded object of Type type.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/MonoBehaviour.htmlObject.FindFirstObjectByType.html">FindFirstObjectByType</a></td><td class="desc">Retrieves the first active loaded object of Type type.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/MonoBehaviour.htmlObject.FindObjectOfType.html">FindObjectOfType</a></td><td class="desc">Returns the first active loaded object of Type type.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/MonoBehaviour.htmlObject.FindObjectsByType.html">FindObjectsByType</a></td><td class="desc">Retrieves a list of all loaded objects of Type type.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/MonoBehaviour.htmlObject.FindObjectsOfType.html">FindObjectsOfType</a></td><td class="desc">Gets a list of all loaded objects of Type type.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/MonoBehaviour.htmlObject.Instantiate.html">Instantiate</a></td><td class="desc">Clones the object original and returns the clone.</td></tr></tbody></table>
