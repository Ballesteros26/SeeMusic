using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	internal class AnalyticsClient : IAnalyticsClient
	{
		private readonly IAnalyticsAdapter m_Analytics;

		private readonly IAnalyticsAdapter m_LegacyAnalytics;

		public AnalyticsClient(IAnalyticsAdapter analytics, IAnalyticsAdapter legacyAnalytics)
		{
		}

		public void OnPurchaseSucceeded(Product product)
		{
		}

		public void OnPurchaseFailed(Product product, PurchaseFailureDescription description)
		{
		}
	}
}
