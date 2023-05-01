## USS selectors
Selectors decide which elements that USS rules affect.

USS supports a set of simple selectors that are analogous, but not identical, to simple selectors in CSS. A simple selector matches elements by element type, USS class, element name, and wildcard.


You can combine simple selectors into complex selectors, or append **pseudo-classes** to them to target elements in specific states. USS supports descendant, child, and multiple complex selectors.


### Type selectors
USS type selectors match elements based on their element types. USS type selectors are analogous to CSS type selectors that match HTML tags.


The following is the syntax for a type selector:

```css
TypeName { ... }
```

When you write type selectors, specify only the concrete object type. Don’t include the namespace in the type name.

For example, this selector is valid:

```css
Button { ... }
```

This selector is invalid:

```css
UnityEngine.UIElements.Button { ... }
```

### Name selectors

USS name selectors match elements based on the name of an element. USS Name selectors are analogous to CSS ID selectors that match elements with a specific `id` attribute.

To set the name of an element:

-   In C# script, use `VisualElement.name`.
-   In UXML, use the `name` attribute. For example: `<VisualElement name="my-nameName">`.

To avoid unexpected matches, make element names unique within a panel.

A name selector consists of an element’s assigned name prefixed with a number sign (`#`).

```css
#ElementName { ... }
```

**Note**: Only use the number sign (`#`) when you write the selector in a USS file. Don’t use it when you assign the name to an element in a UXML or C# file. An element name that includes the number sign is invalid. For example `<Button name="#OK" />` is invalid.


### Class selectors
USS class selectors match elements that have specific USS classes assigned. USS class selectors are analogous to CSS class selectors.


A class selector consists of the class name prefixed with a period. Class names are case-sensitive and can’t begin with a numeral.

```css
.className { ... }
```

Only use a period when you write the selector in a USS file. Don’t include it when you assign the class to an element in a UXML or C# file. For example, don’t use `<Button class=".yellow" />`.

