using System;
using System.Collections.Generic;
using UnityEngine.Purchasing.Interfaces;

namespace UnityEngine.Purchasing.Utils
{
	internal class GooglePurchaseBuilder : IGooglePurchaseBuilder
	{
		private readonly IGoogleCachedQuerySkuDetailsService m_CachedQuerySkuDetailsService;

		private readonly ILogger m_Logger;

		public GooglePurchaseBuilder(IGoogleCachedQuerySkuDetailsService cachedQuerySkuDetailsService, ILogger logger)
		{
		}

		public IEnumerable<IGooglePurchase> BuildPurchases(IEnumerable<IAndroidJavaObjectWrapper> purchases)
		{
			return null;
		}

		private void LogWarningForException(Exception exception)
		{
		}

		public IGooglePurchase BuildPurchase(IAndroidJavaObjectWrapper purchase)
		{
			return null;
		}

		private static IEnumerable<IAndroidJavaObjectWrapper> TryFindAllSkuDetails(IEnumerable<string> skus, IEnumerable<IAndroidJavaObjectWrapper> skuDetails)
		{
			return null;
		}
	}
}
