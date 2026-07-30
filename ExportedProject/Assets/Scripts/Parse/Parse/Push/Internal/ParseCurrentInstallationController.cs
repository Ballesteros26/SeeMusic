using System.Threading;
using System.Threading.Tasks;
using Parse.Common.Internal;
using Parse.Core.Internal;

namespace Parse.Push.Internal
{
	internal class ParseCurrentInstallationController : IParseCurrentInstallationController, IParseObjectCurrentController<ParseInstallation>
	{
		private readonly object mutex;

		private readonly TaskQueue taskQueue;

		private readonly IInstallationIdController installationIdController;

		private readonly IStorageController storageController;

		private readonly IParseInstallationCoder installationCoder;

		private ParseInstallation currentInstallation;

		internal ParseInstallation CurrentInstallation
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ParseCurrentInstallationController(IInstallationIdController installationIdController, IStorageController storageController, IParseInstallationCoder installationCoder)
		{
		}

		public Task SetAsync(ParseInstallation installation, CancellationToken cancellationToken)
		{
			return null;
		}

		public Task<ParseInstallation> GetAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		public bool IsCurrent(ParseInstallation installation)
		{
			return false;
		}

		public void ClearFromMemory()
		{
		}
	}
}
