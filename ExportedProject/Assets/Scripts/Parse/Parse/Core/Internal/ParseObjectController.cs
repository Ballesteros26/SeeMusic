using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Parse.Core.Internal
{
	public class ParseObjectController : IParseObjectController
	{
		private readonly IParseCommandRunner commandRunner;

		public ParseObjectController(IParseCommandRunner commandRunner)
		{
		}

		public Task<IObjectState> FetchAsync(IObjectState state, string sessionToken, CancellationToken cancellationToken)
		{
			return null;
		}

		public Task<IObjectState> SaveAsync(IObjectState state, IDictionary<string, IParseFieldOperation> operations, string sessionToken, CancellationToken cancellationToken)
		{
			return null;
		}

		public IList<Task<IObjectState>> SaveAllAsync(IList<IObjectState> states, IList<IDictionary<string, IParseFieldOperation>> operationsList, string sessionToken, CancellationToken cancellationToken)
		{
			return null;
		}

		public Task DeleteAsync(IObjectState state, string sessionToken, CancellationToken cancellationToken)
		{
			return null;
		}

		public IList<Task> DeleteAllAsync(IList<IObjectState> states, string sessionToken, CancellationToken cancellationToken)
		{
			return null;
		}

		internal IList<Task<IDictionary<string, object>>> ExecuteBatchRequests(IList<ParseCommand> requests, string sessionToken, CancellationToken cancellationToken)
		{
			return null;
		}

		private IList<Task<IDictionary<string, object>>> ExecuteBatchRequest(IList<ParseCommand> requests, string sessionToken, CancellationToken cancellationToken)
		{
			return null;
		}
	}
}
