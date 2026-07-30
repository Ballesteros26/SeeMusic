using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace UnityEngine.Purchasing
{
	internal class UDPBindings : INativeUDPStore, INativeStore
	{
		private readonly object m_Bridge;

		private Action<bool, string> m_RetrieveProductsCallbackCache;

		public void Initialize(Action<bool, string> callback)
		{
		}

		public void Purchase(string productId, Action<bool, string> callback, string developerPayload = null)
		{
		}

		public void RetrieveProducts(ReadOnlyCollection<ProductDefinition> products, Action<bool, string> callback)
		{
		}

		public void FinishTransaction(ProductDefinition productDefinition, string transactionID)
		{
		}

		private void OnInventoryQueried(bool success, object payload)
		{
		}

		public void RetrieveProducts(string json)
		{
		}

		public void Purchase(string productJSON, string developerPayload)
		{
		}

		public void FinishTransaction(string productJSON, string transactionID)
		{
		}

		internal static Dictionary<string, string> StringPropertyToDictionary(object info)
		{
			return null;
		}
	}
}
