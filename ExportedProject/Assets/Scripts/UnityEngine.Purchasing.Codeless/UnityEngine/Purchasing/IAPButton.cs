using System;
using UnityEngine.Events;
using UnityEngine.UI;

namespace UnityEngine.Purchasing
{
	[RequireComponent(typeof(Button))]
	[AddComponentMenu("In-App Purchasing/IAP Button (legacy)", int.MaxValue)]
	[HelpURL("https://docs.unity3d.com/Manual/UnityIAP.html")]
	[Obsolete("IAPButton is deprecated, please use CodelessIAPButton instead.", false)]
	public class IAPButton : BaseIAPButton
	{
		public enum ButtonType
		{
			Purchase = 0,
			Restore = 1
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
		public class OnTransactionsRestoredEvent : UnityEvent<bool, string>
		{
		}

		[HideInInspector]
		public string productId;

		[Tooltip("The type of this button, can be either a purchase or a restore button.")]
		public ButtonType buttonType;

		[Tooltip("Consume the product immediately after a successful purchase.")]
		public bool consumePurchase;

		[Tooltip("Event fired after a restore transactions.")]
		public OnTransactionsRestoredEvent onTransactionsRestored;

		[Tooltip("Event fired after a successful purchase of this product.")]
		public OnPurchaseCompletedEvent onPurchaseComplete;

		[Tooltip("Event fired after a failed purchase of this product.")]
		public OnPurchaseFailedEvent onPurchaseFailed;

		[Tooltip("[Optional] Displays the localized title from the app store.")]
		public Text titleText;

		[Tooltip("[Optional] Displays the localized description from the app store.")]
		public Text descriptionText;

		[Tooltip("[Optional] Displays the localized price from the app store.")]
		public Text priceText;

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

		public void OnPurchaseFailed(Product product, PurchaseFailureReason reason)
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

		private void UpdateAllTexts()
		{
		}

		public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs e)
		{
			return default(PurchaseProcessingResult);
		}
	}
}
