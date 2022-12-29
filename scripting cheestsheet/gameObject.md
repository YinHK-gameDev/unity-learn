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

### Access gameobject

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
  
  
  
  
  
  
  
  