In general, don’t include a period in class names. Unity’s USS parser interprets a period as the beginning of a new class. For example, if you create a class called `yellow.button`, and create the following USS rule: `.yellow.button{...}`. The parser interprets the selector as a [multiple selector](https://docs.unity3d.com/Manual/UIE-USS-Selectors-class.htmlUIE-USS-Selectors-multiple.html), and tries to find elements that match both a `.yellow` class and a `.button` class.

When an element has more than one class assigned, a selector only has to match one of them to match the element.

You can also specify multiple classes in a selector, in which case an element must have all of those classes assigned in order to match.


### Universal selectors

A USS universal selector, also called the wildcard selector, matches any element. USS universal selectors are analogous to CSS universal selectors.


The following is the syntax for a USS universal selector:

```css
* { ... }
```

### Descendant selectors
USS descendant selectors match elements that are the **descendant of another element** in the visual tree.

A descendant selector consists of multiple simple selectors separated by a space:

```css
selector1 selector2 {...}
```

### Child selectors

USS child selectors match elements that are the child of another element in the visual tree.

You can include the wildcard selector in complex selectors. For example, the following USS rule uses the wildcard selector in a **child selector**. This USS rule matches buttons that are children of elements that are children of an element with the USS class **yellow** assigned to it.

```css
.yellow > * > Button{..}
```


### Multiple selectors
A multiple selector is an combination of multiple simple selectors. It selects any elements that **match all the simple selectors**.

A multiple selector consists of multiple simple selector without anything to separate them:

```css
selector1selector2 {...}
```

The USS parser can’t parse a multiple selector if it can’t distinguish each selector in the combination.

For example, the following USS rule combines two type selectors: `ListView`, and `Button`.

```css
ListViewButton{...}
```

The USS parser can’t separate the two element types, it interprets them as a single class called ListViewButton, which might not be the desired result.


You can combine USS class selectors and name selectors into multiple selectors. Because they’re are with the period (.) and number sign (#) respectively, the parser can clearly identify them. Type selectors have no identifying character, so you can only use one of them in a multiple selector, and it must be the first selector in the combination. For example:

```css
ListView.yellow#vertical-list{...}
```

### Selector lists
A selector list is a comma-separated list of selectors that share the same style rule.

A selector list consists of multiple selectors separated by commas:

```css
selector1, selector2 {...}
```


The following two USS snippets have the same effect.

```css
#container2 {
  background-color: pink;
  border-radius: 10px;
}

Button {
  background-color: pink;
  border-radius: 10px;
}
```

```css
#container2, Button {
   background-color: pink;
     border-radius: 10px;
```

### Pseudo-classes

A pseudo-class narrows a selector’s scope so it only matches elements when they enter a specific state.

Append a pseudo-class to a simple selector to match specific elements when they’re in a specific state. For example, the following USS rule uses the `:hover` pseudo-class to change the color of `Button` elements when a user hovers the pointer over them.

```css
Button:hover {
    background-color: palegreen;
}
```

| Pseudo-class | Matches an element when |
| --- | --- |
| `:hover` | The cursor is positioned over the element. |
| `:active` | A user interacts with the element. |
| `:inactive` | A user stops to interact with the element. |
| `:focus` | The element has focus. |
| `:selected` | USS doesn’t support this pseudo-state. Use `:checked` instead. |
| `:disabled` | The element is in a disabled state. |
| `:enabled` | The element is in an enabled state. |
| `:checked` | The element is a `Toggle` or `RadioButton` element and it’s selected. |
| `:root` | The element is the highest-level element in the **visual tree**. |

#### Chain pseudo-classes
You can chain pseudo-classes together to apply the same style for multiple concurrent states. For example, the following USS rule chains the `:checked` and `:hover` pseudo-classes together to change the color of checked `Toggle` elements when a user hovers the pointer over them.

```css
Toggle:checked:hover {
  background-color: yellow;
}
```


### The root pseudo-class
The `:root` pseudo-class matches the highest element in a visual tree. It’s slightly different from other supported pseudo-classes because you use it by itself to define default styles for the elements the style sheet affects.

For example, the following USS rule sets a default font. Any element that doesn’t get its font from a more specific style rule uses that font.

```
:root {
  -unity-font: url("../Resources/fonts/OpenSans-Regular.ttf");
}
```

A common use for the `:root` selector is to declare “global” variables (custom properties), that other style rules can use instead of specific values.


### Selector precedence

#### Precedence for selectors in the same style sheet

When an element matches multiple selectors from the same style sheet, the selector with the highest **specificity** takes precedence.

If both selectors have the same **specificity**, the selector that appears last in the USS file takes precedence.


#### Precedence for selectors in different style sheets
When an element matches multiple selectors in different style sheets, Unity determines precedence according to the following factors in this order:

1. **The type of style sheet**: Selectors from user-defined style sheets takes precedence over selectors from default Unity style sheets.
2. **Selector specificity**: If both selectors are in the same type of style sheet, the selector with the highest **specificity** takes precedence
3. **The style sheets’ positions in the element hierarchy**: If both selectors have the same specificity, the selector whose style sheet is applied lowest in the element hierarchy takes precedence.
4. **The selectors’ positions in their style sheets**: If you apply both style sheets at the same level of the hierarchy, the selector closest to the end of its USS file takes precedence.


### Selector specificity
Selector specificity is a measure of relevance. The higher the specificity, the more relevant the selector is to the elements it matches.

-   **Name** selectors are more specific than **Class** selectors.
-   **Class** selectors are more specific than **Type** selectors.
-   **Type** selectors are more specific than the **Universal** (`*`) selector.
-   **Universal** selectors have the lowest specificity.



### Style overrides
You can style an element in **UI Toolkit** by the following:

- In a **USS** file, write a selector that can affect the element.
- In the **UXML** document where the element is defined, set inline styles.
- In a C# script, get a reference to an element and set its inline style.
- For an inherited property, the element gets the value from its parent element.


If you apply multiple styling methods to an element, it will undergo style overrides.




### ref 
https://docs.unity3d.com/Manual/UIE-USS-Selectors.html
