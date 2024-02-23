## Presets
**Presets** to apply **custom default settings for types of assets.**

Presets are assets that you can use to save and apply identical property settings across multiple components, assets, or Project Settings windows. You can also use Presets to specify default settings for new components and default import settings for assets in the Preset Manager The Preset Manager supports any importers, components, or scriptable objects you add to the Unity Editor.

Presets allow you to save the property configuration of a component, asset, or Project Settings window as a Preset asset. You can then use this Preset asset to apply the same settings to a different component, asset, or Project Settings window.


### Supporting presets

In your Editor scripts, use the `ObjectFactory` class to create **new GameObjects
, components and Assets**. When creating these items, the `ObjectFactory` class **automatically uses default Presets**. Your script does not have to search for and apply default Presets, because `ObjectFactory` handles this for you.

#### Support for new types
To support and enable Presets by default, your class must inherit from one of the following:

- `UnityEngine.Monobehaviour`
- `UnityEngine.ScriptableObject`
- `UnityEngine.ScriptedImporter`

The Preset Inspector
 creates a temporary instance of your class, so that users can modify its values, so make sure your class does not affect or rely on other objects such as static values, Project Assets or Scene
 instances.

 

### ref
https://docs.unity3d.com/Manual/Presets.html \
https://docs.unity3d.com/2021.3/Documentation/Manual/SupportingPresets.html \
https://docs.unity3d.com/2021.3/Documentation/Manual/DefaultPresetsByFolder.html

**`ObjectFactory`** \
https://docs.unity3d.com/2021.3/Documentation/ScriptReference/ObjectFactory.html



