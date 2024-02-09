## Mobile device Input

On mobile devices, the Input class offers access to **touchscreen**, **accelerometer** and **geographical/location input**. \
Access to **keyboard on mobile devices** is provided via the **Mobile keyboard**.

### Multi-touch screen

The iPhone, iPad and iPod Touch devices are capable of tracking up to **five fingers touching** the screen simultaneously. You can retrieve the status of each finger touching the screen during the last frame by accessing the **`Input.touches`** property array.

Android devices don’t have a unified limit on how many fingers they track. Instead, it varies from device to device and can be anything from two-touch on older devices to five fingers on some newer devices.

#### `Input.Touch` data structure
Structure describing the status of a finger touching the screen.

The touch lifecycle describes the state of a touch in any given frame:

-   Began - A user has touched their finger to the screen this frame
-   Stationary - A finger is on the screen but the user has not moved it this frame
-   Moved - A user moved their finger this frame
-   Ended - A user lifted their finger from the screen this frame
-   Cancelled - The touch was interrupted this frame

 
| **Property:** | **Description:** |
| --- | --- |
| `fingerId` | The unique index for a touch. |
| `position` | The screen position of the touch. |
| `deltaPosition` | The screen position change since the last frame. |
| `deltaTime` | Amount of time that has passed since the last state change. |
| `tapCount` | The iPhone/iPad screen is able to distinguish quick finger taps by the user. This counter will let you know how many times the user has tapped the screen without moving a finger to the sides. Android devices do not count number of taps, this field is always 1. |
| `altitudeAngle` |	Value of 0 radians indicates that the stylus is parallel to the surface, pi/2 indicates that it is perpendicular. |
| `azimuthAngle` | Value of 0 radians indicates that the stylus is pointed along the x-axis of the device. |
| `maximumPossiblePressure` | The maximum possible pressure value for a platform. If Input.touchPressureSupported returns false, the value of this property will always be 1.0f. |
| `pressure` | The current amount of pressure being applied to a touch. 1.0f is considered to be the pressure of an average touch. If Input.touchPressureSupported returns false, the value of this property will always be 1.0f. |
| `radius` | An estimated value of the radius of a touch. Add radiusVariance to get the maximum touch size, subtract it to get the minimum touch size. |
| `radiusVariance` | 	This value determines the accuracy of the touch radius. Add this value to the radius to get the maximum touch size, subtract it to get the minimum touch size. |
| `rawPosition` | The first position of the touch contact in screen space pixel coordinates. |
| `tapCount` | 	Number of taps. |
| `type` | 	A value that indicates whether a touch was of Direct, Indirect (or remote), or Stylus type. |



| **phase:** | Describes the state of the touch, which can help you determine whether the user has just started to touch screen, just moved their finger or just lifted their finger. |
|-|-|
|  `Began` | A finger just touched the screen. |
|  `Moved` | A finger moved on the screen. |
|  `Stationary` | A finger is touching the screen but hasn’t moved since the last frame. |
|  `Ended` | A finger was lifted from the screen. This is the final phase of a touch. |
|  `Canceled` | The system cancelled tracking for the touch, as when (for example) the user puts the device to their face or more than five touches happened simultaneously. This is the final phase of a touch. |

> The Touch struct is used by Unity to store data relating to a single touch instance and is returned by the `Input.GetTouch` function. Fresh calls to GetTouch will be required on each frame update to obtain the latest touch information from the device but the `Touch.fingerId` property can be used to identify the same touch between frames.

### Mouse simulation

On top of native touch support Unity iOS/Android provides a mouse simulation. You can use mouse functionality from the standard Input class. Note that iOS/Android devices are designed to support multiple finger touch. Using the mouse functionality will support just a single finger touch. Also, finger touch on mobile devices can move from one area to another with no movement between them. Mouse simulation on mobile devices will provide movement, so is very different compared to touch input. 
> The recommendation is to use the mouse simulation during early development but to use touch input as soon as possible.


### Accelerometer

As the mobile device moves, a built-in accelerometer reports linear acceleration changes along the three primary axes in three-dimensional space. Acceleration along each axis is reported directly by the hardware as G-force values. A value of 1.0 represents a load of about +1g along a given axis while a value of –1.0 represents –1g. If you hold the device upright (with the home button at the bottom) in front of you, the X axis is positive along the right, the Y axis is positive directly up, and the Z axis is positive pointing toward you.

You can retrieve the accelerometer value by accessing the **`Input.acceleration`** property.

```cs
public static Vector3 acceleration;
```
```cs
using UnityEngine;

public class Accelerometer : MonoBehaviour
{
    float speed = 10.0f;

    void Update()
    {
        Vector3 dir = Vector3.zero;
        // we assume that the device is held parallel to the ground
        // and the Home button is in the right hand

        // remap the device acceleration axis to game coordinates:
        // 1) XY plane of the device is mapped onto XZ plane
        // 2) rotated 90 degrees around Y axis

        dir.x = -Input.acceleration.y;
        dir.z = Input.acceleration.x;

        // clamp acceleration vector to the unit sphere
        if (dir.sqrMagnitude > 1)
            dir.Normalize();

        // Make it move 10 meters per second instead of 10 meters per frame...
        dir *= Time.deltaTime;

        // Move object
        transform.Translate(dir * speed);
    }
}
```


https://www.youtube.com/watch?v=hZXLP9_VIso&t=534s

### Create Joystick input in mobile device

You can use Joystick pack asset  from Unity asset to create joustick in mobile game



https://assetstore.unity.com/packages/tools/input-management/joystick-pack-107631 \
https://www.youtube.com/watch?v=pRsCSPb6FXs

### ref
https://docs.unity3d.com/Manual/MobileInput.html

**Mobile keyboard** \
https://docs.unity3d.com/Manual/MobileKeyboard.html

**`Input.Touch` struct** \
https://docs.unity3d.com/ScriptReference/Touch.html

**`Input.acceleration`** \
https://docs.unity3d.com/ScriptReference/Input-acceleration.html
