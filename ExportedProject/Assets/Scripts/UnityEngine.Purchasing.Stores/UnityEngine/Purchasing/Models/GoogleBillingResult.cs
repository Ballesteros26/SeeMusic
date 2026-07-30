namespace UnityEngine.Purchasing.Models
{
	internal class GoogleBillingResult : IGoogleBillingResult
	{
		public GoogleBillingResponseCode responseCode { get; }

		public string debugMessage { get; }

		internal GoogleBillingResult(AndroidJavaObject billingResult)
		{
		}
	}
}
