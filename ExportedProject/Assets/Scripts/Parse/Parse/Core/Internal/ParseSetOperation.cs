namespace Parse.Core.Internal
{
	public class ParseSetOperation : IParseFieldOperation
	{
		public object Value { get; private set; }

		public ParseSetOperation(object value)
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
