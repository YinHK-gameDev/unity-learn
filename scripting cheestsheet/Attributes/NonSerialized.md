### NonSerialized
The `NonSerialized` attribute marks a variable to not be serialized.

This way you can keep a variable public and Unity **does not attempt to serialize it or show it in the Inspector**.


`[NonSerialized]` prevents a variable from being saved (serialized) at all, 
while `[HideInInspector]` keeps the variable serialized (saved) but hides it from the Unity Inspector, useful for private fields you still need saved in scenes/prefabs but don't want to edit manually. Use [NonSerialized] for temporary data, calculated values, or large things you don't need saved; use [HideInInspector] with [SerializeField] for private data that needs to persist but shouldn't clutter the inspector. 


