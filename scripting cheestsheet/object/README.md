## Object class
Unity has a class in the UnityEngine namespace called Object, which acts as a base class for all objects that Unity can reference in the editor. Classes which inherit from `UnityEngine.Object` have special functionality which means they can be dragged and dropped into fields in the Inspector
, or picked using the Object Picker next to an Object field.

**Base class** for all objects Unity can reference.

Any public variable you make that derives from Object gets shown in the inspector as a drop target, allowing you to set the value from the GUI. UnityEngine.Object is the base class of all built-in Unity objects.

https://docs.unity3d.com/ScriptReference/Object.html

### `Object.FindObjectsOfType<type>()`

Assign object to the variable in script:
declare **public variable** in script, drag object into inspecter.

https://docs.unity3d.com/ScriptReference/Object.FindObjectsOfType.html


### Properties

<table class="list"><tbody><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Object.htmlObject-hideFlags.html">hideFlags</a></td><td class="desc">Should the object be hidden, saved with the Scene or modifiable by the user?</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Object.htmlObject-name.html">name</a></td><td class="desc">The name of the object.</td></tr></tbody></table>

### Public Methods

<table class="list"><tbody><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Object.htmlObject.GetInstanceID.html">GetInstanceID</a></td><td class="desc">Gets the instance ID of the object.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Object.htmlObject.ToString.html">ToString</a></td><td class="desc">Returns the name of the object.</td></tr></tbody></table>

### Static Methods

<table class="list"><tbody><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Object.htmlObject.Destroy.html">Destroy</a></td><td class="desc">Removes a GameObject, component or asset.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Object.htmlObject.DestroyImmediate.html">DestroyImmediate</a></td><td class="desc">Destroys the object obj immediately. You are strongly recommended to use Destroy instead.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Object.htmlObject.DontDestroyOnLoad.html">DontDestroyOnLoad</a></td><td class="desc">Do not destroy the target Object when loading a new Scene.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Object.htmlObject.FindAnyObjectByType.html">FindAnyObjectByType</a></td><td class="desc">Retrieves any active loaded object of Type type.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Object.htmlObject.FindFirstObjectByType.html">FindFirstObjectByType</a></td><td class="desc">Retrieves the first active loaded object of Type type.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Object.htmlObject.FindObjectOfType.html">FindObjectOfType</a></td><td class="desc">Returns the first active loaded object of Type type.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Object.htmlObject.FindObjectsByType.html">FindObjectsByType</a></td><td class="desc">Retrieves a list of all loaded objects of Type type.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Object.htmlObject.FindObjectsOfType.html">FindObjectsOfType</a></td><td class="desc">Gets a list of all loaded objects of Type type.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Object.htmlObject.Instantiate.html">Instantiate</a></td><td class="desc">Clones the object original and returns the clone.</td></tr></tbody></table>
