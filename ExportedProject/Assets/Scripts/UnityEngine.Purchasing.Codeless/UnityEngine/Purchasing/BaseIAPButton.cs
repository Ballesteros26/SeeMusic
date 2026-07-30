using UnityEngine.UI;

namespace UnityEngine.Purchasing
{
	public abstract class BaseIAPButton : MonoBehaviour
	{
		protected abstract bool ShouldConsumePurchase();

		protected abstract void OnTransactionsRestored(bool success, string error);

		protected abstract void OnPurchaseComplete(Product purchasedProduct);

		internal abstract void OnInitCompleted();

		protected abstract void AddButtonToCodelessListener();

		protected abstract void RemoveButtonToCodelessListener();

		protected abstract Button GetPurchaseButton();

		private void Start()
		{
		}

		internal abstract string GetProductId();

		internal abstract bool IsAPurchaseButton();

		protected abstract bool IsARestoreButton();

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void PurchaseProduct()
		{
		}

		protected PurchaseProcessingResult ProcessPurchaseInternal(PurchaseEventArgs args)
		{
			return default(PurchaseProcessingResult);
		}

		private void Restore()
		{
		}
	}
}
