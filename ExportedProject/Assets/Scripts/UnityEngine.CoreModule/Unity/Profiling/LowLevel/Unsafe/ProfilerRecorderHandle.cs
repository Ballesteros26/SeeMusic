using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace Unity.Profiling.LowLevel.Unsafe
{
	[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
	[UsedByNativeCode]
	public readonly struct ProfilerRecorderHandle
	{
		[FieldOffset(0)]
		internal readonly ulong handle;

		public bool Valid => false;

		internal ProfilerRecorderHandle(ulong handle)
		{
			this.handle = 0uL;
		}

		public static ProfilerRecorderDescription GetDescription(ProfilerRecorderHandle handle)
		{
			return default(ProfilerRecorderDescription);
		}

		[NativeMethod(IsThreadSafe = true)]
		private static ProfilerRecorderDescription GetDescriptionInternal(ProfilerRecorderHandle handle)
		{
			return default(ProfilerRecorderDescription);
		}

		private static void GetDescriptionInternal_Injected(ref ProfilerRecorderHandle handle, out ProfilerRecorderDescription ret)
		{
			ret = default(ProfilerRecorderDescription);
		}
	}
}
