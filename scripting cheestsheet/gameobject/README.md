## Gameobject

### Creating gameobject
Some games keep a constant number of objects in the scene, but it is very common for characters, treasures and other object to be created and removed during gameplay. In Unity, 
a GameObject can be created using the `Instantiate()` function which makes a new copy of an existing object. eg:

```cs
//create enemy and appear in game the scene
public GameObject enemy;

void Start() {

    for (int i = 0; i < 5; i++) {
        Instantiate(enemy);
    }

}
```



