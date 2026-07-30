using System.Collections.Generic;

namespace Parse.Push.Internal
{
	public class ParsePushEncoder
	{
		private static readonly ParsePushEncoder instance;

		public static ParsePushEncoder Instance => null;

		private ParsePushEncoder()
		{
		}

		public IDictionary<string, object> Encode(IPushState state)
		{
			return null;
		}
	}
}
