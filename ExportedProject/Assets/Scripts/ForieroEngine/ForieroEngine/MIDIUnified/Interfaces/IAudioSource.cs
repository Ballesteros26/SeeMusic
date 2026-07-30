using UnityEngine;

namespace ForieroEngine.MIDIUnified.Interfaces
{
	public interface IAudioSource
	{
		bool IsPlaying { get; }

		AudioSourceState State { get; }

		bool PlayOnAwake { get; set; }

		float Time { get; set; }

		float Speed { get; set; }

		int Semitone { get; set; }

		float Volume { get; set; }

		bool Mute { get; set; }

		bool Initialized { get; set; }

		void Play();

		void Pause();

		void Resume();

		void Stop();

		void Init(AudioClip clip);

		void Init(string clip);

		void PlayOneShot(AudioClip clip);

		void PlayOneShot(AudioClip clip, float volume);

		void PlayOneShot(string clip, float volume);

		void Release();
	}
}
