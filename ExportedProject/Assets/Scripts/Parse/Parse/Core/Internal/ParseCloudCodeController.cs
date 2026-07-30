using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Parse.Core.Internal
{
	public class ParseCloudCodeController : IParseCloudCodeController
	{
		private readonly IParseCommandRunner commandRunner;

		public ParseCloudCodeController(IParseCommandRunner commandRunner)
		{
		}

		public Task<T> CallFunctionAsync<T>(string name, IDictionary<string, object> parameters, string sessionToken, CancellationToken cancellationToken)
		{
			return null;
		}
	}
}
