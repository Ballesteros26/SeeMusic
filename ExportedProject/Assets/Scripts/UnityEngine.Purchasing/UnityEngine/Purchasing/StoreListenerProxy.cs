using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	internal class StoreListenerProxy : IInternalStoreListener
	{
		private readonly IAnalyticsClient m_Analytics;

		private readonly IStoreListener m_ForwardTo;

		private readonly IExtensionProvider m_Extensions;

		public StoreListenerProxy(IStoreListener forwardTo, IAnalyticsClient analytics, IExtensionProvider extensions)
		{
		}

		public void OnInitialized(IStoreController controller)
		{
		}

		public void OnInitializeFailed(InitializationFailureReason error, string? message)
		{
		}

		public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs e)
		{
			return default(PurchaseProcessingResult);
		}

		public void OnPurchaseFailed(Product i, PurchaseFailureDescription p)
		{
		}

		public void SendTransactionEvent(Product product)
		{
		}
	}
}
