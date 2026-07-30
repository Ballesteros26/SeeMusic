using System.Collections.Generic;
using Uniject;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	internal class ScriptingStoreCallback : IStoreCallback
	{
		private readonly IStoreCallback m_ForwardTo;

		private readonly IUtil m_Util;

		public ProductCollection products => null;

		public ScriptingStoreCallback(IStoreCallback forwardTo, IUtil util)
		{
		}

		public void OnSetupFailed(InitializationFailureReason reason, string? message)
		{
		}

		public void OnProductsRetrieved(List<ProductDescription> products)
		{
		}

		public void OnPurchaseSucceeded(string id, string? receipt, string transactionID)
		{
		}

		public void OnAllPurchasesRetrieved(List<Product> purchasedProducts)
		{
		}

		public void OnPurchaseFailed(PurchaseFailureDescription desc)
		{
		}
	}
}
