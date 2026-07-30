using System.Collections.Generic;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Models;

namespace UnityEngine.Purchasing
{
	internal class GooglePlayStoreFinishTransactionService : IGooglePlayStoreFinishTransactionService
	{
		private readonly HashSet<string> m_ProcessedPurchaseToken;

		private readonly IGooglePlayStoreService m_GooglePlayStoreService;

		private IStoreCallback? m_StoreCallback;

		private int m_RetryCount;

		internal GooglePlayStoreFinishTransactionService(IGooglePlayStoreService googlePlayStoreService)
		{
		}

		public void SetStoreCallback(IStoreCallback? storeCallback)
		{
		}

		public void FinishTransaction(ProductDefinition? product, string? purchaseToken)
		{
		}

		private void HandleFinishTransaction(ProductDefinition? product, IGoogleBillingResult billingResult, IGooglePurchase purchase)
		{
		}

		private void CallPurchaseSucceededUpdateReceipt(IGooglePurchase googlePurchase)
		{
		}

		private static bool IsResponseCodeInRecoverableState(IGoogleBillingResult billingResult)
		{
			return false;
		}
	}
}
