using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq
{
	public class JProperty : JContainer
	{
		private class JPropertyList : IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable
		{
			[CompilerGenerated]
			private sealed class _003CGetEnumerator_003Ed__1 : IEnumerator<JToken>, IEnumerator, IDisposable
			{
				private int _003C_003E1__state;

				private JToken _003C_003E2__current;

				public JPropertyList _003C_003E4__this;

				JToken IEnumerator<JToken>.Current
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
				public _003CGetEnumerator_003Ed__1(int _003C_003E1__state)
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

			internal JToken? _token;

			public int Count => 0;

			public bool IsReadOnly => false;

			public JToken this[int index]
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			[IteratorStateMachine(typeof(_003CGetEnumerator_003Ed__1))]
			public IEnumerator<JToken> GetEnumerator()
			{
				return null;
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			public void Add(JToken item)
			{
			}

			public void Clear()
			{
			}

			public bool Contains(JToken item)
			{
				return false;
			}

			public void CopyTo(JToken[] array, int arrayIndex)
			{
			}

			public bool Remove(JToken item)
			{
				return false;
			}

			public int IndexOf(JToken item)
			{
				return 0;
			}

			public void Insert(int index, JToken item)
			{
			}

			public void RemoveAt(int index)
			{
			}
		}

		private readonly JPropertyList _content;

		private readonly string _name;

		protected override IList<JToken> ChildrenTokens => null;

		public string Name
		{
			[DebuggerStepThrough]
			get
			{
				return null;
			}
		}

		public JToken Value
		{
			[DebuggerStepThrough]
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override JTokenType Type
		{
			[DebuggerStepThrough]
			get
			{
				return default(JTokenType);
			}
		}

		internal JProperty(JProperty other, JsonCloneSettings? settings)
		{
		}

		internal override JToken GetItem(int index)
		{
			return null;
		}

		internal override void SetItem(int index, JToken? item)
		{
		}

		internal override bool RemoveItem(JToken? item)
		{
			return false;
		}

		internal override void RemoveItemAt(int index)
		{
		}

		internal override int IndexOfItem(JToken? item)
		{
			return 0;
		}

		internal override bool InsertItem(int index, JToken? item, bool skipParentCheck, bool copyAnnotations)
		{
			return false;
		}

		internal override bool ContainsItem(JToken? item)
		{
			return false;
		}

		internal override void ClearItems()
		{
		}

		internal override JToken CloneToken(JsonCloneSettings? settings)
		{
			return null;
		}

		internal JProperty(string name)
		{
		}

		public JProperty(string name, object? content)
		{
		}

		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		public static JProperty Load(JsonReader reader, JsonLoadSettings? settings)
		{
			return null;
		}
	}
}
