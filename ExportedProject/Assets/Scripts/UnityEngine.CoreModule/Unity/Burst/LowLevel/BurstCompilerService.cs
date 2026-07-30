using UnityEngine;
using UnityEngine.Bindings;

namespace Unity.Burst.LowLevel
{
	[StaticAccessor("BurstCompilerService::Get()", StaticAccessorType.Arrow)]
	[NativeHeader("Runtime/Burst/Burst.h")]
	[NativeHeader("Runtime/Burst/BurstDelegateCache.h")]
	internal static class BurstCompilerService
	{
		public enum BurstLogType
		{
			Info = 0,
			Warning = 1,
			Error = 2
		}

		[ThreadSafe]
		public unsafe static void* GetOrCreateSharedMemory(ref Hash128 key, uint size_of, uint alignment)
		{
			return null;
		}

		[FreeFunction("DefaultBurstLogCallback", true)]
		public unsafe static void Log(void* userData, BurstLogType logType, byte* message, byte* filename, int lineNumber)
		{
		}
	}
}
