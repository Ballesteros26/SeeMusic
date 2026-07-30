using System;
using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	internal class FakeAppleExtensions : IAppleExtensions, IStoreExtension
	{
		[Obsolete("RestoreTransactions(Action<bool> callback) is deprecated, please use RestoreTransactions(Action<bool, string> callback) instead.")]
		public void RestoreTransactions(Action<bool>? callback)
		{
		}

		public void RestoreTransactions(Action<bool, string?>? callback)
		{
		}

		public Dictionary<string, string> GetIntroductoryPriceDictionary()
		{
			return null;
		}
	}
}
