using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace NJsonSchema.Collections
{
	internal sealed class ObservableDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, INotifyCollectionChanged, INotifyPropertyChanged, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>
	{
		private Dictionary<TKey, TValue> _dictionary;

		[CompilerGenerated]
		private PropertyChangedEventHandler PropertyChanged;

		public ICollection<TKey> Keys => null;

		ICollection IDictionary.Values => null;

		ICollection IDictionary.Keys => null;

		IEnumerable<TValue> IReadOnlyDictionary<TKey, TValue>.Values => null;

		IEnumerable<TKey> IReadOnlyDictionary<TKey, TValue>.Keys => null;

		public ICollection<TValue> Values => null;

		public TValue this[TKey key]
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

		public bool IsSynchronized { get; }

		public object SyncRoot { get; }

		public bool IsReadOnly => false;

		object IDictionary.this[object key]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public event NotifyCollectionChangedEventHandler CollectionChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public ObservableDictionary()
		{
		}

		public ObservableDictionary(IDictionary<TKey, TValue> dictionary)
		{
		}

		private void Insert(TKey key, TValue value, bool add)
		{
		}

		private void OnPropertyChanged(string propertyName)
		{
		}

		private void OnCollectionChanged()
		{
		}

		private void OnCollectionChanged(NotifyCollectionChangedAction action, KeyValuePair<TKey, TValue> changedItem)
		{
		}

		private void OnCollectionChanged(NotifyCollectionChangedAction action, KeyValuePair<TKey, TValue> newItem, KeyValuePair<TKey, TValue> oldItem)
		{
		}

		private void OnPropertyChanged()
		{
		}

		public void Add(TKey key, TValue value)
		{
		}

		public bool ContainsKey(TKey key)
		{
			return false;
		}

		public bool Remove(TKey key)
		{
			return false;
		}

		public bool TryGetValue(TKey key, out TValue value)
		{
			value = default(TValue);
			return false;
		}

		public void Add(KeyValuePair<TKey, TValue> item)
		{
		}

		void IDictionary.Add(object key, object value)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(object key)
		{
			return false;
		}

		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		public void Remove(object key)
		{
		}

		public bool Contains(KeyValuePair<TKey, TValue> item)
		{
			return false;
		}

		public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
		}

		public void CopyTo(Array array, int index)
		{
		}

		public bool Remove(KeyValuePair<TKey, TValue> item)
		{
			return false;
		}

		IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator()
		{
			return null;
		}

		public Dictionary<TKey, TValue>.Enumerator GetEnumerator()
		{
			return default(Dictionary<TKey, TValue>.Enumerator);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
