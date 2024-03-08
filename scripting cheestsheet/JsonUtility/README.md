## JsonUtility
JsonUtility is **Unity’s built-in API** for **serializing and deserializing JSON data**.

Utility functions for working with JSON data.

```cs
[Serializable]
public class MyClass
{
    public int level;
    public float timeElapsed;
    public string playerName;
}

MyClass myObject = new MyClass();
myObject.level = 1;
myObject.timeElapsed = 47.5f;
myObject.playerName = "Dr Charles Francis";

```
> A plain **class/struct** marked with the **Serializable attribute**




### `JsonUtility.FromJson`
Create an object from its JSON representation.
```cs
public static T FromJson(string json);
```

**T**: An instance of the object.

```cs
public static object FromJson(string json, Type type);
```


Internally, this method uses the Unity serializer; therefore the type you are creating must be supported by the serializer. It **must be a plain class/struct marked with the Serializable attribute**. Fields of the object must have types supported by the serializer. Fields that have unsupported types, as well as private fields or fields marked with the NonSerialized attribute, will be ignored.

Only plain classes and structures are supported; classes derived from `UnityEngine.Object` (such as MonoBehaviour or ScriptableObject) are not. Note that classes derived from MonoBehaviour or ScriptableObject can be used with `JsonUtility.FromJsonOverwrite` as an alternative.

If the JSON representation is missing any fields, they will be given their default values (i.e. a field of type T will have value default(T) - it will not be given any value specified as a field initializer, as the constructor for the object is not executed during deserialization).

```cs
myObject = JsonUtility.FromJson<MyClass>(json);
```


```cs
using UnityEngine;

[System.Serializable]
public class PlayerInfo
{
    public string name;
    public int lives;
    public float health;

    public static PlayerInfo CreateFromJSON(string jsonString)
    {
        return JsonUtility.FromJson<PlayerInfo>(jsonString);
    }

    // Given JSON input:
    // {"name":"Dr Charles","lives":3,"health":0.8}
    // this example will return a PlayerInfo object with
    // name == "Dr Charles", lives == 3, and health == 0.8f.
}

```




### `JsonUtility.FromJsonOverwrite`
**Overwrite data in an object** by reading from its JSON representation.

```cs
public static void FromJsonOverwrite(string json, object objectToOverwrite);
```
This method is very similar to `JsonUtility.FromJson`, except that instead of creating a new object and loading the JSON data into it, it **loads the JSON data into an existing object**. This allows you to **update the values stored in classes or objects without any allocations**.

Internally, this method uses the Unity serializer; therefore the object you pass in must be supported by the serializer: it **must be a MonoBehaviour, ScriptableObject, or plain class/struct with the Serializable attribute applied**. The types of fields that you want to be overwritten must be supported by the serializer; unsupported fields will be ignored, as will private fields, static fields, and fields with the NonSerialized attribute applied.

Any plain class or structure is supported, along with classes derived from MonoBehaviour or ScriptableObject. Other engine types are not supported. In the Editor only, you can use EditorJsonUtility.FromJsonOverwrite to overwrite other engine objects.

```cs
JsonUtility.FromJsonOverwrite(json, myObject);
```

```cs
using UnityEngine;

public class PlayerState : MonoBehaviour
{
    public string playerName;
    public int lives;
    public float health;

    public void Load(string savedData)
    {
        JsonUtility.FromJsonOverwrite(savedData, this);
    }

    // Given JSON input:
    // {"lives":3, "health":0.8}
    // the Load function will change the object on which it is called such that
    // lives == 3 and health == 0.8
    // the 'playerName' field will be left unchanged
}
```

### `JsonUtility.ToJson`
Generate a JSON representation of the **public fields** of an object.

```cs
public static string ToJson(object obj);
```

```cs
public static string ToJson(object obj, bool prettyPrint);
```

| Pro[erties | Descriptions |
| --- | --- |
| **`obj`** | The object to convert to JSON form. |
| **`prettyPrint`** | If true, format the output for readability. If false, format the output for minimum size. Default is false. |

Internally, this method uses the Unity serializer; therefore the object you pass in must be supported by the serializer: it **must be a `MonoBehaviour`, ScriptableObject, or plain class/struct with the Serializable attribute applied**. The types of fields that you want to be included must be supported by the serializer; unsupported fields will be ignored, as will private fields, static fields, and fields with the NonSerialized attribute applied.

Any plain class or structure is supported, as well as classes derived from `MonoBehaviour` or ScriptableObject. Other engine types are not supported. (In the Editor only, you can use EditorJsonUtility.ToJson to serialize other engine types to JSON).

If the object contains fields with references to other Unity objects, those references are serialized by recording the InstanceID for each referenced object. Because the Instance ID acts like a handle to the in-memory object instance, the JSON string can only be deserialized back during the same session of the Unity engine.

```cs
string json = JsonUtility.ToJson(myObject);
// json now contains: '{"level":1,"timeElapsed":47.5,"playerName":"Dr Charles Francis"}'
```

```cs
using UnityEngine;

public class PlayerState : MonoBehaviour
{
    public string playerName;
    public int lives;
    public float health;

    public string SaveToString()
    {
        return JsonUtility.ToJson(this);
    }

    // Given:
    // playerName = "Dr Charles"
    // lives = 3
    // health = 0.8f
    // SaveToString returns:
    // {"playerName":"Dr Charles","lives":3,"health":0.8}
}

```

### ref
https://docs.unity3d.com/2021.2/Documentation/ScriptReference/JsonUtility.html
