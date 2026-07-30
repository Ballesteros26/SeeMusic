using System;
using System.Threading.Tasks;

namespace Parse.Core.Internal
{
	public interface IInstallationIdController
	{
		Task<Guid?> GetAsync();
	}
}
