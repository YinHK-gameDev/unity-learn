## Pause & resume game

### Pause game 

```cs
Time.timeScale = 0;
```


### Resume game

```cs
Time.timeScale = 1.0;
```




```cs
SerializeField] GameObject pauseMenu = null;

bool isPaused;

void Update()
{
    if (Input.GetKeyDown(KeyCode.Escape))
    {
        isPaused = !isPaused;
        Time.timeScale = isPaused ? 0 : 1;
		pauseMenu.SetActive(isPaused);
    }
}
```


### ref 
https://www.reddit.com/r/unity_tutorials/comments/n4ioec/how_to_pause_and_resume_a_game_in_unity/

https://blog.gamedev.tv/how-to-basic-pause-system-in-unity/

https://docs.unity3d.com/ScriptReference/Time-timeScale.html

