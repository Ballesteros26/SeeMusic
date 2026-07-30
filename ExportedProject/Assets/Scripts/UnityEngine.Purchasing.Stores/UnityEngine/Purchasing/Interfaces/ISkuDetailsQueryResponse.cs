using System.Collections.Generic;
using UnityEngine.Purchasing.Models;

namespace UnityEngine.Purchasing.Interfaces
{
	internal interface ISkuDetailsQueryResponse
	{
		void AddResponse(IGoogleBillingResult billingResult, IEnumerable<AndroidJavaObject> skuDetails);

		List<AndroidJavaObject> SkuDetails();

		bool IsRecoverable();
	}
}
