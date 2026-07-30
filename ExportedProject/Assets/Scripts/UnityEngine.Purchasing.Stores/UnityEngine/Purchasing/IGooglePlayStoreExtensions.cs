using System;

namespace UnityEngine.Purchasing
{
	public interface IGooglePlayStoreExtensions : IStoreExtension
	{
		[Obsolete("RestoreTransactions(Action<bool> callback) is deprecated, please use RestoreTransactions(Action<bool, string> callback) instead.")]
		void RestoreTransactions(Action<bool> callback);

		void RestoreTransactions(Action<bool, string> callback);

		bool IsPurchasedProductDeferred(Product product);
	}
}
