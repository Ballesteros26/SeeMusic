using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Collections.ObjectModel
{
	/// <summary>Represents a dynamic data collection that provides notifications when items get added, removed, or when the whole list is refreshed.</summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	[Serializable]
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(CollectionDebugView<>))]
	public class ObservableCollection<T> : Collection<T>, INotifyCollectionChanged, INotifyPropertyChanged
	{
		[Serializable]
		private sealed class SimpleMonitor : IDisposable
		{
			internal int _busyCount;

			[NonSerialized]
			internal ObservableCollection<T> _collection;

			public SimpleMonitor(ObservableCollection<T> collection)
			{
			}

			public void Dispose()
			{
			}
		}

		private SimpleMonitor _monitor;

		[NonSerialized]
		private int _blockReentrancyCount;

		[NonSerialized]
		[CompilerGenerated]
		private PropertyChangedEventHandler PropertyChanged;

		/// <summary>Occurs when an item is added, removed, changed, moved, or the entire list is refreshed.</summary>
		public virtual event NotifyCollectionChangedEventHandler CollectionChanged
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

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.ObjectModel.ObservableCollection`1" /> class.</summary>
		public ObservableCollection()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.ObjectModel.ObservableCollection`1" /> class that contains elements copied from the specified collection.</summary>
		/// <param name="collection">The collection from which the elements are copied.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="collection" /> parameter cannot be null.</exception>
		public ObservableCollection(IEnumerable<T> collection)
		{
		}

		private static List<T> CreateCopy(IEnumerable<T> collection, string paramName)
		{
			return null;
		}

		/// <summary>Removes all items from the collection.</summary>
		protected override void ClearItems()
		{
		}

		/// <summary>Removes the item at the specified index of the collection.</summary>
		/// <param name="index">The zero-based index of the element to remove.</param>
		protected override void RemoveItem(int index)
		{
		}

		/// <summary>Inserts an item into the collection at the specified index.</summary>
		/// <param name="index">The zero-based index at which <paramref name="item" /> should be inserted.</param>
		/// <param name="item">The object to insert.</param>
		protected override void InsertItem(int index, T item)
		{
		}

		/// <summary>Replaces the element at the specified index.</summary>
		/// <param name="index">The zero-based index of the element to replace.</param>
		/// <param name="item">The new value for the element at the specified index.</param>
		protected override void SetItem(int index, T item)
		{
		}

		/// <summary>Raises the <see cref="E:System.Collections.ObjectModel.ObservableCollection`1.PropertyChanged" /> event with the provided arguments.</summary>
		/// <param name="e">Arguments of the event being raised.</param>
		protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
		{
		}

		/// <summary>Raises the <see cref="E:System.Collections.ObjectModel.ObservableCollection`1.CollectionChanged" /> event with the provided arguments.</summary>
		/// <param name="e">Arguments of the event being raised.</param>
		protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
		{
		}

		/// <summary>Checks for reentrant attempts to change this collection.</summary>
		/// <exception cref="T:System.InvalidOperationException">If there was a call to <see cref="M:System.Collections.ObjectModel.ObservableCollection`1.BlockReentrancy" /> of which the <see cref="T:System.IDisposable" /> return value has not yet been disposed of. Typically, this means when there are additional attempts to change this collection during a <see cref="E:System.Collections.ObjectModel.ObservableCollection`1.CollectionChanged" /> event. However, it depends on when derived classes choose to call <see cref="M:System.Collections.ObjectModel.ObservableCollection`1.BlockReentrancy" />.</exception>
		protected void CheckReentrancy()
		{
		}

		private void OnCountPropertyChanged()
		{
		}

		private void OnIndexerPropertyChanged()
		{
		}

		private void OnCollectionChanged(NotifyCollectionChangedAction action, object item, int index)
		{
		}

		private void OnCollectionChanged(NotifyCollectionChangedAction action, object oldItem, object newItem, int index)
		{
		}

		private void OnCollectionReset()
		{
		}

		private SimpleMonitor EnsureMonitorInitialized()
		{
			return null;
		}

		[OnSerializing]
		private void OnSerializing(StreamingContext context)
		{
		}

		[OnDeserialized]
		private void OnDeserialized(StreamingContext context)
		{
		}
	}
}
