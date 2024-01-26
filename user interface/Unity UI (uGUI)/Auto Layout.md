## Auto Layout
The Rect Transform layout system is flexible enough to handle a lot of different types of layouts and it also allows placing elements in a complete freeform fashion. However, sometimes something a bit more structured can be needed.

The auto layout system provides ways to place elements in nested layout groups such as horizontal groups, vertical groups, or grids. It also allows elements to automatically be sized according to the contained content. For example a button can be dynamically resized to exactly fit its text content plus some padding.

The auto layout system is a system built on top of the basic Rect Transform layout system. It can optionally be used on some or all elements.

The auto layout system provides ways to place elements in **nested layout groups** such as horizontal groups, vertical groups, or grids. It also allows elements to automatically be sized according to the contained content.

- Content Size Fitter
- Layout Element
- Horizontal Layout Group
- Vertical Layout Group
- Grid Layout Group

#### Layout Element Component
If you want to override the minimum, preferred, or flexible size, you can do that by adding a Layout Element component to the Game Object.

#### Content Size Fitter

The Content Size Fitter functions as a layout controller that controls the size of its own layout element. The simplest way to see the auto layout system in action is to add a Content Size Fitter component to a Game Object with a Text component.

#### Aspect Ratio Fitter

The Aspect Ratio Fitter functions as a layout controller that controls the size of its own layout element.

It can adjust the height to fit the width or vice versa, or it can make the element fit inside its parent or envelope its parent. The Aspect Ratio Fitter does not take layout information into account such as minimum size and preferred size.



### ref 
https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/UIAutoLayout.html

https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/comp-UIAutoLayout.html
