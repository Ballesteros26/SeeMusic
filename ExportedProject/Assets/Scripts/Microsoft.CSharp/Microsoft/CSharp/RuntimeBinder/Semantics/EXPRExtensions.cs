using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal static class EXPRExtensions
	{
		[CompilerGenerated]
		private sealed class _003CToEnumerable_003Ed__1 : IEnumerable<Expr>, IEnumerable, IEnumerator<Expr>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private Expr _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private Expr expr;

			public Expr _003C_003E3__expr;

			private ExprList _003Clist_003E5__2;

			Expr IEnumerator<Expr>.Current
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
			public _003CToEnumerable_003Ed__1(int _003C_003E1__state)
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

			[DebuggerHidden]
			IEnumerator<Expr> IEnumerable<Expr>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		public static Expr Map(this Expr expr, Func<Expr, Expr> f)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CToEnumerable_003Ed__1))]
		public static IEnumerable<Expr> ToEnumerable(this Expr expr)
		{
			return null;
		}

		public static bool isLvalue(this Expr expr)
		{
			return false;
		}

		public static bool isChecked(this Expr expr)
		{
			return false;
		}

		public static bool isNull(this Expr expr)
		{
			return false;
		}

		public static bool IsZero(this Expr expr)
		{
			return false;
		}

		private static Expr GetSeqVal(this Expr expr)
		{
			return null;
		}

		public static Expr GetConst(this Expr expr)
		{
			return null;
		}
	}
}
