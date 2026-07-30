using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Linq
{
	/// <summary>Provides a set of static (Shared in Visual Basic) methods for querying objects that implement <see cref="T:System.Collections.Generic.IEnumerable`1" />.</summary>
	public static class Enumerable
	{
		private abstract class Iterator<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
		{
			private int threadId;

			internal int state;

			internal TSource current;

			public TSource Current => default(TSource);

			object IEnumerator.Current => null;

			public Iterator()
			{
			}

			public abstract Iterator<TSource> Clone();

			public virtual void Dispose()
			{
			}

			public IEnumerator<TSource> GetEnumerator()
			{
				return null;
			}

			public abstract bool MoveNext();

			public abstract IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector);

			public abstract IEnumerable<TSource> Where(Func<TSource, bool> predicate);

			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			void IEnumerator.Reset()
			{
			}
		}

		private class WhereEnumerableIterator<TSource> : Iterator<TSource>
		{
			private IEnumerable<TSource> source;

			private Func<TSource, bool> predicate;

			private IEnumerator<TSource> enumerator;

			public WhereEnumerableIterator(IEnumerable<TSource> source, Func<TSource, bool> predicate)
			{
			}

			public override Iterator<TSource> Clone()
			{
				return null;
			}

			public override void Dispose()
			{
			}

			public override bool MoveNext()
			{
				return false;
			}

			public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector)
			{
				return null;
			}

			public override IEnumerable<TSource> Where(Func<TSource, bool> predicate)
			{
				return null;
			}
		}

		private class WhereArrayIterator<TSource> : Iterator<TSource>
		{
			private TSource[] source;

			private Func<TSource, bool> predicate;

			private int index;

			public WhereArrayIterator(TSource[] source, Func<TSource, bool> predicate)
			{
			}

			public override Iterator<TSource> Clone()
			{
				return null;
			}

			public override bool MoveNext()
			{
				return false;
			}

			public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector)
			{
				return null;
			}

			public override IEnumerable<TSource> Where(Func<TSource, bool> predicate)
			{
				return null;
			}
		}

		private class WhereListIterator<TSource> : Iterator<TSource>
		{
			private List<TSource> source;

			private Func<TSource, bool> predicate;

			private List<TSource>.Enumerator enumerator;

			public WhereListIterator(List<TSource> source, Func<TSource, bool> predicate)
			{
			}

			public override Iterator<TSource> Clone()
			{
				return null;
			}

			public override bool MoveNext()
			{
				return false;
			}

			public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector)
			{
				return null;
			}

			public override IEnumerable<TSource> Where(Func<TSource, bool> predicate)
			{
				return null;
			}
		}

		private class WhereSelectEnumerableIterator<TSource, TResult> : Iterator<TResult>
		{
			private IEnumerable<TSource> source;

			private Func<TSource, bool> predicate;

			private Func<TSource, TResult> selector;

			private IEnumerator<TSource> enumerator;

			public WhereSelectEnumerableIterator(IEnumerable<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> selector)
			{
			}

			public override Iterator<TResult> Clone()
			{
				return null;
			}

			public override void Dispose()
			{
			}

			public override bool MoveNext()
			{
				return false;
			}

			public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector)
			{
				return null;
			}

			public override IEnumerable<TResult> Where(Func<TResult, bool> predicate)
			{
				return null;
			}
		}

		private class WhereSelectArrayIterator<TSource, TResult> : Iterator<TResult>
		{
			private TSource[] source;

			private Func<TSource, bool> predicate;

			private Func<TSource, TResult> selector;

			private int index;

			public WhereSelectArrayIterator(TSource[] source, Func<TSource, bool> predicate, Func<TSource, TResult> selector)
			{
			}

			public override Iterator<TResult> Clone()
			{
				return null;
			}

			public override bool MoveNext()
			{
				return false;
			}

			public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector)
			{
				return null;
			}

			public override IEnumerable<TResult> Where(Func<TResult, bool> predicate)
			{
				return null;
			}
		}

		private class WhereSelectListIterator<TSource, TResult> : Iterator<TResult>
		{
			private List<TSource> source;

			private Func<TSource, bool> predicate;

			private Func<TSource, TResult> selector;

			private List<TSource>.Enumerator enumerator;

			public WhereSelectListIterator(List<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> selector)
			{
			}

			public override Iterator<TResult> Clone()
			{
				return null;
			}

			public override bool MoveNext()
			{
				return false;
			}

			public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector)
			{
				return null;
			}

			public override IEnumerable<TResult> Where(Func<TResult, bool> predicate)
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CWhereIterator_003Ed__2<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private TSource _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private IEnumerable<TSource> source;

			public IEnumerable<TSource> _003C_003E3__source;

			private Func<TSource, int, bool> predicate;

			public Func<TSource, int, bool> _003C_003E3__predicate;

			private int _003Cindex_003E5__2;

			private IEnumerator<TSource> _003C_003E7__wrap2;

			TSource IEnumerator<TSource>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(TSource);
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
			public _003CWhereIterator_003Ed__2(int _003C_003E1__state)
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
			IEnumerator<TSource> IEnumerable<TSource>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CSelectIterator_003Ed__5<TSource, TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private TResult _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private IEnumerable<TSource> source;

			public IEnumerable<TSource> _003C_003E3__source;

			private Func<TSource, int, TResult> selector;

			public Func<TSource, int, TResult> _003C_003E3__selector;

			private int _003Cindex_003E5__2;

			private IEnumerator<TSource> _003C_003E7__wrap2;

			TResult IEnumerator<TResult>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(TResult);
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
			public _003CSelectIterator_003Ed__5(int _003C_003E1__state)
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
			IEnumerator<TResult> IEnumerable<TResult>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CSelectManyIterator_003Ed__17<TSource, TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private TResult _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private IEnumerable<TSource> source;

			public IEnumerable<TSource> _003C_003E3__source;

			private Func<TSource, IEnumerable<TResult>> selector;

			public Func<TSource, IEnumerable<TResult>> _003C_003E3__selector;

			private IEnumerator<TSource> _003C_003E7__wrap1;

			private IEnumerator<TResult> _003C_003E7__wrap2;

			TResult IEnumerator<TResult>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(TResult);
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
			public _003CSelectManyIterator_003Ed__17(int _003C_003E1__state)
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

			private void _003C_003Em__Finally2()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<TResult> IEnumerable<TResult>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CSelectManyIterator_003Ed__23<TSource, TCollection, TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private TResult _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private IEnumerable<TSource> source;

			public IEnumerable<TSource> _003C_003E3__source;

			private Func<TSource, IEnumerable<TCollection>> collectionSelector;

			public Func<TSource, IEnumerable<TCollection>> _003C_003E3__collectionSelector;

			private Func<TSource, TCollection, TResult> resultSelector;

			public Func<TSource, TCollection, TResult> _003C_003E3__resultSelector;

			private IEnumerator<TSource> _003C_003E7__wrap1;

			private TSource _003Celement_003E5__3;

			private IEnumerator<TCollection> _003C_003E7__wrap3;

			TResult IEnumerator<TResult>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(TResult);
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
			public _003CSelectManyIterator_003Ed__23(int _003C_003E1__state)
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

			private void _003C_003Em__Finally2()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<TResult> IEnumerable<TResult>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CTakeIterator_003Ed__25<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private TSource _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private int count;

			public int _003C_003E3__count;

			private IEnumerable<TSource> source;

			public IEnumerable<TSource> _003C_003E3__source;

			private IEnumerator<TSource> _003C_003E7__wrap1;

			TSource IEnumerator<TSource>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(TSource);
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
			public _003CTakeIterator_003Ed__25(int _003C_003E1__state)
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
			IEnumerator<TSource> IEnumerable<TSource>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CSkipIterator_003Ed__31<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private TSource _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private IEnumerable<TSource> source;

			public IEnumerable<TSource> _003C_003E3__source;

			private int count;

			public int _003C_003E3__count;

			private IEnumerator<TSource> _003Ce_003E5__2;

			TSource IEnumerator<TSource>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(TSource);
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
			public _003CSkipIterator_003Ed__31(int _003C_003E1__state)
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
			IEnumerator<TSource> IEnumerable<TSource>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CJoinIterator_003Ed__38<TOuter, TInner, TKey, TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private TResult _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private IEnumerable<TInner> inner;

			public IEnumerable<TInner> _003C_003E3__inner;

			private Func<TInner, TKey> innerKeySelector;

			public Func<TInner, TKey> _003C_003E3__innerKeySelector;

			private IEqualityComparer<TKey> comparer;

			public IEqualityComparer<TKey> _003C_003E3__comparer;

			private IEnumerable<TOuter> outer;

			public IEnumerable<TOuter> _003C_003E3__outer;

			private Func<TOuter, TKey> outerKeySelector;

			public Func<TOuter, TKey> _003C_003E3__outerKeySelector;

			private Func<TOuter, TInner, TResult> resultSelector;

			public Func<TOuter, TInner, TResult> _003C_003E3__resultSelector;

			private Lookup<TKey, TInner> _003Clookup_003E5__2;

			private IEnumerator<TOuter> _003C_003E7__wrap2;

			private TOuter _003Citem_003E5__4;

			private Lookup<TKey, TInner>.Grouping _003Cg_003E5__5;

			private int _003Ci_003E5__6;

			TResult IEnumerator<TResult>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(TResult);
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
			public _003CJoinIterator_003Ed__38(int _003C_003E1__state)
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
			IEnumerator<TResult> IEnumerable<TResult>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CConcatIterator_003Ed__59<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private TSource _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private IEnumerable<TSource> first;

			public IEnumerable<TSource> _003C_003E3__first;

			private IEnumerable<TSource> second;

			public IEnumerable<TSource> _003C_003E3__second;

			private IEnumerator<TSource> _003C_003E7__wrap1;

			TSource IEnumerator<TSource>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(TSource);
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
			public _003CConcatIterator_003Ed__59(int _003C_003E1__state)
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

			private void _003C_003Em__Finally2()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<TSource> IEnumerable<TSource>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CZipIterator_003Ed__65<TFirst, TSecond, TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private TResult _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private IEnumerable<TFirst> first;

			public IEnumerable<TFirst> _003C_003E3__first;

			private IEnumerable<TSecond> second;

			public IEnumerable<TSecond> _003C_003E3__second;

			private Func<TFirst, TSecond, TResult> resultSelector;

			public Func<TFirst, TSecond, TResult> _003C_003E3__resultSelector;

			private IEnumerator<TFirst> _003Ce1_003E5__2;

			private IEnumerator<TSecond> _003Ce2_003E5__3;

			TResult IEnumerator<TResult>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(TResult);
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
			public _003CZipIterator_003Ed__65(int _003C_003E1__state)
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

			private void _003C_003Em__Finally2()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<TResult> IEnumerable<TResult>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CDistinctIterator_003Ed__68<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private TSource _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private IEqualityComparer<TSource> comparer;

			public IEqualityComparer<TSource> _003C_003E3__comparer;

			private IEnumerable<TSource> source;

			public IEnumerable<TSource> _003C_003E3__source;

			private Set<TSource> _003Cset_003E5__2;

			private IEnumerator<TSource> _003C_003E7__wrap2;

			TSource IEnumerator<TSource>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(TSource);
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
			public _003CDistinctIterator_003Ed__68(int _003C_003E1__state)
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
			IEnumerator<TSource> IEnumerable<TSource>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CUnionIterator_003Ed__71<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private TSource _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private IEqualityComparer<TSource> comparer;

			public IEqualityComparer<TSource> _003C_003E3__comparer;

			private IEnumerable<TSource> first;

			public IEnumerable<TSource> _003C_003E3__first;

			private IEnumerable<TSource> second;

			public IEnumerable<TSource> _003C_003E3__second;

			private Set<TSource> _003Cset_003E5__2;

			private IEnumerator<TSource> _003C_003E7__wrap2;

			TSource IEnumerator<TSource>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(TSource);
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
			public _003CUnionIterator_003Ed__71(int _003C_003E1__state)
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

			private void _003C_003Em__Finally2()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<TSource> IEnumerable<TSource>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CExceptIterator_003Ed__77<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private TSource _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private IEqualityComparer<TSource> comparer;

			public IEqualityComparer<TSource> _003C_003E3__comparer;

			private IEnumerable<TSource> second;

			public IEnumerable<TSource> _003C_003E3__second;

			private IEnumerable<TSource> first;

			public IEnumerable<TSource> _003C_003E3__first;

			private Set<TSource> _003Cset_003E5__2;

			private IEnumerator<TSource> _003C_003E7__wrap2;

			TSource IEnumerator<TSource>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(TSource);
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
			public _003CExceptIterator_003Ed__77(int _003C_003E1__state)
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
			IEnumerator<TSource> IEnumerable<TSource>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003COfTypeIterator_003Ed__97<TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private TResult _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private IEnumerable source;

			public IEnumerable _003C_003E3__source;

			private IEnumerator _003C_003E7__wrap1;

			TResult IEnumerator<TResult>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(TResult);
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
			public _003COfTypeIterator_003Ed__97(int _003C_003E1__state)
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
			IEnumerator<TResult> IEnumerable<TResult>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CCastIterator_003Ed__99<TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private TResult _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private IEnumerable source;

			public IEnumerable _003C_003E3__source;

			private IEnumerator _003C_003E7__wrap1;

			TResult IEnumerator<TResult>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(TResult);
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
			public _003CCastIterator_003Ed__99(int _003C_003E1__state)
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
			IEnumerator<TResult> IEnumerable<TResult>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CRangeIterator_003Ed__115 : IEnumerable<int>, IEnumerable, IEnumerator<int>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private int _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private int start;

			public int _003C_003E3__start;

			private int count;

			public int _003C_003E3__count;

			private int _003Ci_003E5__2;

			int IEnumerator<int>.Current
			{
				[DebuggerHidden]
				get
				{
					return 0;
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
			public _003CRangeIterator_003Ed__115(int _003C_003E1__state)
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
			IEnumerator<int> IEnumerable<int>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		/// <summary>Filters a sequence of values based on a predicate.</summary>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains elements from the input sequence that satisfy the condition.</returns>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to filter.</param>
		/// <param name="predicate">A function to test each element for a condition.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> or <paramref name="predicate" /> is null.</exception>
		public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return null;
		}

		/// <summary>Filters a sequence of values based on a predicate. Each element's index is used in the logic of the predicate function.</summary>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains elements from the input sequence that satisfy the condition.</returns>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to filter.</param>
		/// <param name="predicate">A function to test each source element for a condition; the second parameter of the function represents the index of the source element.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> or <paramref name="predicate" /> is null.</exception>
		public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CWhereIterator_003Ed__2<>))]
		private static IEnumerable<TSource> WhereIterator<TSource>(IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
		{
			return null;
		}

		/// <summary>Projects each element of a sequence into a new form.</summary>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> whose elements are the result of invoking the transform function on each element of <paramref name="source" />.</returns>
		/// <param name="source">A sequence of values to invoke a transform function on.</param>
		/// <param name="selector">A transform function to apply to each element.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <typeparam name="TResult">The type of the value returned by <paramref name="selector" />.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> or <paramref name="selector" /> is null.</exception>
		public static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
		{
			return null;
		}

		/// <summary>Projects each element of a sequence into a new form by incorporating the element's index.</summary>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> whose elements are the result of invoking the transform function on each element of <paramref name="source" />.</returns>
		/// <param name="source">A sequence of values to invoke a transform function on.</param>
		/// <param name="selector">A transform function to apply to each source element; the second parameter of the function represents the index of the source element.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <typeparam name="TResult">The type of the value returned by <paramref name="selector" />.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> or <paramref name="selector" /> is null.</exception>
		public static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, int, TResult> selector)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CSelectIterator_003Ed__5<, >))]
		private static IEnumerable<TResult> SelectIterator<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, int, TResult> selector)
		{
			return null;
		}

		private static Func<TSource, bool> CombinePredicates<TSource>(Func<TSource, bool> predicate1, Func<TSource, bool> predicate2)
		{
			return null;
		}

		private static Func<TSource, TResult> CombineSelectors<TSource, TMiddle, TResult>(Func<TSource, TMiddle> selector1, Func<TMiddle, TResult> selector2)
		{
			return null;
		}

		/// <summary>Projects each element of a sequence to an <see cref="T:System.Collections.Generic.IEnumerable`1" /> and flattens the resulting sequences into one sequence.</summary>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> whose elements are the result of invoking the one-to-many transform function on each element of the input sequence.</returns>
		/// <param name="source">A sequence of values to project.</param>
		/// <param name="selector">A transform function to apply to each element.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <typeparam name="TResult">The type of the elements of the sequence returned by <paramref name="selector" />.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> or <paramref name="selector" /> is null.</exception>
		public static IEnumerable<TResult> SelectMany<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CSelectManyIterator_003Ed__17<, >))]
		private static IEnumerable<TResult> SelectManyIterator<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector)
		{
			return null;
		}

		/// <summary>Projects each element of a sequence to an <see cref="T:System.Collections.Generic.IEnumerable`1" />, flattens the resulting sequences into one sequence, and invokes a result selector function on each element therein.</summary>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> whose elements are the result of invoking the one-to-many transform function <paramref name="collectionSelector" /> on each element of <paramref name="source" /> and then mapping each of those sequence elements and their corresponding source element to a result element.</returns>
		/// <param name="source">A sequence of values to project.</param>
		/// <param name="collectionSelector">A transform function to apply to each element of the input sequence.</param>
		/// <param name="resultSelector">A transform function to apply to each element of the intermediate sequence.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <typeparam name="TCollection">The type of the intermediate elements collected by <paramref name="collectionSelector" />.</typeparam>
		/// <typeparam name="TResult">The type of the elements of the resulting sequence.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> or <paramref name="collectionSelector" /> or <paramref name="resultSelector" /> is null.</exception>
		public static IEnumerable<TResult> SelectMany<TSource, TCollection, TResult>(this IEnumerable<TSource> source, Func<TSource, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CSelectManyIterator_003Ed__23<, , >))]
		private static IEnumerable<TResult> SelectManyIterator<TSource, TCollection, TResult>(IEnumerable<TSource> source, Func<TSource, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector)
		{
			return null;
		}

		/// <summary>Returns a specified number of contiguous elements from the start of a sequence.</summary>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains the specified number of elements from the start of the input sequence.</returns>
		/// <param name="source">The sequence to return elements from.</param>
		/// <param name="count">The number of elements to return.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> is null.</exception>
		public static IEnumerable<TSource> Take<TSource>(this IEnumerable<TSource> source, int count)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CTakeIterator_003Ed__25<>))]
		private static IEnumerable<TSource> TakeIterator<TSource>(IEnumerable<TSource> source, int count)
		{
			return null;
		}

		/// <summary>Bypasses a specified number of elements in a sequence and then returns the remaining elements.</summary>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains the elements that occur after the specified index in the input sequence.</returns>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to return elements from.</param>
		/// <param name="count">The number of elements to skip before returning the remaining elements.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> is null.</exception>
		public static IEnumerable<TSource> Skip<TSource>(this IEnumerable<TSource> source, int count)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CSkipIterator_003Ed__31<>))]
		private static IEnumerable<TSource> SkipIterator<TSource>(IEnumerable<TSource> source, int count)
		{
			return null;
		}

		/// <summary>Correlates the elements of two sequences based on matching keys. The default equality comparer is used to compare keys.</summary>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that has elements of type <paramref name="TResult" /> that are obtained by performing an inner join on two sequences.</returns>
		/// <param name="outer">The first sequence to join.</param>
		/// <param name="inner">The sequence to join to the first sequence.</param>
		/// <param name="outerKeySelector">A function to extract the join key from each element of the first sequence.</param>
		/// <param name="innerKeySelector">A function to extract the join key from each element of the second sequence.</param>
		/// <param name="resultSelector">A function to create a result element from two matching elements.</param>
		/// <typeparam name="TOuter">The type of the elements of the first sequence.</typeparam>
		/// <typeparam name="TInner">The type of the elements of the second sequence.</typeparam>
		/// <typeparam name="TKey">The type of the keys returned by the key selector functions.</typeparam>
		/// <typeparam name="TResult">The type of the result elements.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="outer" /> or <paramref name="inner" /> or <paramref name="outerKeySelector" /> or <paramref name="innerKeySelector" /> or <paramref name="resultSelector" /> is null.</exception>
		public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, TResult> resultSelector)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CJoinIterator_003Ed__38<, , , >))]
		private static IEnumerable<TResult> JoinIterator<TOuter, TInner, TKey, TResult>(IEnumerable<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, TResult> resultSelector, IEqualityComparer<TKey> comparer)
		{
			return null;
		}

		/// <summary>Sorts the elements of a sequence in ascending order according to a key.</summary>
		/// <returns>An <see cref="T:System.Linq.IOrderedEnumerable`1" /> whose elements are sorted according to a key.</returns>
		/// <param name="source">A sequence of values to order.</param>
		/// <param name="keySelector">A function to extract a key from an element.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <typeparam name="TKey">The type of the key returned by <paramref name="keySelector" />.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> or <paramref name="keySelector" /> is null.</exception>
		public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			return null;
		}

		/// <summary>Sorts the elements of a sequence in descending order according to a key.</summary>
		/// <returns>An <see cref="T:System.Linq.IOrderedEnumerable`1" /> whose elements are sorted in descending order according to a key.</returns>
		/// <param name="source">A sequence of values to order.</param>
		/// <param name="keySelector">A function to extract a key from an element.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <typeparam name="TKey">The type of the key returned by <paramref name="keySelector" />.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> or <paramref name="keySelector" /> is null.</exception>
		public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			return null;
		}

		/// <summary>Performs a subsequent ordering of the elements in a sequence in ascending order according to a key.</summary>
		/// <returns>An <see cref="T:System.Linq.IOrderedEnumerable`1" /> whose elements are sorted according to a key.</returns>
		/// <param name="source">An <see cref="T:System.Linq.IOrderedEnumerable`1" /> that contains elements to sort.</param>
		/// <param name="keySelector">A function to extract a key from each element.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <typeparam name="TKey">The type of the key returned by <paramref name="keySelector" />.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> or <paramref name="keySelector" /> is null.</exception>
		public static IOrderedEnumerable<TSource> ThenBy<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			return null;
		}

		/// <summary>Groups the elements of a sequence according to a specified key selector function.</summary>
		/// <returns>An IEnumerable&lt;IGrouping&lt;TKey, TSource&gt;&gt; in C# or IEnumerable(Of IGrouping(Of TKey, TSource)) in Visual Basic where each <see cref="T:System.Linq.IGrouping`2" /> object contains a sequence of objects and a key.</returns>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> whose elements to group.</param>
		/// <param name="keySelector">A function to extract the key for each element.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <typeparam name="TKey">The type of the key returned by <paramref name="keySelector" />.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> or <paramref name="keySelector" /> is null.</exception>
		public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			return null;
		}

		/// <summary>Groups the elements of a sequence according to a specified key selector function and projects the elements for each group by using a specified function.</summary>
		/// <returns>An IEnumerable&lt;IGrouping&lt;TKey, TElement&gt;&gt; in C# or IEnumerable(Of IGrouping(Of TKey, TElement)) in Visual Basic where each <see cref="T:System.Linq.IGrouping`2" /> object contains a collection of objects of type <paramref name="TElement" /> and a key.</returns>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> whose elements to group.</param>
		/// <param name="keySelector">A function to extract the key for each element.</param>
		/// <param name="elementSelector">A function to map each source element to an element in the <see cref="T:System.Linq.IGrouping`2" />.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <typeparam name="TKey">The type of the key returned by <paramref name="keySelector" />.</typeparam>
		/// <typeparam name="TElement">The type of the elements in the <see cref="T:System.Linq.IGrouping`2" />.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> or <paramref name="keySelector" /> or <paramref name="elementSelector" /> is null.</exception>
		public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
		{
			return null;
		}

		/// <summary>Concatenates two sequences.</summary>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains the concatenated elements of the two input sequences.</returns>
		/// <param name="first">The first sequence to concatenate.</param>
		/// <param name="second">The sequence to concatenate to the first sequence.</param>
		/// <typeparam name="TSource">The type of the elements of the input sequences.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="first" /> or <paramref name="second" /> is null.</exception>
		public static IEnumerable<TSource> Concat<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CConcatIterator_003Ed__59<>))]
		private static IEnumerable<TSource> ConcatIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second)
		{
			return null;
		}

		/// <summary>Applies a specified function to the corresponding elements of two sequences, producing a sequence of the results.</summary>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains merged elements of two input sequences.</returns>
		/// <param name="first">The first sequence to merge.</param>
		/// <param name="second">The second sequence to merge.</param>
		/// <param name="resultSelector">A function that specifies how to merge the elements from the two sequences.</param>
		/// <typeparam name="TFirst">The type of the elements of the first input sequence.</typeparam>
		/// <typeparam name="TSecond">The type of the elements of the second input sequence.</typeparam>
		/// <typeparam name="TResult">The type of the elements of the result sequence.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="first" /> or <paramref name="second" /> is null.</exception>
		public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this IEnumerable<TFirst> first, IEnumerable<TSecond> second, Func<TFirst, TSecond, TResult> resultSelector)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CZipIterator_003Ed__65<, , >))]
		private static IEnumerable<TResult> ZipIterator<TFirst, TSecond, TResult>(IEnumerable<TFirst> first, IEnumerable<TSecond> second, Func<TFirst, TSecond, TResult> resultSelector)
		{
			return null;
		}

		/// <summary>Returns distinct elements from a sequence by using the default equality comparer to compare values.</summary>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains distinct elements from the source sequence.</returns>
		/// <param name="source">The sequence to remove duplicate elements from.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> is null.</exception>
		public static IEnumerable<TSource> Distinct<TSource>(this IEnumerable<TSource> source)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CDistinctIterator_003Ed__68<>))]
		private static IEnumerable<TSource> DistinctIterator<TSource>(IEnumerable<TSource> source, IEqualityComparer<TSource> comparer)
		{
			return null;
		}

		/// <summary>Produces the set union of two sequences by using the default equality comparer.</summary>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains the elements from both input sequences, excluding duplicates.</returns>
		/// <param name="first">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> whose distinct elements form the first set for the union.</param>
		/// <param name="second">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> whose distinct elements form the second set for the union.</param>
		/// <typeparam name="TSource">The type of the elements of the input sequences.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="first" /> or <paramref name="second" /> is null.</exception>
		public static IEnumerable<TSource> Union<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CUnionIterator_003Ed__71<>))]
		private static IEnumerable<TSource> UnionIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
		{
			return null;
		}

		/// <summary>Produces the set difference of two sequences by using the default equality comparer to compare values.</summary>
		/// <returns>A sequence that contains the set difference of the elements of two sequences.</returns>
		/// <param name="first">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> whose elements that are not also in <paramref name="second" /> will be returned.</param>
		/// <param name="second">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> whose elements that also occur in the first sequence will cause those elements to be removed from the returned sequence.</param>
		/// <typeparam name="TSource">The type of the elements of the input sequences.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="first" /> or <paramref name="second" /> is null.</exception>
		public static IEnumerable<TSource> Except<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
		{
			return null;
		}

		/// <summary>Produces the set difference of two sequences by using the specified <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> to compare values.</summary>
		/// <returns>A sequence that contains the set difference of the elements of two sequences.</returns>
		/// <param name="first">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> whose elements that are not also in <paramref name="second" /> will be returned.</param>
		/// <param name="second">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> whose elements that also occur in the first sequence will cause those elements to be removed from the returned sequence.</param>
		/// <param name="comparer">An <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> to compare values.</param>
		/// <typeparam name="TSource">The type of the elements of the input sequences.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="first" /> or <paramref name="second" /> is null.</exception>
		public static IEnumerable<TSource> Except<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CExceptIterator_003Ed__77<>))]
		private static IEnumerable<TSource> ExceptIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
		{
			return null;
		}

		/// <summary>Determines whether two sequences are equal by comparing the elements by using the default equality comparer for their type.</summary>
		/// <returns>true if the two source sequences are of equal length and their corresponding elements are equal according to the default equality comparer for their type; otherwise, false.</returns>
		/// <param name="first">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to compare to <paramref name="second" />.</param>
		/// <param name="second">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to compare to the first sequence.</param>
		/// <typeparam name="TSource">The type of the elements of the input sequences.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="first" /> or <paramref name="second" /> is null.</exception>
		public static bool SequenceEqual<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
		{
			return false;
		}

		/// <summary>Determines whether two sequences are equal by comparing their elements by using a specified <see cref="T:System.Collections.Generic.IEqualityComparer`1" />.</summary>
		/// <returns>true if the two source sequences are of equal length and their corresponding elements compare equal according to <paramref name="comparer" />; otherwise, false.</returns>
		/// <param name="first">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to compare to <paramref name="second" />.</param>
		/// <param name="second">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to compare to the first sequence.</param>
		/// <param name="comparer">An <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> to use to compare elements.</param>
		/// <typeparam name="TSource">The type of the elements of the input sequences.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="first" /> or <paramref name="second" /> is null.</exception>
		public static bool SequenceEqual<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
		{
			return false;
		}

		/// <summary>Creates an array from a <see cref="T:System.Collections.Generic.IEnumerable`1" />.</summary>
		/// <returns>An array that contains the elements from the input sequence.</returns>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to create an array from.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> is null.</exception>
		public static TSource[] ToArray<TSource>(this IEnumerable<TSource> source)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Collections.Generic.List`1" /> from an <see cref="T:System.Collections.Generic.IEnumerable`1" />.</summary>
		/// <returns>A <see cref="T:System.Collections.Generic.List`1" /> that contains elements from the input sequence.</returns>
		/// <param name="source">The <see cref="T:System.Collections.Generic.IEnumerable`1" /> to create a <see cref="T:System.Collections.Generic.List`1" /> from.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> is null.</exception>
		public static List<TSource> ToList<TSource>(this IEnumerable<TSource> source)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Collections.Generic.Dictionary`2" /> from an <see cref="T:System.Collections.Generic.IEnumerable`1" /> according to a specified key selector function.</summary>
		/// <returns>A <see cref="T:System.Collections.Generic.Dictionary`2" /> that contains keys and values.</returns>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to create a <see cref="T:System.Collections.Generic.Dictionary`2" /> from.</param>
		/// <param name="keySelector">A function to extract a key from each element.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <typeparam name="TKey">The type of the key returned by <paramref name="keySelector" />.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> or <paramref name="keySelector" /> is null.-or-<paramref name="keySelector" /> produces a key that is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="keySelector" /> produces duplicate keys for two elements.</exception>
		public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Collections.Generic.Dictionary`2" /> from an <see cref="T:System.Collections.Generic.IEnumerable`1" /> according to specified key selector and element selector functions.</summary>
		/// <returns>A <see cref="T:System.Collections.Generic.Dictionary`2" /> that contains values of type <paramref name="TElement" /> selected from the input sequence.</returns>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to create a <see cref="T:System.Collections.Generic.Dictionary`2" /> from.</param>
		/// <param name="keySelector">A function to extract a key from each element.</param>
		/// <param name="elementSelector">A transform function to produce a result element value from each element.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <typeparam name="TKey">The type of the key returned by <paramref name="keySelector" />.</typeparam>
		/// <typeparam name="TElement">The type of the value returned by <paramref name="elementSelector" />.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> or <paramref name="keySelector" /> or <paramref name="elementSelector" /> is null.-or-<paramref name="keySelector" /> produces a key that is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="keySelector" /> produces duplicate keys for two elements.</exception>
		public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Collections.Generic.Dictionary`2" /> from an <see cref="T:System.Collections.Generic.IEnumerable`1" /> according to a specified key selector function, a comparer, and an element selector function.</summary>
		/// <returns>A <see cref="T:System.Collections.Generic.Dictionary`2" /> that contains values of type <paramref name="TElement" /> selected from the input sequence.</returns>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to create a <see cref="T:System.Collections.Generic.Dictionary`2" /> from.</param>
		/// <param name="keySelector">A function to extract a key from each element.</param>
		/// <param name="elementSelector">A transform function to produce a result element value from each element.</param>
		/// <param name="comparer">An <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> to compare keys.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <typeparam name="TKey">The type of the key returned by <paramref name="keySelector" />.</typeparam>
		/// <typeparam name="TElement">The type of the value returned by <paramref name="elementSelector" />.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> or <paramref name="keySelector" /> or <paramref name="elementSelector" /> is null.-or-<paramref name="keySelector" /> produces a key that is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="keySelector" /> produces duplicate keys for two elements.</exception>
		public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
		{
			return null;
		}

		/// <summary>Filters the elements of an <see cref="T:System.Collections.IEnumerable" /> based on a specified type.</summary>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains elements from the input sequence of type <paramref name="TResult" />.</returns>
		/// <param name="source">The <see cref="T:System.Collections.IEnumerable" /> whose elements to filter.</param>
		/// <typeparam name="TResult">The type to filter the elements of the sequence on.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> is null.</exception>
		public static IEnumerable<TResult> OfType<TResult>(this IEnumerable source)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003COfTypeIterator_003Ed__97<>))]
		private static IEnumerable<TResult> OfTypeIterator<TResult>(IEnumerable source)
		{
			return null;
		}

		/// <summary>Casts the elements of an <see cref="T:System.Collections.IEnumerable" /> to the specified type.</summary>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains each element of the source sequence cast to the specified type.</returns>
		/// <param name="source">The <see cref="T:System.Collections.IEnumerable" /> that contains the elements to be cast to type <paramref name="TResult" />.</param>
		/// <typeparam name="TResult">The type to cast the elements of <paramref name="source" /> to.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> is null.</exception>
		/// <exception cref="T:System.InvalidCastException">An element in the sequence cannot be cast to type <paramref name="TResult" />.</exception>
		public static IEnumerable<TResult> Cast<TResult>(this IEnumerable source)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCastIterator_003Ed__99<>))]
		private static IEnumerable<TResult> CastIterator<TResult>(IEnumerable source)
		{
			return null;
		}

		/// <summary>Returns the first element of a sequence.</summary>
		/// <returns>The first element in the specified sequence.</returns>
		/// <param name="source">The <see cref="T:System.Collections.Generic.IEnumerable`1" /> to return the first element of.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> is null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The source sequence is empty.</exception>
		public static TSource First<TSource>(this IEnumerable<TSource> source)
		{
			return default(TSource);
		}

		/// <summary>Returns the first element in a sequence that satisfies a specified condition.</summary>
		/// <returns>The first element in the sequence that passes the test in the specified predicate function.</returns>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to return an element from.</param>
		/// <param name="predicate">A function to test each element for a condition.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> or <paramref name="predicate" /> is null.</exception>
		/// <exception cref="T:System.InvalidOperationException">No element satisfies the condition in <paramref name="predicate" />.-or-The source sequence is empty.</exception>
		public static TSource First<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return default(TSource);
		}

		/// <summary>Returns the first element of a sequence, or a default value if the sequence contains no elements.</summary>
		/// <returns>default(<paramref name="TSource" />) if <paramref name="source" /> is empty; otherwise, the first element in <paramref name="source" />.</returns>
		/// <param name="source">The <see cref="T:System.Collections.Generic.IEnumerable`1" /> to return the first element of.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> is null.</exception>
		public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source)
		{
			return default(TSource);
		}

		/// <summary>Returns the first element of the sequence that satisfies a condition or a default value if no such element is found.</summary>
		/// <returns>default(<paramref name="TSource" />) if <paramref name="source" /> is empty or if no element passes the test specified by <paramref name="predicate" />; otherwise, the first element in <paramref name="source" /> that passes the test specified by <paramref name="predicate" />.</returns>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to return an element from.</param>
		/// <param name="predicate">A function to test each element for a condition.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> or <paramref name="predicate" /> is null.</exception>
		public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return default(TSource);
		}

		/// <summary>Returns the last element of a sequence.</summary>
		/// <returns>The value at the last position in the source sequence.</returns>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to return the last element of.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> is null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The source sequence is empty.</exception>
		public static TSource Last<TSource>(this IEnumerable<TSource> source)
		{
			return default(TSource);
		}

		/// <summary>Returns the last element of a sequence that satisfies a condition or a default value if no such element is found.</summary>
		/// <returns>default(<paramref name="TSource" />) if the sequence is empty or if no elements pass the test in the predicate function; otherwise, the last element that passes the test in the predicate function.</returns>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to return an element from.</param>
		/// <param name="predicate">A function to test each element for a condition.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> or <paramref name="predicate" /> is null.</exception>
		public static TSource LastOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return default(TSource);
		}

		/// <summary>Returns the only element of a sequence, and throws an exception if there is not exactly one element in the sequence.</summary>
		/// <returns>The single element of the input sequence.</returns>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to return the single element of.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> is null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The input sequence contains more than one element.-or-The input sequence is empty.</exception>
		public static TSource Single<TSource>(this IEnumerable<TSource> source)
		{
			return default(TSource);
		}

		/// <summary>Returns the only element of a sequence that satisfies a specified condition, and throws an exception if more than one such element exists.</summary>
		/// <returns>The single element of the input sequence that satisfies a condition.</returns>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to return a single element from.</param>
		/// <param name="predicate">A function to test an element for a condition.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> or <paramref name="predicate" /> is null.</exception>
		/// <exception cref="T:System.InvalidOperationException">No element satisfies the condition in <paramref name="predicate" />.-or-More than one element satisfies the condition in <paramref name="predicate" />.-or-The source sequence is empty.</exception>
		public static TSource Single<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return default(TSource);
		}

		/// <summary>Returns the only element of a sequence, or a default value if the sequence is empty; this method throws an exception if there is more than one element in the sequence.</summary>
		/// <returns>The single element of the input sequence, or default(<paramref name="TSource" />) if the sequence contains no elements.</returns>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to return the single element of.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> is null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The input sequence contains more than one element.</exception>
		public static TSource SingleOrDefault<TSource>(this IEnumerable<TSource> source)
		{
			return default(TSource);
		}

		/// <summary>Returns the only element of a sequence that satisfies a specified condition or a default value if no such element exists; this method throws an exception if more than one element satisfies the condition.</summary>
		/// <returns>The single element of the input sequence that satisfies the condition, or default(<paramref name="TSource" />) if no such element is found.</returns>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to return a single element from.</param>
		/// <param name="predicate">A function to test an element for a condition.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> or <paramref name="predicate" /> is null.</exception>
		public static TSource SingleOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return default(TSource);
		}

		/// <summary>Returns the element at a specified index in a sequence.</summary>
		/// <returns>The element at the specified position in the source sequence.</returns>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to return an element from.</param>
		/// <param name="index">The zero-based index of the element to retrieve.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> is less than 0 or greater than or equal to the number of elements in <paramref name="source" />.</exception>
		public static TSource ElementAt<TSource>(this IEnumerable<TSource> source, int index)
		{
			return default(TSource);
		}

		/// <summary>Generates a sequence of integral numbers within a specified range.</summary>
		/// <returns>An IEnumerable&lt;Int32&gt; in C# or IEnumerable(Of Int32) in Visual Basic that contains a range of sequential integral numbers.</returns>
		/// <param name="start">The value of the first integer in the sequence.</param>
		/// <param name="count">The number of sequential integers to generate.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="count" /> is less than 0.-or-<paramref name="start" /> + <paramref name="count" /> -1 is larger than <see cref="F:System.Int32.MaxValue" />.</exception>
		public static IEnumerable<int> Range(int start, int count)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CRangeIterator_003Ed__115))]
		private static IEnumerable<int> RangeIterator(int start, int count)
		{
			return null;
		}

		/// <summary>Returns an empty <see cref="T:System.Collections.Generic.IEnumerable`1" /> that has the specified type argument.</summary>
		/// <returns>An empty <see cref="T:System.Collections.Generic.IEnumerable`1" /> whose type argument is <paramref name="TResult" />.</returns>
		/// <typeparam name="TResult">The type to assign to the type parameter of the returned generic <see cref="T:System.Collections.Generic.IEnumerable`1" />.</typeparam>
		public static IEnumerable<TResult> Empty<TResult>()
		{
			return null;
		}

		/// <summary>Determines whether a sequence contains any elements.</summary>
		/// <returns>true if the source sequence contains any elements; otherwise, false.</returns>
		/// <param name="source">The <see cref="T:System.Collections.Generic.IEnumerable`1" /> to check for emptiness.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> is null.</exception>
		public static bool Any<TSource>(this IEnumerable<TSource> source)
		{
			return false;
		}

		/// <summary>Determines whether any element of a sequence satisfies a condition.</summary>
		/// <returns>true if any elements in the source sequence pass the test in the specified predicate; otherwise, false.</returns>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> whose elements to apply the predicate to.</param>
		/// <param name="predicate">A function to test each element for a condition.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> or <paramref name="predicate" /> is null.</exception>
		public static bool Any<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return false;
		}

		/// <summary>Determines whether all elements of a sequence satisfy a condition.</summary>
		/// <returns>true if every element of the source sequence passes the test in the specified predicate, or if the sequence is empty; otherwise, false.</returns>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains the elements to apply the predicate to.</param>
		/// <param name="predicate">A function to test each element for a condition.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> or <paramref name="predicate" /> is null.</exception>
		public static bool All<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return false;
		}

		/// <summary>Returns the number of elements in a sequence.</summary>
		/// <returns>The number of elements in the input sequence.</returns>
		/// <param name="source">A sequence that contains elements to be counted.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> is null.</exception>
		/// <exception cref="T:System.OverflowException">The number of elements in <paramref name="source" /> is larger than <see cref="F:System.Int32.MaxValue" />.</exception>
		public static int Count<TSource>(this IEnumerable<TSource> source)
		{
			return 0;
		}

		/// <summary>Returns a number that represents how many elements in the specified sequence satisfy a condition.</summary>
		/// <returns>A number that represents how many elements in the sequence satisfy the condition in the predicate function.</returns>
		/// <param name="source">A sequence that contains elements to be tested and counted.</param>
		/// <param name="predicate">A function to test each element for a condition.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> or <paramref name="predicate" /> is null.</exception>
		/// <exception cref="T:System.OverflowException">The number of elements in <paramref name="source" /> is larger than <see cref="F:System.Int32.MaxValue" />.</exception>
		public static int Count<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return 0;
		}

		/// <summary>Determines whether a sequence contains a specified element by using the default equality comparer.</summary>
		/// <returns>true if the source sequence contains an element that has the specified value; otherwise, false.</returns>
		/// <param name="source">A sequence in which to locate a value.</param>
		/// <param name="value">The value to locate in the sequence.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> is null.</exception>
		public static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value)
		{
			return false;
		}

		/// <summary>Determines whether a sequence contains a specified element by using a specified <see cref="T:System.Collections.Generic.IEqualityComparer`1" />.</summary>
		/// <returns>true if the source sequence contains an element that has the specified value; otherwise, false.</returns>
		/// <param name="source">A sequence in which to locate a value.</param>
		/// <param name="value">The value to locate in the sequence.</param>
		/// <param name="comparer">An equality comparer to compare values.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> is null.</exception>
		public static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer)
		{
			return false;
		}

		/// <summary>Applies an accumulator function over a sequence. The specified seed value is used as the initial accumulator value.</summary>
		/// <returns>The final accumulator value.</returns>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to aggregate over.</param>
		/// <param name="seed">The initial accumulator value.</param>
		/// <param name="func">An accumulator function to be invoked on each element.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <typeparam name="TAccumulate">The type of the accumulator value.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> or <paramref name="func" /> is null.</exception>
		public static TAccumulate Aggregate<TSource, TAccumulate>(this IEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func)
		{
			return default(TAccumulate);
		}

		/// <summary>Computes the sum of a sequence of <see cref="T:System.Int32" /> values.</summary>
		/// <returns>The sum of the values in the sequence.</returns>
		/// <param name="source">A sequence of <see cref="T:System.Int32" /> values to calculate the sum of.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> is null.</exception>
		/// <exception cref="T:System.OverflowException">The sum is larger than <see cref="F:System.Int32.MaxValue" />.</exception>
		public static int Sum(this IEnumerable<int> source)
		{
			return 0;
		}

		/// <summary>Returns the minimum value in a sequence of <see cref="T:System.Int32" /> values.</summary>
		/// <returns>The minimum value in the sequence.</returns>
		/// <param name="source">A sequence of <see cref="T:System.Int32" /> values to determine the minimum value of.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> is null.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="source" /> contains no elements.</exception>
		public static int Min(this IEnumerable<int> source)
		{
			return 0;
		}

		/// <summary>Returns the maximum value in a sequence of <see cref="T:System.Int32" /> values.</summary>
		/// <returns>The maximum value in the sequence.</returns>
		/// <param name="source">A sequence of <see cref="T:System.Int32" /> values to determine the maximum value of.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> is null.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="source" /> contains no elements.</exception>
		public static int Max(this IEnumerable<int> source)
		{
			return 0;
		}
	}
}
