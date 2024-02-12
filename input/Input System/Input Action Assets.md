## Input Action Assets

To create an Asset that contains Input Actions in Unity, right-click in the Project window or go to **Assets > Create > Input Actions** from Unity's main menu.


![](./img/MyGameActions.png)

By default, Unity doesn't save edits you make in the Action Asset window when you save the Project. To save your changes, select **Save Asset** in the window's toolbar. To discard your changes, close the window and choose **Don't Save** when prompted. Alternatively, you can toggle auto-saving on by enabling the **Auto-Save** checkbox in the toolbar. This saves any changes to that Asset.

The Action editor window is divided into three panes:

1.  The left pane lists the Action Maps in the Asset. Each Action Map is a collection of Actions that you can enable or disable in bulk.
2.  The middle pane contains the Actions in the currently selected Action Map, and the bindings associated with each Action.
3.  The right pane contains the properties of the currently selected Action or Binding.

If you select an Action, you can edit it's properties in the right-hand pane of the window

![](,.img/ActionProperties.png)



#### Editing Bindings

-   To add a new Binding, select the Add **(+)** icon on the action you want to add it to, and select the binding type from the menu that appears.
-   To delete an existing Binding, either right-click it and select **Delete** from the context menu, or use the **Delete** key (Windows) / **⌘⌫ (Mac)**.
-   To duplicate an existing Binding, either right-click it and select **Duplicate** from the context menu, or use **Ctrl-D** (Windows) / **⌘D (Mac)**.

If you select a Binding, you can edit its properties in the right-hand pane of the window:

![](./img/BindingProperties.png)

#### Picking Controls

The most important property of any Binding is the control path. To edit it, open the **Path** drop-down list. This displays a Control picker window.

![](./img/InputControlPicker.png)







### ref
https://docs.unity3d.com/Packages/com.unity.inputsystem@1.7/manual/ActionAssets.html


