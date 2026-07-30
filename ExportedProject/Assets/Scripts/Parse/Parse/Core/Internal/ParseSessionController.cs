using System.Threading;
using System.Threading.Tasks;

namespace Parse.Core.Internal
{
	public class ParseSessionController : IParseSessionController
	{
		private readonly IParseCommandRunner commandRunner;

		public ParseSessionController(IParseCommandRunner commandRunner)
		{
		}

		public Task<IObjectState> GetSessionAsync(string sessionToken, CancellationToken cancellationToken)
		{
			return null;
		}

		public Task RevokeAsync(string sessionToken, CancellationToken cancellationToken)
		{
			return null;
		}

		public Task<IObjectState> UpgradeToRevocableSessionAsync(string sessionToken, CancellationToken cancellationToken)
		{
			return null;
		}

		public bool IsRevocableSessionToken(string sessionToken)
		{
			return false;
		}
	}
}
