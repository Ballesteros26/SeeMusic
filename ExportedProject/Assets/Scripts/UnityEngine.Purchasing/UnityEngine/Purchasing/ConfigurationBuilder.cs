using System.Collections.Generic;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	public class ConfigurationBuilder
	{
		public bool useCatalogProvider { get; }

		public HashSet<ProductDefinition> products { get; }

		internal PurchasingFactory factory { get; }

		internal ConfigurationBuilder(PurchasingFactory factory)
		{
		}

		public T Configure<T>() where T : IStoreConfiguration
		{
			return default(T);
		}

		public static ConfigurationBuilder Instance(IPurchasingModule first, params IPurchasingModule[] rest)
		{
			return null;
		}

		public ConfigurationBuilder AddProduct(string id, ProductType type, IDs storeIDs, IEnumerable<PayoutDefinition> payouts)
		{
			return null;
		}
	}
}
