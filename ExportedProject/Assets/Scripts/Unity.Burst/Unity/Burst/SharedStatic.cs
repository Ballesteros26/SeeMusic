using System;

namespace Unity.Burst
{
	internal static class SharedStatic
	{
		internal class PreserveAttribute : Attribute
		{
		}

		[Preserve]
		public unsafe static void* GetOrCreateSharedStaticInternal(long getHashCode64, long getSubHashCode64, uint sizeOf, uint alignment)
		{
			return null;
		}
	}
}
