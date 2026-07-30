using System;
using System.Threading.Tasks;
using Parse.Common.Internal;

namespace Parse.Core.Internal
{
	public class InstallationIdController : IInstallationIdController
	{
		private readonly object mutex;

		private Guid? installationId;

		private readonly IStorageController storageController;

		public InstallationIdController(IStorageController storageController)
		{
		}

		public Task SetAsync(Guid? installationId)
		{
			return null;
		}

		public Task<Guid?> GetAsync()
		{
			return null;
		}
	}
}
