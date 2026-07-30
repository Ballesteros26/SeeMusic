namespace System.Threading
{
	internal struct DeferredDisposableLifetime<T> where T : class, IDeferredDisposable
	{
		private int _count;

		static DeferredDisposableLifetime()
		{
		}

		public bool AddRef(T obj)
		{
			return false;
		}

		public void Release(T obj)
		{
		}

		public void Dispose(T obj)
		{
		}
	}
}
