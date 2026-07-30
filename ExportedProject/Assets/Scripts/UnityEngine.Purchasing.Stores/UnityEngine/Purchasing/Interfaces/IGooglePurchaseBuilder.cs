using System.Collections.Generic;
using UnityEngine.Purchasing.Utils;

namespace UnityEngine.Purchasing.Interfaces
{
	internal interface IGooglePurchaseBuilder
	{
		IEnumerable<IGooglePurchase> BuildPurchases(IEnumerable<IAndroidJavaObjectWrapper> purchases);
	}
}
