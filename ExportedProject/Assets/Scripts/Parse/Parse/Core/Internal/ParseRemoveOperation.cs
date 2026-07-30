using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Parse.Core.Internal
{
	public class ParseRemoveOperation : IParseFieldOperation
	{
		private ReadOnlyCollection<object> objects;

		public IEnumerable<object> Objects => null;

		public ParseRemoveOperation(IEnumerable<object> objects)
		{
		}

		public object Encode()
		{
			return null;
		}

		public IParseFieldOperation MergeWithPrevious(IParseFieldOperation previous)
		{
			return null;
		}

		public object Apply(object oldValue, string key)
		{
			return null;
		}
	}
}
