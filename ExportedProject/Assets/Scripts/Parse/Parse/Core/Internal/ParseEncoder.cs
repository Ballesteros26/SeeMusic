using System.Collections.Generic;

namespace Parse.Core.Internal
{
	public abstract class ParseEncoder
	{
		private static readonly bool isCompiledByIL2CPP;

		public static bool IsValidType(object value)
		{
			return false;
		}

		public object Encode(object value)
		{
			return null;
		}

		protected abstract IDictionary<string, object> EncodeParseObject(ParseObject value);

		private object EncodeList(IList<object> list)
		{
			return null;
		}
	}
}
