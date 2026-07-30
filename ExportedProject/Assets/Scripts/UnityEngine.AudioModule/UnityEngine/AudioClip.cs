using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Modules/Audio/Public/ScriptBindings/Audio.bindings.h")]
	[StaticAccessor("AudioClipBindings", StaticAccessorType.DoubleColon)]
	public sealed class AudioClip : Object
	{
		public delegate void PCMReaderCallback(float[] data);

		public delegate void PCMSetPositionCallback(int position);

		[NativeProperty("LengthSec")]
		public float length => 0f;

		[NativeProperty("SampleCount")]
		public int samples => 0;

		[NativeProperty("ChannelCount")]
		public int channels => 0;

		public int frequency => 0;

		public AudioDataLoadState loadState
		{
			[NativeMethod(Name = "AudioClipBindings::GetLoadState", HasExplicitThis = true)]
			get
			{
				return default(AudioDataLoadState);
			}
		}

		private event PCMReaderCallback m_PCMReaderCallback
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private event PCMSetPositionCallback m_PCMSetPositionCallback
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private AudioClip()
		{
		}

		private static bool GetData([NotNull("NullExceptionObject")] AudioClip clip, [Out] float[] data, int numSamples, int samplesOffset)
		{
			return false;
		}

		private static bool SetData([NotNull("NullExceptionObject")] AudioClip clip, float[] data, int numsamples, int samplesOffset)
		{
			return false;
		}

		private static AudioClip Construct_Internal()
		{
			return null;
		}

		private string GetName()
		{
			return null;
		}

		private void CreateUserSound(string name, int lengthSamples, int channels, int frequency, bool stream)
		{
		}

		public bool UnloadAudioData()
		{
			return false;
		}

		public bool GetData(float[] data, int offsetSamples)
		{
			return false;
		}

		public bool SetData(float[] data, int offsetSamples)
		{
			return false;
		}

		public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream)
		{
			return null;
		}

		public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, PCMReaderCallback pcmreadercallback, PCMSetPositionCallback pcmsetpositioncallback)
		{
			return null;
		}

		[RequiredByNativeCode]
		private void InvokePCMReaderCallback_Internal(float[] data)
		{
		}

		[RequiredByNativeCode]
		private void InvokePCMSetPositionCallback_Internal(int position)
		{
		}
	}
}
