using System;
using NatML.API.Graph;

namespace NatML.API.Types
{
	[Serializable]
	[Preserve]
	public class Profile
	{
		public string username;

		public string? email;

		public string created;

		public string? name;

		public string? avatar;

		public string? bio;

		public string? website;

		public string? github;
	}
}
