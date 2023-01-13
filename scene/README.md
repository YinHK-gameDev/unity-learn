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

When you create a new scene from a template, either from a script or using the New Scene dialog, Unity triggers an [event](./https://docs.unity3d.com/ScriptReference/SceneTemplate.SceneTemplateService.html). Unity triggers this event after the template is instantiated, and also after it triggers the `EditorSceneManager.newSceneCreated` or `EditorSceneManager.sceneOpened` events.

```cs
public class SceneTemplate
{
    public delegate void NewTemplateInstantiated(SceneTemplateAsset sceneTemplateAsset, Scene scene, SceneAsset sceneAsset, bool additiveLoad);

    public static event NewTemplateInstantiated newSceneTemplateInstantiated;
}
```

### Load scene
To open a scene, do one of the following:

- In the Project window, **double-click the scene asset**.
- From the menu, **select File > New Scene**
- From the menu, **select File > Recent Scenes > [NAME-OF-SCENE]**



https://docs.unity3d.com/Manual/scenes-working-with.html

