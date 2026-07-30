namespace Parse.Core.Internal
{
	public class ParseDeleteOperation : IParseFieldOperation
	{
		internal static readonly object DeleteToken;

		private static ParseDeleteOperation _Instance;

		public static ParseDeleteOperation Instance => null;

		private ParseDeleteOperation()
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
