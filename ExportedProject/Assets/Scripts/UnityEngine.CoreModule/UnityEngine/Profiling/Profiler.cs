using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Profiling
{
	[NativeHeader("Runtime/Allocator/MemoryManager.h")]
	[MovedFrom("UnityEngine")]
	[NativeHeader("Runtime/Profiler/ScriptBindings/Profiler.bindings.h")]
	[NativeHeader("Runtime/ScriptingBackend/ScriptingApi.h")]
	[UsedByNativeCode]
	[NativeHeader("Runtime/Utilities/MemoryUtilities.h")]
	[NativeHeader("Runtime/Profiler/Profiler.h")]
	public sealed class Profiler
	{
		public static bool enabled
		{
			[NativeConditional("ENABLE_PROFILER")]
			[NativeMethod(Name = "profiler_is_enabled", IsFreeFunction = true, IsThreadSafe = true)]
			get
			{
				return false;
			}
		}

		[NativeMethod(Name = "ProfilerBindings::GetRuntimeMemorySizeLong", IsFreeFunction = true)]
		public static long GetRuntimeMemorySizeLong([NotNull("ArgumentNullException")] Object o)
		{
			return 0L;
		}

		[NativeMethod(Name = "scripting_gc_get_heap_size", IsFreeFunction = true)]
		public static long GetMonoHeapSizeLong()
		{
			return 0L;
		}

		[NativeMethod(Name = "scripting_gc_get_used_size", IsFreeFunction = true)]
		public static long GetMonoUsedSizeLong()
		{
			return 0L;
		}

		[NativeMethod(Name = "GetTotalAllocatedMemory")]
		[StaticAccessor("GetMemoryManager()", StaticAccessorType.Dot)]
		[NativeConditional("ENABLE_MEMORY_MANAGER")]
		public static long GetTotalAllocatedMemoryLong()
		{
			return 0L;
		}

		[NativeConditional("ENABLE_MEMORY_MANAGER")]
		[NativeMethod(Name = "GetTotalUnusedReservedMemory")]
		[StaticAccessor("GetMemoryManager()", StaticAccessorType.Dot)]
		public static long GetTotalUnusedReservedMemoryLong()
		{
			return 0L;
		}

		[NativeConditional("ENABLE_MEMORY_MANAGER")]
		[StaticAccessor("GetMemoryManager()", StaticAccessorType.Dot)]
		[NativeMethod(Name = "GetTotalReservedMemory")]
		public static long GetTotalReservedMemoryLong()
		{
			return 0L;
		}
	}
}
