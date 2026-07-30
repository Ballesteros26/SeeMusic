using UnityEngine.Purchasing.Interfaces;

namespace UnityEngine.Purchasing
{
	internal class GooglePriceChangeService : IGooglePriceChangeService
	{
		private readonly IGoogleBillingClient m_BillingClient;

		private readonly IQuerySkuDetailsService m_QuerySkuDetailsService;

		internal GooglePriceChangeService(IGoogleBillingClient billingClient, IQuerySkuDetailsService querySkuDetailsService)
		{
		}
	}
}
