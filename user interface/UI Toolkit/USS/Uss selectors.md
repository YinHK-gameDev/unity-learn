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





### ref 
https://docs.unity3d.com/Manual/UIE-USS-Selectors.html
