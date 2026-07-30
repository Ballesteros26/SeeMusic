using System;
using System.Collections.Generic;
using UnityEngine.Purchasing.Models;
using UnityEngine.Purchasing.Utils;

namespace UnityEngine.Purchasing.Interfaces
{
	internal interface IGoogleBillingClient
	{
		void StartConnection(IBillingClientStateListener billingClientStateListener);

		GoogleBillingConnectionState GetConnectionState();

		void QueryPurchasesAsync(string skuType, Action<IGoogleBillingResult, IEnumerable<IAndroidJavaObjectWrapper>> onQueryPurchasesResponse);

		void QuerySkuDetailsAsync(List<string> skus, string type, Action<IGoogleBillingResult, List<AndroidJavaObject>> onSkuDetailsResponseAction);

		AndroidJavaObject LaunchBillingFlow(AndroidJavaObject sku, string oldPurchaseToken, GooglePlayProrationMode? prorationMode);

		void ConsumeAsync(string purchaseToken, Action<IGoogleBillingResult> onConsume);

		void AcknowledgePurchase(string purchaseToken, Action<IGoogleBillingResult> onAcknowledge);
	}
}
