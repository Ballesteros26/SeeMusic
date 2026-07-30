using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Audio
{
	[NativeHeader("Modules/Audio/Public/AudioSource.h")]
	[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioPlayableOutput.bindings.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AudioPlayableOutputBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Modules/Audio/Public/Director/AudioPlayableOutput.h")]
	public struct AudioPlayableOutput : IPlayableOutput
	{
		private PlayableOutputHandle m_Handle;

		internal AudioPlayableOutput(PlayableOutputHandle handle)
		{
			m_Handle = default(PlayableOutputHandle);
		}

		public PlayableOutputHandle GetHandle()
		{
			return default(PlayableOutputHandle);
		}

		public static explicit operator AudioPlayableOutput(PlayableOutput output)
		{
			return default(AudioPlayableOutput);
		}

		public void SetEvaluateOnSeek(bool value)
		{
		}

		[NativeThrows]
		private static void InternalSetEvaluateOnSeek(ref PlayableOutputHandle output, bool value)
		{
		}
	}
}
