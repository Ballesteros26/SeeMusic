using System.Runtime.InteropServices;
using UnityEngine.Audio;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
	[StaticAccessor("AudioSourceBindings", StaticAccessorType.DoubleColon)]
	[RequireComponent(typeof(Transform))]
	public sealed class AudioSource : AudioBehaviour
	{
		public float volume
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float pitch
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[NativeProperty("SecPosition")]
		public float time
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[NativeProperty("SamplePosition")]
		public int timeSamples
		{
			[NativeMethod(IsThreadSafe = true)]
			get
			{
				return 0;
			}
			[NativeMethod(IsThreadSafe = true)]
			set
			{
			}
		}

		[NativeProperty("AudioClip")]
		public AudioClip clip
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public AudioMixerGroup outputAudioMixerGroup
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool isPlaying
		{
			[NativeName("IsPlayingScripting")]
			get
			{
				return false;
			}
		}

		public bool loop
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool playOnAwake
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[NativeProperty("StereoPan")]
		public float panStereo
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[NativeProperty("SpatialBlendMix")]
		public float spatialBlend
		{
			set
			{
			}
		}

		public bool spatialize
		{
			set
			{
			}
		}

		public bool spatializePostEffects
		{
			set
			{
			}
		}

		public bool bypassEffects
		{
			set
			{
			}
		}

		public bool bypassListenerEffects
		{
			set
			{
			}
		}

		public bool bypassReverbZones
		{
			set
			{
			}
		}

		public int priority
		{
			set
			{
			}
		}

		public bool mute
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float maxDistance
		{
			set
			{
			}
		}

		private static float GetPitch([NotNull("ArgumentNullException")] AudioSource source)
		{
			return 0f;
		}

		private static void SetPitch([NotNull("ArgumentNullException")] AudioSource source, float pitch)
		{
		}

		private static void PlayHelper([NotNull("ArgumentNullException")] AudioSource source, ulong delay)
		{
		}

		private void Play(double delay)
		{
		}

		private static void PlayOneShotHelper([NotNull("ArgumentNullException")] AudioSource source, [NotNull("NullExceptionObject")] AudioClip clip, float volumeScale)
		{
		}

		private void Stop(bool stopOneShots)
		{
		}

		[NativeThrows]
		private static void GetSpectrumDataHelper([NotNull("ArgumentNullException")] AudioSource source, [Out] float[] samples, int channel, FFTWindow window)
		{
		}

		[ExcludeFromDocs]
		public void Play()
		{
		}

		public void PlayScheduled(double time)
		{
		}

		[ExcludeFromDocs]
		public void PlayOneShot(AudioClip clip)
		{
		}

		public void PlayOneShot(AudioClip clip, [DefaultValue("1.0F")] float volumeScale)
		{
		}

		public void Stop()
		{
		}

		public void Pause()
		{
		}

		public void GetSpectrumData(float[] samples, int channel, FFTWindow window)
		{
		}
	}
}
