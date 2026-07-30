using System.Collections.Generic;
using UnityEngine.Purchasing.Security;

namespace UnityEngine.Purchasing
{
	public class SubscriptionManager
	{
		private readonly string receipt;

		private readonly string productId;

		private readonly string intro_json;

		public SubscriptionManager(Product product, string intro_json)
		{
		}

		public SubscriptionInfo getSubscriptionInfo()
		{
			return null;
		}

		private SubscriptionInfo getAmazonAppStoreSubInfo(string productId)
		{
			return null;
		}

		private SubscriptionInfo getAppleAppStoreSubInfo(string payload, string productId)
		{
			return null;
		}

		private AppleInAppPurchaseReceipt findMostRecentReceipt(List<AppleInAppPurchaseReceipt> receipts)
		{
			return null;
		}

		private SubscriptionInfo getGooglePlayStoreSubInfo(string payload)
		{
			return null;
		}
	}
}
