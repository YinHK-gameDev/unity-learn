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


### USS built-in variables
**USS built-in** variables specify default values for Editor and runtime UI. You can use these variables in your own USS to match your custom interfaces with Unity style.

The name of each built-in variable indicates how and where the variable is used. A variable name consists of one or more parts, separated by hyphens. Each part consists of one or more words separated by underscores.

```css
--unity-{group}-{role_and_control}-{sub_element}-{pseudo_state_sequence}
```

Each part of the name shows the types of USS rules that use the variable.

- Group: The kind of data the variable represents.
- Role/Control: A conceptual grouping for the elements the variable affects.
- Sub-Element: An element or control the variable affects.
- Pseudo States: Lists the states Unity uses the variable for.

### ref 
https://docs.unity3d.com/Manual/UIB-styling-ui-using-uss-variables.html

https://docs.unity3d.com/Manual/UIE-USS-variables.html
