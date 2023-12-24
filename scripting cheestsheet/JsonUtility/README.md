## JsonUtility
JsonUtility is **Unity’s built-in API** for **serializing and deserializing JSON data**.

Utility functions for working with JSON data.

### `JsonUtility.FromJson`
Create an object from its JSON representation.
```cs
public static T FromJson(string json);
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
