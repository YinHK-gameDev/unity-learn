## Audio 
Unity’s audio system can import most standard audio file formats, play sounds in 3D space, and apply optional effects such as echo and filtering. Unity can also **record audio from any available microphone on your machine** for **use during gameplay** or **for storage and transmission**.

### Audio files
Unity can import audio files in `AIFF`, `WAV`, `MP3` and `Ogg` formats in the same way as other assets, simply by **dragging the files into the Project panel**. Importing an audio file creates an **Audio Clip** which can then be dragged to an Audio Source or used from a script. 

### Tracker modules
For music, Unity also supports tracker modules, which use short audio samples as “instruments” that are then arranged to play tunes. Tracker modules can be imported from `.xm`, `.mod`, `.it`, and `.s3m` files but are otherwise used in much the same way as ordinary audio clips.

### Audio recording
Unity can access the computer’s microphones from a script and create Audio Clips by direct recording.
The **Microphone** class provides an API to **find available microphones**, **query their capabilities**, and **start and end a recording session**.
https://docs.unity3d.com/ScriptReference/Microphone.html


### Audio making tools
https://www.instabug.com/blog/game-audio-tools


### ref
https://docs.unity3d.com/Manual/Audio.html
