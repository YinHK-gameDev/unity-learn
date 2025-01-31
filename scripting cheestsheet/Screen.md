### Screen class
Provides access to display information.

Use the Screen class to get a list of supported screen resolutions, switch the current resolution, or hide or show the system mouse pointer.

| Static property                         | Description                                                                 |
|-----------------------------------------|-----------------------------------------------------------------------------|
| **autorotateToLandscapeLeft**           | Enables auto-rotation to landscape left.                                    |
| **autorotateToLandscapeRight**          | Enables auto-rotation to landscape right.                                   |
| **autorotateToPortrait**                | Enables auto-rotation to portrait.                                          |
| **autorotateToPortraitUpsideDown**      | Enables auto-rotation to portrait, upside down.                             |
| **brightness**                          | Indicates the current brightness of the screen.                             |
| **currentResolution**                   | The current screen resolution (Read Only).                                  |
| **cutouts**                             | Returns a list of screen areas that are not functional for displaying content (Read Only). |
| **dpi**                                 | The current DPI of the screen/device (Read Only).                           |
| **fullScreen**                          | Enables full-screen mode for the application.                               |
| **fullScreenMode**                      | Set this property to one of the values in FullScreenMode to change the display mode of your application. |
| **height**                              | The current height of the screen window in pixels (Read Only).              |
| **mainWindowDisplayInfo**               | The display information associated with the display that the main application window is on. |
| **mainWindowPosition**                  | The position of the top left corner of the main window relative to the top left corner of the display. |
| **msaaSamples**                         | Get the requested MSAA sample count of the screen buffer.                   |
| **orientation**                         | Specifies the logical orientation of the screen.                            |
| **resolutions**                         | Returns all full-screen resolutions that the monitor supports (Read Only).  |
| **safeArea**                            | Returns the safe area of the screen in pixels (Read Only).                  |
| **sleepTimeout**                        | A power-saving setting, allowing the screen to dim some time after the last active user interaction. |
| **width**                               | The current width of the screen window in pixels (Read Only).               |


| Static method                    | Description                           
|----------------------------------|--------------------------------------------
| **GetDisplayLayout**             | Retrieves layout information about connected displays such as names, resolutions, and refresh rates. |
| **MoveMainWindowTo**             | Moves the main window to the specified position relative to the top left corner of the specified display. Position value is represented in pixels. Moving the window is an asynchronous operation, which can take multiple frames. |
| **SetMSAASamples**               | Sets the given number of MSAA samples for the screen buffer.                |
| **SetResolution**                | Switches the screen resolution.                                             |


### ref
https://docs.unity3d.com/6000.0/Documentation/ScriptReference/Screen.html
