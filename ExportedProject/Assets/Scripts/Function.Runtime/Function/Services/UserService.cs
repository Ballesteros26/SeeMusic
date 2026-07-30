using System.Threading.Tasks;
using Function.Graph;
using Function.Types;

namespace Function.Services
{
	public sealed class UserService
	{
		internal sealed class UserInput
		{
			public string username;
		}

		private readonly IGraphClient client;

		public const string ProfileFields = "\n        username\n        created\n        name\n        avatar\n        bio\n        website\n        github\n        ";

		public const string UserFields = "\n        ... on User {\n            email\n        }\n        ";

		public Task<User> Retrieve()
		{
			return null;
		}

		public Task<Profile> Retrieve(string username)
		{
			return null;
		}

		internal UserService(IGraphClient client)
		{
		}

		private Task<T?>? Retrieve<T>(string? username = null)
		{
			return null;
		}
	}
}
