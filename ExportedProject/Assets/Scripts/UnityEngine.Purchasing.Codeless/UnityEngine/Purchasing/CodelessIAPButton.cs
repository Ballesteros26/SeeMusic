using System;
using UnityEngine.Events;
using UnityEngine.Purchasing.Extension;
using UnityEngine.UI;

namespace UnityEngine.Purchasing
{
	[AddComponentMenu("In-App Purchasing/IAP Button")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.purchasing@latest")]
	public class CodelessIAPButton : BaseIAPButton
	{
		[Serializable]
		public class OnProductFetchedEvent : UnityEvent<Product>
		{
		}

		[Serializable]
		public class OnPurchaseCompletedEvent : UnityEvent<Product>
		{
		}

		[Serializable]
		public class OnPurchaseFailedEvent : UnityEvent<Product, PurchaseFailureDescription>
		{
		}

		[Serializable]
		public class OnTransactionsRestoredEvent : UnityEvent<bool, string>
		{
		}

		[HideInInspector]
		public string productId;

		[Tooltip("The type of this button, can be either a purchase or a restore button.")]
		public CodelessButtonType buttonType;

		[Tooltip("Consume the product immediately after a successful purchase.")]
		public bool consumePurchase;

		[Tooltip("Event fired after a restore transactions.")]
		public OnTransactionsRestoredEvent onTransactionsRestored;

		[Tooltip("Event fired after a successful purchase of this product.")]
		public OnPurchaseCompletedEvent onPurchaseComplete;

		[Tooltip("Event fired after a failed purchase of this product.")]
		public OnPurchaseFailedEvent onPurchaseFailed;

		[Tooltip("Event fired after a successful fetching the product information from the store.")]
		public OnProductFetchedEvent onProductFetched;

		[Tooltip("Button that triggers purchase.")]
		public Button button;

		internal override string GetProductId()
		{
			return null;
		}

		internal override bool IsAPurchaseButton()
		{
			return false;
		}

		protected override bool IsARestoreButton()
		{
			return false;
		}

		protected override bool ShouldConsumePurchase()
		{
			return false;
		}

		protected override void OnTransactionsRestored(bool success, string error)
		{
		}

		protected override void OnPurchaseComplete(Product purchasedProduct)
		{
		}

		public void OnPurchaseFailed(Product product, PurchaseFailureDescription failureDescription)
		{
		}

		protected override Button GetPurchaseButton()
		{
			return null;
		}

		protected override void AddButtonToCodelessListener()
		{
		}

		protected override void RemoveButtonToCodelessListener()
		{
		}

		internal override void OnInitCompleted()
		{
		}

		public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args)
		{
			return default(PurchaseProcessingResult);
		}
	}
}
