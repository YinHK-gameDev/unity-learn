## Audio Filters

### Audio Low Pass Filter
passes low frequencies of an AudioSource or all sound reaching an AudioListener while removing frequencies higher than the Cutoff Frequency.
 
| Property: | Function: |
| --- | --- |
| Cutoff Frequency | Lowpass cutoff frequency in Hertz (range 0.0 to 22000.0, default = 5000.0). |
| Lowpass Resonance Q | Lowpass resonance quality value (range 1.0 to 10.0, default = 1.0). |

The **Lowpass Resonance Q** (short for Lowpass Resonance Quality Factor) determines how much the filter’s self-resonance is dampened. Higher lowpass resonance quality indicates a lower rate of energy loss, that is the oscillations die out more slowly.

