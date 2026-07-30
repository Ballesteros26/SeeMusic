using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Dynamic.Utils
{
	internal abstract class ListProvider<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable where T : class
	{
		[CompilerGenerated]
		private sealed class _003CGetEnumerator_003Ed__20 : IEnumerator<T>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private T _003C_003E2__current;

			public ListProvider<T> _003C_003E4__this;

			private int _003Ci_003E5__2;

			private int _003Cn_003E5__3;

			T IEnumerator<T>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CGetEnumerator_003Ed__20(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		protected abstract T First { get; }

		protected abstract int ElementCount { get; }

		public T this[int index]
		{
			get
			{
				return null;
			}
			[ExcludeFromCodeCoverage]
			set
			{
			}
		}

		public int Count => 0;

		[ExcludeFromCodeCoverage]
		public bool IsReadOnly => false;

		protected abstract T GetElement(int index);

		public int IndexOf(T item)
		{
			return 0;
		}

		[ExcludeFromCodeCoverage]
		public void Insert(int index, T item)
		{
		}

		[ExcludeFromCodeCoverage]
		public void RemoveAt(int index)
		{
		}

		[ExcludeFromCodeCoverage]
		public void Add(T item)
		{
		}

		[ExcludeFromCodeCoverage]
		public void Clear()
		{
		}

		public bool Contains(T item)
		{
			return false;
		}

		public void CopyTo(T[] array, int index)
		{
		}

		[ExcludeFromCodeCoverage]
		public bool Remove(T item)
		{
			return false;
		}

		[IteratorStateMachine(typeof(ListProvider<>._003CGetEnumerator_003Ed__20))]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
