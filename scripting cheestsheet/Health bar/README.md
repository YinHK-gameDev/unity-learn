## UI - Health Bar


### **Health bar move smoothly**
> ✅ use **lerp** through update method
```cs
slider.value = Mathf.Lerp(currentValue, expectValue,Time.deltaTime * speed)
  ```
