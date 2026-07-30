using System.Collections.Generic;

namespace Parse.Core.Internal
{
	public class ParseRelationOperation : IParseFieldOperation
	{
		private readonly IList<string> adds;

		private readonly IList<string> removes;

		private readonly string targetClassName;

		public string TargetClassName => null;

		private ParseRelationOperation(IEnumerable<string> adds, IEnumerable<string> removes, string targetClassName)
		{
		}

		public ParseRelationOperation(IEnumerable<ParseObject> adds, IEnumerable<ParseObject> removes)
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

		private IEnumerable<string> IdsFromObjects(IEnumerable<ParseObject> objects)
		{
			return null;
		}
	}
}
