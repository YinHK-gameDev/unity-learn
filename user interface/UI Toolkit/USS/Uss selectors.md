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






### ref 
https://docs.unity3d.com/Manual/UIE-USS-Selectors.html
