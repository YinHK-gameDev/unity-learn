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
