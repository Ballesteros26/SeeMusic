using System;
using Function.Internal;

namespace Function.Types
{
	[Serializable]
	[Preserve]
	public class Profile
	{
		public string username;

		public string created;

		public string? name;

		public string? avatar;

		public string? bio;

		public string? website;

		public string? github;
	}
}
