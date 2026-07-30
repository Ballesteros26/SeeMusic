using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Utils;

namespace UnityEngine.Purchasing.Models
{
	internal class GooglePurchase : IGooglePurchase
	{
		[CompilerGenerated]
		private readonly string _003CorderId_003Ek__BackingField;

		public IAndroidJavaObjectWrapper javaPurchase { get; }

		public int purchaseState { get; }

		public List<string> skus { get; }

		public string receipt { get; }

		public string signature { get; }

		public string originalJson { get; }

		public string purchaseToken { get; }

		public string? sku => null;

		internal GooglePurchase(IAndroidJavaObjectWrapper purchase, IEnumerable<IAndroidJavaObjectWrapper> skuDetails)
		{
		}

		public virtual bool IsAcknowledged()
		{
			return false;
		}

		public virtual bool IsPurchased()
		{
			return false;
		}

		public virtual bool IsPending()
		{
			return false;
		}
	}
}
