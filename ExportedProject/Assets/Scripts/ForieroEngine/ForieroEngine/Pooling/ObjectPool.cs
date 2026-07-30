using System;
using System.Collections.Generic;

namespace ForieroEngine.Pooling
{
	public class ObjectPool<T>
	{
		private List<ObjectPoolContainer<T>> list;

		private Dictionary<T, ObjectPoolContainer<T>> lookup;

		private Func<T> factoryFunc;

		private int lastIndex;

		public int Count => 0;

		public int UsedItems => 0;

		public int AvailableItems => 0;

		public ObjectPool(Func<T> factoryFunc, int initialSize)
		{
		}

		private void Warm(int capacity)
		{
		}

		private ObjectPoolContainer<T> CreateConatiner()
		{
			return null;
		}

		public T GetItem()
		{
			return default(T);
		}

		public void ReleaseItem(object item)
		{
		}

		public void ReleaseAll()
		{
		}

		public void ReleaseItem(T item)
		{
		}
	}
}
