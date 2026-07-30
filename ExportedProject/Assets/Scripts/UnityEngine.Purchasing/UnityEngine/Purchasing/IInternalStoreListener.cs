using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	internal interface IInternalStoreListener
	{
		void OnInitializeFailed(InitializationFailureReason error, string? message = null);

		PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs e);

		void OnPurchaseFailed(Product i, PurchaseFailureDescription p);

		void OnInitialized(IStoreController controller);

		void SendTransactionEvent(Product product);
	}
}
