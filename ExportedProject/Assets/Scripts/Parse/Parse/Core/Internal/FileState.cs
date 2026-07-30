using System;

namespace Parse.Core.Internal
{
	public class FileState
	{
		public string Name { get; set; }

		public string MimeType { get; set; }

		public Uri Url { get; set; }

		public Uri SecureUrl => null;
	}
}
