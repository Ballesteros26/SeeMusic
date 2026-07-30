using System;
using UnityEngine.Events;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	[AddComponentMenu("In-App Purchasing/IAP Listener")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.purchasing@latest")]
	public class IAPListener : MonoBehaviour
	{
		[Serializable]
		public class OnProductsFetchedEvent : UnityEvent<ProductCollection>
		{
		}

		[Serializable]
		public class OnPurchaseCompletedEvent : UnityEvent<Product>
		{
		}

		[Serializable]
		public class OnPurchaseFailedEvent : UnityEvent<Product, PurchaseFailureReason>
		{
		}

		[Serializable]
		public class OnPurchaseDetailedFailedEvent : UnityEvent<Product, PurchaseFailureDescription>
		{
		}

		[Tooltip("Consume successful purchases immediately.")]
		public bool consumePurchase;

		[Tooltip("Preserve this GameObject when a new scene is loaded.")]
		public bool dontDestroyOnLoad;

		[Tooltip("Event fired after a successful fetching the products from the store.")]
		public OnProductsFetchedEvent onProductsFetched;

		[Tooltip("Event fired after a successful purchase of this product.")]
		public OnPurchaseCompletedEvent onPurchaseComplete;

		[Tooltip("Event fired after a failed purchase of this product.")]
		public OnPurchaseFailedEvent onPurchaseFailed;

		[Tooltip("Event fired after a failed purchase of this product.")]
		public OnPurchaseDetailedFailedEvent onPurchaseDetailedFailedEvent;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs e)
		{
			return default(PurchaseProcessingResult);
		}

		public void OnPurchaseFailed(Product product, PurchaseFailureReason reason)
		{
		}

		public void OnPurchaseFailed(Product product, PurchaseFailureDescription description)
		{
		}
	}
}
