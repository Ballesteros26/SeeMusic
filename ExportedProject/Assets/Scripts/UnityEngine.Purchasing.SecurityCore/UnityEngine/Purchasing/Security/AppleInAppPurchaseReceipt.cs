using System;

namespace UnityEngine.Purchasing.Security
{
	public class AppleInAppPurchaseReceipt
	{
		public string productID { get; }

		public string transactionID { get; }

		public string originalTransactionIdentifier { get; }

		public DateTime purchaseDate { get; }

		public DateTime subscriptionExpirationDate { get; }

		public DateTime cancellationDate { get; }

		public int isFreeTrial { get; }

		public int productType { get; }

		public int isIntroductoryPricePeriod { get; }
	}
}
