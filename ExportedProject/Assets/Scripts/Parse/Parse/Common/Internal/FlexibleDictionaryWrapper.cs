using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Parse.Common.Internal
{
	[Preserve(AllMembers = true, Conditional = false)]
	public class FlexibleDictionaryWrapper<TOut, TIn> : IDictionary<string, TOut>, ICollection<KeyValuePair<string, TOut>>, IEnumerable<KeyValuePair<string, TOut>>, IEnumerable
	{
		[CompilerGenerated]
		private sealed class _003CGetEnumerator_003Ed__22 : IEnumerator<KeyValuePair<string, TOut>>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private KeyValuePair<string, TOut> _003C_003E2__current;

			public FlexibleDictionaryWrapper<TOut, TIn> _003C_003E4__this;

			private IEnumerator<KeyValuePair<string, TIn>> _003C_003E7__wrap1;

			KeyValuePair<string, TOut> IEnumerator<KeyValuePair<string, TOut>>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, TOut>);
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
			public _003CGetEnumerator_003Ed__22(int _003C_003E1__state)
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

		private readonly IDictionary<string, TIn> toWrap;

		public ICollection<string> Keys => null;

		public ICollection<TOut> Values => null;

		public TOut this[string key]
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

		public FlexibleDictionaryWrapper(IDictionary<string, TIn> toWrap)
		{
		}

		public void Add(string key, TOut value)
		{
		}

		public bool ContainsKey(string key)
		{
			return false;
		}

		public bool Remove(string key)
		{
			return false;
		}

		public bool TryGetValue(string key, out TOut value)
		{
			value = default(TOut);
			return false;
		}

		public void Add(KeyValuePair<string, TOut> item)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(KeyValuePair<string, TOut> item)
		{
			return false;
		}

		public void CopyTo(KeyValuePair<string, TOut>[] array, int arrayIndex)
		{
		}

		public bool Remove(KeyValuePair<string, TOut> item)
		{
			return false;
		}

		[IteratorStateMachine(typeof(FlexibleDictionaryWrapper<, >._003CGetEnumerator_003Ed__22))]
		public IEnumerator<KeyValuePair<string, TOut>> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
