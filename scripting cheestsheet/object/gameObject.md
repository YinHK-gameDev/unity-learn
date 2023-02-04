## Game Object

### Set game object:

> 📌 Declare **public GameObject <name>** in script, then drag game object into inspecter inside that **GameObject** field.
  
  or 

> 📌 Declare **``private GameObject <name>``** in script, then use **``GameObject.Find( )``** method to find out the game object in the hierchy.

### Access gameobject's component
Returns the component of Type type if the game object has one attached, null if it doesn't.
```cs
 GameObject.GetComponent<Type>() 
```
> Get access gameobject's component should begain in `void start()`, `void aware()`
  
https://docs.unity3d.com/ScriptReference/GameObject.GetComponent.html

### Accessing other game objects
add a public GameObject variable to the script
eg:
```cs
  public class Enemy : MonoBehaviour 
  {

    public GameObject player;
    
    void Start() 
    {
        // Start the enemy ten units behind the player character.
        transform.position = player.transform.position - Vector3.forward * 10f;
    }
  }
```

Then you will see the is game object field show on inspector,
drag the game object in to inspectpr, the public game object field
  
  
### Access parent/child gameobject

➡️ **1. 取得父物件**
```cs
 gameObject.transform.parent.gameObject; 
```

➡️ 2. **取得子物件**
```cs
gameObject.transform.GetChild(int index).gameObject;  
```  
> 📌  **int index :**  數字，放入索引值，代表取第幾個子物件，第一個索引值為0**。**

e.g:  **get the object of first child**
```cs
  gameObject.transform.GetChild(0).gameObject;
```
  
**取得子物件數量:**
```cs
gameObject.transform.childCount;
```
**e.g.** 

```csharp
**int Obj_childCount;
Obj_childCount = gameObject.transform.childCount;**
```

➡️  **3. 把XX物件變成子物件**
```cs
XX.transform.parent = gameObject.transform;
```
  
➡️ **4. XX物件變成父物件** 
```cs
gameObject.transform.parent = XX.transform;  
```
  
➡️ **5. 子物件脫離父物件**
```cs
gameObject.transform.parent = null;
```
