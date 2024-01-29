## USS variables

**USS** variables define values that you can reuse in other USS rules. USS variables are primarily used for themes, with the default Unity themes exposing a long list of standard variables to make your UI more consistent with standard controls.

You can’t create USS variables with UI Builder. You **must use a text editor** to create a new USS variable in the USS file.

To assign a variable:

1. In the StyleSheet window, select the selector.
2. In the Inspector window, right-click a style field.
3. Select **Set Variable**. This converts the style field into a text field.
4. Enter the name of the **USS** variable. As you type the name of the variable, a dropdown list displays the available variables.


### USS custom properties (variables)
USS variables, also called custom properties, define values that you can reuse in other USS rules. You can create variables for any type of USS property.

You can create a USS variable and use it in other USS properties. When you update a USS variable, all of the USS properties that use that variable update. You can also specify default values for USS variables.


### Create and use USS variables

To create a USS variable, prefix its name with a double-hyphen (`--`).

```css
--color-1: red;
```

To use a USS variable value in another USS rule, use the `var()` function to call it.

```css
var(--color-1);
```

When you update a variable, it updates all the USS properties that use it.

For example, the following USS snippet defines one style rule that declares two color variables, and two style rules that use those variables.

```css
:root {
  --color-1: blue;
  --color-2: yellow;
}

.paragraph-regular {
  color: var(--color-1);
  background: var(--color-2);
  padding: 2px;
  }

.paragraph-reverse {
  color: var(--color-2);
  background: var(--color-1);
  padding: 2px;
  }
```

To update the color scheme, you can change the two variable values instead of the four color values.

Variables make it easier to manage styles for complex **UI** where multiple rules, sometimes in different style sheets, use the same values.

### Specify default values for USS variables

The `var()` function accepts an optional default value. The UI system uses the default value when it cannot resolve the variable. For example, if you remove a variable from a style sheet but forget to remove a reference to it.

To specify a default value for a variable, add it after the variable value, separated by a comma `,`.

The following USS snippet calls the `--color-1` variable. If the UI system can’t resolve the variable, it uses the hex value for red (`#FF0000`).

```css
var(--color-1, #FF0000);
```

### Differences from CSS variables

