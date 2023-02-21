## Using Physical Cameras

The camera component’s Physical Camera properties simulate real-world camera formats on a Unity camera. 
> **Note**: Physical camera option only under perspective mode


Unity provides the same settings as those in most 3D modeling application’s physical camera settings. The two main properties that control what the camera sees are Focal Length and Sensor Size.

- Focal Length: The distance between the sensor and the camera lens. This determines the vertical field of view. When a Unity camera is in Physical Camera mode, changing the Focal Length also changes the field of view accordingly. Smaller focal lengths result in a larger field of view, and vice versa.

- Sensor Size: The width and height of the sensor that captures the image. These determine the physical camera’s aspect ratio
. You can choose from several preset sensor sizes that correspond to real-world camera formats, or set a custom size. When the sensor aspect ratio is different to the rendered aspect ratio, as set in the Game view, you can control how Unity fits the camera image to the rendered image.


![](./PhysCamAttributes.png)


