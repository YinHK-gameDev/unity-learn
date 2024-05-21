## Preset Manager
The Preset Manager is a window in Project Settings (menu: **Edit > Project Settings > Preset Manager**) that allows you to **manage custom Presets** you **create to specify default properties** when you add a component to a GameObject or a new Asset to your project. 


> **Note**: The default Presets you define override Unity’s default settings.

| Property | Description |
| --- | --- |
| **Filter** | Use the **Filter** field to define which components or importers the Preset is applied to. |
| **Preset** | Use the **Preset** field to set the Preset you want to use. By default, a Preset applies to all components or asset importers of that Preset type once you create it. If you want to only apply it to specific components or asset types, use the **Filter** field to **define when to apply the Preset**. |
| **Add Default Preset** | Select this button to choose the **Importer**, **Component** or **ScriptableObject** to add a Preset to. If you choose **Importer** or **Component**, select the type of asset importer or component you want to create a Preset for. |


### Assigning a Preset for default settings


![](./preset-manager-add-type.png)


To specify a Preset to use for default settings in the Preset Manager:

1.  If you don’t already have a Preset in your project to use for default settings, create one.
2.  Open the Preset Manager by choosing **Edit > Project Settings**, and selecting the **Preset Manager**.
3.  Select **Add Default Preset** and select a default type. \
    The Preset type you choose appears in the **Preset Manager** list.
4.  In the Preset field, click the **Preset selector** (circle icon).
5.  From the **Select Preset** window, choose a Preset for this Preset type. \
    Alternatively, you can also drag and drop a Preset from the **Project** window into the Preset field.  
6.  If you want to add another Preset field to the list, click the **Add** (**+**) tab.  

> **Note**: If you set a default Preset for Transform components, Unity does not use the Position values when you create a new GameObject. Instead, it sets the default Position values to the center of the Scene view. To set the Position values to those of the default Preset, select the Transform component’s More items button (⋮) and select Reset.


### Assigning Presets via the Inspector window

You can also add and remove Presets to use for default settings via the **Inspector** window.

To add a default Preset:

1.  Select a Preset in the **Project** window.
2.  In the **Inspector** window, click **Add to default**.  \
    Unity adds your default Preset to the **Preset Manager**.
3.  Open the **Preset Manager** to add filters to the Preset or reorder your Preset list.

To remove a default Preset:

1.  Select a Preset in the **Project** window.
2.  In the **Inspector** window, click **Remove from**.




### ref
https://docs.unity3d.com/Manual/class-PresetManager.html
