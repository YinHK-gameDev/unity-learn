## Unity UI (uGUI)

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

#### Selectable Base Class(Add selectable component to a UI element)
The Selectable Class is the base class for all the interaction components and it handles the items that are in common.

| **Property:** | **Function:** |
| --- | --- |
| **Interactable** | This determines if this component will accept input. When it is set to false interaction is disabled and the transition state will be set to the disabled state. |
| **Transition** | Within a selectable component there are several depending on what state the selectable is currently in. The different states are: normal, highlighted, pressed and disabled. |
| **Navigation** | There are also a number of Navigation Options to control how keyboard navigation of the controls is implemented. |

https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/script-Selectable.html

**Transition Options:**

Within a selectable component there are several transition options depending on what state the selectable is currently in. The different states are: normal, highlighted, pressed and disabled.

| **Transition Options:** | **Function:** |
| --- | --- |
| **None** | This option is for the button to have no state effects at all. |
| **Color Tint** | Changes the colour of the button depending on what state it is in. It is possible to select the colour for each individual state. It is also possible to set the Fade Duration between the different states. The higher the number is, the slower the fade between colors will be. |
| **Sprite Swap** | Allows different sprites to display depending on what state the button is currently in, the sprites can be customised. |
| **Animation** | Allows animations to occur depending on the state of the button, an animator component must exist in order to use animation transition. It’s important to make sure root motion is disabled. To create an animation controller click on generate animation (or create your own) and make sure that an animation controller has been added to the animator component of the button. |

https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/script-SelectableTransition.html


**Navigation Options:**
| **Property:** | **Function:** |
| --- | --- |
| **Navigation** | The Navigation options refers to how the navigation of UI elements in play mode will be controlled. |
| **None** | No keyboard navigation. Also ensures that it does not receive focus from clicking/tapping on it. |
| **Horizontal** | Navigates Horizontally. |
| **Vertical** | Navigates Vertically. |
| **Automatic** | Automatic Navigation. |
| **Explicit** | In this mode you can explicitly specify where the control navigates to for different arrow keys. |
| **Visualize** | Selecting Visualize gives you a visual representation of the navigation you have set up in the scene window. See below. |


https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/script-SelectableNavigation.html



### UI Effect Components

The effects components allow adding simple effects to Text and Image graphics, such as **shadow and outline**.

 - Shadow
 - Outline
 - Position as UV1


https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/comp-UIEffects.html

### ref
https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/index.html

**`UnityEngine.UI` scripting API** \
https://docs.unity3d.com/Packages/com.unity.ugui@1.0/api/UnityEngine.UI.html

**UI reference** \
https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/UIReference.html

**`UnityEngine.UIElements`** \
https://docs.unity3d.com/Packages/com.unity.ui@1.0/api/UnityEngine.UIElements.html

**`UnityEditor.UIElements`** \
https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/script-Toggle.html



