namespace UnityEngine.Purchasing
{
	internal class iOSStoreBindings : INativeAppleStore, INativeStore
	{
		public string appReceipt => null;

		public double appReceiptModificationDate => 0.0;

		public void SetUnityPurchasingCallback(UnityPurchasingCallback AsyncCallback)
		{
		}

		public void RestoreTransactions()
		{
		}

		public void AddTransactionObserver()
		{
		}

		public void RetrieveProducts(string json)
		{
		}

		public void Purchase(string productJSON, string developerPayload)
		{
		}

		public void FinishTransaction(string productJSON, string transactionID)
		{
		}

		public void InterceptPromotionalPurchases()
		{
		}
	}
}
