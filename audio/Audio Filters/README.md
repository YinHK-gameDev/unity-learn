## Audio Filters

### Audio Low Pass FilterPpasses low frequencies of an AudioSource or all sound reaching an AudioListener while removing frequencies higher than the Cutoff Frequency.
 
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



