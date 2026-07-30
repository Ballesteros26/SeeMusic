using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Audio
{
	[StaticAccessor("AudioMixerPlayableBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioMixerPlayable.bindings.h")]
	[NativeHeader("Modules/Audio/Public/Director/AudioMixerPlayable.h")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[RequiredByNativeCode]
	public struct AudioMixerPlayable : IPlayable, IEquatable<AudioMixerPlayable>
	{
		private PlayableHandle m_Handle;

		public PlayableHandle GetHandle()
		{
			return default(PlayableHandle);
		}

		public bool Equals(AudioMixerPlayable other)
		{
			return false;
		}
	}
}
