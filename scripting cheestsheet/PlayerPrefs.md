### PlayerPrefs

The **PlayerPrefs** class in Unity allows you to save basic data between gameplay sessions, such as options settings, that can be **saved and reloaded, even after a game has been closed.**

It works by **storing a string, float or integer value to disk with a key**, which is a text string that’s used to store and recall a preference.

For example, to save an integer, simply call the Set Int function of the Player Prefs class and pass in the key you want to use to retrieve it again.


> store value eg score in database

Unity stores PlayerPrefs in a local registry, without encryption. 

**Do not use PlayerPrefs data to store sensitive data !**.  
  
Unity stores **`PlayerPrefs`** data differently based on which operating system the application runs on. 


### ref
https://docs.unity3d.com/2021.3/Documentation/ScriptReference/PlayerPrefs.html
