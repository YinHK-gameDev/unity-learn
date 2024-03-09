### Screen, Viewport, World concerpt
- Screen = 螢幕由左上角開始算 x=0,y=0, 到右下角 1920x1080 (你的桌面解像度/像素)
- Viewport = (0,0) 到 (1,1) 那是百分比, 例 0.1f = 10%, 0.5f = 50%, 1f = 100%, 最後的位置是由玩家電腦配置決定. **Viewport coordinates are normalized** and **relative to the camera**. The bottom-left of the camera is **(0,0)**; the top-right is **(1,1**).
- World = 就是 Vector3 的坐標, 即 x,y,z axis


WorldToViewportPoint 如字面意思一樣是由 "世界坐標轉換為螢幕坐標"
 
http://docs.unity3d.com/ScriptReference/Camera.WorldToViewportPoint.html

```cs
public Vector3 WorldToViewportPoint(Vector3 position);
```
```cs
public Vector3 WorldToViewportPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye);
```

```cs
Vector3 viewPos = camera.WorldToViewportPoint(target.position);  

if (viewPos.x > 0.5F) 
  print("target is on the right side!");  
 else  print("target is on the left side!");  
```

那是幹啥?
假設你現在要判斷一個在三維世界的坐標是在玩家螢幕上的左邊/右邊
因為 viewport 恆定是百分比, 0~0.5f 一定是在左邊, 反之 0.5f~1f 一定是在右邊.
如此類推, 判斷物件在 camera viewport 上的位置就需要用到 WorldToViewport
(當然你是數學達人可以選擇自行計算, 只是一個方便用的工具罷了)

至於 ViewportToWorldPoint 就是 WorldToViewportPoint 的相反意思,

http://docs.unity3d.com/ScriptReference/Camera.ViewportToScreenPoint.html


然後放進去 ViewportToWorldPoint , 你就擁有一個三維坐標點.

從這個 Vector3 的點再加上 Camera.tranform.forward 的方向 Vector3 即可以換算成玩家現在觸碰的點跟方向.
WorldToViewportPoint 跟 ViewportToWorldPoint 就是這個簡單

再之後可以考慮使用 `Raycast` 進行三維坐標的射線.....etc 但這是另一道題了.
其實這個有個方便的給初階使用.



**Transforms a point from screen space into world space**:

```cs
public Vector3 ScreenToWorldPoint(Vector3 position);
```
```cs
public Vector3 ScreenToWorldPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye);
```

http://docs.unity3d.com/ScriptReference/Camera.ScreenToWorldPoint.html

**Transforms position from world space into screen space**:

```cs
public Vector3 WorldToScreenPoint(Vector3 position);
```
```cs
public Vector3 WorldToScreenPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye);
```

https://docs.unity3d.com/ScriptReference/Camera.WorldToScreenPoint.html

**`Camera.ViewportToScreenPoint` transform viewport point to screen point**:
Transforms position from **viewport space into screen space**.

```cs
public Vector3 ViewportToScreenPoint(Vector3 position);
```
```cs
using UnityEngine;

public class Example : MonoBehaviour
{
    // Draw an image based on normalized view coordinates
    // rather than pixel positions.
    Texture2D bottomPanel;

    void VPToScreenPtExample()
    {
        var origin = Camera.main.ViewportToScreenPoint(new Vector3(0.25f, 0.1f, 0));
        var extent = Camera.main.ViewportToScreenPoint(new Vector3(0.5f, 0.2f, 0));

        GUI.DrawTexture(new Rect(origin.x, origin.y, extent.x, extent.y), bottomPanel);
    }
}
```

https://docs.unity3d.com/ScriptReference/Camera.ViewportToScreenPoint.html


**`Camera.ScreenToViewportPoint` transforms position from screen space into viewport space**:

```cs
public Vector3 ScreenToViewportPoint(Vector3 position);
```

https://docs.unity3d.com/ScriptReference/Camera.ScreenToViewportPoint.html

### ref
https://forum.gamer.com.tw/Co.php?bsn=60602&sn=947

