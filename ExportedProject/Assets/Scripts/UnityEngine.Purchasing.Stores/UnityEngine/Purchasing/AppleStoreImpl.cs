using System;
using System.Collections.Generic;
using AOT;
using Uniject;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Security;
using UnityEngine.Purchasing.Telemetry;

namespace UnityEngine.Purchasing
{
	internal class AppleStoreImpl : JSONStore, IAppleExtensions, IStoreExtension, IAppleConfiguration, IStoreConfiguration
	{
		private Action<Product>? m_DeferredCallback;

		private Action<List<Product>>? m_RevokedCallback;

		private Action<string>? m_RefreshReceiptError;

		private Action<string>? m_RefreshReceiptSuccess;

		private Action<bool>? m_ObsoleteRestoreCallback;

		private Action<bool, string?>? m_RestoreCallback;

		private Action? m_FetchStorePromotionOrderError;

		private Action<List<Product>>? m_FetchStorePromotionOrderSuccess;

		private Action<Product>? m_PromotionalPurchaseCallback;

		private Action? m_FetchStorePromotionVisibilityError;

		private Action<string, AppleStorePromotionVisibility>? m_FetchStorePromotionVisibilitySuccess;

		private INativeAppleStore? m_Native;

		private readonly ITelemetryDiagnostics m_TelemetryDiagnostics;

		private static IUtil? s_Util;

		private static AppleStoreImpl? s_Instance;

		private string? m_CachedAppReceipt;

		private double? m_CachedAppReceiptModificationDate;

		private string? m_ProductsJson;

		public string? appReceipt => null;

		private double? appReceiptModificationDate => null;

		protected AppleStoreImpl(IUtil util, ITelemetryDiagnostics telemetryDiagnostics)
		{
		}

		public void SetNativeStore(INativeAppleStore apple)
		{
		}

		public override void OnProductsRetrieved(string json)
		{
		}

		private bool HasInAppPurchaseReceipts(AppleReceipt? appleReceipt)
		{
			return false;
		}

		private List<ProductDescription> EnrichProductDescriptions(List<ProductDescription> productDescriptions, AppleReceipt appleReceipt)
		{
			return null;
		}

		private static AppleInAppPurchaseReceipt? FindMostRecentReceipt(AppleReceipt? appleReceipt, string productId)
		{
			return null;
		}

		private static AppleInAppPurchaseReceipt FirstNonCancelledReceipt(AppleInAppPurchaseReceipt[] foundReceipts)
		{
			return null;
		}

		[Obsolete("RestoreTransactions(Action<bool> callback) is deprecated, please use RestoreTransactions(Action<bool, string> callback) instead.")]
		public virtual void RestoreTransactions(Action<bool>? callback)
		{
		}

		public virtual void RestoreTransactions(Action<bool, string?>? callback)
		{
		}

		public Dictionary<string, string> GetIntroductoryPriceDictionary()
		{
			return null;
		}

		public void OnPurchaseDeferred(string productId)
		{
		}

		public void OnPromotionalPurchaseAttempted(string productId)
		{
		}

		public void OnTransactionsRestoredSuccess()
		{
		}

		public void OnTransactionsRestoredFail(string error)
		{
		}

		public void OnAppReceiptRetrieved(string receipt)
		{
		}

		public void OnAppReceiptRefreshedFailed(string error)
		{
		}

		private void OnEntitlementsRevoked(string productIds)
		{
		}

		private void RevokeEntitlement(AppleReceipt? appleReceipt, string productId, List<Product> revokedProducts, Product product)
		{
		}

		private bool RestoreActiveEntitlement(AppleReceipt appleReceipt, string productId)
		{
			return false;
		}

		public void OnFetchStorePromotionOrderSucceeded(string productIds)
		{
		}

		public void OnFetchStorePromotionOrderFailed()
		{
		}

		public void OnFetchStorePromotionVisibilitySucceeded(string result)
		{
		}

		public void OnFetchStorePromotionVisibilityFailed()
		{
		}

		[MonoPInvokeCallback(typeof(UnityPurchasingCallback))]
		private static void MessageCallback(string subject, string payload, string receipt, string transactionId, string originalTransactionId, bool isRestored)
		{
		}

		private void ProcessMessage(string subject, string payload, string receipt, string transactionId, string originalTransactionId, bool isRestored)
		{
		}

		public void OnPurchaseSucceeded(string id, string receipt, string transactionId, string originalTransactionId, bool isRestored)
		{
		}

		private AppleReceipt? GetAppleReceiptFromBase64String(string? receipt)
		{
			return null;
		}

		private static bool IsValidPurchaseState(AppleInAppPurchaseReceipt? mostRecentReceipt, string productId)
		{
			return false;
		}

		private bool IsRestored(string productId, AppleInAppPurchaseReceipt? productReceipt, string transactionId, string originalTransactionId)
		{
			return false;
		}

		private static bool IsSubscriptionRestored(AppleInAppPurchaseReceipt? productReceipt, Product previousProduct)
		{
			return false;
		}

		private static bool IsNonSubscriptionRestored(string transactionId, string? originalTransactionId)
		{
			return false;
		}

		private void UpdateAppleProductFields(string id, string originalTransactionId, bool isRestored)
		{
		}
	}
}
