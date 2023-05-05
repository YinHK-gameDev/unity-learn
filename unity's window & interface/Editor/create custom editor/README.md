## Editor Scripting




### `MenuItem` attribute
The `MenuItem` attribute allows you to add menu items to the main menu and Inspector window context menus.

The `MenuItem` attribute turns any static function into a menu command. Only static functions can use the `MenuItem` attribute.  
  
To create a hotkey, use the following special characters: **%** (ctrl on Windows and Linux, cmd on macOS), **^** (ctrl on Windows, Linux, and macOS), **#** (shift), **&** (alt). If no special modifier key combinations are required, the key can be given after an underscore. For example, to create a menu with the hotkey Shift+Alt+G, use `"MyMenu/Do Something #&g"`. To create a menu with hotkey **G** and no key modifiers pressed, use `"MyMenu/Do Something _g"`.

https://docs.unity3d.com/ScriptReference/MenuItem.html


### ref 
https://learn.unity.com/tutorial/editor-scripting#


