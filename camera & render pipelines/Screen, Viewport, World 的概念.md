### Screen, Viewport, World 的概念
- Screen = 螢幕由左上角開始算 x=0,y=0, 到右下角 1920x1080 (你的桌面解像度/像素)
- Viewport = (0,0) 到 (1,1) 那是百分比, 例 0.1f = 10%, 0.5f = 50%, 1f = 100%, 最後的位置是由玩家電腦配置決定.
- World = 就是 Vector3 的坐標, 即 x,y,z axis


WorldToViewportPoint 如字面意思一樣是由 "世界坐標轉換為螢幕坐標"
 
http://docs.unity3d.com/ScriptReference/Camera.WorldToViewportPoint.html

```cs
Vector3 viewPos = camera.WorldToViewportPoint(target.position);  

if (viewPos.x > 0.5F) 
  print("target is on the right side!");  
 else  print("target is on the left side!");  
```

