using System;

namespace UnityEngine.Purchasing
{
	public interface IStoreListener
	{
		void OnInitializeFailed(InitializationFailureReason error, string message);

		PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs purchaseEvent);

		[Obsolete("Use IDetailedStoreListener.OnPurchaseFailed for more detailed callback.", false)]
		void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason);

		void OnInitialized(IStoreController controller, IExtensionProvider extensions);
	}
}
