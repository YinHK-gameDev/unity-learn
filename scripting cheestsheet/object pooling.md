## Object pooling

Object pooling is a design pattern that will allow you to **reduce the amount of garbage collection** you have when working with instantiating multiple objects. 

It allows you to store destroyed network objects in a pool to reuse later. This is useful for often used objects, such as projectiles, and is a way to increase the application's overall performance. By pre-instantiating and reusing the instances of those objects, object pooling removes the need to create or destroy objects at runtime, which can save a lot of work for the CPU. This means that instead of creating or destroying the same object over and over again, it's simply deactivated after use, then, when another object is needed, the pool recycles one of the deactivated objects and reactivates it.



> 📌 better than instantiate and destroy method

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

GameObject bullet = ObjectPooler.SharedInstance.GetPooledObject(); 
  if (bullet != null) {
    bullet.transform.position = turret.transform.position;
    bullet.transform.rotation = turret.transform.rotation;
    bullet.SetActive(true);
  }

```


> Unity already has one built in if you are using Unity 2021.

https://docs.unity3d.com/ScriptReference/Pool.ObjectPool_1.html


https://www.youtube.com/watch?v=7EZ2F-TzHYw

https://learn.unity.com/tutorial/introduction-to-object-pooling#5ff8d015edbc2a002063971d

https://youtu.be/tdSmKaJvCoA

https://medium.com/nerd-for-tech/object-pooling-design-pattern-in-unity-de5334b0fe3d

https://learn.unity.com/tutorial/introduction-to-object-pooling
