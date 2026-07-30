using System.Collections.ObjectModel;
using Uniject;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;

namespace UnityEngine.Purchasing
{
	internal class GooglePlayStore : AbstractStore
	{
		private readonly IGooglePlayStoreRetrieveProductsService m_RetrieveProductsService;

		private readonly IGooglePlayStorePurchaseService m_StorePurchaseService;

		private readonly IGoogleFetchPurchases m_FetchPurchases;

		private readonly IGooglePlayStoreFinishTransactionService m_FinishTransactionService;

		private readonly IGooglePurchaseCallback m_GooglePurchaseCallback;

		private readonly IGooglePlayStoreExtensionsInternal m_GooglePlayStoreExtensions;

		private readonly IGooglePlayConfigurationInternal m_GooglePlayConfigurationInternal;

		private readonly IUtil m_Util;

		public GooglePlayStore(IGooglePlayStoreRetrieveProductsService retrieveProductsService, IGooglePlayStorePurchaseService storePurchaseService, IGoogleFetchPurchases fetchPurchases, IGooglePlayStoreFinishTransactionService transactionService, IGooglePurchaseCallback googlePurchaseCallback, IGooglePlayConfigurationInternal googlePlayConfigurationInternal, IGooglePlayStoreExtensionsInternal googlePlayStoreExtensions, IUtil util)
		{
		}

		public override void Initialize(IStoreCallback callback)
		{
		}

		public override void RetrieveProducts(ReadOnlyCollection<ProductDefinition> products)
		{
		}

		private bool HasInitiallyRetrievedProducts()
		{
			return false;
		}

		private bool ShouldFetchPurchasesNext()
		{
			return false;
		}

		public override void Purchase(ProductDefinition product, string dummy)
		{
		}

		public override void FinishTransaction(ProductDefinition product, string transactionId)
		{
		}

		public void OnPause(bool isPaused)
		{
		}
	}
}
