using ForieroEngine.MIDIUnified.Interfaces;
using UnityEngine;
using UnityEngine.Audio;

[RequireComponent(typeof(AudioSource))]
public class AudioSourceUnity : MonoBehaviour, IAudioSource
{
	public AudioSource audioSource;

	public bool IsPlaying => false;

	public AudioSourceState State => default(AudioSourceState);

	public bool PlayOnAwake
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float Time
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float Speed
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public int Semitone { get; set; }

	public float Volume
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public AudioMixerGroup OutputAudioMixerGroup
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool Initialized { get; set; }

	public bool Mute
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

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

	private void Awake()
	{
	}

	private AudioSourceState GetState()
	{
		return default(AudioSourceState);
	}
}
