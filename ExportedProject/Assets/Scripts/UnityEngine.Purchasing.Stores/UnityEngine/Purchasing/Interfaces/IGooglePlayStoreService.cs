using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Models;

namespace UnityEngine.Purchasing.Interfaces
{
	internal interface IGooglePlayStoreService
	{
		void RetrieveProducts(ReadOnlyCollection<ProductDefinition> products, Action<List<ProductDescription>> onProductsReceived, Action<GoogleRetrieveProductsFailureReason, GoogleBillingResponseCode> onRetrieveProductFailed);

		void Purchase(ProductDefinition product);

		void FinishTransaction(ProductDefinition product, string purchaseToken, Action<IGoogleBillingResult, IGooglePurchase> onTransactionFinished);

		void FetchPurchases(Action<List<IGooglePurchase>> onQueryPurchaseSucceed);

		void ResumeConnection();
	}
}
