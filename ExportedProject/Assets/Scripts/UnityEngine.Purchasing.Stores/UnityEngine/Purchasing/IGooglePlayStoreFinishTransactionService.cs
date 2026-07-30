using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	internal interface IGooglePlayStoreFinishTransactionService
	{
		void SetStoreCallback(IStoreCallback storeCallback);

		void FinishTransaction(ProductDefinition product, string purchaseToken);
	}
}
