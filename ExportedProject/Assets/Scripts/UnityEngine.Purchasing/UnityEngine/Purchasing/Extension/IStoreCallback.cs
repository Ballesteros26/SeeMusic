using System.Collections.Generic;

namespace UnityEngine.Purchasing.Extension
{
	public interface IStoreCallback
	{
		ProductCollection products { get; }

		void OnSetupFailed(InitializationFailureReason reason, string message);

		void OnProductsRetrieved(List<ProductDescription> products);

		void OnPurchaseSucceeded(string storeSpecificId, string receipt, string transactionIdentifier);

		void OnAllPurchasesRetrieved(List<Product> purchasedProducts);

		void OnPurchaseFailed(PurchaseFailureDescription desc);
	}
}
