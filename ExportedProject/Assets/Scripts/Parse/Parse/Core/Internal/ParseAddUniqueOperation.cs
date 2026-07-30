using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Parse.Core.Internal
{
	public class ParseAddUniqueOperation : IParseFieldOperation
	{
		private ReadOnlyCollection<object> objects;

		public IEnumerable<object> Objects => null;

		public ParseAddUniqueOperation(IEnumerable<object> objects)
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
