namespace ForieroEngine.Collections.NonBlocking
{
	public class NonBlockingQueue<T>
	{
		private class NoteT
		{
			public T value;

			public PointerT next;
		}

		private struct PointerT
		{
			public long count;

			public NoteT ptr;

			public PointerT(PointerT p)
			{
				count = 0L;
				ptr = null;
			}

			public PointerT(NoteT node, long c)
			{
				count = 0L;
				ptr = null;
			}
		}

		private PointerT Head;

		private PointerT Tail;

		private bool CAS(ref PointerT destination, PointerT compared, PointerT exchange)
		{
			return false;
		}

		public bool Dequeue(ref T t)
		{
			return false;
		}

		public void Enqueue(T t)
		{
		}
	}
}
