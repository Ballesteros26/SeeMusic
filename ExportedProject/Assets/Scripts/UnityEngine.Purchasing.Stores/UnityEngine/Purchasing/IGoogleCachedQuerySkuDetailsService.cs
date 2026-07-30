using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	internal interface IGoogleCachedQuerySkuDetailsService
	{
		IEnumerable<AndroidJavaObject> GetCachedQueriedSkus();

		IEnumerable<AndroidJavaObject> GetCachedQueriedSkus(IEnumerable<ProductDefinition> products);

		bool Contains(ProductDefinition products);

		void AddCachedQueriedSkus(IEnumerable<AndroidJavaObject> queriedSkus);
	}
}
