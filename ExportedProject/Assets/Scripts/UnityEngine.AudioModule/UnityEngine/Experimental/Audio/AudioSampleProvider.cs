using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Audio
{
	[StaticAccessor("AudioSampleProviderBindings", StaticAccessorType.DoubleColon)]
	[NativeType(Header = "Modules/Audio/Public/ScriptBindings/AudioSampleProvider.bindings.h")]
	public class AudioSampleProvider
	{
		public delegate void SampleFramesHandler(AudioSampleProvider provider, uint sampleFrameCount);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private SampleFramesHandler sampleFramesAvailable;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private SampleFramesHandler sampleFramesOverflow;

		[RequiredByNativeCode]
		private void InvokeSampleFramesAvailable(int sampleFrameCount)
		{
		}

		[RequiredByNativeCode]
		private void InvokeSampleFramesOverflow(int droppedSampleFrameCount)
		{
		}
	}
}
