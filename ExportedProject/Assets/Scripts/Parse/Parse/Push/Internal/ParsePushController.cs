using System.Threading;
using System.Threading.Tasks;
using Parse.Core.Internal;

namespace Parse.Push.Internal
{
	internal class ParsePushController : IParsePushController
	{
		private readonly IParseCommandRunner commandRunner;

		private readonly IParseCurrentUserController currentUserController;

		public ParsePushController(IParseCommandRunner commandRunner, IParseCurrentUserController currentUserController)
		{
		}

		public Task SendPushNotificationAsync(IPushState state, CancellationToken cancellationToken)
		{
			return null;
		}
	}
}
