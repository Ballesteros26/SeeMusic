using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Audio
{
	[StaticAccessor("AudioClipPlayableBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Modules/Audio/Public/Director/AudioClipPlayable.h")]
	[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioClipPlayable.bindings.h")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[RequiredByNativeCode]
	public struct AudioClipPlayable : IPlayable, IEquatable<AudioClipPlayable>
	{
		private PlayableHandle m_Handle;

		public PlayableHandle GetHandle()
		{
			return default(PlayableHandle);
		}

		public bool Equals(AudioClipPlayable other)
		{
			return false;
		}
	}
}
