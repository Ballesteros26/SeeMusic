using System.Collections;

namespace System.ComponentModel
{
	/// <summary>Represents a collection of <see cref="T:System.ComponentModel.EventDescriptor" /> objects.</summary>
	public class EventDescriptorCollection : ICollection, IEnumerable, IList
	{
		private class ArraySubsetEnumerator : IEnumerator
		{
			private readonly Array _array;

			private readonly int _total;

			private int _current;

			public object Current => null;

			public ArraySubsetEnumerator(Array array, int count)
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			public void Reset()
			{
			}
		}

		private EventDescriptor[] _events;

		private string[] _namedSort;

		private readonly IComparer _comparer;

		private bool _eventsOwned;

		private bool _needSort;

		private readonly bool _readOnly;

		/// <summary>Specifies an empty collection to use, rather than creating a new one with no items. This static field is read-only.</summary>
		public static readonly EventDescriptorCollection Empty;

		/// <summary>Gets the number of event descriptors in the collection.</summary>
		/// <returns>The number of event descriptors in the collection.</returns>
		public int Count { get; private set; }

		/// <summary>Gets or sets the event with the specified index number.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.EventDescriptor" /> with the specified index number.</returns>
		/// <param name="index">The zero-based index number of the <see cref="T:System.ComponentModel.EventDescriptor" /> to get or set. </param>
		/// <exception cref="T:System.IndexOutOfRangeException">
		///   <paramref name="index" /> is not a valid index for <see cref="P:System.ComponentModel.EventDescriptorCollection.Item(System.Int32)" />. </exception>
		public virtual EventDescriptor this[int index] => null;

		/// <summary>Gets a value indicating whether access to the collection is synchronized.</summary>
		/// <returns>true if access to the collection is synchronized; otherwise, false.</returns>
		bool ICollection.IsSynchronized => false;

		/// <summary>Gets an object that can be used to synchronize access to the collection.</summary>
		/// <returns>An object that can be used to synchronize access to the collection.</returns>
		object ICollection.SyncRoot => null;

		/// <summary>Gets the number of elements contained in the collection.</summary>
		/// <returns>The number of elements contained in the collection.</returns>
		int ICollection.Count => 0;

		/// <summary>Gets or sets the element at the specified index.</summary>
		/// <returns>The element at the specified index.</returns>
		/// <param name="index">The zero-based index of the element to get or set.</param>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		/// <exception cref="T:System.IndexOutOfRangeException">
		///   <paramref name="index" /> is less than 0. -or-<paramref name="index" /> is equal to or greater than <see cref="P:System.ComponentModel.EventDescriptorCollection.Count" />.</exception>
		object IList.this[int index]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Gets a value indicating whether the collection is read-only.</summary>
		/// <returns>true if the collection is read-only; otherwise, false.</returns>
		bool IList.IsReadOnly => false;

		/// <summary>Gets a value indicating whether the collection has a fixed size.</summary>
		/// <returns>true if the collection has a fixed size; otherwise, false.</returns>
		bool IList.IsFixedSize => false;

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.EventDescriptorCollection" /> class with the given array of <see cref="T:System.ComponentModel.EventDescriptor" /> objects.</summary>
		/// <param name="events">An array of type <see cref="T:System.ComponentModel.EventDescriptor" /> that provides the events for this collection. </param>
		public EventDescriptorCollection(EventDescriptor[] events)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.EventDescriptorCollection" /> class with the given array of <see cref="T:System.ComponentModel.EventDescriptor" /> objects. The collection is optionally read-only.</summary>
		/// <param name="events">An array of type <see cref="T:System.ComponentModel.EventDescriptor" /> that provides the events for this collection. </param>
		/// <param name="readOnly">true to specify a read-only collection; otherwise, false.</param>
		public EventDescriptorCollection(EventDescriptor[] events, bool readOnly)
		{
		}

		/// <summary>Adds an <see cref="T:System.ComponentModel.EventDescriptor" /> to the end of the collection.</summary>
		/// <returns>The position of the <see cref="T:System.ComponentModel.EventDescriptor" /> within the collection.</returns>
		/// <param name="value">An <see cref="T:System.ComponentModel.EventDescriptor" /> to add to the collection. </param>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		public int Add(EventDescriptor value)
		{
			return 0;
		}

		/// <summary>Removes all objects from the collection.</summary>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		public void Clear()
		{
		}

		/// <summary>Returns whether the collection contains the given <see cref="T:System.ComponentModel.EventDescriptor" />.</summary>
		/// <returns>true if the collection contains the <paramref name="value" /> parameter given; otherwise, false.</returns>
		/// <param name="value">The <see cref="T:System.ComponentModel.EventDescriptor" /> to find within the collection. </param>
		public bool Contains(EventDescriptor value)
		{
			return false;
		}

