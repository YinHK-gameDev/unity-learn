## UI - Health Bar


### **Health bar move smoothly**
> ✅ use **lerp** through update method

```cs
slider.value = Mathf.Lerp( currentValue, expectValue, Time.deltaTime * speed )
```

### UI toolkit health bar
https://www.youtube.com/watch?v=S0gmSDRXzgs

https://www.youtube.com/watch?v=pLzyj9dQ7n8

### ref 
https://docs.unity3d.com/2021.2/Documentation/ScriptReference/UIElements.Slider.html
