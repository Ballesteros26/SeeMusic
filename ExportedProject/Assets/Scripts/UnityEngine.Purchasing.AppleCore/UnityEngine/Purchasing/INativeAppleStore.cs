namespace UnityEngine.Purchasing
{
	internal interface INativeAppleStore : INativeStore
	{
		string appReceipt { get; }

		double appReceiptModificationDate { get; }

		void SetUnityPurchasingCallback(UnityPurchasingCallback AsyncCallback);

		void RestoreTransactions();

		void AddTransactionObserver();

		void InterceptPromotionalPurchases();
	}
}
