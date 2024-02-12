## Controls

An Input Control represents a source of values. These values can be of any structured or primitive type. The only requirement is that the type is blittable.

> **Note**: Controls are for input only. Output and configuration items on Input Devices are not represented as Controls.

### Control types

| Control Type | Description | Example |
| --- | --- | --- |
| AxisControl | A 1D floating-point axis. | `Gamepad.leftStick.x` |
| ButtonControl | A button expressed as a floating-point value. Whether the button can have a value other than 0 or 1 depends on the underlying representation. For example, gamepad trigger buttons can have values other than 0 and 1, but gamepad face buttons generally can't. | `Mouse.leftButton` |
| KeyControl | A specialized button that represents a key on a Keyboard. Keys have an associated keyCode and, unlike other types of Controls, change their display name in accordance to the currently active system-wide keyboard layout. See the Keyboard documentation for details. | `Keyboard.aKey` |
| Vector2Control | A 2D floating-point vector. | `Pointer.position` |
| Vector3Control | A 3D floating-point vector. | `Accelerometer.acceleration` |
| QuaternionControl | A 3D rotation. | `AttitudeSensor.attitude` |
| IntegerControl | An integer value. | `Touchscreen.primaryTouch.touchId` |
| StickControl | A 2D stick control like the thumbsticks on gamepads or the stick control of a joystick. | `Gamepad.rightStick` |
| DpadControl | A 4-way button control like the D-pad on gamepads or hatswitches on joysticks. | `Gamepad.dpad` |
| TouchControl | A control that represents all the properties of a touch on a touch screen. | `Touchscreen.primaryTouch` |



### ref
https://docs.unity3d.com/Packages/com.unity.inputsystem@1.7/manual/Controls.html

