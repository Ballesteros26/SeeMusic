using System.Collections.Generic;

namespace UnityEngine.Purchasing.Interfaces
{
	internal interface IGooglePurchase
	{
		int purchaseState { get; }

		List<string> skus { get; }

		string receipt { get; }

		string purchaseToken { get; }

		string? sku { get; }

		bool IsAcknowledged();

		bool IsPurchased();

		bool IsPending();
	}
}
