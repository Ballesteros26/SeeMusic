namespace UnityEngine.Purchasing.Interfaces
{
	internal interface IGoogleLastKnownProductService
	{
		string? LastKnownOldProductId { get; set; }

		string? LastKnownProductId { get; set; }

		GooglePlayProrationMode? LastKnownProrationMode { get; set; }
	}
}
