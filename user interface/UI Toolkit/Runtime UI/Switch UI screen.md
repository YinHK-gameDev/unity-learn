## Switch UI screen

To switch UI screen, set the display *style* to **'None'** (to not have the UIDocument display) and to **'Flex'** (to show it once again) on the UIDocument's **root visual element**.

```cs
// Make it not visible on screen.
myUiDocumentReference.rootVisualElement.style.display = DisplayStyle.None;
   
// Make it visible on screen.
myUiDocumentReference.rootVisualElement.style.display = DisplayStyle.Flex;
```

### ref 
https://www.youtube.com/watch?v=a8g-MqTUXiU
