using System.Collections.Generic;

namespace Parse.Push.Internal
{
	public interface IParseInstallationCoder
	{
		IDictionary<string, object> Encode(ParseInstallation installation);

		ParseInstallation Decode(IDictionary<string, object> data);
	}
}
