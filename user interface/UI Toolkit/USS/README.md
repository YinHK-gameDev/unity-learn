## USS selectors

A **Unity Style Sheet (USS)** is a text file recognized as an asset that supports style rules. The USS text file must have the **`.uss`** extension.

Selectors decide which elements that USS rules affect.

USS supports a set of simple selectors that are analogous, but not identical, to simple selectors in CSS. A simple selector matches elements by element type, USS class, element name, and wildcard.

You can combine simple selectors into complex selectors, or append pseudo-classes to them to target elements in specific states. USS supports descendant, child, and multiple complex selectors.

### Syntax
```
selector {
  property1: value;
  property2: value;
}
```
#### Style matching with rules
When you define a style sheet, you can apply it to a **visual tree**
. Selectors match against elements to resolve which properties apply from the USS file. If a selector matches an element, the style declarations apply to the element.


| Topic | Description |
| --- | --- |
| Type selectors | Match elements based on their element types. |
| Name selectors | Match elements based on the name of an element. |
| Class selectors | Match elements that have specific USS classes assigned. |
| Universal selectors | Match any element. |
| Descendant selectors | Match elements that are descendants of another element in the visual tree. |
| Child selectors | Match elements that are children of another element in the visual tree. |
| Multiple selectors | Select elements that match all the simple selectors. |
| Selectors list | Create a comma-separated list of selectors that share the same style rule. |
| Pseudo-classes | Use pseudo-classes with selectors to target elements that are in a specific state. |
| Selector precedence | Understand USS precedence when multiple USS rules target the same elements. |

### ref 

https://docs.unity3d.com/Manual/UIE-USS-Selectors.html

