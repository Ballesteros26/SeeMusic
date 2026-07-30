using Unity.Collections;

namespace VideoKit.Utilities
{
	internal sealed class RingBuffer<T> where T : unmanaged
	{
		private readonly T[] buffer;

		private int read;

		private int write;

		public int Length => 0;

		public int Available => 0;

		public int Capacity => 0;

		public RingBuffer(int capacity)
		{
		}

		public void Clear()
		{
		}

		public void Read(T[] destination)
		{
		}

		public void Read(T[] destination, int index, int length)
		{
		}

		public void Read(NativeArray<T> destination)
		{
		}

		public unsafe void Read(T* destination, int length)
		{
		}

		public void Write(T[] source)
		{
		}

		public void Write(T[] source, int index, int length)
		{
		}

		public void Write(NativeArray<T> source)
		{
		}

		public unsafe void Write(T* source, int length)
		{
		}
	}
}
