using System;
using System.Collections.Concurrent;

namespace ForieroEngine.Pooling.Concurrent
{
	public class ConcurrentPool<T> : IRecycler<T>, IRecycler, IDisposable where T : class, IRecyclable
	{
		public delegate T CreateInstanceDelegate(IRecycler recycler);

		private int InstancesInUseCount;

		private string Name;

		private ConcurrentQueue<T> Instances;

		private CreateInstanceDelegate Constructor;

		private ReleaseInstanceDelegate Releaser;

		public int Count => 0;

		public int AvailableCount => 0;

		public int InUseCount => 0;

		public bool IsEmpty => false;

		public ConcurrentPool(string name)
		{
		}

		public ConcurrentPool(string name, CreateInstanceDelegate constructor)
		{
		}

		public ConcurrentPool(string name, int initialCapacity)
		{
		}

		public ConcurrentPool(string name, CreateInstanceDelegate constructor, int initialCapacity)
		{
		}

		protected virtual T CreateInstance()
		{
			return null;
		}

		public virtual T Acquire()
		{
			return null;
		}

		public virtual void Release(T instance)
		{
		}

		IRecyclable IRecycler.Acquire()
		{
			return null;
		}

		void IRecycler.Release(IRecyclable instance)
		{
		}

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		~ConcurrentPool()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
