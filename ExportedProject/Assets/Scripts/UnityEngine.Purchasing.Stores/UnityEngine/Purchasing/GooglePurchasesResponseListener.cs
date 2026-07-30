using System;
using System.Collections.Generic;
using UnityEngine.Purchasing.Models;
using UnityEngine.Purchasing.Utils;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	internal class GooglePurchasesResponseListener : AndroidJavaProxy
	{
		private readonly Action<IGoogleBillingResult, IEnumerable<IAndroidJavaObjectWrapper>> m_OnQueryPurchasesResponse;

		internal GooglePurchasesResponseListener(Action<IGoogleBillingResult, IEnumerable<IAndroidJavaObjectWrapper>> onQueryPurchasesResponse)
			: base((string)null)
		{
		}

		[Preserve]
		public void onQueryPurchasesResponse(AndroidJavaObject billingResult, AndroidJavaObject purchases)
		{
		}
	}
}
