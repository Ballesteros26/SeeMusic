using System.Collections.Generic;
using System.Threading.Tasks;

namespace UnityEngine.Purchasing.Interfaces
{
	internal interface IGoogleQueryPurchasesService
	{
		Task<List<IGooglePurchase>> QueryPurchases();
	}
}
