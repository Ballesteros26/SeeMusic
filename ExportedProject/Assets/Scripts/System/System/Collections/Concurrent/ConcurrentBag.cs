using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace System.Collections.Concurrent
{
	/// <summary>Represents a thread-safe, unordered collection of objects.</summary>
	/// <typeparam name="T">The type of the elements to be stored in the collection.</typeparam>
	[Serializable]
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(IProducerConsumerCollectionDebugView<>))]
	public class ConcurrentBag<T> : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>
	{
		private sealed class WorkStealingQueue
		{
			private int _headIndex;

			private int _tailIndex;

			private T[] _array;

			private int _mask;

			private int _addTakeCount;

			private int _stealCount;

			internal int _currentOp;

			internal bool _frozen;

			internal readonly WorkStealingQueue _nextQueue;

			internal readonly int _ownerThreadId;

			internal int DangerousCount => 0;

			internal WorkStealingQueue(WorkStealingQueue nextQueue)
			{
			}

			internal void LocalPush(T item, ref long emptyToNonEmptyListTransitionCount)
			{
			}

			internal int DangerousCopyTo(T[] array, int arrayIndex)
			{
				return 0;
			}
		}

		[Serializable]
		private sealed class Enumerator : IEnumerator<T>, IDisposable, IEnumerator
		{
			private readonly T[] _array;

			private T _current;

			private int _index;

			public T Current => default(T);

			object IEnumerator.Current => null;

			public Enumerator(T[] array)
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			public void Reset()
			{
			}

			public void Dispose()
			{
			}
		}

		private readonly ThreadLocal<WorkStealingQueue> _locals;

		private WorkStealingQueue _workStealingQueues;

		private long _emptyToNonEmptyListTransitionCount;

		/// <summary>Gets the number of elements contained in the <see cref="T:System.Collections.Concurrent.ConcurrentBag`1" />.</summary>
		/// <returns>The number of elements contained in the <see cref="T:System.Collections.Concurrent.ConcurrentBag`1" />.</returns>
		public int Count => 0;

		private int DangerousCount => 0;

		/// <summary>Gets a value indicating whether access to the <see cref="T:System.Collections.ICollection" /> is synchronized with the SyncRoot.</summary>
		/// <returns>true if access to the <see cref="T:System.Collections.ICollection" /> is synchronized with the SyncRoot; otherwise, false. For <see cref="T:System.Collections.Concurrent.ConcurrentBag`1" />, this property always returns false.</returns>
		bool ICollection.IsSynchronized => false;

		/// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Collections.ICollection" />. This property is not supported.</summary>
		/// <returns>Returns null  (Nothing in Visual Basic).</returns>
		/// <exception cref="T:System.NotSupportedException">The SyncRoot property is not supported.</exception>
		object ICollection.SyncRoot => null;

		private object GlobalQueuesLock => null;

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Concurrent.ConcurrentBag`1" /> class.</summary>
		public ConcurrentBag()
		{
		}

		/// <summary>Adds an object to the <see cref="T:System.Collections.Concurrent.ConcurrentBag`1" />.</summary>
		/// <param name="item">The object to be added to the <see cref="T:System.Collections.Concurrent.ConcurrentBag`1" />. The value can be a null reference (Nothing in Visual Basic) for reference types.</param>
		public void Add(T item)
		{
		}

		private WorkStealingQueue GetCurrentThreadWorkStealingQueue(bool forceCreate)
		{
			return null;
		}

		private WorkStealingQueue CreateWorkStealingQueueForCurrentThread()
		{
			return null;
		}

		private WorkStealingQueue GetUnownedWorkStealingQueue()
		{
			return null;
		}

		/// <summary>Copies the <see cref="T:System.Collections.Concurrent.ConcurrentBag`1" /> elements to an existing one-dimensional <see cref="T:System.Array" />, starting at the specified array index.</summary>
		/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from the <see cref="T:System.Collections.Concurrent.ConcurrentBag`1" />. The <see cref="T:System.Array" /> must have zero-based indexing.</param>
		/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> is a null reference (Nothing in Visual Basic).</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> is less than zero.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="index" /> is equal to or greater than the length of the <paramref name="array" /> -or- the number of elements in the source <see cref="T:System.Collections.Concurrent.ConcurrentBag`1" /> is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="array" />.</exception>
		public void CopyTo(T[] array, int index)
		{
		}

		private int CopyFromEachQueueToArray(T[] array, int index)
		{
			return 0;
		}

		/// <summary>Copies the elements of the <see cref="T:System.Collections.ICollection" /> to an <see cref="T:System.Array" />, starting at a particular <see cref="T:System.Array" /> index.</summary>
		/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from the <see cref="T:System.Collections.Concurrent.ConcurrentBag`1" />. The <see cref="T:System.Array" /> must have zero-based indexing.</param>
		/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> is a null reference (Nothing in Visual Basic).</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> is less than zero.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="array" /> is multidimensional. -or- <paramref name="array" /> does not have zero-based indexing. -or- <paramref name="index" /> is equal to or greater than the length of the <paramref name="array" /> -or- The number of elements in the source <see cref="T:System.Collections.ICollection" /> is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="array" />. -or- The type of the source <see cref="T:System.Collections.ICollection" /> cannot be cast automatically to the type of the destination <paramref name="array" />.</exception>
		void ICollection.CopyTo(Array array, int index)
		{
		}

		/// <summary>Copies the <see cref="T:System.Collections.Concurrent.ConcurrentBag`1" /> elements to a new array.</summary>
		/// <returns>A new array containing a snapshot of elements copied from the <see cref="T:System.Collections.Concurrent.ConcurrentBag`1" />.</returns>
		public T[] ToArray()
		{
			return null;
		}

		/// <summary>Returns an enumerator that iterates through the <see cref="T:System.Collections.Concurrent.ConcurrentBag`1" />.</summary>
		/// <returns>An enumerator for the contents of the <see cref="T:System.Collections.Concurrent.ConcurrentBag`1" />.</returns>
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		/// <summary>Returns an enumerator that iterates through the <see cref="T:System.Collections.Concurrent.ConcurrentBag`1" />.</summary>
		/// <returns>An enumerator for the contents of the <see cref="T:System.Collections.Concurrent.ConcurrentBag`1" />.</returns>
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		private void FreezeBag(ref bool lockTaken)
		{
		}

		private void UnfreezeBag(bool lockTaken)
		{
		}
	}
}
