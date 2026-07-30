using System;
using System.Collections.Generic;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	internal class PurchasingManager : IStoreCallback, IStoreController
	{
		private readonly IStore m_Store;

		private IInternalStoreListener? m_Listener;

		private readonly ILogger m_Logger;

		private readonly TransactionLog m_TransactionLog;

		private readonly string m_StoreName;

		private readonly IUnityServicesInitializationChecker m_UnityServicesInitializationChecker;

		private Action? m_AdditionalProductsCallback;

		private Action<InitializationFailureReason>? m_AdditionalProductsFailCallback;

		private Action<InitializationFailureReason, string?>? m_AdditionalProductsDetailedFailCallback;

		private readonly HashSet<string> purchasesProcessedInSession;

		private bool initialized;

		public bool useTransactionLog { get; set; }

		public ProductCollection products { get; private set; }

		internal PurchasingManager(TransactionLog tDb, ILogger logger, IStore store, string storeName, IUnityServicesInitializationChecker unityServicesInitializationChecker)
		{
		}

		public void InitiatePurchase(string? productId)
		{
		}

		public void InitiatePurchase(Product? product, string developerPayload)
		{
		}

		public void InitiatePurchase(string? purchasableId, string developerPayload)
		{
		}

		public void ConfirmPendingPurchase(Product product)
		{
		}

		public void OnPurchaseSucceeded(string id, string? receipt, string transactionId)
		{
		}

		private void UpdateProductReceiptAndTransactionID(Product product, string? receipt, string transactionId)
		{
		}

		public void OnAllPurchasesRetrieved(List<Product> purchasedProducts)
		{
		}

		internal static void OnEntitlementRevoked(Product revokedProduct)
		{
		}

		private void HandlePurchaseRetrieved(Product product, Product purchasedProduct)
		{
		}

		private bool WasPurchaseAlreadyProcessed(string transactionId)
		{
			return false;
		}

		private static void ClearProductReceipt(Product product)
		{
		}

		public void OnSetupFailed(InitializationFailureReason reason, string? message)
		{
		}

		public void OnPurchaseFailed(PurchaseFailureDescription description)
		{
		}

		public void OnProductsRetrieved(List<ProductDescription> products)
		{
		}

		private string CreateUnifiedReceipt(string? rawReceipt, string transactionId)
		{
			return null;
		}

		private void ProcessPurchaseOnStart()
		{
		}

		private void ProcessPurchaseIfNew(Product product)
		{
		}

		private bool HasRecordedTransaction(string transactionId)
		{
			return false;
		}

		private void CheckForInitialization()
		{
		}

		private bool HasAvailableProductsToPurchase(bool shouldLogUnavailableProducts = true)
		{
			return false;
		}

		public void Initialize(IInternalStoreListener listener, HashSet<ProductDefinition> products)
		{
		}
	}
}
