## Scripting about Audio



### AudioSource
An **AudioSource** is **attached to a GameObject for playing back sounds** in a 3D environment. 

In order to play 3D sounds you also need to have a **AudioListener**. The audio listener is normally **attached to the camera** you want to use. 

You can **play a single audio clip using `AudioSource.Play()`**, **`AudioSource.PlayDelayed(float delay)`**, **`AudioSource.Pause`**, **`AudioSource.UnPause`** and **`AudioSource.Stop()`**. You can also adjust its volume while playing using the volume property, or seek using time. 

> **Multiple sounds** can be played on **one AudioSource** using **`AudioSource.PlayOneShot()`**.


> You can play a clip at a **static position** in 3D space using **`AudioSource.PlayClipAtPoint`**.

> To play a different audioclip other than default audioclip inside Audio Source, use **`AudioSource.clip`**, **`AudioSource.PlayOneShot()`** or **`AudioSource.PlayClipAtPoint`** method.



```cs
// Plays the clip.
public void Play();

// Plays the clip with a delay specified in seconds. 
public void PlayDelayed(float delay);

// Pauses playing the clip.
public void Pause();

// Stops playing the clip.
public void Stop();

// Unpause the paused playback of this AudioSource.
// This function is similar to calling Play() on a paused AudioSource,
// except that it will not create a new playback voice if it is not currently paused.
public void UnPause();
```



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

https://m-ansley.medium.com/playing-sound-effects-in-unity-3c624b48e5bc


### `AudioSource.clip`

The **default** AudioClip to play.

> **Note**: You can use this property to **change the AudioClip played in the audio source**.

> **`AudioSource.clip`** determines the audio clip that will be **played next**. Assigning clip with a **new audio clip** does not instantly change the clip that is being played.

```cs
// Declare a audioClip to be changed in Audio Source
public AudioClip clip;
```

```cs
// Use this property in Audio Source to change the default clip inside Audio Source
AudioSource.clip;
```

Eg:
```cs
using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class ExampleClass : MonoBehaviour
{
    public AudioClip otherClip;

    IEnumerator Start()
    {
        AudioSource audio = GetComponent<AudioSource>();

        audio.Play();
        yield return new WaitForSeconds(audio.clip.length);
        audio.clip = otherClip;
        audio.Play();
    }
}

```

#### `AudioSource.PlayOneShot`
> **Plays an AudioClip**, and **scales the AudioSource volume** by **volumeScale**.

**`AudioSource.PlayOneShot`** does not cancel clips that are already being played by **`AudioSource.PlayOneShot`** and **`AudioSource.Play`**.

**`PlayOneShot()`** is an instance method that you can call on an existing **AudioSource component** to **play a given audioclip**. The clip is played at the position of whatever object the AudioSource component is attached to.


> Only **temporarily change the clip in order for it to play**, is to use the **`PlayOneShot`** method. We’re able to **play multiple sounds at the same time through the same AudioSource** using this method, meaning that second PlayOneShot call **doesn’t actually stop/interrupt the first in order to start playing**.

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
> Plays an AudioClip at a **given position** in world space.

> **Note**: This function creates an audio source but automatically **disposes** of it once the clip has finished playing.

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
private AudioSource[] source;

void Awake()
{
    source = GetComponents<AudioSource>();
    gunAudio = source[0];
    outOfAmmo = source[1];
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

| Properties | Description |
| --- | --- |
| ambisonic | Returns true if this audio clip is ambisonic (read-only). |
| channels | The number of channels in the audio clip. (Read Only) |
| frequency | The sample frequency of the clip in Hertz. (Read Only) |
| length | The length of the audio clip in seconds. (Read Only) |
| loadInBackground | Corresponding to the "Load In Background" flag in the inspector, when this flag is set, the loading will happen delayed without blocking the main thread. |
| loadState | Returns the current load state of the audio data associated with an AudioClip. |
| loadType | The load type of the clip (read-only). |
| preloadAudioData | Preloads audio data of the clip when the clip asset is loaded. When this flag is off, scripts have to call AudioClip.LoadAudioData() to load the data before the clip can be played. Properties like length, channels and format are available before the audio data has been loaded. |
| samples | The length of the audio clip in samples. (Read Only) |




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

> **Note**: If there are multiple scenes, it may contain more than one Audio listener. But Unity only allows **one active Audio Listener** at a time. If more than one is enabled, Unity will log a warning:  \
> `"There are 2 audio listeners in the scene. Please ensure there is always exactly one audio listener in the scene."`
> Solution: disable the Audio Listener component in cameras from inactive or secondary scenes.

Eg: 

```cs
AudioListener[] listeners = FindObjectsOfType<AudioListener>();
for (int i = 1; i < listeners.Length; i++) // Keep only one active
{
    listeners[i].enabled = false;
}

```

https://docs.unity3d.com/ScriptReference/AudioListener.html




