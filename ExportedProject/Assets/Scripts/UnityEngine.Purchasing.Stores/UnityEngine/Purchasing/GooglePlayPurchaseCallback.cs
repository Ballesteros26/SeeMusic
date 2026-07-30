using Uniject;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;

namespace UnityEngine.Purchasing
{
	internal class GooglePlayPurchaseCallback : IGooglePurchaseCallback
	{
		private IStoreCallback? m_StoreCallback;

		private IGooglePlayConfigurationInternal? m_GooglePlayConfigurationInternal;

		private readonly IUtil m_Util;

		public GooglePlayPurchaseCallback(IUtil util)
		{
		}

		public void SetStoreCallback(IStoreCallback storeCallback)
		{
		}

		public void SetStoreConfiguration(IGooglePlayConfigurationInternal configuration)
		{
		}

		public void OnPurchaseSuccessful(IGooglePurchase purchase, string receipt, string purchaseToken)
		{
		}

		public void OnPurchaseFailed(PurchaseFailureDescription purchaseFailureDescription)
		{
		}

		public void NotifyDeferredPurchase(IGooglePurchase purchase, string receipt, string purchaseToken)
		{
		}

		public void NotifyDeferredProrationUpgradeDowngradeSubscription(string sku)
		{
		}
	}
}
