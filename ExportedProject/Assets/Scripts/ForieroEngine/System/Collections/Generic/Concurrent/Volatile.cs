using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Collections.Generic.Concurrent
{
	public static class Volatile
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 128)]
		public struct PaddedLong
		{
			[FieldOffset(64)]
			private long _value;

			public PaddedLong(long value)
			{
				_value = 0L;
			}

			public long ReadUnfenced()
			{
				return 0L;
			}

			public long ReadAcquireFence()
			{
				return 0L;
			}

			public long ReadFullFence()
			{
				return 0L;
			}

			[MethodImpl(MethodImplOptions.NoOptimization)]
			public long ReadCompilerOnlyFence()
			{
				return 0L;
			}

			public void WriteReleaseFence(long newValue)
			{
			}

			public void WriteFullFence(long newValue)
			{
			}

			[MethodImpl(MethodImplOptions.NoOptimization)]
			public void WriteCompilerOnlyFence(long newValue)
			{
			}

			public void WriteUnfenced(long newValue)
			{
			}

			public bool AtomicCompareExchange(long newValue, long comparand)
			{
				return false;
			}

			public long AtomicExchange(long newValue)
			{
				return 0L;
			}

			public long AtomicAddAndGet(long delta)
			{
				return 0L;
			}

			public long AtomicIncrementAndGet()
			{
				return 0L;
			}

			public long AtomicDecrementAndGet()
			{
				return 0L;
			}

			public override string ToString()
			{
				return null;
			}
		}

		private const int CacheLineSize = 64;
	}
}
