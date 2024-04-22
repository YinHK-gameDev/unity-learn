## Scripting about Audio



### AudioSource
An **AudioSource** is **attached to a GameObject for playing back sounds** in a 3D environment. 

In order to play 3D sounds you also need to have a **AudioListener**. The audio listener is normally **attached to the camera** you want to use. 

You can **play a single audio clip using `AudioSource.Play()`**, **`AudioSource.Pause`** and **`AudioSource.Stop()`**. You can also adjust its volume while playing using the volume property, or seek using time. Multiple sounds can be played on one AudioSource using **`AudioSource.PlayOneShot()`**. You can play a clip at a **static position** in 3D space using **`AudioSource.PlayClipAtPoint`**.

Eg:
```cs
//This script allows you to toggle music to play and stop.
//Assign an AudioSource to a GameObject and attach an Audio Clip in the Audio Source. Attach this script to the GameObject.

using UnityEngine;

public class Example : MonoBehaviour
{
    AudioSource m_MyAudioSource;

    //Play the music
    bool m_Play;
    //Detect when you use the toggle, ensures music isn’t played multiple times
    bool m_ToggleChange;

    void Start()
    {
        //Fetch the AudioSource from the GameObject
        m_MyAudioSource = GetComponent<AudioSource>();
        //Ensure the toggle is set to true for the music to play at start-up
        m_Play = true;
    }

    void Update()
    {
        //Check to see if you just set the toggle to positive
        if (m_Play == true && m_ToggleChange == true)
        {
            //Play the audio you attach to the AudioSource component
            m_MyAudioSource.Play();
            //Ensure audio doesn’t play more than once
            m_ToggleChange = false;
        }
        //Check if you just set the toggle to false
        if (m_Play == false && m_ToggleChange == true)
        {
            //Stop the audio
            m_MyAudioSource.Stop();
            //Ensure audio doesn’t play more than once
            m_ToggleChange = false;
        }
    }

    void OnGUI()
    {
        //Switch this toggle to activate and deactivate the parent GameObject
        m_Play = GUI.Toggle(new Rect(10, 10, 100, 30), m_Play, "Play Music");

        //Detect if there is a change with the toggle
        if (GUI.changed)
        {
            //Change to true to show that there was just a change in the toggle state
            m_ToggleChange = true;
        }
    }
}
```

https://docs.unity3d.com/ScriptReference/AudioSource.html

#### `AudioSource.PlayOneShot`
Plays an AudioClip, and scales the AudioSource volume by **volumeScale**.

```cs
public void PlayOneShot(AudioClip clip, float volumeScale = 1.0F);
```

```cs
using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class ExampleClass : MonoBehaviour
{
    public AudioClip impact;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter()
    {
        audioSource.PlayOneShot(impact, 0.7F);
    }
}
```
#### `AudioSource.PlayClipAtPoint`
Plays an AudioClip at a **given position** in world space.

This function creates an audio source but automatically disposes of it once the clip has finished playing.

```cs
public static void PlayClipAtPoint(AudioClip clip, Vector3 position, float volume = 1.0F);
```

```cs
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Example : MonoBehaviour
{
    public AudioClip clip; //make sure you assign an actual clip here in the inspector

    void Start()
    {
        AudioSource.PlayClipAtPoint(clip, new Vector3(5, 1, 2));
    }
}
```
https://docs.unity3d.com/ScriptReference/AudioSource.PlayClipAtPoint.html


#### A game object has different audio source, play two different audio source depend on the situation
eg:

```cs
public currentBullets = 1;

private AudioSource gunAudio;
private AudioSource outOfAmmo;

void Awake()
{
    gunAudio = GetComponent<AudioSource>();
    outOfAmmo = GetComponent<AudioSource>();
}

void Update()
{
    if (currentBullets == 0)
    {
        outOfAmmo.Play();
    }
    else 
    {
        gunAudio.Play();
    }
}


```

### AudioClip

An AudioClip stores the audio file either compressed as ogg vorbis or uncompressed. AudioClips are referenced and used by AudioSources to play sounds.

https://docs.unity3d.com/ScriptReference/AudioClip.html


### AudioListener
Representation of a listener in 3D space.

This class implements a microphone-like device. It **records the sounds around it** and **plays that through the player's speakers**. You can only have **one listener in a Scene**.

> 📌 use **"AudioListener.Pause = true"** to pause all audios and use in **`update()`** only.

```cs
AudioListener.Pause = true;
AudioListener.Pause = False;
```
```cs

//Controls the game sound volume (0.0 to 1.0).
public static float volume;
AudioListener.volume = 1.0F;
```
https://docs.unity3d.com/ScriptReference/AudioListener.html





### 



