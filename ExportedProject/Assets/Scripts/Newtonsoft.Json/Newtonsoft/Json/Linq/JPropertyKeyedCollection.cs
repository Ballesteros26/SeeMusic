using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace Newtonsoft.Json.Linq
{
	[DefaultMember("Item")]
	internal class JPropertyKeyedCollection : Collection<JToken>
	{
		private static readonly IEqualityComparer<string> Comparer;

		private Dictionary<string, JToken>? _dictionary;

		public ICollection<string> Keys => null;

		private void AddKey(string key, JToken item)
		{
		}

		protected override void ClearItems()
		{
		}

		public bool Contains(string key)
		{
			return false;
		}

		private void EnsureDictionary()
		{
		}

		private string GetKeyForItem(JToken item)
		{
			return null;
		}

		protected override void InsertItem(int index, JToken item)
		{
		}

		protected override void RemoveItem(int index)
		{
		}

		private void RemoveKey(string key)
		{
		}

		protected override void SetItem(int index, JToken item)
		{
		}

		public bool TryGetValue(string key, [NotNullWhen(true)] out JToken? value)
		{
			value = null;
			return false;
		}

		public int IndexOfReference(JToken t)
		{
			return 0;
		}
	}
}