Variables work mostly the same way in USS as they do in CSS. For detailed information about CSS variables, see the [MDN documentation](https://developer.mozilla.org/en-US/docs/Web/CSS/Using_CSS_custom_properties). However, USS doesn’t support some of the functionalites of CSS:

-   USS doesn’t support the `var()` function inside of other functions, such as shown below:

```css
  background-color: rgb(var(--red), 0, 0);
```

-   USS doesn’t support mathematical operations on variables.

#### Using a prefix of two dashes (`--`)
A custom property prefixed with two dashes begins with `--`, followed by the property name (e.g.,`--my-property`), and a property value that can be any valid CSS value. Like any other property, this is written inside a ruleset. The following example shows how to create a custom property `--main-bg-color` and uses a `<named-color>` value of brown:

```
section {
  --main-bg-color: brown;
}
```


### USS built-in variables
**USS built-in** variables specify default values for Editor and runtime UI. You can use these variables in your own USS to match your custom interfaces with Unity style.

The name of each built-in variable indicates how and where the variable is used. A variable name consists of one or more parts, **separated by hyphens**. Each part consists of one or more words **separated by underscores**.

```css
--unity-{group}-{role_and_control}-{sub_element}-{pseudo_state_sequence}
```

Each part of the name shows the types of USS rules that use the variable.

- Group: The kind of data the variable represents.
- Role/Control: A conceptual grouping for the elements the variable affects.
- Sub-Element: An element or control the variable affects.
- Pseudo States: Lists the states Unity uses the variable for.

For example, the following variable name:

`--unity-colors-button-text-hover`

Provides the following information about how Unity uses the variable:

  
|  | **Value** | **Meaning** |
| --- | --- | --- |
| **Group** | `colors` | Represents color data. |
| **Role/Control** | `button` | Affects buttons. |
| **Sub-Element** | `text` | Affects text. Its `group` is `colors`, so it affects text color. |
| **Pseudo-States** | `hover` | Applies to elements when the mouse pointer hovers over them. |

This USS built-in variable changes the color of button text when a user hovers over the button.


#### Group
The group specifies what kind of data the variable represents. Each group has several possible **sub-elements**.

The variable names have the following groups:

| **Group** | **Used for** |
| --- | --- |
| `colors` | Color properties, such as `background-color` and `border-color` |
| `metrics` | Properties that control dimensions and shapes. For example, `border-radius`, `border-width`, `margin`, and `padding` |
| `icons` | Standard Unity icon images |


#### Role and Control
Roles and controls are two ways of grouping elements conceptually.

-   **Role** refers to a group of elements that have the same purpose, regardless of what type each element is. For example, the `error` role includes all elements that display error messages to users.
-   **Control** refers to a group of elements of the same type, regardless of what they do. For example, `buttons` includes all buttons in the Editor.

Each variable has either a role or a control.

The variable names have the following roles and controls:

**Roles**
| **Role** | **Description** |
| --- | --- |
| `default` | Default style settings such as text color, background, and margin. |
| `alternated_rows` | Elements that display tabular data with alternating row colors. For example, list items in a list view. |
| `error` | Elements that communicate error states to users. |
| `highlight` | Highlighted parts of the UI. For example, text selections, or selected items in tree views. |
| `link` | Parts of the UI (typically text) that are clickable links. This is the un-clicked state. |
| `play_mode` | Elements displayed when the Editor is in Play mode. |
| `visited_link` | Parts of the UI, typically text, that are clickable links that a user has already clicked. |
| `warning` | Elements that communicate a warning message to users. |

**Controls**

 
| **Control** | **Description** |
| --- | --- |
| `app_toolbar` | The main Unity **toolbar** |
| `app_toolbar_button` | Buttons in the main Unity toolbar |
| `box` | Boxes used to group elements in the Editor UI |
| `button` | Buttons in the UI, except for toolbars |
| `dropdown` | Dropdown lists or menus |
| `helpbox` | Boxes used to display help information |
| `input_field` | Fields used to input text or numeric values |
| `label` | Text labels in the Editor UI |
| `object_field` | Fields used for object values. For example, property values for a **GameObject** or Asset. |
| `popup` | Popup menu and other popup controls |
| `preview` | Views used to display previews. For example, of Assets such as meshes and textures. |
| `scrollbar_groove` | The background element of a scrollbar in which users drag the scrollbar thumb |
| `scrollbar_thumb` | The draggable handle element in a scrollbar |
| `slider_groove` | The background element of a slider in which users drag the slider thumb |
| `slider_thumb` | The draggable handle element in a slider |
| `slider_thumb_halo` | An overlay displayed around the slider thumb when the user drags it |
| `tab` | Tab items in tab controls |
| `toolbar` | Any Editor toolbar except for the main Unity toolbar (`app_toolbar`) |
| `toolbar_button` | Buttons in an Editor toolbar |
| `window` | Editor windows |

### Sub-Element
The sub-element is the part of an element that the variable affects. Together with a variable’s group, the sub-element shows what kind of data the variable represents.

For example, when you see a variable name with the colors group and the text sub-element, it means Unity uses the variable in styles that affect text color.

The variable names have the following sub-elements:



### Pseudo-States

The pseudo-state sequence is a list of UI states that Unity uses a variable for.

For example, when you see a variable name with the `hover` pseudo state, it means Unity uses the variable in styles that affect elements when a user hovers the pointer over them.

For example: `--unity-colors-toolbar_button-text-hover`.

A variable name can have more than one pseudo-state. Multiple pseudo states appear in alphabetical order, separated by underscores `_`.

For example: `--unity-colors-toolbar_button-text-focus_selected`.

Unity variable names can have any combination of the following pseudo-states:


| **Pseudo-state** | **Description** |
| --- | --- |
| (none) | Normal state |
| `checked` | A checkbox-type control is checked |
| `disabled` | A control is disabled |
| `focus` | A control has focus |
| `hover` | A user hovers over a control |
| `inactive` | A control doesn’t have focus |
| `pressed` | A control is pressed |
| `selected` | A control is selected |

### USS built-in variable references
https://docs.unity3d.com/Manual/UIE-uss-built-in-variable-reference.html

### ref 
https://docs.unity3d.com/Manual/UIB-styling-ui-using-uss-variables.html

https://docs.unity3d.com/Manual/UIE-USS-variables.html

https://docs.unity3d.com/Manual/UIE-USS-UnityVariables.html

