using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Parse.Common.Internal
{
	public interface IStorageDictionary<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
	{
		int Count { get; }

		TValue this[TKey key] { get; }

		IEnumerable<TKey> Keys { get; }

		IEnumerable<TValue> Values { get; }

		bool ContainsKey(TKey key);

		bool TryGetValue(TKey key, out TValue value);

		Task AddAsync(TKey key, TValue value);

		Task RemoveAsync(TKey key);
	}
}
