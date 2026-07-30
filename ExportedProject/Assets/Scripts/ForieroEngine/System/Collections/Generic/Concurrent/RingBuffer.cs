namespace System.Collections.Generic.Concurrent
{
	public class RingBuffer<T>
	{
		private readonly T[] _entries;

		private readonly int _modMask;

		private Volatile.PaddedLong _consumerCursor;

		private Volatile.PaddedLong _producerCursor;

		public int Capacity => 0;

		public T this[long index]
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		public int Count => 0;

		public RingBuffer(int capacity)
		{
		}

		public T Dequeue()
		{
			return default(T);
		}

		public bool TryDequeue(out T obj)
		{
			obj = default(T);
			return false;
		}

		public void Enqueue(T item)
		{
		}

		private static int NextPowerOfTwo(int x)
		{
			return 0;
		}
	}
}
