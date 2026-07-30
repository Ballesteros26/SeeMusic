using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Parse.Common.Internal
{
	[Preserve(AllMembers = true, Conditional = false)]
	public class FlexibleListWrapper<TOut, TIn> : IList<TOut>, ICollection<TOut>, IEnumerable<TOut>, IEnumerable
	{
		[CompilerGenerated]
		private sealed class _003CGetEnumerator_003Ed__17 : IEnumerator<TOut>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private TOut _003C_003E2__current;

			public FlexibleListWrapper<TOut, TIn> _003C_003E4__this;

			private IEnumerator _003C_003E7__wrap1;

			TOut IEnumerator<TOut>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(TOut);
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
			public _003CGetEnumerator_003Ed__17(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private IList<TIn> toWrap;

		public TOut this[int index]
		{
			get
			{
				return default(TOut);
			}
			set
			{
			}
		}

		public int Count => 0;

		public bool IsReadOnly => false;

		public FlexibleListWrapper(IList<TIn> toWrap)
		{
		}

		public int IndexOf(TOut item)
		{
			return 0;
		}

		public void Insert(int index, TOut item)
		{
		}

		public void RemoveAt(int index)
		{
		}

		public void Add(TOut item)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(TOut item)
		{
			return false;
		}

		public void CopyTo(TOut[] array, int arrayIndex)
		{
		}

		public bool Remove(TOut item)
		{
			return false;
		}

		[IteratorStateMachine(typeof(FlexibleListWrapper<, >._003CGetEnumerator_003Ed__17))]
		public IEnumerator<TOut> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
