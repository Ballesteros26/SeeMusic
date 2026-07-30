using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Namotion.Reflection
{
	public static class EnumerableExtensions
	{
		[CompilerGenerated]
		private sealed class _003CGetAssignableToTypeName_003Ed__0<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull
		{
			private int _003C_003E1__state;

			private T _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private IEnumerable<T> objects;

			public IEnumerable<T> _003C_003E3__objects;

			private string typeName;

			public string _003C_003E3__typeName;

			private TypeNameStyle typeNameStyle;

			public TypeNameStyle _003C_003E3__typeNameStyle;

			private IEnumerator<T> _003C_003E7__wrap1;

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
			public _003CGetAssignableToTypeName_003Ed__0(int _003C_003E1__state)
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

		[IteratorStateMachine(typeof(_003CGetAssignableToTypeName_003Ed__0<>))]
		public static IEnumerable<T> GetAssignableToTypeName<T>(this IEnumerable<T> objects, string typeName, TypeNameStyle typeNameStyle = TypeNameStyle.FullName) where T : notnull
		{
			return null;
		}

		public static T? FirstAssignableToTypeNameOrDefault<T>(this IEnumerable<T>? objects, string typeName, TypeNameStyle typeNameStyle = TypeNameStyle.FullName)
		{
			return default(T);
		}

		internal static T? GetSingleOrDefault<T>(this Attribute[] attributes)
		{
			return default(T);
		}
	}
}
