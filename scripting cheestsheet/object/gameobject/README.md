## Gameobject

Base class for all entities in Unity Scenes.

Inherited from Unity Object class 


### Set game object
> Declare **`public GameObject <name>`** in script, then drag game object into inspecter inside that GameObject field.

or

> Declare **`private GameObject <name>`** in script, then use **`GameObject.Find( )`** method to find out the game object in the hierchy.


### Get access component in gameobject
Gets a reference to a component of type T on the specified GameObject.

The typical usage for this method is to call it on a reference to a different GameObject than the one your script is on. For example:

```cs

public GameObject otherGameObject;

myResults = otherGameObject.GetComponent<ComponentType>();
```

However if you are writing code inside a MonoBehaviour class, you can omit the preceding GameObject reference to get a component from the same GameObject your script is attached to. In this instance, you are actually calling Component.GetComponent because the script itself is a type of component, but the result is the same as if you had referenced the GameObject itself. For example:

```cs
myResults = GetComponent<ComponentType>();
```

> **GetComponent()**  should be declared in **`void start()`**

This returns the component of Type type if the game object has one attached (inspecter 中的component).

https://docs.unity3d.com/ScriptReference/GameObject.GetComponent.html

### Adding component to GameObject by script
```cs
public T AddComponent();
```
```cs
void Start()
{
    SphereCollider sc = gameObject.AddComponent<SphereCollider>();
}
```

Adds a **component** class of type componentType to the GameObjec
```cs
public Component AddComponent(Type componentType);
```

```cs
void Start()
{
    SphereCollider sc = gameObject.AddComponent(typeof(SphereCollider)) as SphereCollider;
}
```


> Note that there is no **RemoveComponent()**, to remove a component, use **`Destroy()`**.

https://docs.unity3d.com/ScriptReference/GameObject.AddComponent.html

### Create an array to store game objects
In the hierarchy, create an empty object, then assign a script to it. In the script, to create a public array, then you can see in the inspector. In the inspector, change the Array size to match your game objects count, then assign your objects by dragging them in.

https://docs.unity3d.com/2020.1/Documentation/ScriptReference/Array.html


### SetActive

```cs
GameObject.SetActive
```
```cs
public void SetActive(bool value);
```

> use to set game object visible and active in the scene or not.

https://docs.unity3d.com/ScriptReference/GameObject.SetActive.html


### Find Game object 

- **`GameObject.Find()`** \
  Finds a GameObject by name and returns it. 
  ```cs
    public static GameObject Find(string name);
  ```
  https://docs.unity3d.com/ScriptReference/GameObject.Find.html
- **`GameObject.FindWithTag()`** \
  Returns one active GameObject tagged tag. Returns null if no GameObject was found. 
  ```cs
    public static GameObject FindWithTag(string tag);
  ```
  https://docs.unity3d.com/ScriptReference/GameObject.FindWithTag.html
- **`GameObject.FindGameObjectsWithTag`** \
  Returns an array of active GameObjects tagged `tag`. Returns empty array if no GameObject was found. 
  ```cs
    public static GameObject[] FindGameObjectsWithTag(string tag);
  ```
  https://docs.unity3d.com/ScriptReference/GameObject.FindGameObjectsWithTag.html
- **`GameObject.CompareTag()`** \
  Returns boolean if exists the tag in the gameobject. 
  ```cs
    public bool CompareTag(string tag);
  ```
  https://docs.unity3d.com/ScriptReference/GameObject.CompareTag.html
  
> **Note**: Use **tag** rather than **name** to detect/find game objects, tag is suitable for finding game objects with same tag/name, whereas , name can’t.

### Creating gameobject
Some games keep a constant number of objects in the scene, but it is very common for characters, treasures and other object to be created and removed during gameplay. In Unity, 
a GameObject can be created using the **`Instantiate()`** function which makes a new copy of an existing object. eg:

```cs
//create enemy and appear in game the scene
public GameObject enemy;

void Start() 
{

    for (int i = 0; i < 5; i++) 
    {
        Instantiate(enemy);
    }

}
```
https://docs.unity3d.com/2017.4/Documentation/Manual/CreateDestroyObjects.html

### Destroy GameObjects

To destroy game object/component, use **`Destroy()`** function.

```cs
public static void Destroy(Object obj, float t = 0.0F);
```

|Parameters|Description|
|-|-|
|`obj`|	The object to destroy|
|`t`|The optional amount of time to delay before destroying the object|

```cs
//destroy game objects
void OnCollisionEnter(Collision otherObj) 
{
    if (otherObj.gameObject.tag == "Missile") 
    {
        Destroy(gameObject,.5f);
    }
}
```

https://docs.unity3d.com/ScriptReference/Object.Destroy.html


### Do not destroy the target game object when loading a new Scene

```cs
 public static void DontDestroyOnLoad(Object target);
```

The **load of a new Scene destroys all current Scene objects**. **Call `Object.DontDestroyOnLoad` to preserve an Object during scene loading**. If the target Object is a component or GameObject, Unity also **preserves all of the Transform’s children**. `Object.DontDestroyOnLoad` **only works for root GameObjects or components on root GameObjects**. `Object.DontDestroyOnLoad` does not return a value.


https://docs.unity3d.com/ScriptReference/Object.DontDestroyOnLoad.html

### Clone the existing GameObject
**`Instantiate()`**  function is used to clone the object original and return the clones. Most commonly used to instantiate projectiles, AI Enemies, particle explosions or wrecked object replacements.

https://docs.unity3d.com/ScriptReference/Object.Instantiate.html

### Creates a GameObject with a primitive
```cs
public static GameObject CreatePrimitive(PrimitiveType type);
```

