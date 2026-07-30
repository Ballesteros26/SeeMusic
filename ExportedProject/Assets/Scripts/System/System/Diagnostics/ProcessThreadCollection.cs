using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace System.Diagnostics
{
	/// <summary>Provides a strongly typed collection of <see cref="T:System.Diagnostics.ProcessThread" /> objects.</summary>
	/// <filterpriority>2</filterpriority>
	public class ProcessThreadCollection : ReadOnlyCollectionBase
	{
		/// <summary>Gets an index for iterating over the set of process threads.</summary>
		/// <returns>A <see cref="T:System.Diagnostics.ProcessThread" /> that indexes the threads in the collection.</returns>
		/// <param name="index">The zero-based index value of the thread in the collection. </param>
		/// <filterpriority>2</filterpriority>
		public ProcessThread this[int index] => null;

		[Obsolete("This API is no longer available", true)]
		public int Capacity
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.ProcessThreadCollection" /> class, with no associated <see cref="T:System.Diagnostics.ProcessThread" /> instances.</summary>
		protected ProcessThreadCollection()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.ProcessThreadCollection" /> class, using the specified array of <see cref="T:System.Diagnostics.ProcessThread" /> instances.</summary>
		/// <param name="processThreads">An array of <see cref="T:System.Diagnostics.ProcessThread" /> instances with which to initialize this <see cref="T:System.Diagnostics.ProcessThreadCollection" /> instance. </param>
		public ProcessThreadCollection(ProcessThread[] processThreads)
		{
		}

		/// <summary>Appends a process thread to the collection.</summary>
		/// <returns>The zero-based index of the thread in the collection.</returns>
		/// <param name="thread">The thread to add to the collection. </param>
		/// <filterpriority>2</filterpriority>
		public int Add(ProcessThread thread)
		{
			return 0;
		}

		/// <summary>Inserts a process thread at the specified location in the collection.</summary>
		/// <param name="index">The zero-based index indicating the location at which to insert the thread. </param>
		/// <param name="thread">The thread to insert into the collection. </param>
		/// <filterpriority>2</filterpriority>
		public void Insert(int index, ProcessThread thread)
		{
		}

		/// <summary>Provides the location of a specified thread within the collection.</summary>
		/// <returns>The zero-based index that defines the location of the thread within the <see cref="T:System.Diagnostics.ProcessThreadCollection" />.</returns>
		/// <param name="thread">The <see cref="T:System.Diagnostics.ProcessThread" /> whose index is retrieved. </param>
		/// <filterpriority>2</filterpriority>
		public int IndexOf(ProcessThread thread)
		{
			return 0;
		}

		/// <summary>Determines whether the specified process thread exists in the collection.</summary>
		/// <returns>true if the thread exists in the collection; otherwise, false.</returns>
		/// <param name="thread">A <see cref="T:System.Diagnostics.ProcessThread" /> instance that indicates the thread to find in this collection. </param>
		/// <filterpriority>2</filterpriority>
		public bool Contains(ProcessThread thread)
		{
			return false;
		}

		/// <summary>Deletes a process thread from the collection.</summary>
		/// <param name="thread">The thread to remove from the collection. </param>
		/// <filterpriority>2</filterpriority>
		public void Remove(ProcessThread thread)
		{
		}

		/// <summary>Copies an array of <see cref="T:System.Diagnostics.ProcessThread" /> instances to the collection, at the specified index.</summary>
		/// <param name="array">An array of <see cref="T:System.Diagnostics.ProcessThread" /> instances to add to the collection. </param>
		/// <param name="index">The location at which to add the new instances. </param>
		/// <filterpriority>2</filterpriority>
		public void CopyTo(ProcessThread[] array, int index)
		{
		}

		[Obsolete("This API is no longer available", true)]
		public void AddRange(IEnumerable<ProcessThread> collection)
		{
		}

		[Obsolete("This API is no longer available", true)]
		public ReadOnlyCollection<ProcessThread> AsReadOnly()
		{
			return null;
		}

		[Obsolete("This API is no longer available", true)]
		public int BinarySearch(int index, int count, ProcessThread item, IComparer<ProcessThread> comparer)
		{
			return 0;
		}

		[Obsolete("This API is no longer available", true)]
		public int BinarySearch(ProcessThread item)
		{
			return 0;
		}

		[Obsolete("This API is no longer available", true)]
		public int BinarySearch(ProcessThread item, IComparer<ProcessThread> comparer)
		{
			return 0;
		}

		[Obsolete("This API is no longer available", true)]
		public void Clear()
		{
		}

		[Obsolete("This API is no longer available", true)]
		public List<TOutput> ConvertAll<TOutput>(Converter<ProcessThread, TOutput> converter)
		{
			return null;
		}

		[Obsolete("This API is no longer available", true)]
		public void CopyTo(ProcessThread[] array)
		{
		}

		[Obsolete("This API is no longer available", true)]
		public void CopyTo(int index, ProcessThread[] array, int arrayIndex, int count)
		{
		}

		[Obsolete("This API is no longer available", true)]
		public bool Exists(Predicate<ProcessThread> match)
		{
			return false;
		}

		[Obsolete("This API is no longer available", true)]
		public ProcessThread Find(Predicate<ProcessThread> match)
		{
			return null;
		}

		[Obsolete("This API is no longer available", true)]
		public List<ProcessThread> FindAll(Predicate<ProcessThread> match)
		{
			return null;
		}

		[Obsolete("This API is no longer available", true)]
		public int FindIndex(Predicate<ProcessThread> match)
		{
			return 0;
		}

		[Obsolete("This API is no longer available", true)]
		public int FindIndex(int startIndex, Predicate<ProcessThread> match)
		{
			return 0;
		}

		[Obsolete("This API is no longer available", true)]
		public int FindIndex(int startIndex, int count, Predicate<ProcessThread> match)
		{
			return 0;
		}

		[Obsolete("This API is no longer available", true)]
		public ProcessThread FindLast(Predicate<ProcessThread> match)
		{
			return null;
		}

		[Obsolete("This API is no longer available", true)]
		public int FindLastIndex(Predicate<ProcessThread> match)
		{
			return 0;
		}

		[Obsolete("This API is no longer available", true)]
		public int FindLastIndex(int startIndex, Predicate<ProcessThread> match)
		{
			return 0;
		}

		[Obsolete("This API is no longer available", true)]
		public int FindLastIndex(int startIndex, int count, Predicate<ProcessThread> match)
		{
			return 0;
		}

		[Obsolete("This API is no longer available", true)]
		public void ForEach(Action<ProcessThread> action)
		{
		}

		[Obsolete("This API is no longer available", true)]
		public List<ProcessThread> GetRange(int index, int count)
		{
			return null;
		}

		[Obsolete("This API is no longer available", true)]
		public int IndexOf(ProcessThread item, int index)
		{
			return 0;
		}

		[Obsolete("This API is no longer available", true)]
		public int IndexOf(ProcessThread item, int index, int count)
		{
			return 0;
		}

		[Obsolete("This API is no longer available", true)]
		public void InsertRange(int index, IEnumerable<ProcessThread> collection)
		{
		}

		[Obsolete("This API is no longer available", true)]
		public int LastIndexOf(ProcessThread item)
		{
			return 0;
		}

		[Obsolete("This API is no longer available", true)]
		public int LastIndexOf(ProcessThread item, int index)
		{
			return 0;
		}

		[Obsolete("This API is no longer available", true)]
		public int LastIndexOf(ProcessThread item, int index, int count)
		{
			return 0;
		}

		[Obsolete("This API is no longer available", true)]
		public int RemoveAll(Predicate<ProcessThread> match)
		{
			return 0;
		}

		[Obsolete("This API is no longer available", true)]
		public void RemoveAt(int index)
		{
		}

		[Obsolete("This API is no longer available", true)]
		public void RemoveRange(int index, int count)
		{
		}

		[Obsolete("This API is no longer available", true)]
		public void Reverse()
		{
		}

		[Obsolete("This API is no longer available", true)]
		public void Reverse(int index, int count)
		{
		}

		[Obsolete("This API is no longer available", true)]
		public void Sort()
		{
		}

		[Obsolete("This API is no longer available", true)]
		public void Sort(IComparer<ProcessThread> comparer)
		{
		}

		[Obsolete("This API is no longer available", true)]
		public void Sort(int index, int count, IComparer<ProcessThread> comparer)
		{
		}

		[Obsolete("This API is no longer available", true)]
		public void Sort(Comparison<ProcessThread> comparison)
		{
		}

		[Obsolete("This API is no longer available", true)]
		public ProcessThread[] ToArray()
		{
			return null;
		}

		[Obsolete("This API is no longer available", true)]
		public void TrimExcess()
		{
		}

		[Obsolete("This API is no longer available", true)]
		public bool TrueForAll(Predicate<ProcessThread> match)
		{
			return false;
		}
	}
}
