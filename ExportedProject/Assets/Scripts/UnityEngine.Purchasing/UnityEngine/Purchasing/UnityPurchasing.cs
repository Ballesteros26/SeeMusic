using System;
using System.Collections.Generic;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	public abstract class UnityPurchasing
	{
		public static void Initialize(IDetailedStoreListener listener, ConfigurationBuilder builder)
		{
		}

		private static IAnalyticsAdapter GenerateUnityAnalytics(ILogger logger)
		{
			return null;
		}

		private static IAnalyticsAdapter GenerateLegacyUnityAnalytics()
		{
			return null;
		}

		internal static void Initialize(IStoreListener listener, ConfigurationBuilder builder, ILogger logger, string persistentDatapath, IAnalyticsAdapter ugsAnalytics, IAnalyticsAdapter legacyAnalytics, ICatalogProvider catalog, IUnityServicesInitializationChecker unityServicesInitializationChecker)
		{
		}

		internal static void FetchAndMergeProducts(bool useCatalog, HashSet<ProductDefinition> localProductSet, ICatalogProvider catalog, Action<HashSet<ProductDefinition>> callback)
		{
		}
	}
}