		/// <summary>Copies the elements of the collection to an <see cref="T:System.Array" />, starting at a particular <see cref="T:System.Array" /> index.</summary>
		/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from collection. The <see cref="T:System.Array" /> must have zero-based indexing.</param>
		/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins.</param>
		void ICollection.CopyTo(Array array, int index)
		{
		}

		private void EnsureEventsOwned()
		{
		}

		private void EnsureSize(int sizeNeeded)
		{
		}

		/// <summary>Returns the index of the given <see cref="T:System.ComponentModel.EventDescriptor" />.</summary>
		/// <returns>The index of the given <see cref="T:System.ComponentModel.EventDescriptor" /> within the collection.</returns>
		/// <param name="value">The <see cref="T:System.ComponentModel.EventDescriptor" /> to find within the collection. </param>
		public int IndexOf(EventDescriptor value)
		{
			return 0;
		}

		/// <summary>Inserts an <see cref="T:System.ComponentModel.EventDescriptor" /> to the collection at a specified index.</summary>
		/// <param name="index">The index within the collection in which to insert the <paramref name="value" /> parameter. </param>
		/// <param name="value">An <see cref="T:System.ComponentModel.EventDescriptor" /> to insert into the collection. </param>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		public void Insert(int index, EventDescriptor value)
		{
		}

		/// <summary>Removes the specified <see cref="T:System.ComponentModel.EventDescriptor" /> from the collection.</summary>
		/// <param name="value">The <see cref="T:System.ComponentModel.EventDescriptor" /> to remove from the collection. </param>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		public void Remove(EventDescriptor value)
		{
		}

		/// <summary>Removes the <see cref="T:System.ComponentModel.EventDescriptor" /> at the specified index from the collection.</summary>
		/// <param name="index">The index of the <see cref="T:System.ComponentModel.EventDescriptor" /> to remove. </param>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		public void RemoveAt(int index)
		{
		}

		/// <summary>Gets an enumerator for this <see cref="T:System.ComponentModel.EventDescriptorCollection" />.</summary>
		/// <returns>An enumerator that implements <see cref="T:System.Collections.IEnumerator" />.</returns>
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		/// <summary>Sorts the members of this <see cref="T:System.ComponentModel.EventDescriptorCollection" />. The specified order is applied first, followed by the default sort for this collection, which is usually alphabetical.</summary>
		/// <param name="names">An array of strings describing the order in which to sort the <see cref="T:System.ComponentModel.EventDescriptor" /> objects in this collection. </param>
		protected void InternalSort(string[] names)
		{
		}

		/// <summary>Sorts the members of this <see cref="T:System.ComponentModel.EventDescriptorCollection" />, using the specified <see cref="T:System.Collections.IComparer" />.</summary>
		/// <param name="sorter">A comparer to use to sort the <see cref="T:System.ComponentModel.EventDescriptor" /> objects in this collection. </param>
		protected void InternalSort(IComparer sorter)
		{
		}

		/// <summary>Returns an enumerator that iterates through a collection.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> that can be used to iterate through the collection.</returns>
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		/// <summary>Adds an item to the collection.</summary>
		/// <returns>The position into which the new element was inserted.</returns>
		/// <param name="value">The <see cref="T:System.Object" /> to add to the collection.</param>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		int IList.Add(object value)
		{
			return 0;
		}

		/// <summary>Determines whether the collection contains a specific value.</summary>
		/// <returns>true if the <see cref="T:System.Object" /> is found in the collection; otherwise, false.</returns>
		/// <param name="value">The <see cref="T:System.Object" /> to locate in the collection.</param>
		bool IList.Contains(object value)
		{
			return false;
		}

		/// <summary>Removes all the items from the collection.</summary>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		void IList.Clear()
		{
		}

		/// <summary>Determines the index of a specific item in the collection.</summary>
		/// <returns>The index of <paramref name="value" /> if found in the list; otherwise, -1.</returns>
		/// <param name="value">The <see cref="T:System.Object" /> to locate in the collection.</param>
		int IList.IndexOf(object value)
		{
			return 0;
		}

		/// <summary>Inserts an item to the collection at the specified index.</summary>
		/// <param name="index">The zero-based index at which <paramref name="value" /> should be inserted.</param>
		/// <param name="value">The <see cref="T:System.Object" /> to insert into the collection.</param>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		void IList.Insert(int index, object value)
		{
		}

		/// <summary>Removes the first occurrence of a specific object from the collection.</summary>
		/// <param name="value">The <see cref="T:System.Object" /> to remove from the collection.</param>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		void IList.Remove(object value)
		{
		}

		/// <summary>Removes the item at the specified index.</summary>
		/// <param name="index">The zero-based index of the item to remove.</param>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		void IList.RemoveAt(int index)
		{
		}
	}
}
