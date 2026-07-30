using System.Collections.Generic;

namespace Parse.Core.Internal
{
	public class PointerOrLocalIdEncoder : ParseEncoder
	{
		private static readonly PointerOrLocalIdEncoder instance;

		public static PointerOrLocalIdEncoder Instance => null;

		protected override IDictionary<string, object> EncodeParseObject(ParseObject value)
		{
			return null;
		}
	}
}
