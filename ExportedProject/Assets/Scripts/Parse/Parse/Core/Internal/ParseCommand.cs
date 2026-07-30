using System.Collections.Generic;
using System.IO;
using Parse.Common.Internal;

namespace Parse.Core.Internal
{
	public class ParseCommand : HttpRequest
	{
		public IDictionary<string, object> DataObject { get; private set; }

		public override Stream Data
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ParseCommand(string relativeUri, string method, string sessionToken = null, IList<KeyValuePair<string, string>> headers = null, IDictionary<string, object> data = null)
		{
		}

		public ParseCommand(string relativeUri, string method, string sessionToken = null, IList<KeyValuePair<string, string>> headers = null, Stream stream = null, string contentType = null)
		{
		}

		public ParseCommand(ParseCommand other)
		{
		}
	}
}
