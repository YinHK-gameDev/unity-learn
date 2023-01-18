## Audio 
Unity’s audio system can import most standard audio file formats, play sounds in 3D space, and apply optional effects such as echo and filtering. Unity can also **record audio from any available microphone on your machine** for **use during gameplay** or **for storage and transmission**.

Unity requires sounds to originate from **Audio Sources attached to objects**. The sounds emitted are then picked up by an **Audio Listener attached to another object**, most often the **main camera**.

Unity can then simulate the effects of a source’s distance and position from the listener object and play them to you accordingly.

You can also use the relative speed of the source and listener objects to simulate the Doppler Effect for added realism.


### Audio files
Unity can import audio files in `AIFF`, `WAV`, `MP3` and `Ogg` formats in the same way as other assets, simply by **dragging the files into the Project panel**. Importing an audio file creates an **Audio Clip** which can then be dragged to an Audio Source or used from a script. 

### Tracker modules
Tracker Modules are essentially just packages of audio samples that have been modeled, arranged and sequenced programatically.
For music, Unity also supports tracker modules, which use short audio samples as “instruments” that are then arranged to play tunes. Tracker modules can be imported from `.xm`, `.mod`, `.it`, and `.s3m` files but are otherwise used in much the same way as ordinary audio clips.

### Audio recording
Unity can access the computer’s microphones from a script and create Audio Clips by direct recording.
The **Microphone** class provides an API to **find available microphones**, **query their capabilities**, and **start and end a recording session**.

https://docs.unity3d.com/ScriptReference/Microphone.html

### Echoes
To calculate echoes, simulate them by adding **Audio Filters** to objects.

### Audio making tools
https://www.instabug.com/blog/game-audio-tools


### ref
https://docs.unity3d.com/Manual/Audio.html
