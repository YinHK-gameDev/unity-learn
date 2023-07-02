## Unity UI

Unity UI is a set of tools for developing user interfaces for games and applications. The Unity User Interface (Unity UI) package (also called uGUI) is **an older, GameObject-based UI system** that you can use to develop runtime UI for games and applications. 

It is a **GameObject-based UI system** that uses **Components and the Game View to arrange, position, and style user interfaces**. 

You cannot use Unity UI to create or change user interfaces in the Unity Editor.


### Visual Components
- Text
- Image
- Raw Image
- Mask
- RectMask2D

https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/UIVisualComponents.html

https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/comp-UIVisual.html


### Interaction Components
The interaction components are not visible on their own, and must be combined with one or more visual components in order to work correctly.

Most of the interaction components have some things in common. They are selectables, which means they have shared built-in functionality for visualising transitions between states (normal, highlighted, pressed, disabled), and for navigation to other **selectables** using keyboard or controller. 

> The interaction components have at least one UnityEvent that is invoked when user interacts with the component in specific way. The UI system catches and logs any exceptions that propagate out of code attached to UnityEvent.

- Selectable Base Class
- Button
- Toggle
- Toggle Group
- Slider
- Scrollbar
- Scroll Rect(Scroll View)
- InputField

https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/UIInteractionComponents.html

https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/comp-UIInteraction.html

Selectable Base Class 

https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/script-Selectable.html

### UI Effect Components

The effects components allow adding simple effects to Text and Image graphics, such as **shadow and outline**.

 - Shadow
 - Outline
 - Position as UV1


https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/comp-UIEffects.html

### ref
https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/index.html

**Scripting API** \
https://docs.unity3d.com/Packages/com.unity.ugui@1.0/api/UnityEngine.UI.html

**UI reference** \
https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/UIReference.html

https://docs.unity3d.com/Manual/UIToolkits.html
