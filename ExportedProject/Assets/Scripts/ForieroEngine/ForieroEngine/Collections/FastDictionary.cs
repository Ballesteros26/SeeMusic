using System.Collections;
using System.Collections.Generic;

namespace ForieroEngine.Collections
{
	public class FastDictionary<TKey, TValue> : IEnumerable<TKey>, IEnumerable
	{
		private readonly Dictionary<TKey, TValue> _dictionary;

		public TValue this[TKey index]
		{
			get
			{
				return default(TValue);
			}
			set
			{
			}
		}

		public int Count => 0;

		public IEnumerator<TKey> GetEnumerator()
		{
			return null;
		}

		public void Remove(TKey key)
		{
		}

		public bool ContainsKey(TKey key)
		{
			return false;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
