using System.Collections.Generic;

namespace Parse.Push.Internal
{
	public class ParseInstallationCoder : IParseInstallationCoder
	{
		private static readonly ParseInstallationCoder instance;

		public static ParseInstallationCoder Instance => null;

		public IDictionary<string, object> Encode(ParseInstallation installation)
		{
			return null;
		}

		public ParseInstallation Decode(IDictionary<string, object> data)
		{
			return null;
		}
	}
}
