using System;
using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	[Serializable]
	public class ProductCatalogItem
	{
		public string id;

		public ProductType type;

		[SerializeField]
		private List<StoreID> storeIDs;

		public LocalizedProductDescription defaultDescription;

		public Price googlePrice;

		[SerializeField]
		private List<LocalizedProductDescription> descriptions;

		public Price udpPrice;

		[SerializeField]
		private List<ProductCatalogPayout> payouts;

		public IList<ProductCatalogPayout> Payouts => null;

		public ICollection<StoreID> allStoreIDs => null;
	}
}
