using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Modules/Audio/Public/ScriptBindings/Audio.bindings.h")]
	[StaticAccessor("GetAudioManager()", StaticAccessorType.Dot)]
	public sealed class AudioSettings
	{
		public delegate void AudioConfigurationChangeHandler(bool deviceWasChanged);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action OnAudioSystemShuttingDown;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action OnAudioSystemStartedUp;

		public static AudioSpeakerMode driverCapabilities
		{
			[NativeName("GetSpeakerModeCaps")]
			get
			{
				return default(AudioSpeakerMode);
			}
		}

		public static AudioSpeakerMode speakerMode => default(AudioSpeakerMode);

		public static double dspTime
		{
			[NativeMethod(Name = "GetDSPTime", IsThreadSafe = true)]
			get
			{
				return 0.0;
			}
		}

		public static int outputSampleRate => 0;

		public static event AudioConfigurationChangeHandler OnAudioConfigurationChanged
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

		private static AudioSpeakerMode GetSpeakerMode()
		{
			return default(AudioSpeakerMode);
		}

		[NativeThrows]
		[NativeMethod(Name = "AudioSettings::SetConfiguration", IsFreeFunction = true)]
		private static bool SetConfiguration(AudioConfiguration config)
		{
			return false;
		}

		[NativeMethod(Name = "AudioSettings::GetSampleRate", IsFreeFunction = true)]
		private static int GetSampleRate()
		{
			return 0;
		}

		[NativeMethod(Name = "AudioSettings::GetDSPBufferSize", IsFreeFunction = true)]
		public static void GetDSPBufferSize(out int bufferLength, out int numBuffers)
		{
			bufferLength = default(int);
			numBuffers = default(int);
		}

		public static AudioConfiguration GetConfiguration()
		{
			return default(AudioConfiguration);
		}

		public static bool Reset(AudioConfiguration config)
		{
			return false;
		}

		[RequiredByNativeCode]
		internal static void InvokeOnAudioConfigurationChanged(bool deviceWasChanged)
		{
		}

		[RequiredByNativeCode]
		internal static void InvokeOnAudioSystemShuttingDown()
		{
		}

		[RequiredByNativeCode]
		internal static void InvokeOnAudioSystemStartedUp()
		{
		}

		private static bool SetConfiguration_Injected(ref AudioConfiguration config)
		{
			return false;
		}

		private static void GetConfiguration_Injected(out AudioConfiguration ret)
		{
			ret = default(AudioConfiguration);
		}
	}
}
