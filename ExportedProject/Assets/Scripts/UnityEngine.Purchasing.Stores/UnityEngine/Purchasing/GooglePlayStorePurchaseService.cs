using UnityEngine.Purchasing.Interfaces;

namespace UnityEngine.Purchasing
{
	internal class GooglePlayStorePurchaseService : IGooglePlayStorePurchaseService
	{
		private readonly IGooglePlayStoreService m_GooglePlayStoreService;

		internal GooglePlayStorePurchaseService(IGooglePlayStoreService googlePlayStoreService)
		{
		}

		public void Purchase(ProductDefinition product)
		{
		}
	}
}
