## Instantiate

**Instantiate with different angle**

> 📌 use **`Quaternion.Euler(x, y, z)`** in `Instantiate()`

Returns a rotation that rotates z degrees around the z axis, x degrees around the x axis, and y degrees around the y axis;

```cs
public static Object Instantiate(Object original);
public static Object Instantiate(Object original, Transform parent);
public static Object Instantiate(Object original, Transform parent, bool instantiateInWorldSpace);
public static Object Instantiate(Object original, Vector3 position, Quaternion rotation);
public static Object Instantiate(Object original, Vector3 position, Quaternion rotation, Transform parent);
```

<table class="list"><tbody><tr><td class="name lbl">original</td><td class="desc">An existing object that you want to make a copy of.</td></tr><tr><td class="name lbl">position</td><td class="desc">Position for the new object.</td></tr><tr><td class="name lbl">rotation</td><td class="desc">Orientation of the new object.</td></tr><tr><td class="name lbl">parent</td><td class="desc">Parent that will be assigned to the new object.</td></tr><tr><td class="name lbl">instantiateInWorldSpace</td><td class="desc">When you assign a parent Object, pass true to position the new object directly in world space. Pass false to set the Object’s position relative to its new par</td></tr></tbody></table>



### Instantiate vs Instantiate as gameObject
https://docs.unity3d.com/ScriptReference/Quaternion.Euler.html


### ref
https://docs.unity3d.com/ScriptReference/Object.Instantiate.html

