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

| **phase:** | Describes the state of the touch, which can help you determine whether the user has just started to touch screen, just moved their finger or just lifted their finger. |
|-|-|
|  `Began` | A finger just touched the screen. |
|  `Moved` | A finger moved on the screen. |
|  `Stationary` | A finger is touching the screen but hasn’t moved since the last frame. |
|  `Ended` | A finger was lifted from the screen. This is the final phase of a touch. |
|  `Canceled` | The system cancelled tracking for the touch, as when (for example) the user puts the device to their face or more than five touches happened simultaneously. This is the final phase of a touch. |

> The Touch struct is used by Unity to store data relating to a single touch instance and is returned by the `Input.GetTouch` function. Fresh calls to GetTouch will be required on each frame update to obtain the latest touch information from the device but the `Touch.fingerId` property can be used to identify the same touch between frames.

### ref
https://docs.unity3d.com/Manual/MobileInput.html

**Mobile keyboard** \
https://docs.unity3d.com/Manual/MobileKeyboard.html

`Input.Touch` struct
https://docs.unity3d.com/ScriptReference/Touch.html
