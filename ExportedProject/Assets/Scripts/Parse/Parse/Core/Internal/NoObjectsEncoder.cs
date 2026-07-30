using System.Collections.Generic;

namespace Parse.Core.Internal
{
	public class NoObjectsEncoder : ParseEncoder
	{
		private static readonly NoObjectsEncoder instance;

		public static NoObjectsEncoder Instance => null;

		protected override IDictionary<string, object> EncodeParseObject(ParseObject value)
		{
			return null;
		}
	}
}
