### Unity​Editor.​Scene​Template


### `SceneTemplate` class

```cs
public static class SceneTemplate
```

Create a new Scene template at a specific path. This scene template won't be bound to a scene.
```cs
public static SceneTemplateAsset CreateSceneTemplate(string sceneTemplatePath)
```

Create a new scene template bound to a specific scene. All its dependencies will automatically be extracted and set to reference.
```cs
public static SceneTemplateAsset CreateTemplateFromScene(SceneAsset sourceSceneAsset, string sceneTemplatePath)
```

Instantiate a new scene from a template.
```cs
public static Tuple<Scene, SceneAsset> Instantiate(SceneTemplateAsset sceneTemplate, bool loadAdditively, string newSceneOutputPath = null)
```


Events fired after a template is instantiated.
```cs
public static event SceneTemplate.NewTemplateInstantiated newSceneTemplateInstantiated
```

Events fired before a template is instantiated
```cs
public static event SceneTemplate.NewTemplateInstantiating newSceneTemplateInstantiating
```


### ref
https://docs.unity3d.com/Packages/com.unity.scene-template@1.0/api/UnityEditor.SceneTemplate.html \
https://docs.unity3d.com/Packages/com.unity.scene-template@1.0/api/UnityEditor.SceneTemplate.SceneTemplate.html
