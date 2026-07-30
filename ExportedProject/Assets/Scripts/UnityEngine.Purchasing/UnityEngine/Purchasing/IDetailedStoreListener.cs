using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	public interface IDetailedStoreListener : IStoreListener
	{
		void OnPurchaseFailed(Product product, PurchaseFailureDescription failureDescription);
	}
}
