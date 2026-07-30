using System.Collections.ObjectModel;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	internal interface IGooglePlayStoreRetrieveProductsService
	{
		void SetStoreCallback(IStoreCallback storeCallback);

		void RetrieveProducts(ReadOnlyCollection<ProductDefinition> products, bool wantPurchases);

		void ResumeConnection();

		bool HasInitiallyRetrievedProducts();
	}
}
