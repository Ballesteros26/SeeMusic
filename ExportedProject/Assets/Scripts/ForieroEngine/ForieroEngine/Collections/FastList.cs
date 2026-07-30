using System;
using System.Collections;
using System.Collections.Generic;

namespace ForieroEngine.Collections
{
	public class FastList<T> : IEnumerable<T>, IEnumerable
	{
		private readonly List<T> _list;

		public int Count => 0;

		public T this[int index]
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		public FastList()
		{
		}

		private FastList(IEnumerable<T> collection)
		{
		}

		public void Add(T item)
		{
		}

		public void Sort(Comparison<T> comparison)
		{
		}

		public FastList<T> Clone()
		{
			return null;
		}

		public void RemoveAt(int index)
		{
		}

		public T[] ToArray()
		{
			return null;
		}

		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		public int IndexOf(T item)
		{
			return 0;
		}

		public void Reverse()
		{
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public void InsertAt(int insertPos, T item)
		{
		}

		public void Clear()
		{
		}
	}
}
