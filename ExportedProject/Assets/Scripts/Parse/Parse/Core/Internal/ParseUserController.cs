using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Parse.Core.Internal
{
	public class ParseUserController : IParseUserController
	{
		private readonly IParseCommandRunner commandRunner;

		public ParseUserController(IParseCommandRunner commandRunner)
		{
		}

		public Task<IObjectState> SignUpAsync(IObjectState state, IDictionary<string, IParseFieldOperation> operations, CancellationToken cancellationToken)
		{
			return null;
		}

		public Task<IObjectState> LogInAsync(string username, string password, CancellationToken cancellationToken)
		{
			return null;
		}

		public Task<IObjectState> LogInAsync(string authType, IDictionary<string, object> data, CancellationToken cancellationToken)
		{
			return null;
		}

		public Task<IObjectState> GetUserAsync(string sessionToken, CancellationToken cancellationToken)
		{
			return null;
		}

		public Task RequestPasswordResetAsync(string email, CancellationToken cancellationToken)
		{
			return null;
		}
	}
}
