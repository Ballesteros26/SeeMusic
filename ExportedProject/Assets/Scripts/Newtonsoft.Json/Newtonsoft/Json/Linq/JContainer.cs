using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace Newtonsoft.Json.Linq
{
	public abstract class JContainer : JToken, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable, IBindingList, ICollection, IList, INotifyCollectionChanged
	{
		internal ListChangedEventHandler? _listChanged;

		internal NotifyCollectionChangedEventHandler? _collectionChanged;

		private object? _syncRoot;

		private bool _busy;

		protected abstract IList<JToken> ChildrenTokens { get; }

		public override bool HasValues => false;

		public override JToken? First => null;

		public override JToken? Last => null;

		JToken IList<JToken>.this[int index]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		bool ICollection<JToken>.IsReadOnly => false;

		bool IList.IsFixedSize => false;

		bool IList.IsReadOnly => false;

		object? IList.this[int index]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int Count => 0;

		bool ICollection.IsSynchronized => false;

		object ICollection.SyncRoot => null;

		internal JContainer()
		{
		}

		internal JContainer(JContainer other, JsonCloneSettings? settings)
		{
		}

		internal void CheckReentrancy()
		{
		}

		protected virtual void OnListChanged(ListChangedEventArgs e)
		{
		}

		protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
		{
		}

		public override JEnumerable<JToken> Children()
		{
			return default(JEnumerable<JToken>);
		}

		internal bool IsMultiContent([NotNullWhen(true)] object? content)
		{
			return false;
		}

		internal JToken EnsureParentToken(JToken? item, bool skipParentCheck, bool copyAnnotations)
		{
			return null;
		}

		internal abstract int IndexOfItem(JToken? item);

		internal virtual bool InsertItem(int index, JToken? item, bool skipParentCheck, bool copyAnnotations)
		{
			return false;
		}

		internal virtual void RemoveItemAt(int index)
		{
		}

		internal virtual bool RemoveItem(JToken? item)
		{
			return false;
		}

		internal virtual JToken GetItem(int index)
		{
			return null;
		}

		internal virtual void SetItem(int index, JToken? item)
		{
		}

		internal virtual void ClearItems()
		{
		}

		internal virtual void ReplaceItem(JToken existing, JToken replacement)
		{
		}

		internal virtual bool ContainsItem(JToken? item)
		{
			return false;
		}

		internal virtual void CopyItemsTo(Array array, int arrayIndex)
		{
		}

		internal static bool IsTokenUnchanged(JToken currentValue, JToken? newValue)
		{
			return false;
		}

		internal virtual void ValidateToken(JToken o, JToken? existing)
		{
		}

		public virtual void Add(object? content)
		{
		}

		internal bool TryAdd(object? content)
		{
			return false;
		}

		internal void AddAndSkipParentCheck(JToken token)
		{
		}

		internal bool TryAddInternal(int index, object? content, bool skipParentCheck, bool copyAnnotations)
		{
			return false;
		}

		internal static JToken CreateFromContent(object? content)
		{
			return null;
		}

		public void RemoveAll()
		{
		}

		internal void ReadTokenFrom(JsonReader reader, JsonLoadSettings? options)
		{
		}

		internal void ReadContentFrom(JsonReader r, JsonLoadSettings? settings)
		{
		}

		private static JProperty? ReadProperty(JsonReader r, JsonLoadSettings? settings, IJsonLineInfo? lineInfo, JContainer parent)
		{
			return null;
		}

		int IList<JToken>.IndexOf(JToken item)
		{
			return 0;
		}

		void IList<JToken>.Insert(int index, JToken item)
		{
		}

		void IList<JToken>.RemoveAt(int index)
		{
		}

		void ICollection<JToken>.Add(JToken item)
		{
		}

		void ICollection<JToken>.Clear()
		{
		}

		bool ICollection<JToken>.Contains(JToken item)
		{
			return false;
		}

		void ICollection<JToken>.CopyTo(JToken[] array, int arrayIndex)
		{
		}

		bool ICollection<JToken>.Remove(JToken item)
		{
			return false;
		}

		private JToken? EnsureValue(object? value)
		{
			return null;
		}

		int IList.Add(object? value)
		{
			return 0;
		}

		void IList.Clear()
		{
		}

		bool IList.Contains(object? value)
		{
			return false;
		}

		int IList.IndexOf(object? value)
		{
			return 0;
		}

		void IList.Insert(int index, object? value)
		{
		}

		void IList.Remove(object? value)
		{
		}

		void IList.RemoveAt(int index)
		{
		}

		void ICollection.CopyTo(Array array, int index)
		{
		}
	}
}
