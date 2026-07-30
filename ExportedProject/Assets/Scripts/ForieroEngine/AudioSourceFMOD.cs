using ForieroEngine.MIDIUnified.Interfaces;
using UnityEngine;

public class AudioSourceFMOD : MonoBehaviour, IAudioSource
{
	public string clipId;

	public bool IsPlaying { get; }

	public AudioSourceState State { get; set; }

	public bool PlayOnAwake { get; set; }

	public float Time { get; set; }

	public float Speed { get; set; }

	public int Semitone { get; set; }

	public float Volume { get; set; }

	public bool Mute { get; set; }

	public bool Initialized { get; set; }

	public void Play()
	{
	}

	public void Pause()
	{
	}

	public void Resume()
	{
	}

	public void Stop()
	{
	}

	public void Init(AudioClip clip)
	{
	}

	public void Init(string clip)
	{
	}

	public void PlayOneShot(AudioClip clip)
	{
	}

	public void PlayOneShot(AudioClip clip, float volume)
	{
	}

	public void PlayOneShot(string clip, float volume)
	{
	}

	public void Release()
	{
	}
}