```cs
using UnityEngine;

public class Example : MonoBehaviour
{
    // Create a plane, sphere and cube in the Scene.

    void Start()
    {
        GameObject plane  = GameObject.CreatePrimitive(PrimitiveType.Plane);

        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(0, 0.5f, 0);

        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.position = new Vector3(0, 1.5f, 0);

        GameObject capsule = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        capsule.transform.position = new Vector3(2, 1, 0);

        GameObject cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder.transform.position = new Vector3(-2, 1, 0);
    }
}
```

### Properties

<table class="list"><tbody><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/GameObject.htmlGameObject-activeInHierarchy.html">activeInHierarchy</a></td><td class="desc">Defines whether the GameObject is active in the Scene.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/GameObject.htmlGameObject-activeSelf.html">activeSelf</a></td><td class="desc">The local active state of this GameObject. (Read Only)</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/GameObject.htmlGameObject-isStatic.html">isStatic</a></td><td class="desc">Gets and sets the GameObject's StaticEditorFlags.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/GameObject.htmlGameObject-layer.html">layer</a></td><td class="desc">The layer the GameObject is in.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/GameObject.htmlGameObject-scene.html">scene</a></td><td class="desc">Scene that the GameObject is part of.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/GameObject.htmlGameObject-sceneCullingMask.html">sceneCullingMask</a></td><td class="desc">Scene culling mask Unity uses to determine which scene to render the GameObject in.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/GameObject.htmlGameObject-tag.html">tag</a></td><td class="desc">The tag of this GameObject.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/GameObject.htmlGameObject-transform.html">transform</a></td><td class="desc">The Transform attached to this GameObject.</td></tr></tbody></table>

### Constructors

<table class="list"><tbody><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/GameObject.htmlGameObject-ctor.html">GameObject</a></td><td class="desc">Creates a new GameObject, named name.</td></tr></tbody></table>

### Public Methods

<table class="list"><tbody><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/GameObject.htmlGameObject.AddComponent.html">AddComponent</a></td><td class="desc">Adds a component class of type componentType to the GameObject. C# Users can use a generic version.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/GameObject.htmlGameObject.BroadcastMessage.html">BroadcastMessage</a></td><td class="desc">Calls the method named methodName on every MonoBehaviour in this GameObject or any of its children.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/GameObject.htmlGameObject.CompareTag.html">CompareTag</a></td><td class="desc">Is this GameObject tagged with tag ?</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/GameObject.htmlGameObject.GetComponent.html">GetComponent</a></td><td class="desc">Gets a reference to a component of type T on the specified GameObject.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/GameObject.htmlGameObject.GetComponentInChildren.html">GetComponentInChildren</a></td><td class="desc">Gets a reference to a component of type T on the specified GameObject, or any child of the GameObject.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/GameObject.htmlGameObject.GetComponentInParent.html">GetComponentInParent</a></td><td class="desc">Gets a reference to a component of type T on the specified GameObject, or any parent of the GameObject.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/GameObject.htmlGameObject.GetComponents.html">GetComponents</a></td><td class="desc">Gets references to all components of type T on the specified GameObject.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/GameObject.htmlGameObject.GetComponentsInChildren.html">GetComponentsInChildren</a></td><td class="desc">Gets references to all components of type T on the specified GameObject, and any child of the GameObject.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/GameObject.htmlGameObject.GetComponentsInParent.html">GetComponentsInParent</a></td><td class="desc">Gets references to all components of type T on the specified GameObject, and any parent of the GameObject.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/GameObject.htmlGameObject.SendMessage.html">SendMessage</a></td><td class="desc">Calls the method named methodName on every MonoBehaviour in this GameObject.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/GameObject.htmlGameObject.SendMessageUpwards.html">SendMessageUpwards</a></td><td class="desc">Calls the method named methodName on every MonoBehaviour in this GameObject and on every ancestor of the behaviour.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/GameObject.htmlGameObject.SetActive.html">SetActive</a></td><td class="desc">Activates/Deactivates the GameObject, depending on the given true or false value.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/GameObject.htmlGameObject.TryGetComponent.html">TryGetComponent</a></td><td class="desc">Gets the component of the specified type, if it exists.</td></tr></tbody></table>

### Static Methods

<table class="list"><tbody><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/GameObject.htmlGameObject.CreatePrimitive.html">CreatePrimitive</a></td><td class="desc">Creates a GameObject with a primitive mesh renderer and appropriate collider.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/GameObject.htmlGameObject.Find.html">Find</a></td><td class="desc">Finds a GameObject by name and returns it.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/GameObject.htmlGameObject.FindGameObjectsWithTag.html">FindGameObjectsWithTag</a></td><td class="desc">Returns an array of active GameObjects tagged tag. Returns empty array if no GameObject was found.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/GameObject.htmlGameObject.FindWithTag.html">FindWithTag</a></td><td class="desc">Returns one active GameObject tagged tag. Returns null if no GameObject was found.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/GameObject.htmlGameObject.GetScene.html">GetScene</a></td><td class="desc">Returns the Scene of a GameObject given by instance ID.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/GameObject.htmlGameObject.InstantiateGameObjects.html">InstantiateGameObjects</a></td><td class="desc">Instantiate a GameObject multiple times by instance ID and populate NativeArrays containing the new GameObjects by instance ID and their corresponding Transforms by instance ID.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/GameObject.htmlGameObject.SetGameObjectsActive.html">SetGameObjectsActive</a></td><td class="desc">Activates/Deactivates the GameObjects by instance ID, depending on the given true or false value.</td></tr></tbody></table>


### ref
https://docs.unity3d.com/ScriptReference/GameObject.html


