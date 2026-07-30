using System;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;

namespace UnityEngine.Purchasing
{
	internal class GooglePlayConfiguration : IGooglePlayConfiguration, IStoreConfiguration, IGooglePlayConfigurationInternal
	{
		private Action? m_InitializationConnectionLister;

		private readonly IGooglePlayStoreService m_GooglePlayStoreService;

		private Action<Product>? m_DeferredPurchaseAction;

		private Action<Product>? m_DeferredProrationUpgradeDowngradeSubscriptionAction;

		private Action<int>? m_QueryProductDetailsFailedListener;

		private bool m_FetchPurchasesAtInitialize;

		private bool m_FetchPurchasesExcludeDeferred;

		public GooglePlayConfiguration(IGooglePlayStoreService googlePlayStoreService)
		{
		}

		public void NotifyInitializationConnectionFailed()
		{
		}

		public void NotifyQueryProductDetailsFailed(int retryCount)
		{
		}

		public void NotifyDeferredProrationUpgradeDowngradeSubscription(IStoreCallback? storeCallback, string productId)
		{
		}

		public bool IsFetchPurchasesAtInitializeSkipped()
		{
			return false;
		}

		public bool DoesRetrievePurchasesExcludeDeferred()
		{
			return false;
		}

		public void NotifyDeferredPurchase(IStoreCallback? storeCallback, IGooglePurchase? purchase, string? receipt, string? transactionId)
		{
		}
	}
}
