using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	public class ProductCollection
	{
		private Dictionary<string, Product> m_IdToProduct;

		private Dictionary<string, Product> m_StoreSpecificIdToProduct;

		public HashSet<Product> set { get; }

		public Product[] all { get; private set; }

		internal ProductCollection(Product[] products)
		{
		}

		internal void AddProducts(IEnumerable<Product> products)
		{
		}

		public Product WithID(string id)
		{
			return null;
		}

		public Product WithStoreSpecificID(string id)
		{
			return null;
		}
	}
}
