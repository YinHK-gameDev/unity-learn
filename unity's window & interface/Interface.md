## Unity’s interface


- (A) The **Toolbar** provides access to your Unity Account and Unity Cloud Services. It also contains controls for Play mode; Undo history; Unity Search; a layer visibility menu; and the Editor layout menu.
- (B) The **Hierarchy window** is a hierarchical text representation of every GameObject
 in the Scene. Each item in the Scene has an entry in the hierarchy, so the two windows are inherently linked. The hierarchy reveals the structure of how GameObjects attach to each other.
- (C) The **Game view** simulates what your final rendered game will look like through your Scene Cameras
. When you click the Play button, the simulation begins.
- (D) The **Scene view** allows you to visually navigate and edit your Scene. The Scene view
 can display a 3D or 2D perspective, depending on the type of Project you are working on.
- (E) **Overlays** contain the basic tools for manipulating the Scene view and the GameObjects within it. You can also add custom Overlays to improve your workflow.
- (F) The **Inspector window** allows you to view and edit all the properties(components) of the currently selected GameObject. Because different types of GameObjects have different sets of properties, the layout and contents of the Inspector window change each time you select a different GameObject. (You can copy component from one gameobject to paste it to another gameobject)
- (G) The **Project window** displays your library of Assets that are available to use in your Project. When you import Assets into your Project, they appear here.
- (H) The **status bar** provides notifications about various Unity processes, and quick access to related tools and settings.



> **Note**:  In Unity's **Hierarchy** window, the **eye** and **finger** icons represent the **visibility** and **interactivity** settings for GameObjects in the scene. The eye icon controls the visibility of a GameObject in the Scene view.

> If the eye icon is closed (grayed out), the GameObject is hidden from the Scene view (the editor view). This means you cannot see the GameObject in the scene when editing it, but it is still present in the game during runtime.

> The finger icon (or the "raycast" icon) controls whether the GameObject can interact with the player or respond to input events, such as clicks or raycasts. This is usually seen with UI elements, such as buttons, that are interactive.
> When the finger icon is enabled (visible), the GameObject can receive user input, and it will respond to things like clicks or touch events.
When the finger icon is disabled (grayed out), the GameObject cannot receive any input, and will be inactive to interaction (e.g., buttons won't be clickable).
This is useful for disabling UI elements or GameObjects that you don't want the player to interact with during certain parts of the game (like a pause menu).



