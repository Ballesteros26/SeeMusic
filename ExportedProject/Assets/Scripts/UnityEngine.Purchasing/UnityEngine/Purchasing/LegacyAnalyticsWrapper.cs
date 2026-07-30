using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	internal class LegacyAnalyticsWrapper : IAnalyticsAdapter, ICoreServicesEnvironmentObserver
	{
		private bool m_Enabled;

		private IAnalyticsAdapter m_LegacyAdapter;

		private IAnalyticsAdapter m_EmptyAdapter;

		private IAnalyticsAdapter m_AnalyticsAdapter => null;

		internal LegacyAnalyticsWrapper(IAnalyticsAdapter legacyAdapter, IAnalyticsAdapter emptyAdapter)
		{
		}

		public void SendTransactionEvent(Product product)
		{
		}

		public void SendTransactionFailedEvent(Product product, PurchaseFailureDescription description)
		{
		}

		public void OnUpdatedCoreServicesEnvironment(string currentEnvironment)
		{
		}
	}
}
