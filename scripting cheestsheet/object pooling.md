## Object pooling


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





https://www.youtube.com/watch?v=7EZ2F-TzHYw

https://learn.unity.com/tutorial/introduction-to-object-pooling#5ff8d015edbc2a002063971d

https://youtu.be/tdSmKaJvCoA



