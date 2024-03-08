## Collider & Collision


### Collider
A **base class** of all colliders.

| Properties | Descriptions |
| --- | --- |
| `attachedArticulationBody` | The articulation body the collider is attached to. |
| `attachedRigidbody` | The rigidbody the collider is attached to. |
| `bounds` | The world space bounding volume of the collider (Read Only). |
| `contactOffset` | Contact offset value of this collider. |
| `enabled` | Enabled Colliders will collide with other Colliders, disabled Colliders won't. |
| `excludeLayers` | The additional layers that this Collider should exclude when deciding if the Collider can contact another Collider. |
| `hasModifiableContacts` | Specify whether this Collider's contacts are modifiable or not. |
| `includeLayers` | The additional layers that this Collider should include when deciding if the Collider can contact another Collider. |
| `isTrigger` | Specify if this collider is configured as a trigger. |
| `layerOverridePriority` | A decision priority assigned to this Collider used when there is a conflicting decision on whether a Collider can contact another Collider. |
| `material` | The material used by the collider. |
| `providesContacts` | Whether or not this Collider generates contacts for Physics.ContactEvent. |
| `sharedMaterial` | The shared physic material of this collider. |

| Public Methods | Descriptions |
| --- | --- |
| `ClosestPoint` | Returns a point on the collider that is closest to a given location. |
| `ClosestPointOnBounds` | The closest point to the bounding box of the attached collider. |
| `Raycast` | Casts a Ray that ignores all Colliders except this one. |

| Messages | Descriptions |
| --- | --- |
| `OnCollisionEnter` | OnCollisionEnter is called when this collider/rigidbody has begun touching another rigidbody/collider. |
| `OnCollisionExit` | OnCollisionExit is called when this collider/rigidbody has stopped touching another rigidbody/collider. |
| `OnCollisionStay` | OnCollisionStay is called once per frame for every Collider or Rigidbody that touches another Collider or Rigidbody. |
| `OnTriggerEnter` | When a GameObject collides with another GameObject, Unity calls OnTriggerEnter. |
| `OnTriggerExit` | OnTriggerExit is called when the Collider other has stopped touching the trigger. |
| `OnTriggerStay` | OnTriggerStay is called almost all the frames for every Collider other that is touching the trigger. The function is on the physics timer so it won't necessarily run every frame. |

#### Inherited Members
| Properties | Descriptions |
| --- | --- |
| `gameObject` | The game object this component is attached to. A component is always attached to a game object. |
| `tag` | The tag of this game object. |
| `transform` | The Transform attached to this GameObject. |
| `hideFlags` | Should the object be hidden, saved with the Scene or modifiable by the user? |
| `name` | The name of the object. |


| Public Methods | Descriptions |
| --- | --- |
| `BroadcastMessage` | Calls the method named methodName on every MonoBehaviour in this game object or any of its children. |
| `CompareTag` | Checks the GameObject's tag against the defined tag. |
| `GetComponent` | Gets a reference to a component of type T on the same GameObject as the component specified. |
| `GetComponentInChildren` | Gets a reference to a component of type T on the same GameObject as the component specified, or any child of the GameObject. |
| `GetComponentIndex` | Gets the index of the component on its parent GameObject. |
| `GetComponentInParent` | Gets a reference to a component of type T on the same GameObject as the component specified, or any parent of the GameObject. |
| `GetComponents` | Gets references to all components of type T on the same GameObject as the component specified. |
| `GetComponentsInChildren` | Gets references to all components of type T on the same GameObject as the component specified, and any child of the GameObject. |
| `GetComponentsInParent` | Gets references to all components of type T on the same GameObject as the component specified, and any parent of the GameObject. |
| `SendMessage` | Calls the method named methodName on every MonoBehaviour in this game object. |
| `SendMessageUpwards` | Calls the method named methodName on every MonoBehaviour in this game object and on every ancestor of the behaviour. |
| `TryGetComponent` | Gets the component of the specified type, if it exists. |
| `GetInstanceID` | Gets the instance ID of the object. |
| `ToString` | Returns the name of the object. |

| Static Methods | Descriptions |
| --- | --- |
| `Destroy` | Removes a GameObject, component or asset. |
| `DestroyImmediate` | Destroys the object obj immediately. You are strongly recommended to use Destroy instead. |
| `DontDestroyOnLoad` | Do not destroy the target Object when loading a new Scene. |
| `FindAnyObjectByType` | Retrieves any active loaded object of Type type. |
| `FindFirstObjectByType` | Retrieves the first active loaded object of Type type. |
| `FindObjectOfType` | Returns the first active loaded object of Type type. |
| `FindObjectsByType` | Retrieves a list of all loaded objects of Type type. |
| `FindObjectsOfType` | Gets a list of all loaded objects of Type type. |
| `Instantiate` | Clones the object original and returns the clone. |
| `InstantiateAsync` | Captures a snapshot of the original object (that must be related to some GameObject) and returns the AsyncInstantiateOperation. |


### Collision
**Collision information** is **passed** to `Collider.OnCollisionEnter`, `Collider.OnCollisionStay` and `Collider.OnCollisionExit` events.

| Properties | Descriptions |
| --- | --- |
| `articulationBody` | The ArticulationBody of the collider that your GameObject collides with (Read Only). |
| `body` | The Rigidbody or ArticulationBody of the collider that your Component collides with (Read Only). |
| `collider` | The Collider we hit (Read Only). |
| `contactCount` | Gets the number of contacts for this collision. |
| `contacts` | The contact points generated by the physics engine. You should avoid using this as it produces memory garbage. Use GetContact or GetContacts instead. |
| `gameObject` | The GameObject whose collider you are colliding with. (Read Only). |
| `impulse` | The total impulse applied to this contact pair to resolve the collision. |
| `relativeVelocity` | The relative linear velocity of the two colliding objects (Read Only). |
| `rigidbody` | The Rigidbody we hit (Read Only). This is null if the object we hit is a collider with no rigidbody attached. |
| `transform` | The Transform of the object we hit (Read Only). |

| Public Methods | Descriptions |
| --- | --- |
| `GetContact` | Gets the contact point at the specified index. |
| `GetContacts` | Retrieves all contact points for this collision. |

### ref

Collider \
https://docs.unity3d.com/ScriptReference/Collider.html

Collision \
https://docs.unity3d.com/ScriptReference/Collision.html
