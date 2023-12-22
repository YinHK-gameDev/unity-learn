## Camera

#### Camera.main
The first enabled Camera component that is tagged **"MainCamera"** (Read Only).

If there is no enabled Camera component with the "MainCamera" tag, this property is null.

Internally, Unity caches all GameObjects with the "MainCamera" tag. When you access this property, Unity returns the first valid result from its cache. Accessing this property has a small CPU overhead, comparable to calling GameObject.GetComponent. Where CPU performance is important, consider caching this property.

```cs
public static Camera main;
```


### ref
https://docs.unity3d.com/ScriptReference/Camera.html
