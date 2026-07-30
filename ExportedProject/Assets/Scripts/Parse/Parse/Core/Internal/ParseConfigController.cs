using System.Threading;
using System.Threading.Tasks;
using Parse.Common.Internal;

namespace Parse.Core.Internal
{
	internal class ParseConfigController : IParseConfigController
	{
		private readonly IParseCommandRunner commandRunner;

		public IParseCurrentConfigController CurrentConfigController { get; internal set; }

		public ParseConfigController(IParseCommandRunner commandRunner, IStorageController storageController)
		{
		}

		public Task<ParseConfig> FetchConfigAsync(string sessionToken, CancellationToken cancellationToken)
		{
			return null;
		}
	}
}
