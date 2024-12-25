## Particle system 


### `ParticalSystem.Play`
> Use to play the particle system

```cs
public void Play();
public void Play(bool withChildren = true);
```

https://docs.unity3d.com/ScriptReference/ParticleSystem.Play.html

### `ParticleSystem.Stop`
> Stops playing the Particle System using the supplied stop behaviour.

```cs
public void Stop();
public void Stop(bool withChildren = true);
public void Stop(bool withChildren = true, ParticleSystemStopBehavior stopBehavior = ParticleSystemStopBehavior.StopEmitting);
```

https://docs.unity3d.com/6000.0/Documentation/ScriptReference/ParticleSystem.Stop.html

### `ParticleSystem.Pause`
> Pauses the system so no new particles are emitted and the existing particles are not updated.

```cs
public void Pause();
public void Pause(bool withChildren = true);
```

https://docs.unity3d.com/6000.0/Documentation/ScriptReference/ParticleSystem.Pause.html

### `OnParticleCollision(GameObject)`
> 📌 This can be used to apply damage to a **GameObject** when hit by particles

https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnParticleCollision.html


### ref
https://docs.unity3d.com/ScriptReference/ParticleSystem.html
