using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	internal class EmptyAnalyticsAdapter : IAnalyticsAdapter
	{
		public void SendTransactionEvent(Product product)
		{
		}

		public void SendTransactionFailedEvent(Product product, PurchaseFailureDescription reason)
		{
		}
	}
}
