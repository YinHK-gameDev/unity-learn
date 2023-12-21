## Gameobject


### Set game object
> Declare **`public GameObject <name>`** in script, then drag game object into inspecter inside that GameObject field.

or

> Declare **`private GameObject <name>`** in script, then use **`GameObject.Find( )`** method to find out the game object in the hierchy.


### Get access component in gameobject
Gets a reference to a component of type T on the specified GameObject.

The typical usage for this method is to call it on a reference to a different GameObject than the one your script is on. For example:

```cs

public GameObject otherGameObject;

myResults = otherGameObject.GetComponent<ComponentType>()'
```

However if you are writing code inside a MonoBehaviour class, you can omit the preceding GameObject reference to get a component from the same GameObject your script is attached to. In this instance, you are actually calling Component.GetComponent because the script itself is a type of component, but the result is the same as if you had referenced the GameObject itself. For example:

```cs
myResults = GetComponent<ComponentType>()'
```

> **GetComponent()**  should be declared in **`void start()`**

This returns the component of Type type if the game object has one attached (inspecter 中的component).

https://docs.unity3d.com/ScriptReference/GameObject.GetComponent.html

### Create an array to store game objects
In the hierarchy, create an empty object, then assign a script to it. In the script, to create a public array, then you can see in the inspector. In the inspector, change the Array size to match your game objects count, then assign your objects by dragging them in.

https://docs.unity3d.com/2020.1/Documentation/ScriptReference/Array.html


### SetActive

```cs
GameObject.SetActive
```
> use to set game object visible and active in the scene or not.

https://docs.unity3d.com/ScriptReference/GameObject.SetActive.html


### Find Game object 

- **`GameObject.Find()`** \
  Finds a GameObject by name and returns it. \
  https://docs.unity3d.com/ScriptReference/GameObject.Find.html
- **`GameObject.FindWithTag()`** \
  Returns one active GameObject tagged tag. Returns null if no GameObject was found. \
  https://docs.unity3d.com/ScriptReference/GameObject.FindWithTag.html
- **`GameObject.FindGameObjectsWithTag`** \
  Returns an array of active GameObjects tagged `tag`. Returns empty array if no GameObject was found. \
  https://docs.unity3d.com/ScriptReference/GameObject.FindGameObjectsWithTag.html
- **`GameObject.CompareTag()`**
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

### Clone the existing GameObject
**`Instantiate()`**  function is used to clone the object original and return the clones. Most commonly used to instantiate projectiles, AI Enemies, particle explosions or wrecked object replacements.

https://docs.unity3d.com/ScriptReference/Object.Instantiate.html





