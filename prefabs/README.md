## Prefabs

### What are prefabs in Unity?

> **Prefabs** are a special type of component that allows fully configured GameObjects to be saved in the Project for **reuse**.

These assets can then be shared between scenes, or even other projects without having to be configured again. This is quite useful for objects that will be used many times, such as platforms.

**Prefabs is that they are essentially linked copies of the asset** that exist in the Project window. 

For Prefabs, you can
- Instantiate a Prefab using one line of code. Creating equivalent GameObjects from scratch requires many more lines of code.
- Set up, test, and modify the Prefab quickly and easily using the Scene
 view, **Hierarchy** and **Inspector**.


### How to create Prefabs?
Prefabs are created automatically when an object is **dragged from the Hierarchy into the Project window**.
Prefabs look quite similar to other objects that appear in the Project window. However, when selected, their file type will be a **`*.prefab`**. When the Prefab is selected, the Inspector displays all of the components that were configured on the original object.

### How to use Prefabs?
Just drag Prefabs from project window into Hierarchy if you want to reuse. When prefabs are present in the Hierarchy, they’re represented with blue text and a **blue cube**.

### Unpacking Prefab instances
To return the contents of a Prefab instance into a regular GameObject
, you unpack the Prefab instance. This is exactly the reverse operation of creating (packing) a Prefab, except that it doesn’t destroy the Prefab Asset but only affects the Prefab instance.

You can unpack a Prefab instance by **right-clicking on it in the Hierarchy and selecting Unpack Prefab.** The resulting GameObject in the Scene no longer has any link to its former Prefab Asset. The Prefab Asset itself is not affected by this operation and there may still be other instances of it in your Project.


### ref
https://learn.unity.com/tutorial/prefabs-e# \
https://docs.unity3d.com/Manual/InstantiatingPrefabs.html \
https://docs.unity3d.com/Manual/UnpackingPrefabInstances.html


