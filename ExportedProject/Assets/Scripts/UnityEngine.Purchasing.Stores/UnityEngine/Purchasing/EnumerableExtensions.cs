using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	internal static class EnumerableExtensions
	{
		[CompilerGenerated]
		private sealed class _003CIgnoreExceptions_003Ed__1<T, TException> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where TException : Exception
		{
			private int _003C_003E1__state;

			private T _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private IEnumerable<T> enumerable;

			public IEnumerable<T> _003C_003E3__enumerable;

			private Action<TException> onException;

			public Action<TException> _003C_003E3__onException;

			private IEnumerator<T> _003Cenumerator_003E5__2;

			private bool _003ChasNext_003E5__3;

			T IEnumerator<T>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(T);
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
			public _003CIgnoreExceptions_003Ed__1(int _003C_003E1__state)
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

			[DebuggerHidden]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		public static IEnumerable<T> NonNull<T>(this IEnumerable<T> enumerable)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CIgnoreExceptions_003Ed__1<, >))]
		public static IEnumerable<T> IgnoreExceptions<T, TException>(this IEnumerable<T> enumerable, Action<TException> onException = null) where TException : Exception
		{
			return null;
		}
	}
}
