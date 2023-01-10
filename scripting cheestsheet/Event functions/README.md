## Event functions

A script in Unity is not like the traditional idea of a program where the code runs continuously in a loop until it completes its task. Instead, Unity passes control to a script **intermittently by calling certain functions that are declared within it**. Once a function has finished executing, control is passed back to Unity.

These functions are known as **event functions** since they are activated by Unity in response to events that occur during gameplay.


### Regular Update Events
A game is rather like an animation where the animation frames are generated on the fly. A key concept in games programming is that of making changes to position, state and behavior of objects in the game just before each frame is rendered.
- `void Update()`
- `void FixedUpdate()`
- `void LateUpdate()`
