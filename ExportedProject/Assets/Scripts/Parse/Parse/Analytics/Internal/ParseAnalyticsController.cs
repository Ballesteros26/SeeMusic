using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Parse.Core.Internal;

namespace Parse.Analytics.Internal
{
	public class ParseAnalyticsController : IParseAnalyticsController
	{
		private IParseCommandRunner Runner { get; }

		public ParseAnalyticsController(IParseCommandRunner commandRunner)
		{
		}

		public Task TrackEventAsync(string name, IDictionary<string, string> dimensions, string sessionToken, CancellationToken cancellationToken)
		{
			return null;
		}

		public Task TrackAppOpenedAsync(string pushHash, string sessionToken, CancellationToken cancellationToken)
		{
			return null;
		}
	}
}
