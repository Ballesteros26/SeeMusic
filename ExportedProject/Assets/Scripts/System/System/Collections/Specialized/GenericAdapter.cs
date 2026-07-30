using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Collections.Specialized
{
	internal class GenericAdapter : IDictionary<string, string>, ICollection<KeyValuePair<string, string>>, IEnumerable<KeyValuePair<string, string>>, IEnumerable
	{
		internal enum KeyOrValue
		{
			Key = 0,
			Value = 1
		}

		private class ICollectionToGenericCollectionAdapter : ICollection<string>, IEnumerable<string>, IEnumerable
		{
			[CompilerGenerated]
			private sealed class _003CGetEnumerator_003Ed__14 : IEnumerator<string>, IDisposable, IEnumerator
			{
				private int _003C_003E1__state;

				private string _003C_003E2__current;

				public ICollectionToGenericCollectionAdapter _003C_003E4__this;

				private IEnumerator _003C_003E7__wrap1;

				string IEnumerator<string>.Current
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
				public _003CGetEnumerator_003Ed__14(int _003C_003E1__state)
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

			private StringDictionary _internal;

			private KeyOrValue _keyOrValue;

			public int Count => 0;

			public bool IsReadOnly => false;

			public ICollectionToGenericCollectionAdapter(StringDictionary source, KeyOrValue keyOrValue)
			{
			}

			public void Add(string item)
			{
			}

			public void Clear()
			{
			}

			public void ThrowNotSupportedException()
			{
			}

			public bool Contains(string item)
			{
				return false;
			}

			public void CopyTo(string[] array, int arrayIndex)
			{
			}

			public bool Remove(string item)
			{
				return false;
			}

			private ICollection GetUnderlyingCollection()
			{
				return null;
			}

			[IteratorStateMachine(typeof(_003CGetEnumerator_003Ed__14))]
			public IEnumerator<string> GetEnumerator()
			{
				return null;
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CGetEnumerator_003Ed__25 : IEnumerator<KeyValuePair<string, string>>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private KeyValuePair<string, string> _003C_003E2__current;

			public GenericAdapter _003C_003E4__this;

			private IEnumerator _003C_003E7__wrap1;

			KeyValuePair<string, string> IEnumerator<KeyValuePair<string, string>>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, string>);
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
			public _003CGetEnumerator_003Ed__25(int _003C_003E1__state)
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

		private StringDictionary m_stringDictionary;

		private ICollectionToGenericCollectionAdapter _values;

		private ICollectionToGenericCollectionAdapter _keys;

		public int Count => 0;

		public string this[string key]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ICollection<string> Keys => null;

		public ICollection<string> Values => null;

		bool ICollection<KeyValuePair<string, string>>.IsReadOnly => false;

		internal GenericAdapter(StringDictionary stringDictionary)
		{
		}

		public void Add(string key, string value)
		{
		}

		public bool ContainsKey(string key)
		{
			return false;
		}

		public void Clear()
		{
		}

		public bool Remove(string key)
		{
			return false;
		}

		public bool TryGetValue(string key, out string value)
		{
			value = null;
			return false;
		}

		void ICollection<KeyValuePair<string, string>>.Add(KeyValuePair<string, string> item)
		{
		}

		bool ICollection<KeyValuePair<string, string>>.Contains(KeyValuePair<string, string> item)
		{
			return false;
		}

		void ICollection<KeyValuePair<string, string>>.CopyTo(KeyValuePair<string, string>[] array, int arrayIndex)
		{
		}

		bool ICollection<KeyValuePair<string, string>>.Remove(KeyValuePair<string, string> item)
		{
			return false;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CGetEnumerator_003Ed__25))]
		public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
		{
			return null;
		}
	}
}
