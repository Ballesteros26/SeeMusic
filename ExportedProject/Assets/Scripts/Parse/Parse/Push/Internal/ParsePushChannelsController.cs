using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Parse.Push.Internal
{
	internal class ParsePushChannelsController : IParsePushChannelsController
	{
		public Task SubscribeAsync(IEnumerable<string> channels, CancellationToken cancellationToken)
		{
			return null;
		}

		public Task UnsubscribeAsync(IEnumerable<string> channels, CancellationToken cancellationToken)
		{
			return null;
		}
	}
}
