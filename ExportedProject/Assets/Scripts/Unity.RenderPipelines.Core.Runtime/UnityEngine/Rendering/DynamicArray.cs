using System;

namespace UnityEngine.Rendering
{
	public class DynamicArray<T> where T : new()
	{
		private T[] m_Array;

		public int size { get; private set; }

		public int capacity => 0;

		public ref T this[int index]
		{
			get
			{
				throw null;
			}
		}

		public DynamicArray()
		{
		}

		public DynamicArray(int size)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(T item)
		{
			return false;
		}

		public int Add(in T value)
		{
			return 0;
		}

		public void AddRange(DynamicArray<T> array)
		{
		}

		public bool Remove(T item)
		{
			return false;
		}

		public void RemoveAt(int index)
		{
		}

		public void RemoveRange(int index, int count)
		{
		}

		public int FindIndex(int startIndex, int count, Predicate<T> match)
		{
			return 0;
		}

		public int IndexOf(T item, int index, int count)
		{
			return 0;
		}

		public int IndexOf(T item, int index)
		{
			return 0;
		}

		public int IndexOf(T item)
		{
			return 0;
		}

		public void Resize(int newSize, bool keepContent = false)
		{
		}

		public void Reserve(int newCapacity, bool keepContent = false)
		{
		}

		public static implicit operator T[](DynamicArray<T> array)
		{
			return null;
		}
	}
}
