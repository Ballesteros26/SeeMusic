using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	internal class GoogleCachedQuerySkuDetailsService : IGoogleCachedQuerySkuDetailsService
	{
		private readonly Dictionary<string, AndroidJavaObject> m_CachedQueriedSkus;

		public IEnumerable<AndroidJavaObject> GetCachedQueriedSkus()
		{
			return null;
		}

		private AndroidJavaObject GetCachedQueriedSku(string sku)
		{
			return null;
		}

		private IEnumerable<AndroidJavaObject> GetCachedQueriedSkus(IEnumerable<string> skus)
		{
			return null;
		}

		public IEnumerable<AndroidJavaObject> GetCachedQueriedSkus(IEnumerable<ProductDefinition> products)
		{
			return null;
		}

		private bool Contains(string sku)
		{
			return false;
		}

		public bool Contains(ProductDefinition products)
		{
			return false;
		}

		public void AddCachedQueriedSkus(IEnumerable<AndroidJavaObject> queriedSkus)
		{
		}
	}
}
