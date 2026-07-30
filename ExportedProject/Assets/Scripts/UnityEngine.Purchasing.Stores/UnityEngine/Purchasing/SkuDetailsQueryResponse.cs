using System.Collections.Concurrent;
using System.Collections.Generic;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Models;

namespace UnityEngine.Purchasing
{
	internal class SkuDetailsQueryResponse : ISkuDetailsQueryResponse
	{
		private readonly ConcurrentBag<(IGoogleBillingResult, IEnumerable<AndroidJavaObject>)> m_Responses;

		public void AddResponse(IGoogleBillingResult billingResult, IEnumerable<AndroidJavaObject> skuDetails)
		{
		}

		public List<AndroidJavaObject> SkuDetails()
		{
			return null;
		}

		public bool IsRecoverable()
		{
			return false;
		}

		private static bool IsRecoverable(IGoogleBillingResult billingResult)
		{
			return false;
		}
	}
}
