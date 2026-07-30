using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Parse.Core.Internal
{
	public class ParseAddOperation : IParseFieldOperation
	{
		private ReadOnlyCollection<object> objects;

		public IEnumerable<object> Objects => null;

		public ParseAddOperation(IEnumerable<object> objects)
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
