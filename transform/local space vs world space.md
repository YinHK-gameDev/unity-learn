## Local space vs World space


###  World Space 


#### **World Space** = global coordinate system
-   Think of this as the **overall scene's coordinate system**.
-   `Vector3(0, 0, 0)` is the center of the world.
-   Every object's position in world space is **absolute**, no matter who its parent is.
    
```cs
`transform.position // <- this gives you position in world space`
```

### Local Space

####  Local Space = coordinate system relative to the object's parent
- An object’s local position is relative to its parent's transform.
- `Vector3(0, 0, 1)` in local space means "one unit forward from the parent," no matter where or how the parent is rotated or placed in the world.

```cs
transform.localPosition // <- position relative to parent
```
### Summary
- Use local space when you want things to move relative to a parent (e.g., moving inside a car).
- Use world space when dealing with scene-wide logic (e.g., pathfinding, physics).

### ref 
https://m-ansley.medium.com/local-space-and-world-space-in-unity-970e0bfb7694
