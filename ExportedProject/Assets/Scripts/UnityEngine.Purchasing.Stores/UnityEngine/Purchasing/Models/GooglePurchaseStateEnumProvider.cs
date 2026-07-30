using UnityEngine.Purchasing.Interfaces;

namespace UnityEngine.Purchasing.Models
{
	internal class GooglePurchaseStateEnumProvider : IGooglePurchaseStateEnumProvider
	{
		public int Purchased()
		{
			return 0;
		}

		public int Pending()
		{
			return 0;
		}
	}
}
