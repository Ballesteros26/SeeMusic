using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Models;

namespace UnityEngine.Purchasing
{
	internal class GooglePlayStoreRetrieveProductsService : IGooglePlayStoreRetrieveProductsService
	{
		private readonly IGooglePlayStoreService m_GooglePlayStoreService;

		private readonly IGoogleFetchPurchases m_GoogleFetchPurchases;

		private IStoreCallback? m_StoreCallback;

		private readonly IGooglePlayConfigurationInternal m_GooglePlayConfigurationInternal;

		private readonly IGooglePlayStoreExtensions m_GooglePlayStoreExtensions;

		private bool m_HasInitiallyRetrievedProducts;

		private bool m_RetrieveProductsFailed;

		internal GooglePlayStoreRetrieveProductsService(IGooglePlayStoreService googlePlayStoreService, IGoogleFetchPurchases googleFetchPurchases, IGooglePlayConfigurationInternal googlePlayConfigurationInternal, IGooglePlayStoreExtensions googlePlayStoreExtensions)
		{
		}

		public void SetStoreCallback(IStoreCallback? storeCallback)
		{
		}

		public void RetrieveProducts(ReadOnlyCollection<ProductDefinition> products, bool wantPurchases = true)
		{
		}

		private void OnProductsRetrievedWithPurchaseFetch(List<ProductDescription> retrievedProducts)
		{
		}

		private void OnProductsRetrieved(List<ProductDescription> retrievedProducts)
		{
		}

		private void OnRetrieveProductsFailed(GoogleRetrieveProductsFailureReason reason, GoogleBillingResponseCode responseCode)
		{
		}

		public void ResumeConnection()
		{
		}

		private List<ProductDescription> MakePurchasesIntoProducts(List<ProductDescription> retrievedProducts, IEnumerable<Product> purchaseProducts)
		{
			return null;
		}

		private bool IsPurchasedProductDeferred(Product product)
		{
			return false;
		}

		private static Product CreateNewProductUnifiedReceipt(Product product)
		{
			return null;
		}

		public bool HasInitiallyRetrievedProducts()
		{
			return false;
		}
	}
}
