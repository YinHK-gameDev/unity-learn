## Audio Effects

You can modify the output of Audio Source and Audio Listener components by applying Audio Effects.
The effects are applied by adding effect components to the relevant section of the Audio Mixer.

> The ordering of the components is important, since it reflects the order in which the effects will be applied to the source audio.

- **Audio Low Pass Effect**:  passes low frequencies of an AudioMixer group while removing frequencies higher than the Cutoff Frequency.
- **Audio High Pass Effect**:  passes high frequencies of an AudioMixer group and cuts off signals with frequencies lower than the Cutoff Frequency.
- **Audio Echo Effect**:  repeats a sound after a given Delay, attenuating the repetitions based on the Decay Ratio.
- **Audio Flange Effect**: used to create the audio effect
 produced by mixing two identical signals together, one signal delayed by a small and gradually changing period, usually smaller than 20 milliseconds.
 
 
