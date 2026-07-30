namespace UnityEngine.Purchasing
{
	internal delegate void UnityPurchasingCallback(string subject, string payload, string receipt, string transactionId, string originalTransactionId, bool isRestored);
}
