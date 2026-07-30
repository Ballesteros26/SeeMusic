using System;
using System.Collections.Generic;
using Uniject;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Purchasing.Utils;

namespace UnityEngine.Purchasing.Models
{
	internal class GoogleBillingClient : IGoogleBillingClient
	{
		private readonly AndroidJavaObject m_BillingClient;

		private string m_ObfuscatedAccountId;

		private string m_ObfuscatedProfileId;

		private readonly IUtil m_Util;

		private readonly ITelemetryDiagnostics m_TelemetryDiagnostics;

		private static AndroidJavaClass GetSkuDetailsParamClass()
		{
			return null;
		}

		private static AndroidJavaClass GetBillingFlowParamClass()
		{
			return null;
		}

		private static AndroidJavaClass GetSubscriptionUpdateParamClass()
		{
			return null;
		}

		private static AndroidJavaClass GetConsumeParamsClass()
		{
			return null;
		}

		private static AndroidJavaClass GetAcknowledgePurchaseParamsClass()
		{
			return null;
		}

		private static AndroidJavaClass GetBillingClientClass()
		{
			return null;
		}

		internal GoogleBillingClient(IGooglePurchaseUpdatedListener googlePurchaseUpdatedListener, IUtil util, ITelemetryDiagnostics telemetryDiagnostics)
		{
		}

		public void StartConnection(IBillingClientStateListener billingClientStateListener)
		{
		}

		public GoogleBillingConnectionState GetConnectionState()
		{
			return default(GoogleBillingConnectionState);
		}

		public void QueryPurchasesAsync(string skuType, Action<IGoogleBillingResult, IEnumerable<IAndroidJavaObjectWrapper>> onQueryPurchasesResponse)
		{
		}

		public void QuerySkuDetailsAsync(List<string> skus, string type, Action<IGoogleBillingResult, List<AndroidJavaObject>> onSkuDetailsResponseAction)
		{
		}

		public AndroidJavaObject LaunchBillingFlow(AndroidJavaObject sku, string oldPurchaseToken, GooglePlayProrationMode? prorationMode)
		{
			return null;
		}

		private AndroidJavaObject MakeBillingFlowParams(AndroidJavaObject sku, string oldPurchaseToken, GooglePlayProrationMode? prorationMode)
		{
			return null;
		}

		private static AndroidJavaObject BuildSubscriptionUpdateParams(string oldPurchaseToken, GooglePlayProrationMode prorationMode)
		{
			return null;
		}

		private AndroidJavaObject SetObfuscatedProfileIdIfNeeded(AndroidJavaObject billingFlowParams)
		{
			return null;
		}

		private AndroidJavaObject SetObfuscatedAccountIdIfNeeded(AndroidJavaObject billingFlowParams)
		{
			return null;
		}

		public void ConsumeAsync(string purchaseToken, Action<IGoogleBillingResult> onConsume)
		{
		}

		public void AcknowledgePurchase(string purchaseToken, Action<IGoogleBillingResult> onAcknowledge)
		{
		}
	}
}
