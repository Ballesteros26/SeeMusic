using System;
using System.Collections;
using System.Collections.Generic;

namespace Parse.Core.Internal
{
	public class MutableObjectState : IObjectState, IEnumerable<KeyValuePair<string, object>>, IEnumerable
	{
		private IDictionary<string, object> serverData;

		public bool IsNew { get; set; }

		public string ClassName { get; set; }

		public string ObjectId { get; set; }

		public DateTime? UpdatedAt { get; set; }

		public DateTime? CreatedAt { get; set; }

		public IDictionary<string, object> ServerData
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public object this[string key] => null;

		public bool ContainsKey(string key)
		{
			return false;
		}

		public void Apply(IDictionary<string, IParseFieldOperation> operationSet)
		{
		}

		public void Apply(IObjectState other)
		{
		}

		public IObjectState MutatedClone(Action<MutableObjectState> func)
		{
			return null;
		}

		protected virtual MutableObjectState MutableClone()
		{
			return null;
		}

		IEnumerator<KeyValuePair<string, object>> IEnumerable<KeyValuePair<string, object>>.GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
