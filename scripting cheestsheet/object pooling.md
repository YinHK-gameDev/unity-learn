## Object pooling

Object pooling is a design pattern that will allow you to **reduce the amount of garbage collection** you have when working with instantiating multiple objects. 

It allows you to store destroyed network objects in a pool to reuse later. This is useful for often used objects, such as projectiles, and is a way to increase the application's overall performance. By **pre-instantiating and reusing the instances of those objects**, **object pooling removes the need to create or destroy objects at runtime, which can save a lot of work for the CPU**. This means that instead of creating or destroying the same object over and over again, it's simply deactivated after use, then, when another object is needed, the pool recycles one of the **deactivated objects and reactivates** it.

Object Pooling is a great way to optimize your projects and lower the burden that is placed on the CPU when having to rapidly create and destroy GameObjects. It is a good practice and design pattern to keep in mind to help relieve the processing power of the CPU to handle more important tasks and not become inundated by repetitive create and destroy calls. In this tutorial, you will learn to use Object Pooling to optimize your projects. 

In Unity, object pooling typically involves creating a pool of objects at the start of the game and reusing them as needed, rather than instantiating and destroying objects dynamically during runtime. This can be particularly beneficial for things like bullets, enemies, particle effects, or any other objects that are frequently created and destroyed.

The primary goal of object pooling is to improve performance by reducing the overhead associated with creating and destroying objects frequently.


> 📌 better than instantiate and destroy method

> **Note**: Instead of instantiating and destroying, object pooling method is to **reuse the disable object**. Just **disable after using the object** and **enable to reuse it when is nee**ded. 

- Create a pool - **`List<GameObject> pool`**
- **InitializeObjectPool** - pre-instantiate the object & set them inactive, add them into the pool
- **GetObjectFromPool**
- **ReturnObjectToPool**
- Give reference to the Objectpooling class you created, using Object Pooling methods in other script


Eg: \
Create a **ObjectPool** class:
```cs
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public GameObject prefab = default;
    public int poolSize = default;

    // Declare a list to store the object in the pool
    private List<GameObject> objectPool = new List<GameObject>();

    void Start()
    {
        InitializeObjectPool();
    }

    // Pre-instantiate the objects in the pool & set them inactive first
    void InitializeObjectPool()
    {
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(prefab, transform);
            obj.SetActive(false);
            objectPool.Add(obj);
        }
    }

    // Get the object from the pool & set it to be active for use later
    public GameObject GetObjectFromPool()
    {
        foreach (GameObject obj in objectPool)
        {
            // Find any inactive object from the pool & set it to be active
            if (!obj.activeInHierarchy)
            {
                obj.SetActive(true);
                return obj;
            }
        }

        // If all objects are in use, consider expanding the pool or handling it as needed.
        return null;
    }

    // If the object is unused right now, set it to be inactive & return to the pool
    public void ReturnObjectToPool(GameObject obj)
    {
        obj.SetActive(false);
    }
}

```
Then give reference to that class, use that class for object pooling in your script
```cs
public class ExampleUsage : MonoBehaviour
{
    private ObjectPool objectPool;

    void Start()
    {
        objectPool = GetComponent<ObjectPool>();
        UsePooledObject();
    }

    void UsePooledObject()
    {
        // Get the object from the pool
        GameObject obj = objectPool.GetObjectFromPool();
        if (obj != null)
        {
            // Do something with the object.
            // When done, return it to the pool.
            objectPool.ReturnObjectToPool(obj);
        }
    }
}

```

Eg:
```cs
public class GameObjectPool 
     {
         private int maxObjects;
         private GameObject pooledObject;
         private List<GameObject> pooledObjects = new List<GameObject>();
 
 
         public GameObjectPool(GameObject pooledObject, int maxObjects = 500)
         {
             this.pooledObject = pooledObject;
             this.maxObjects = maxObjects;
 
             destroyAll(pooledObjects);
         }
 
 
         public GameObject GetPooledObject(Vector3 position)
         {
             for (int i = 0; i < pooledObjects.Count; i++)
             {
                 // check active & return inaccive
                 if (!pooledObjects[i].activeInHierarchy)
                 {
                     pooledObjects[i].SetActive(true);
                     pooledObjects[i].transform.position = position;
                     return pooledObjects[i];
                 }
             }
 
             // Put a cap on how many we can have
             if (pooledObjects.Count < maxObjects)
             {
                 GameObject obj = (GameObject)GameObject.Instantiate(pooledObject, position, Quaternion.identity);
                 obj.SetActive(true);
                 pooledObjects.Add(obj);
                 return obj;
             }
 
             return null;
         }
 
 
         private void destroyAll(List<GameObject> objects)
         {
             foreach (GameObject ob in objects)
             {
                 GameObject.Destroy(ob);
             }
             objects.Clear();
         }
     }

```
**example:**


1\. Create a new script and call it “Object Pool”

2\. Attach the script to your game controller.

3\. Open the script and write the following within the class define it

```cs
public List<GameObject> pooledObjects;
public GameObject objectToPool;
public int amountToPool;

pooledObjects = new List<GameObject>();
for (int i = 0; i < amountToPool; i++) {
  GameObject obj = (GameObject)Instantiate(objectToPool);
  obj.SetActive(false); 
  pooledObjects.Add(obj);
}

public GameObject GetPooledObject() {
//1
  for (int i = 0; i < pooledObjects.Count; i++) {
//2
    if (!pooledObjects[i].activeInHierarchy) {
      return pooledObjects[i];
    }
  }
//3   
  return null;
}

Instantiate(playerBullet, turret.transform.position, turret.transform.rotation);

GameObject bullet = ObjectPool.SharedInstance.GetPooledObject(); 
  if (bullet != null) {
    bullet.transform.position = turret.transform.position;
    bullet.transform.rotation = turret.transform.rotation;
    bullet.SetActive(true);
  }

```

The code will request a GameObject to become active, and set the properties of that given GameObject. It removes the need to instantiate a new object and efficiently requests and acquires a GameObject that is **only pre-instantiated**, **relieving the burden from the CPU** of having to create and destroy a new one.

Next, replace any code that destroys the bullets, such as:

```cs
Destroy(gameObject);
```

Instead of destroying the GameObject, deactivate it to return it to the pool.

```cs
gameobject.SetActive(false);
```


> **Note**: **Pre-instantiting** an amount of game objects **needed for the pool**, **Keep pooled objects setting active** and **inactive return to the poo**l. This way let you **keeping reuse the game objects without destroy them** and **instantiating again**.


> Unity already has one built in class if you are using Unity 2021.

**`ObjectPool`** class \
https://docs.unity3d.com/ScriptReference/Pool.ObjectPool_1.html


https://www.youtube.com/watch?v=7EZ2F-TzHYw

https://learn.unity.com/tutorial/introduction-to-object-pooling#5ff8d015edbc2a002063971d

https://youtu.be/tdSmKaJvCoA

https://medium.com/nerd-for-tech/object-pooling-design-pattern-in-unity-de5334b0fe3d

https://learn.unity.com/tutorial/introduction-to-object-pooling
