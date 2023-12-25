## Audio Effects

You can modify the **output of Audio Source and Audio Listene**r components by **applying Audio Effects**.
The effects are applied by **adding effect components** to the **relevant section of the Audio Mixer**.

> The ordering of the components is important, since it reflects the order in which the effects will be applied to the source audio.

- **Audio Low Pass Effect**:  passes low frequencies of an AudioMixer group while removing frequencies higher than the Cutoff Frequency.
- **Audio High Pass Effect**:  passes high frequencies of an AudioMixer group and cuts off signals with frequencies lower than the Cutoff Frequency.
- **Audio Echo Effect**:  repeats a sound after a given Delay, attenuating the repetitions based on the Decay Ratio.
- **Audio Flange Effect**: used to create the audio effect
 produced by mixing two identical signals together, one signal delayed by a small and gradually changing period, usually smaller than 20 milliseconds.
- **Audio Distortion Effect**: distorts the sound from an AudioMixer group.
- **Audio Normalize Effect**: applies a constant amount of gain to an audio stream to bring the average or peak amplitude to a target level.
- **Audio Parametric Equalizer Effect**: used to alter the frequency response of an audio system using linear filters.
- **Audio Pitch Shifter Effect**: used to shift a signal up or down in pitch.
- **Audio Chorus Effect**: takes an Audio Mixer group output and processes it creating a chorus effect.
- **Audio Compressor Effect**: reduces the volume of loud sounds or amplifies quiet sounds by narrowing or “compressing” an audio signal’s dynamic range.
- **Audio SFX Reverb Effect**: takes the output of an Audio Mixer group and distorts it to create a custom reverb effect.
- **Audio Low Pass Simple Effect**: passes low frequencies of an AudioMixer group while removing frequencies higher than the Cutoff Frequency.
- **Audio High Pass Simple Effect**: passes high frequencies of an AudioMixer group and cuts off signals with frequencies lower than the Cutoff Frequency.

https://docs.unity3d.com/Manual/class-AudioEffectMixer.html

 
