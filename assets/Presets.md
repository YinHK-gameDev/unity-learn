## Presets
**Presets** to apply **custom default settings for types of assets.**

Presets are assets that you can use to save and apply identical property settings across multiple components, assets, or Project Settings windows. You can also use Presets to specify default settings for new components and default import settings for assets in the Preset Manager The Preset Manager supports any importers, components, or scriptable objects you add to the Unity Editor.

### Saving and applying Presets

Presets allow you to **save the property configuration of a component, asset, or Project Settings window as a Preset asset**. You can then use this **Preset asset** to **apply the same settings** to a **different component, asset, or Project Settings window**.

**For example**, you could edit the properties of a **Rigidbody component**, **save these settings to a Preset asset**, then **apply that Preset asset to Rigidbody components** in other GameObjects
. The other components in the GameObjects are not affected; the Preset only applies its settings to the Rigidbody component.

> You can **store Presets in the Assets folder of your project** (You may create a Preset folder to store all the Presets). Use the Project window to view and select Presets to edit in the Inspector.

### Saving property settings to a Preset
To save property settings to a **Preset asset**, follow the instructions below. You can save property settings while in **Edit mo**de or in **Play mod**e.

1.  Select the GameObject, Asset import settings, or Project Settings window from which you want to reuse settings. When you select it, it appears in the **Inspector** window.
2.  In the **Inspector** window, configure the properties as you want to save them. 
3.  Click the Preset selector (the slider icon) at the top-right of the **Inspector** window.

   


### Supporting presets

In your Editor scripts, use the `ObjectFactory` class to create **new GameObjects
, components and Assets**. When creating these items, the `ObjectFactory` class **automatically uses default Presets**. Your script does not have to search for and apply default Presets, because `ObjectFactory` handles this for you.

#### Support for new types
To support and enable Presets by default, your class must inherit from one of the following:

- `UnityEngine.Monobehaviour`
- `UnityEngine.ScriptableObject`
- `UnityEngine.ScriptedImporter`

The Preset Inspector creates a temporary instance of your class, so that users can modify its values, so make sure your class does not affect or rely on other objects such as static values, Project Assets or Scene instances.

 

### ref
https://docs.unity3d.com/Manual/Presets.html \
https://docs.unity3d.com/2021.3/Documentation/Manual/SupportingPresets.html \
https://docs.unity3d.com/2021.3/Documentation/Manual/DefaultPresetsByFolder.html

**`ObjectFactory`** \
https://docs.unity3d.com/2021.3/Documentation/ScriptReference/ObjectFactory.html



