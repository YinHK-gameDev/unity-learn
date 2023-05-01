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

### ref 
https://docs.unity3d.com/Manual/UIB-styling-ui-using-uss-variables.html

https://docs.unity3d.com/Manual/UIE-USS-variables.html
