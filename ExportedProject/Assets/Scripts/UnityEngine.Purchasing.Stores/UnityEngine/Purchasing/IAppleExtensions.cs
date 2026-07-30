using System;
using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	public interface IAppleExtensions : IStoreExtension
	{
		[Obsolete("RestoreTransactions(Action<bool> callback) is deprecated, please use RestoreTransactions(Action<bool, string> callback) instead.")]
		void RestoreTransactions(Action<bool> callback);

		void RestoreTransactions(Action<bool, string> callback);

		Dictionary<string, string> GetIntroductoryPriceDictionary();
	}
}
