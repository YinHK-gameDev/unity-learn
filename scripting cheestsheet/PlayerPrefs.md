### PlayerPrefs

The **PlayerPrefs** class in Unity allows you to save basic data between gameplay sessions, such as options settings, that can be **saved and reloaded, even after a game has been closed.**

It works by **storing a string, float or integer value to disk with a key**, which is a text string that’s used to store and recall a preference.

For example, to save an integer, simply call the Set Int function of the Player Prefs class and pass in the key you want to use to retrieve it again.


> store value eg score in database

Unity stores PlayerPrefs in a local registry, without encryption. 

> **Do not use PlayerPrefs data to store sensitive data !**.  
  
Unity stores **`PlayerPrefs`** data differently based on which operating system the application runs on. 



#### Static Methods of `PlayerPrefs` class

```cs
// Removes all keys and values from the preferences. Use with caution.
public static void DeleteAll();

/ Removes the given key from the PlayerPrefs. If the key does not exist, DeleteKey has no impact.
public static void DeleteKey(string key);

// Returns the value corresponding to key in the preference file if it exists.
public static float GetFloat(string key);
public static float GetFloat(string key, float defaultValue);

// Returns the value corresponding to key in the preference file if it exists.
public static int GetInt(string key);
public static int GetInt(string key, int defaultValue);

// Returns the value corresponding to key in the preference file if it exists.
public static string GetString(string key);
public static string GetString(string key, string defaultValue);

// Returns true if the given key exists in PlayerPrefs, otherwise returns false.
public static bool HasKey(string key);

// Saves all modified preferences
public static void Save();

// Sets the float value of the preference identified by the given key. You can use PlayerPrefs.GetFloat to retrieve this value.
public static void SetFloat(string key, float value);

// Sets a single integer value for the preference identified by the given key. You can use PlayerPrefs.GetInt to retrieve this value.
public static void SetInt(string key, int value);

// Sets a single string value for the preference identified by the given key. You can use PlayerPrefs.GetString to retrieve this value.
public static void SetString(string key, string value);

```





### ref
https://docs.unity3d.com/2021.3/Documentation/ScriptReference/PlayerPrefs.html
