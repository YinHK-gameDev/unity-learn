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

### Transform component in the Inspector
#### Position
By default, the Position values (X, Y, Z) in the Inspector show the GameObject’s position relative to its parent (**local space**). If the GameObject has no parent (i.e., it’s at the root of the hierarchy), **local space equals world space**, so the values are effectively world-space coordinates.

Example: For your object (root-level GameObject, no parent), Position (2, 1, 3) means it’s at (2, 1, 3) in world space. If it had a parent at (5, 0, 0), Position (2, 1, 3) would mean it’s offset by (2, 1, 3) from the parent’s position, resulting in world position (7, 1, 3).

#### Rotation

The Rotation values (X, Y, Z, in Euler angles) in the Inspector show the GameObject’s rotation relative to its parent (local space). For a root-level GameObject (like your forklift), local rotation equals world rotation [].

#### Scale

The Scale values (X, Y, Z) are always shown in local space, representing the scaling relative to the GameObject’s own coordinate system (not affected by the parent’s scale directly in the Inspector display) [].












### ref 
https://m-ansley.medium.com/local-space-and-world-space-in-unity-970e0bfb7694
