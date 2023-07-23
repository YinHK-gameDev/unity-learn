## Save & Load System in Unity - How to save your game states and settings?

Saving data is critical for any game. Whether you need to save high scores, preferences, or a game state, Unity offers a variety of methods – from PlayerPrefs to serializing data, encrypting it, and writing to a file.


### PlayerPrefs

**PlayerPrefs** are not made to save game states. However, they’re useful, so we’ll discuss them. You can use PlayerPrefs to store a player’s preferences between sessions, such as quality settings, audio volume or other non-essential data. PlayerPrefs are stored somewhere on your device, separate from your project. The exact location varies depending on your operating system, but it’s usually somewhere that’s globally accessible and managed by your OS. The stored data is in simple key-value pairs. Because of their ease of access, they aren’t safe from users who wish to open and modify them, and they can be deleted by accident since they’re saved outside of the project and managed by your OS.


PlayerPrefs are relatively easy to implement and require only a few lines of code, but they only support Float, Int and String-type values, making it challenging to serialize large, complex objects. A determined user can overcome this limitation by converting their saved data into some format represented by one of these basic types



eg:
```cs
public void SavePrefs()
{
    PlayerPrefs.SetInt("Volume", 50);
    PlayerPrefs.Save();
}
 
public void LoadPrefs()
{
    int volume = PlayerPrefs.GetInt("Volume", 0); 
}


```

> Since each Unity application stores all its PlayerPrefs **in a single file**, it’s **not well-suited for handling multiple save files or cloud saves**, both of which require you to store and receive save data from a **different location**.


### JSON
**JSON** is standardized and widely used in many different applications. As a result, all platforms support it strongly, which is helpful when building cross-platform games.

JSON is excellent for sending and receiving data from a **server backend**.


### JsonUtility

**JsonUtility** is Unity’s built-in API for **serializing and deserializing JSON data**.

Use the JsonUtility class to convert Unity objects to and from the JSON format.

For example, you can use JSON Serialization to interact with web services, or to easily pack and unpack data to a text-based format.


> **Note**: You **must save the JSON data yourself**, either in a **file or over a network**. Handling the data storage yourself makes it easy to **manage multiple save files** because you can store each file in a different location.


JSON Serialization uses a notion of "structured" JSON: you create a class or structure to describe what variables you want to store in your JSON data. For example:

```cs
[Serializable]
public class MyClass
{
    public int level;
    public float timeElapsed;
    public string playerName;
}
```
This defines a plain C# class containing three variables (**level**, **timeElapsed**, and **playerName**) and marks it with the `Serializable` attribute, in order to work with the JSON serializer. To create an instance of your class, you can use something like this:

```cs
MyClass myObject = new MyClass();
myObject.level = 1;
myObject.timeElapsed = 47.5f;
myObject.playerName = "Dr Charles Francis";
```
use the `JsonUtility.ToJson` method to serialize it (convert it) to the JSON format:
```cs
string json = JsonUtility.ToJson(myObject);
// json now contains: '{"level":1,"timeElapsed":47.5,"playerName":"Dr Charles Francis"}'
```

To convert the JSON back into an object, use `JsonUtility.FromJson`:

```cs
myObject = JsonUtility.FromJson<MyClass>(json);
```
This creates a new instance of `MyClass` and sets the values on it using the JSON data. If the JSON data contains values that do not map to fields in `MyClass`, then the serializer ignores those values. If the JSON data is missing values for fields in `MyClass`, then the serializer leaves the constructed values for those fields in the returned object.

Overwriting objects with JSON, you can also deserialize JSON data over an existing object, which overwrites any existing data:
```cs
JsonUtility.FromJsonOverwrite(json, myObject);
```
> If the JSON data does not contain a value for a field, the serializer does not change that field’s value.

### Supported types
The JSON Serializer API supports any **`MonoBehaviour` subclass**, **`ScriptableObject` subclass**, or **plain class** or **struct with the `[Serializable]` attribute**. When you pass in an object to the standard Unity serializer for processing, the same rules and limitations apply as they do in the Inspector: Unity serializes fields only; and types like **`Dictionary<>` are not supported**.

Unity does not support passing other types directly to the API, such as **primitive types or arrays**. If you need to convert those, wrap them in a `class` or `struct` of some sort.

https://docs.unity3d.com/2021.2/Documentation/Manual/JSONSerialization.html

### ref 
https://www.youtube.com/watch?v=XOjd_qU2Ido

https://www.youtube.com/watch?v=gZ3wtNGB3nU

https://www.youtube.com/watch?v=aUi9aijvpgs

**Persistent data: How to save your game states and settings** \
https://blog.unity.com/games/persistent-data-how-to-save-your-game-states-and-settings \

**Persistent Data – How to save your game states and settings | Unite Now 2020** \
https://www.youtube.com/watch?v=uD7y4T4PVk0


https://github.com/UnityTechnologies/UniteNow20-Persistent-Data/tree/main
