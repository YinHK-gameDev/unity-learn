## Audio Clip

Audio Clips contain the audio data used by Audio Sources. Unity supports mono, stereo and multichannel audio assets (up to eight channels). The audio file formats that Unity can import are `.aif`, `.wav`, `.mp3`, and `ogg`. Unity can also import tracker modules in the `.xm`, `.mod`, `.it`, and `.s3m` formats.


- **Force To Mono**: \
  When this option is enabled, multi-channel audio will be mixed down to a mono track before packing.

- **Normalize**: \
  When this option is enabled, audio will be normalized during the “Force To Mono” mixing down process.

- **Load In Background**: \
  When this option is enabled, the loading of the clip will happen at a delayed time on a separate thread, without blocking the main thread.

- **Ambisonic**: \
  Ambisonic audio sources store audio in a format which represents a soundfield that can be rotated based on the listener’s orientation. It is useful
  for 360-degree videos and XR applications. Enable this option if your audio file contains Ambisonic-encoded audio.
