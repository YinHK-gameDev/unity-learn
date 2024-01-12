## Scene

### Creating a new scene
There are several ways to create a new scene:

- Use the New Scene dialog to create a new scene from a specific scene template.
- Use the menu(**Assets > Create > Scene**)  or the Project window to create new scenes from your Project’s Basic scene template without opening the New Scene dialog.
- Create a scene from a specific template directly from a C# script.


### The New Scene dialog
The New Scene dialog opens when you create a new scene from the File menu: (**`File > New Scene`**) or the **`Ctrl/Cmd + n`** shortcut. Use it to create new scenes from specific scene templates in your project, and get information about existing templates.


### Creating a new scene from a C# script

To create a new scene from a C# script using a specific scene template, use the Instantiate method.

```cs
Tuple<Scene, SceneAsset> SceneTemplate.Instantiate(SceneTemplateAsset sceneTemplate, bool loadAdditively, string newSceneOutputPath = null);
```

When you create a new scene from a template, either from a script or using the New Scene dialog, Unity triggers an **`event`**. Unity triggers this event after the template is instantiated, and also after it triggers the **`EditorSceneManager.newSceneCreated`** or **`EditorSceneManager.sceneOpened`** events.

```cs
public class SceneTemplate
{
    public delegate void NewTemplateInstantiated(SceneTemplateAsset sceneTemplateAsset, Scene scene, SceneAsset sceneAsset, bool additiveLoad);

    public static event NewTemplateInstantiated newSceneTemplateInstantiated;
}
```
### Scene templates
You can create your **own scene templates** to customize the types of new scene you can create in a project. For example, you might create templates for each level in a game so that everyone working on the project can start their scenes with the correct assets and configuration.

https://docs.unity3d.com/Manual/scene-templates.html \
https://docs.unity3d.com/Packages/com.unity.scene-template@1.0/manual/index.html

### Creating scene templates
You can create a new scene template in one of the following ways:

- Start an empty template:
  - From the menu, select **Assets > Create > Scene Template**. Or
  - create an empty scene template in a specific project folder:
    - In the Project window , right-click the folder to open the context menu. Or
    - Open the folder in the Project window, and right-click the asset pane to open the context menu. Or
    - Select **Create > Scene Template**.
- Create a template from an existing scene asset.
  You can turn any existing scene into a scene template.
  - **Right-click** a scene asset to open the **context menu**. Then select **Create > Scene Template From Scene**.
  - Select the scene asset, and from the **main menu**, select **Assets > Create > Scene Template From Scene**.
- Create a template from the current scene.
  - **select File > Save As Scene Template**.
- Creating templates from C# scripts
  - create an empty scene template, use the `CreateSceneTemplate` method.
    ```cs
     SceneTemplate.CreateSceneTemplate(string sceneTemplatePath)
    ```
  - create a template from an existing scene, use the `CreateTemplateFromScene` method. 
    ```cs
     SceneTemplate.CreateTemplateFromScene(SceneAsset sourceSceneAsset, string sceneTemplatePath);
    ```
  https://docs.unity3d.com/Packages/com.unity.scene-template@1.0/api/UnityEditor.SceneTemplate.SceneTemplate.html \
  https://docs.unity3d.com/Packages/com.unity.scene-template@1.0/manual/creating-scene-templates.html

### Load scene
To open a scene, do one of the following:

- In the Project window, **double-click the scene asset**.
- From the menu, **select File > New Scene**
- From the menu, **select File > Recent Scenes > [NAME-OF-SCENE]**

### Saving scenes
**File > Save** Scene from the menu, or press **Ctrl + S** (Windows)

### Multiple scenes in Unity
We can open and edit multiple scenes in the Unity Editor simultaneously. Open multi scenes at once.
Having multiple scenes open at once also lets you improve the workflow, especially if you often have to edit scenes collaboratively.

> If you have multiple active scenes, all the game objects in multiple scenes will be showed unless you deactivate the scene or gameobjects.

To add multi scenes at editor: 

- Right click to open the menu of a scene asset in the Project window and select Open Scene Additive.
- Drag one or more scenes from the Project window into the Hierarchy window.

Right click the scene, in the list you can:
| Setting | Description |
| --- | --- |
| Set Active Scene | Sets the scene as the target for new GameObjects created through scripts. For more information, see SceneManager.SetActiveScene. |
| Save Scene | Saves the scene that you selected. |
| Save Scene As | Opens your file browser so you can choose where and how to save the scene. |
| Save All | Saves all the scenes you have open in the Hierarchy window. |
| Unload Scene | Hides the contents of the scene from the Scene view and the Hierarchy window. If you have unsaved changes, save them before you unload the scene to not lose any changes. |
| Remove Scene | Removes the scene from the Hierarchy window. |
| Discard changes | Undoes any changes that you haven’t saved. |
| Select Scene Asset | Highlights the scene asset in the Project window. |
| Add New Scene | Adds a new untitled scene below the scene you have selected. |
| GameObject | Opens a dropdown menu of GameObjects that you can add to the scene you have selected. |

| Setting | Description |
| --- | --- |
| Load Scene | Displays the contents of the scene in the Hierarchy window and the Scene view, and allows you to edit them. |
| Remove Scene | Removes the scene from the Hierarchy window. |
| Select Scene Asset | Highlights the scene asset in the Project window. |
| Add New Scene | Adds a new untitled scene below the scene you have selected. |

**Play mode**:

When you are in Play mode and have multiple scenes in the Hierarchy window, the Editor displays an additional scene called DontDestroyOnLoad. You can’t access the DontDestroyOnLoad scene and it’s also not available at runtime.


https://docs.unity3d.com/Manual/MultiSceneEditing.html

https://docs.unity3d.com/Manual/setupmultiplescenes.html



### Use scripts to edit multiple scenes

When using (or running) scripts within the Editor, use:

- `Scene struct`: Available both in the Editor and at runtime, Scene struct contains read-only properties that relate to the scene itself, such as name and asset path.
- `EditorSceneManager` API: This class is only available only in the Editor and has several functions to implement all the Multi-Scene editing features described in the pages Setup multiple scenes and Bake data in multiple scenes.
- `SceneSetup utility` class: A utility class that you can use to store information about a scene that is in the Hierarchy window.

https://www.youtube.com/watch?v=zObWVOv1GlE

https://www.youtube.com/watch?v=91kJtsDLTyE

https://www.youtube.com/watch?v=kJCEW0ECuqk

**runtime scripts:**

When using scripts at runtime to edit multiple scenes, use the functions in the `SceneManager` class such as `LoadScene` and `UnloadScene`.



https://docs.unity3d.com/Manual/scenes-working-with.html

