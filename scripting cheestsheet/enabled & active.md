## Enabled vs Active


In Unity, **`enabled`** and **`active`** are two different concepts that control whether or not certain components or GameObjects are functioning or visible, but they work in different ways:

### **`enabled`** (for Components):

-   The **`enabled`** property is used for individual **components** attached to a **GameObject** (e.g., `Renderer`, `Collider`, `Script`, `UI`, etc.).
-   It determines whether the component is active and will be executed or rendered during the game.

**Key Points:**

-   **Renderer (`Renderer.enabled`)**: Controls whether the object is rendered. If `false`, the object will not be visible.
-   **Collider (`Collider.enabled`)**: Controls whether the collider is active for detecting collisions. If `false`, the object will not interact with other colliders.
-   **Scripts (`MonoBehaviour.enabled`)**: Controls whether the script will run. If `false`, the `Update()`, `Start()`, and other functions will not be called.

Eg: 
```cs
// Example of disabling a component
Renderer renderer = GetComponent<Renderer>();
renderer.enabled = false; // The object will be invisible but still present in the scene
```


### **`SetActive()`** (for GameObjects):

-   The **`SetActive()`** method is used on **GameObjects** and determines whether the GameObject itself is active in the scene or not.
-   If a GameObject is inactive, it and all its components (including children) will be **deactivated**.

**Key Points:** 

-   **SetActive(false)**: The GameObject becomes inactive, and all its components will stop functioning (no updates, no rendering, etc.). The GameObject will not appear in the scene and will not be part of any physics, interactions, etc.
-   **SetActive(true)**: The GameObject and its components are re-activated.


Eg: 
```cs
// Example of disabling a GameObject
GameObject myObject = GameObject.Find("MyObject");
myObject.SetActive(false); // The entire GameObject and its components will be disabled

```

### **Differences:**

1.  **Scope**:
    
    -   **`enabled`** affects only a specific **component** (e.g., `Renderer`, `Collider`, `MonoBehaviour`).
    -   **`SetActive()`** affects the entire **GameObject**, including all of its components and children.
2.  **Functionality**:
    
    -   **`enabled`** allows you to selectively disable specific functionality within a component while keeping the GameObject active. For example, disabling a `Renderer` will hide the object but the GameObject itself is still part of the scene.
    -   **`SetActive()`** completely disables the **GameObject**, preventing all its components (including the `Renderer`, `Collider`, and any scripts) from running. It effectively "removes" the GameObject from the scene during gameplay.
3.  **Hierarchy Propagation**:
    
    -   When you disable a **GameObject** using `SetActive(false)`, it also disables all of its **children**, regardless of their individual `enabled` states.
    -   Disabling a component (e.g., `Renderer.enabled = false`) only affects that component, leaving other components on the GameObject unaffected.

### **Summary of Use Cases**:

-   **Use `enabled`** when you want to disable specific **components** on a GameObject, such as stopping a script from running, making the object invisible, or disabling a collider.
-   **Use `SetActive(false)`** when you want to **completely hide and deactivate a GameObject**, including all its components and child objects.


### Example Scenario:

Imagine you have a character that you want to make **invisible** and **stop moving** when the game is paused.

```cs
// Disable renderer to make invisible
GetComponent<Renderer>().enabled = false;

// Disable player movement script to stop movement
GetComponent<PlayerMovement>().enabled = false;

```

If you want to **completely remove** the character (including its components and child objects) from the scene, you would do:

```cs
// Deactivate the entire GameObject
gameObject.SetActive(false);

```

This way, you can control the visibility and activity of both individual components and entire GameObjects based on your game logic.




