using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	public class ProductDefinition
	{
		private readonly List<PayoutDefinition> m_Payouts;

		public string id { get; private set; }

		public string storeSpecificId { get; private set; }

		public ProductType type { get; private set; }

		public bool enabled { get; private set; }

		public IEnumerable<PayoutDefinition> payouts => null;

		public ProductDefinition(string id, string storeSpecificId, ProductType type)
		{
		}

		public ProductDefinition(string id, string storeSpecificId, ProductType type, bool enabled)
		{
		}

		public ProductDefinition(string id, string storeSpecificId, ProductType type, bool enabled, IEnumerable<PayoutDefinition> payouts)
		{
		}

		public ProductDefinition(string id, ProductType type)
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		internal void SetPayouts(IEnumerable<PayoutDefinition> newPayouts)
		{
		}
	}
}
