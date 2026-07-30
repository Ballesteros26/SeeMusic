namespace UnityEngine.Purchasing.Models
{
	internal interface IGoogleBillingResult
	{
		GoogleBillingResponseCode responseCode { get; }

		string debugMessage { get; }
	}
}
