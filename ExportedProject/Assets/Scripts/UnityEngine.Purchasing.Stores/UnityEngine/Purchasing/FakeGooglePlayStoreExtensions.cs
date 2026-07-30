using System;

namespace UnityEngine.Purchasing
{
	public class FakeGooglePlayStoreExtensions : IGooglePlayStoreExtensions, IStoreExtension
	{
		[Obsolete("RestoreTransactions(Action<bool> callback) is deprecated, please use RestoreTransactions(Action<bool, string> callback) instead.")]
		public void RestoreTransactions(Action<bool> callback)
		{
		}

		public void RestoreTransactions(Action<bool, string> callback)
		{
		}

		public bool IsPurchasedProductDeferred(Product product)
		{
			return false;
		}
	}
}
