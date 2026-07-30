using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Parse.Core.Internal
{
	internal class ParseQueryController : IParseQueryController
	{
		private readonly IParseCommandRunner commandRunner;

		public ParseQueryController(IParseCommandRunner commandRunner)
		{
		}

		public Task<IEnumerable<IObjectState>> FindAsync<T>(ParseQuery<T> query, ParseUser user, CancellationToken cancellationToken) where T : ParseObject
		{
			return null;
		}

		public Task<int> CountAsync<T>(ParseQuery<T> query, ParseUser user, CancellationToken cancellationToken) where T : ParseObject
		{
			return null;
		}

		public Task<IObjectState> FirstAsync<T>(ParseQuery<T> query, ParseUser user, CancellationToken cancellationToken) where T : ParseObject
		{
			return null;
		}

		private Task<IDictionary<string, object>> FindAsync(string className, IDictionary<string, object> parameters, string sessionToken, CancellationToken cancellationToken)
		{
			return null;
		}
	}
}
