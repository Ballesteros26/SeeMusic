using System.Threading.Tasks;
using Parse.Common.Internal;

namespace Parse.Core.Internal
{
	internal class ParseCurrentConfigController : IParseCurrentConfigController
	{
		private readonly TaskQueue taskQueue;

		private ParseConfig currentConfig;

		private IStorageController storageController;

		public ParseCurrentConfigController(IStorageController storageController)
		{
		}

		public Task<ParseConfig> GetCurrentConfigAsync()
		{
			return null;
		}

		public Task SetCurrentConfigAsync(ParseConfig config)
		{
			return null;
		}

		public Task ClearCurrentConfigAsync()
		{
			return null;
		}

		public Task ClearCurrentConfigInMemoryAsync()
		{
			return null;
		}
	}
}
