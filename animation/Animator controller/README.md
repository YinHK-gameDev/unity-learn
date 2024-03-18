## Animator controller
An Animator Controller allows you to arrange and maintain a set of Animation Clips and associated Animation Transitions for a character or object.

When you have animation clips ready to use, you need to use an Animator Controller to bring them together. An **Animator Controller asset** is created within Unity and allows you to maintain a set of animations for a character or object.

 
The various ways an **Animator Controller** can be created:

- From the Project View by selecting `Create > Animator Controller`.

- By right-clicking in the Project View and selecting `Create > Animator Controller`.

- From the Assets menu by selecting `Assets > Create > Animator Controller`.

This creates a `.controller` asset on disk. In the Project Browser window the icon will look like:

> Animator Controller assets are created from the Assets menu, or from the Create menu in the Project window.

The controller manages the various **animation states** and the transitions between them using a so-called **State Machine**
, which could be thought of as a kind of flow-chart, or a simple program written in a visual programming language within Unity.


> To focus on an item in the Animator Controller window, select one or multiple states (click or drag a selection box around the states you wish to select), then press the F key to zoom in on the selection.


> Press the A key to fit all of the animation states into the Animator Controller view.

https://www.youtube.com/watch?v=S3ys0jCUE9s


### Animator Controller Asset
When you have animation clips ready to use, you need to use an Animator Controller
 to bring them together. An **Animator Controller asset** is **created within Unit**y and allows you to **maintain a set of animations** for a character or object.

![](./Animation_controller_asset.png)


Animator Controller assets are created from the Assets menu, or from the Create menu in the Project window.

The controller manages the **various animation states and the transitions between them using a so-called State Machine**. 

### Animator window

The **Animator Window** allows you to create, view and modify Animator Controller assets. 

**Animator window**: \
![](./MecanimAnimatorControllerWindow.png)

The **left-hand pane** can be switched betwen **Parameters view** and **Layers view**. The parameters view **allows you to create, view and edit the Animator Controller Parameters**. These are variables you define that act as inputs into the state machine. To add a parameter, click the Plus icon and select the parameter type from the pop up menu. To delete a parameter, select the parameter in the lists and press the delete key (on macOS use fn-Delete to delete the selected parameter).



When the **left-hand pane is switched to Layers view**, you can create, view and edit layers
 within your Animator Controller. \
This allows you to **have multiple layers of animation within a single animation controller working at the same time**, each **controlled by a separate state machine**. A common use of this is to have a **separate layer** **playing upper-body animations over a base layer** that controls the general movement animations for a character.

To **add a layer**, click the **plus icon**. To **delete a layer**, select the layer and right click to select delete.

Clicking the **"eye" icon** on or **off** will **show or hide the Parameters & Layers side-pane**, allowing you more room to see and edit your state machine.

The **lock icon**
enabling the lock icon will keep the Animator Window focused on the current state machine. When the lock icon is off, clicking a new animator asset or a Game Object with an animator component will switch the Animator Window to show that item’s state machine. Locking the window allows you to keep the Animator window showing the same state machine, regardless of which other assets or Game Objects are selected.

###  Animator Override Controller
It is a type of asset which allows you to extend an existing Animator Controller, replacing the specific animation clips but otherwise retaining the original’s structure, parameters and logic. The difference is the animation clips. 

This allows you to create multiple variants of the same basic state machine, but with each using different sets of animations.

> Reuse the original animation controller from other game object(with same logic, structure and parameters), just override the specific orignal animation clips

To create a new Animator Override Controller, use the **Assets > Create** menu, or the **Create** button in the Project view, and select **Animator Override Controller**.

In the controller field in the **Animator Override Controller** component, dragging an existing controller into the Animator Override Controller’s inspector.



### ref 
https://docs.unity3d.com/Manual/AnimatorControllers.html \
https://docs.unity3d.com/Manual/class-AnimatorController.html

