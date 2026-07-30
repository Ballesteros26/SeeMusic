using System.Collections.Generic;
using System.Threading.Tasks;

namespace Parse.Common.Internal
{
	public interface IStorageController
	{
		Task<IStorageDictionary<string, object>> LoadAsync();

		Task<IStorageDictionary<string, object>> SaveAsync(IDictionary<string, object> contents);
	}
}
