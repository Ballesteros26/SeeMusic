using System.Collections.Generic;
using UnityEngine.Purchasing.Models;

namespace UnityEngine.Purchasing.Interfaces
{
	internal interface ISkuDetailsResponseConsolidator
	{
		void Consolidate(IGoogleBillingResult billingResult, IEnumerable<AndroidJavaObject> skuDetails);
	}
}
