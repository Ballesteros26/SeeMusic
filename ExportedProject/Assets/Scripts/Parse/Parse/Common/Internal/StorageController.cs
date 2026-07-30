using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Parse.Common.Internal
{
	public class StorageController : IStorageController
	{
		private class StorageDictionary : IStorageDictionary<string, object>, IEnumerable<KeyValuePair<string, object>>, IEnumerable
		{
			private object mutex;

			private Dictionary<string, object> dictionary;

			private FileInfo file;

			public IEnumerable<string> Keys => null;

			public IEnumerable<object> Values => null;

			public object this[string key] => null;

			public int Count => 0;

			public StorageDictionary(FileInfo file)
			{
			}

			internal Task SaveAsync()
			{
				return null;
			}

			internal Task LoadAsync()
			{
				return null;
			}

			internal void Update(IDictionary<string, object> contents)
			{
			}

			public Task AddAsync(string key, object value)
			{
				return null;
			}

			public Task RemoveAsync(string key)
			{
				return null;
			}

			public bool ContainsKey(string key)
			{
				return false;
			}

			public bool TryGetValue(string key, out object value)
			{
				value = null;
				return false;
			}

			public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
			{
				return null;
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		private FileInfo File { get; }

		private StorageDictionary Storage { get; set; }

		private TaskQueue Queue { get; }

		public StorageController()
		{
		}

		public StorageController(FileInfo file)
		{
		}

		public Task<IStorageDictionary<string, object>> LoadAsync()
		{
			return null;
		}

		public Task<IStorageDictionary<string, object>> SaveAsync(IDictionary<string, object> contents)
		{
			return null;
		}
	}
}
