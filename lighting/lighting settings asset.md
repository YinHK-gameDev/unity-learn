## Lighting Settings Asset
A Lighting Settings Asset represents a saved instance of the **`LightingSettings`** class, which stores data for the Baked Global Illumination and the **`Enlighten Realtime Global Illumination systems`**. The Unity Editor uses this data when it **precomputes lighting data for a Scene**
 that uses one or both of these systems.


> You can assign the same **`Lighting Settings Asset`** or **instance of the LightingSettings class to more than one Scene**, which makes it easy to share **`Global Illumination system settings`** across multiple Scenes.


### Creating a Lighting Settings Asset
There are two ways to create a Lighting Settings Asset in the Unity Editor.

To create a Lighting Settings Asset from the Project view:

1. In the Project view, either click the add (+) button, or open the context menu and navigate to Create.
2. Click Lighting Settings. Unity creates a new Lighting Settings Asset in the Project view.


To create and automatically assign Lighting Settings Asset from the Lighting window:

1. Open the Lighting window (menu: Window > Rendering > Lighting).
2. Open the Scene tab.
3. Click **New Lighting Asset**. Unity creates a new Lighting Settings Asset in the Project view, and immediately assigns it to the active Scene.

> You can also create a **Lighting Settings Asset** from a script. To do this, create an instance of the **`LightingSettings`** class and either save it to disk, or assign it to a Scene and save that Scene.


### Assigning a Lighting Settings Asset to a Scene

To assign a Lighting Settings Asset to a Scene in the Unity Editor:

1. Open the Scene that you want to assign the Lighting Settings Asset to.
2. If you have more than one Scene open, ensure that the Scene that you want to assign the Lighting Settings Asset to is the active Scene.
Open the Lighting window (menu: **Window > Rendering > Lighting**).
3. Open the Scene tab.
4. Either drag the Lighting Settings Asset to the **Lighting Settings** field, or click the icon to the right of the **Lighting Settings** field and choose the Lighting Settings Asset from the list.

You can also assign a Lighting Settings Asset to the active Scene from a script. To do this, load the Lighting Settings Asset to obtain an instance of the `LightingSettings` class, then use the `Lightmapping.lightingSettings` API to assign that `LightingSettings` instance to the active Scene.


### Viewing and editing the properties of a Lighting Settings Asset
You can view and edit the properties of Lighting Settings Asset in two places in the Unity Editor:

- In the Project view, if you select a Lighting Settings Asset, you can view and edit its properties in the Inspector.
- If the active Scene has a Lighting Settings Asset assigned to it, you can view and edit the properties of that Lighting Settings Asset in the Lighting Window’s Scene tab.


> You can also read from or write to the properties of a **Lighting Settings Asset** from a script. To do this, load the Lighting Settings Asset to obtain an instance of the `LightingSettings` class, and access its properties.



https://docs.unity3d.com/Manual/class-LightingSettings.html


