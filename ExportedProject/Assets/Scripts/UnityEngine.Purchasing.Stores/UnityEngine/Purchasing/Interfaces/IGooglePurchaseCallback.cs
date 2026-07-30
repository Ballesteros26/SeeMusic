using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing.Interfaces
{
	internal interface IGooglePurchaseCallback
	{
		void SetStoreCallback(IStoreCallback storeCallback);

		void SetStoreConfiguration(IGooglePlayConfigurationInternal configuration);

		void OnPurchaseSuccessful(IGooglePurchase purchase, string receipt, string purchaseToken);

		void OnPurchaseFailed(PurchaseFailureDescription purchaseFailureDescription);

		void NotifyDeferredPurchase(IGooglePurchase purchase, string receipt, string purchaseToken);

		void NotifyDeferredProrationUpgradeDowngradeSubscription(string sku);
	}
}
