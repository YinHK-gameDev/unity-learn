## Animation controller
An Animator Controller allows you to arrange and maintain a set of Animation Clips and associated Animation Transitions for a character or object.

When you have animation clips ready to use, you need to use an Animator Controller to bring them together. An Animator Controller asset is created within Unity and allows you to maintain a set of animations for a character or object.
 
 
The various ways an Animator Controller can be created:

- From the Project View by selecting `Create > Animator Controller`.

- By right-clicking in the Project View and selecting `Create > Animator Controller`.

- From the Assets menu by selecting `Assets > Create > Animator Controlle`.

This creates a `.controller` asset on disk. In the Project Browser window the icon will look like:

> Animator Controller assets are created from the Assets menu, or from the Create menu in the Project window.

The controller manages the various **animation states** and the transitions between them using a so-called **State Machine**
, which could be thought of as a kind of flow-chart, or a simple program written in a visual programming language within Unity.


> To focus on an item in the Animator Controller window, select one or multiple states (click or drag a selection box around the states you wish to select), then press the F key to zoom in on the selection.

https://www.youtube.com/watch?v=S3ys0jCUE9s


###  Animator Override Controller
It is a type of asset which allows you to extend an existing Animator Controller, replacing the specific animation clips but otherwise retaining the original’s structure, parameters and logic. The difference is the animation clips. 

This allows you to create multiple variants of the same basic state machine, but with each using different sets of animations.

> Reuse the original animation controller from other game object(with same logic, structure and parameters), just override the specific orignal animation clips

To create a new Animator Override Controller, use the **Assets -> Create** menu, or the **Create** button in the Project view, and select **Animator Override Controller**.

In the controller field in the **Animator Override Controller** component, dragging an existing controller into the Animator Override Controller’s inspector.


https://docs.unity3d.com/Manual/class-AnimatorController.html

