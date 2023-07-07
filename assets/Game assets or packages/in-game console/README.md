## In Game Console for debug


### Quantum Console

Quantum Console is a powerful and easy to use in-game command console. By simply adding [Command] to your code you can add your own commands and dev cheats to the console!

- Static and non-static commands

- Command overloads and default parameters

- Generic commands

- Async commands

- Interactive commands with coroutine-like actions

- Generate commands at runtime with lambda commands

- Supports functions, properties, fields and delegates

- Per command platform black/whitelist

- Easy to use

- Full C# source included

In order to get started as quickly as possible, simply follow the following steps:

1.  Ensure the Text Mesh Pro package is installed; this is done by default for new projects
2.  Add an Event System to your scene if you do not already have one `GameObject > UI > EventSystem`
3.  Navigate to `Assets/Plugins/QFSW/Quantum Console/Source/Prefabs` and add the `Quantum Console` prefab to your scene.

After this, you are ready to try out Quantum Console!


#### Quantum Registry
The Quantum Console Processor supports a feature called the registry.

By using the registry in conjunction with **`MonoTargetType.Registry`**, you can fully control which objects are used for target

Objects can be added to the registry with:

-   `QuantumRegistry.RegisterObject<T>(T target)` programmatically
-   `register-object<T>` command

Multiple objects can be registered per type, and will not be removed from the registry unless they are destroyed or manually removed.

Objects can be removed from the registry with:

-   `QuantumRegistry.DeregisterObject<T>(T target)` 
-   `deregister-object<T>`


https://assetstore.unity.com/packages/tools/utilities/quantum-console-211046#description

https://www.youtube.com/watch?v=bOf6CjpuSFs

https://qfsw.co.uk/docs/QC/

https://www.youtube.com/watch?v=3fltFRFa6Mg

https://www.youtube.com/watch?v=3fltFRFa6Mg&t=1s

**Command** \
https://qfsw.co.uk/docs/QC/articles/docs/commands.html

**Command Actio**ns \
https://qfsw.co.uk/docs/QC/articles/docs/actions.html

**Quantum Registry** \
https://qfsw.co.uk/docs/QC/articles/docs/registry.html

**Included commands** \
https://qfsw.co.uk/docs/QC/articles/docs/incl-cmds.html

**Events and Callbacks about QC** \
https://qfsw.co.uk/docs/QC/articles/docs/events.html


### AzeS - In Game Console
https://assetstore.unity.com/packages/tools/gui/azes-in-game-console-191452

### In-game debug console
https://assetstore.unity.com/packages/tools/gui/in-game-debug-console-68068#content


### Realtime In Game Log Console
https://assetstore.unity.com/packages/tools/gui/realtime-in-game-log-console-212758
