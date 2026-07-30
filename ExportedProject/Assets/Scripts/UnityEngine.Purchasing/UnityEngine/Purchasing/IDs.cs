using System.Collections;
using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	public class IDs : IEnumerable<KeyValuePair<string, string>>, IEnumerable
	{
		private readonly Dictionary<string, string> m_Dic;

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public void Add(string id, params string[] stores)
		{
		}

		internal string SpecificIDForStore(string store, string defaultValue)
		{
			return null;
		}

		public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
		{
			return null;
		}
	}
}
