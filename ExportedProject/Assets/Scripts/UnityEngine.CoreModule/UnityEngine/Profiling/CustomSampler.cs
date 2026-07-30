using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Profiling
{
	[UsedByNativeCode]
	[NativeHeader("Runtime/Profiler/Marker.h")]
	[NativeHeader("Runtime/Profiler/ScriptBindings/Sampler.bindings.h")]
	public sealed class CustomSampler : Sampler
	{
		internal static CustomSampler s_InvalidCustomSampler;

		internal CustomSampler()
		{
		}

		internal CustomSampler(IntPtr ptr)
		{
		}

		public static CustomSampler Create(string name, bool collectGpuData = false)
		{
			return null;
		}
	}
}
