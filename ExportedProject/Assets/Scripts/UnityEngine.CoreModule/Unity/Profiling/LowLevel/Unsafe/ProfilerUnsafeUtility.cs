using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace Unity.Profiling.LowLevel.Unsafe
{
	[UsedByNativeCode]
	[NativeHeader("Runtime/Profiler/ScriptBindings/ProfilerUnsafeUtility.bindings.h")]
	public static class ProfilerUnsafeUtility
	{
		[ThreadSafe]
		public static ProfilerCategoryDescription GetCategoryDescription(ushort categoryId)
		{
			return default(ProfilerCategoryDescription);
		}

		[ThreadSafe]
		public static IntPtr CreateMarker(string name, ushort categoryId, MarkerFlags flags, int metadataCount)
		{
			return (IntPtr)0;
		}

		[ThreadSafe]
		internal static IntPtr GetMarker(string name)
		{
			return (IntPtr)0;
		}

		[ThreadSafe]
		public static void BeginSample(IntPtr markerPtr)
		{
		}

		[ThreadSafe]
		public static void EndSample(IntPtr markerPtr)
		{
		}

		internal unsafe static string Utf8ToString(byte* chars, int charsLen)
		{
			return null;
		}

		private static void GetCategoryDescription_Injected(ushort categoryId, out ProfilerCategoryDescription ret)
		{
			ret = default(ProfilerCategoryDescription);
		}
	}
}
