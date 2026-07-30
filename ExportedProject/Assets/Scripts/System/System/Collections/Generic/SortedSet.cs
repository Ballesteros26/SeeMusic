using System.Diagnostics;
using System.Runtime.Serialization;

namespace System.Collections.Generic
{
	/// <summary>Represents a collection of objects that is maintained in sorted order.</summary>
	/// <typeparam name="T">The type of elements in the set.</typeparam>
	[Serializable]
	[DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
	[DebuggerDisplay("Count = {Count}")]
	public class SortedSet<T> : ISet<T>, ICollection<T>, IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback
	{
		[Serializable]
		internal sealed class Node
		{
			public T Item { get; set; }

			public Node Left { get; set; }

			public Node Right { get; set; }

			public NodeColor Color { get; set; }

			public bool IsBlack => false;

			public bool IsRed => false;

			public bool Is2Node => false;

			public bool Is4Node => false;

			public Node(T item, NodeColor color)
			{
			}

			public static bool IsNonNullRed(Node node)
			{
				return false;
			}

			public static bool IsNullOrBlack(Node node)
			{
				return false;
			}

			public void ColorBlack()
			{
			}

			public void ColorRed()
			{
			}

			public TreeRotation GetRotation(Node current, Node sibling)
			{
				return default(TreeRotation);
			}

			public Node GetSibling(Node node)
			{
				return null;
			}

			public void Split4Node()
			{
			}

			public Node Rotate(TreeRotation rotation)
			{
				return null;
			}

			public Node RotateLeft()
			{
				return null;
			}

			public Node RotateLeftRight()
			{
				return null;
			}

			public Node RotateRight()
			{
				return null;
			}

			public Node RotateRightLeft()
			{
				return null;
			}

			public void Merge2Nodes()
			{
			}

			public void ReplaceChild(Node child, Node newChild)
			{
			}
		}

		/// <summary>Enumerates the elements of a <see cref="T:System.Collections.Generic.SortedSet`1" /> object.</summary>
		[Serializable]
		public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator, ISerializable, IDeserializationCallback
		{
			private static readonly Node s_dummyNode;

			private SortedSet<T> _tree;

			private int _version;

			private Stack<Node> _stack;

			private Node _current;

			private bool _reverse;

			/// <summary>Gets the element at the current position of the enumerator.</summary>
			/// <returns>The element in the collection at the current position of the enumerator.</returns>
			public T Current => default(T);

			/// <summary>Gets the element at the current position of the enumerator.</summary>
			/// <returns>The element in the collection at the current position of the enumerator.</returns>
			/// <exception cref="T:System.InvalidOperationException">The enumerator is positioned before the first element of the collection or after the last element. </exception>
			object IEnumerator.Current => null;

			internal bool NotStartedOrEnded => false;

			internal Enumerator(SortedSet<T> set)
			{
				_tree = null;
				_version = 0;
				_stack = null;
				_current = null;
				_reverse = false;
			}

			internal Enumerator(SortedSet<T> set, bool reverse)
			{
				_tree = null;
				_version = 0;
				_stack = null;
				_current = null;
				_reverse = false;
			}

			/// <summary>Implements the <see cref="T:System.Runtime.Serialization.ISerializable" /> interface and returns the data needed to serialize the <see cref="T:System.Collections.Generic.SortedSet`1" /> instance.</summary>
			/// <param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object that contains the information required to serialize the <see cref="T:System.Collections.Generic.SortedSet`1" /> instance.</param>
			/// <param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> object that contains the source and destination of the serialized stream associated with the <see cref="T:System.Collections.Generic.SortedSet`1" /> instance.</param>
			/// <exception cref="T:System.ArgumentNullException">
			///   <paramref name="info" /> is null.</exception>
			void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
			{
			}

			/// <summary>Implements the <see cref="T:System.Runtime.Serialization.ISerializable" /> interface and raises the deserialization event when the deserialization is complete.</summary>
			/// <param name="sender">The source of the deserialization event.</param>
			/// <exception cref="T:System.Runtime.Serialization.SerializationException">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object associated with the current <see cref="T:System.Collections.Generic.SortedSet`1" /> instance is invalid.</exception>
			void IDeserializationCallback.OnDeserialization(object sender)
			{
			}

			private void Initialize()
			{
			}

			/// <summary>Advances the enumerator to the next element of the <see cref="T:System.Collections.Generic.SortedSet`1" /> collection.</summary>
			/// <returns>true if the enumerator was successfully advanced to the next element; false if the enumerator has passed the end of the collection.</returns>
			/// <exception cref="T:System.InvalidOperationException">The collection was modified after the enumerator was created. </exception>
			public bool MoveNext()
			{
				return false;
			}

			/// <summary>Releases all resources used by the <see cref="T:System.Collections.Generic.SortedSet`1.Enumerator" />. </summary>
			public void Dispose()
			{
			}

			internal void Reset()
			{
			}

			/// <summary>Sets the enumerator to its initial position, which is before the first element in the collection.</summary>
			/// <exception cref="T:System.InvalidOperationException">The collection was modified after the enumerator was created. </exception>
			void IEnumerator.Reset()
			{
			}
		}

		private Node root;

		private IComparer<T> comparer;

		private int count;

		private int version;

		[NonSerialized]
		private object _syncRoot;

		private SerializationInfo siInfo;

		private const string ComparerName = "Comparer";

		private const string CountName = "Count";

		private const string ItemsName = "Items";

		private const string VersionName = "Version";

		private const string TreeName = "Tree";

		private const string NodeValueName = "Item";

		private const string EnumStartName = "EnumStarted";

		private const string ReverseName = "Reverse";

		private const string EnumVersionName = "EnumVersion";

		private const string MinName = "Min";

		private const string MaxName = "Max";

		private const string LowerBoundActiveName = "lBoundActive";

		private const string UpperBoundActiveName = "uBoundActive";

		internal const int StackAllocThreshold = 100;

		/// <summary>Gets the number of elements in the <see cref="T:System.Collections.Generic.SortedSet`1" />.</summary>
		/// <returns>The number of elements in the <see cref="T:System.Collections.Generic.SortedSet`1" />.</returns>
		public int Count => 0;

		bool ICollection<T>.IsReadOnly => false;

		/// <summary>Gets a value that indicates whether access to the <see cref="T:System.Collections.ICollection" /> is synchronized (thread safe).</summary>
		/// <returns>true if access to the <see cref="T:System.Collections.ICollection" /> is synchronized; otherwise, false.</returns>
		bool ICollection.IsSynchronized => false;

		/// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Collections.ICollection" />.</summary>
		/// <returns>An object that can be used to synchronize access to the <see cref="T:System.Collections.ICollection" />. In the default implementation of <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection" />, this property always returns the current instance.</returns>
		object ICollection.SyncRoot => null;

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Generic.SortedSet`1" /> class. </summary>
		public SortedSet()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Generic.SortedSet`1" /> class that uses a specified comparer.</summary>
		/// <param name="comparer">The default comparer to use for comparing objects. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="comparer" /> is null.</exception>
		public SortedSet(IComparer<T> comparer)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Generic.SortedSet`1" /> class that contains serialized data.</summary>
		/// <param name="info">The object that contains the information that is required to serialize the <see cref="T:System.Collections.Generic.SortedSet`1" /> object.</param>
		/// <param name="context">The structure that contains the source and destination of the serialized stream associated with the <see cref="T:System.Collections.Generic.SortedSet`1" /> object.</param>
		protected SortedSet(SerializationInfo info, StreamingContext context)
		{
		}

		internal virtual bool InOrderTreeWalk(TreeWalkPredicate<T> action)
		{
			return false;
		}

		internal virtual void VersionCheck()
		{
		}

		internal virtual bool IsWithinRange(T item)
		{
			return false;
		}

		/// <summary>Adds an element to the set and returns a value that indicates if it was successfully added.</summary>
		/// <returns>true if <paramref name="item" /> is added to the set; otherwise, false. </returns>
		/// <param name="item">The element to add to the set.</param>
		public bool Add(T item)
		{
			return false;
		}

		/// <summary>Adds an item to an <see cref="T:System.Collections.Generic.ICollection`1" /> object.</summary>
		/// <param name="item">The object to add to the <see cref="T:System.Collections.Generic.ICollection`1" /> object.</param>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Generic.ICollection`1" /> is read-only.</exception>
		void ICollection<T>.Add(T item)
		{
		}

		internal virtual bool AddIfNotPresent(T item)
		{
			return false;
		}

		/// <summary>Removes a specified item from the <see cref="T:System.Collections.Generic.SortedSet`1" />.</summary>
		/// <returns>true if the element is found and successfully removed; otherwise, false. </returns>
		/// <param name="item">The element to remove.</param>
		public bool Remove(T item)
		{
			return false;
		}

		internal virtual bool DoRemove(T item)
		{
			return false;
		}

		/// <summary>Removes all elements from the set.</summary>
		public virtual void Clear()
		{
		}

		/// <summary>Determines whether the set contains a specific element.</summary>
		/// <returns>true if the set contains <paramref name="item" />; otherwise, false.</returns>
		/// <param name="item">The element to locate in the set.</param>
		public virtual bool Contains(T item)
		{
			return false;
		}

		/// <summary>Copies the complete <see cref="T:System.Collections.Generic.SortedSet`1" /> to a compatible one-dimensional array, starting at the specified array index.</summary>
		/// <param name="array">A one-dimensional array that is the destination of the elements copied from the <see cref="T:System.Collections.Generic.SortedSet`1" />. The array must have zero-based indexing.</param>
		/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins.</param>
		/// <exception cref="T:System.ArgumentException">The number of elements in the source array is greater than the available space from <paramref name="index" /> to the end of the destination array.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> is less than zero.</exception>
		public void CopyTo(T[] array, int index)
		{
		}

		/// <summary>Copies a specified number of elements from <see cref="T:System.Collections.Generic.SortedSet`1" /> to a compatible one-dimensional array, starting at the specified array index.</summary>
		/// <param name="array">A one-dimensional array that is the destination of the elements copied from the <see cref="T:System.Collections.Generic.SortedSet`1" />. The array must have zero-based indexing.</param>
		/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins.</param>
		/// <param name="count">The number of elements to copy.</param>
		/// <exception cref="T:System.ArgumentException">The number of elements in the source array is greater than the available space from <paramref name="index" /> to the end of the destination array.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> is less than zero.-or-<paramref name="count" /> is less than zero.</exception>
		public void CopyTo(T[] array, int index, int count)
		{
		}

		/// <summary>Copies the complete <see cref="T:System.Collections.Generic.SortedSet`1" /> to a compatible one-dimensional array, starting at the specified array index.</summary>
		/// <param name="array">A one-dimensional array that is the destination of the elements copied from the <see cref="T:System.Collections.Generic.SortedSet`1" />. The array must have zero-based indexing.</param>
		/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins.</param>
		/// <exception cref="T:System.ArgumentException">The number of elements in the source array is greater than the available space from <paramref name="index" /> to the end of the destination array. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> is less than zero.</exception>
		void ICollection.CopyTo(Array array, int index)
		{
		}

		/// <summary>Returns an enumerator that iterates through the <see cref="T:System.Collections.Generic.SortedSet`1" />.</summary>
		/// <returns>An enumerator that iterates through the <see cref="T:System.Collections.Generic.SortedSet`1" /> in sorted order.</returns>
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		/// <summary>Returns an enumerator that iterates through a collection.</summary>
		/// <returns>An enumerator that can be used to iterate through the collection.</returns>
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		/// <summary>Returns an enumerator that iterates through a collection.</summary>
		/// <returns>An enumerator that can be used to iterate through the collection.</returns>
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		private void InsertionBalance(Node current, ref Node parent, Node grandParent, Node greatGrandParent)
		{
		}

		private void ReplaceChildOrRoot(Node parent, Node child, Node newChild)
		{
		}

		private void ReplaceNode(Node match, Node parentOfMatch, Node successor, Node parentOfSuccessor)
		{
		}

		internal virtual Node FindNode(T item)
		{
			return null;
		}

		internal void UpdateVersion()
		{
		}

		/// <summary>Implements the <see cref="T:System.Runtime.Serialization.ISerializable" /> interface, and returns the data that you need to serialize the <see cref="T:System.Collections.Generic.SortedSet`1" /> instance.</summary>
		/// <param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object that contains the information that is required to serialize the <see cref="T:System.Collections.Generic.SortedSet`1" /> instance.</param>
		/// <param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> structure that contains the source and destination of the serialized stream associated with the <see cref="T:System.Collections.Generic.SortedSet`1" /> instance.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="info" /> is null.</exception>
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		/// <summary>Implements the <see cref="T:System.Runtime.Serialization.ISerializable" /> interface and returns the data that you must have to serialize a <see cref="T:System.Collections.Generic.SortedSet`1" /> object.</summary>
		/// <param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object that contains the information that is required to serialize the <see cref="T:System.Collections.Generic.SortedSet`1" /> object.</param>
		/// <param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> structure that contains the source and destination of the serialized stream associated with the <see cref="T:System.Collections.Generic.SortedSet`1" /> object.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="info" /> is null.</exception>
		protected virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		/// <summary>Implements the <see cref="T:System.Runtime.Serialization.IDeserializationCallback" /> interface, and raises the deserialization event when the deserialization is completed.</summary>
		/// <param name="sender">The source of the deserialization event.</param>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object associated with the current <see cref="T:System.Collections.Generic.SortedSet`1" /> instance is invalid.</exception>
		void IDeserializationCallback.OnDeserialization(object sender)
		{
		}

		/// <summary>Implements the <see cref="T:System.Runtime.Serialization.ISerializable" /> interface, and raises the deserialization event when the deserialization is completed.</summary>
		/// <param name="sender">The source of the deserialization event.</param>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object associated with the current <see cref="T:System.Collections.Generic.SortedSet`1" /> object is invalid.</exception>
		protected virtual void OnDeserialization(object sender)
		{
		}

		private static int Log2(int value)
		{
			return 0;
		}
	}
}
