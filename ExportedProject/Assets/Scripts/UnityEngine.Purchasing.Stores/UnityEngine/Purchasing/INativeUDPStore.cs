using System;
using System.Collections.ObjectModel;

namespace UnityEngine.Purchasing
{
	internal interface INativeUDPStore : INativeStore
	{
		void Initialize(Action<bool, string> callback);

		void Purchase(string productId, Action<bool, string> callback, string developerPayload = null);

		void RetrieveProducts(ReadOnlyCollection<ProductDefinition> products, Action<bool, string> callback);

		void FinishTransaction(ProductDefinition productDefinition, string transactionID);
	}
}
