## Audio Filters

### Audio Low Pass Filter
Passes low frequencies of an AudioSource or all sound reaching an AudioListener while removing frequencies higher than the Cutoff Frequency.
 
| Property: | Function: |
| --- | --- |
| Cutoff Frequency | Lowpass cutoff frequency in Hertz (range 0.0 to 22000.0, default = 5000.0). |
| Lowpass Resonance Q | Lowpass resonance quality value (range 1.0 to 10.0, default = 1.0). |

The **Lowpass Resonance Q** (short for Lowpass Resonance Quality Factor) determines how much the filter’s self-resonance is dampened. Higher lowpass resonance quality indicates a lower rate of energy loss, that is the oscillations die out more slowly.

### Audio High Pass Filter
Passes high frequencies of an AudioSource and cuts off signals with frequencies lower than the Cutoff Frequency.

| Property: | Function: |
| --- | --- |
| Cutoff Frequency | Highpass cutoff frequency in Hertz (range 10.0 to 22000.0, default = 5000.0). |
| Highpass Resonance Q | Highpass resonance quality value (range 1.0 to 10.0, default = 1.0). |

The Highpass resonance Q (short for Highpass Resonance Quality Factor) determines how much the filter’s self-resonance is dampened. Higher highpass resonance quality indicates a lower rate of energy loss, that is the oscillations die out more slowly.

### Audio Echo Filter
Repeats a sound after a given Delay, attenuating the repetitions based on the Decay Ratio.

| Property: | Function: |
| --- | --- |
| Delay | Echo delay in ms. 10 to 5000. Default = 500. |
| Decay Ratio | Echo decay per delay. 0 to 1. 1.0 = No decay, 0.0 = total decay (ie simple 1 line delay). Default = 0.5.L |
| Wet Mix | Volume of echo signal to pass to output. 0.0 to 1.0. Default = 1.0. |
| Dry Mix | Volume of original signal to pass to output. 0.0 to 1.0. Default = 1.0. |

### Audio Distortion Filter
Distorts the sound from an AudioSource or sounds reaching the AudioListener.

| Property: | Function: |
| --- | --- |
| Distortion | Distortion value. 0.0 to 1.0. Default = 0.5. |

### Audio Reverb Filter
Takes an Audio Clip and distorts it to create a custom reverb effect.

| Property: | Function: |
| --- | --- |
| Reverb Preset | Custom reverb presets, select user to create your own customized reverbs. |
| Dry Level | Mix level of dry signal in output in mB. Ranges from –10000.0 to 0.0. Default is 0. |
| Room | Room effect level at low frequencies in mB. Ranges from –10000.0 to 0.0. Default is 0.0. |
| Room HF | Room effect high-frequency level in mB. Ranges from –10000.0 to 0.0. Default is 0.0. |
| Room LF | Room effect low-frequency level in mB. Ranges from –10000.0 to 0.0. Default is 0.0. |
| Decay Time | Reverberation decay time at low-frequencies in seconds. Ranges from 0.1 to 20.0. Default is 1.0. |
| Decay HFRatio | Decay HF Ratio : High-frequency to low-frequency decay time ratio. Ranges from 0.1 to 2.0. Default is 0.5. |
| Reflections Level | Early reflections level relative to room effect in mB. Ranges from –10000.0 to 1000.0. Default is –10000.0. |
| Reflections Delay | Early reflections delay time relative to room effect in mB. Ranges from 0 to 0.3. Default is 0.0. |
| Reverb Level | Late reverberation level relative to room effect in mB. Ranges from –10000.0 to 2000.0. Default is 0.0. |
| Reverb Delay | Late reverberation delay time relative to first reflection in seconds. Ranges from 0.0 to 0.1. Default is 0.04. |
| HFReference | Reference high frequency in Hz. Ranges from 1000.0 to 20000.0. Default is 5000.0. |
| LFReference | Reference low-frequency in Hz. Ranges from 20.0 to 1000.0. Default is 250.0. |
| Diffusion | Reverberation diffusion (echo density) in percent. Ranges from 0.0 to 100.0. Default is 100.0. |
| Density | Reverberation density (modal density) in percent. Ranges from 0.0 to 100.0. Default is 100.0. |


### Audio Chorus Filter
Takes an Audio Clip and processes it creating a chorus effect.

| Property: | Function: |
| --- | --- |
| Dry Mix | Volume of original signal to pass to output. 0.0 to 1.0. Default = 0.5. |
| Wet Mix 1 | Volume of 1st chorus tap. 0.0 to 1.0. Default = 0.5. |
| Wet Mix 2 | Volume of 2nd chorus tap. This tap is 90 degrees out of phase of the first tap. 0.0 to 1.0. Default = 0.5. |
| Wet Mix 3 | Volume of 3rd chorus tap. This tap is 90 degrees out of phase of the second tap. 0.0 to 1.0. Default = 0.5. |
| Delay | The LFO’s delay in ms. 0.1 to 100.0. Default = 40.0 ms |
| Rate | The LFO’s modulation rate in Hz. 0.0 to 20.0. Default = 0.8 Hz. |
| Depth | Chorus modulation depth. 0.0 to 1.0. Default = 0.03. |
| Feed Back | Chorus feedback. Controls how much of the wet signal gets fed back into the filter’s buffer. 0.0 to 1.0. Default = 0.0. |


