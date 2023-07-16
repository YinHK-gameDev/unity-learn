## Save & Load System in Unity 

Saving data is critical for any game. Whether you need to save high scores, preferences, or a game state, Unity offers a variety of methods – from PlayerPrefs to serializing data, encrypting it, and writing to a file.


### PlayerPrefs

**PlayerPrefs** are not made to save game states. However, they’re useful, so we’ll discuss them. You can use PlayerPrefs to store a player’s preferences between sessions, such as quality settings, audio volume or other non-essential data. PlayerPrefs are stored somewhere on your device, separate from your project. The exact location varies depending on your operating system, but it’s usually somewhere that’s globally accessible and managed by your OS. The stored data is in simple key-value pairs. Because of their ease of access, they aren’t safe from users who wish to open and modify them, and they can be deleted by accident since they’re saved outside of the project and managed by your OS.


### ref 
https://www.youtube.com/watch?v=XOjd_qU2Ido

https://www.youtube.com/watch?v=gZ3wtNGB3nU

https://www.youtube.com/watch?v=aUi9aijvpgs

Persistent data: How to save your game states and settings \
https://blog.unity.com/games/persistent-data-how-to-save-your-game-states-and-settings \
https://www.youtube.com/watch?v=uD7y4T4PVk0
