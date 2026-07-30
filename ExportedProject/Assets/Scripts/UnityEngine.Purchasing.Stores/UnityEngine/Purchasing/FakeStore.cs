using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	internal class FakeStore : JSONStore, IStoreExtension, INativeStore
	{
		protected enum DialogType
		{
			Purchase = 0,
			RetrieveProducts = 1
		}

		private IStoreCallback m_Biller;

		private readonly List<string> m_PurchasedProducts;

		public bool purchaseCalled;

		public FakeStoreUIMode UIMode;

		public string unavailableProductId { get; }

		public override void Initialize(IStoreCallback biller)
		{
		}

		public void RetrieveProducts(string json)
		{
		}

		public void StoreRetrieveProducts(ReadOnlyCollection<ProductDefinition> productDefinitions)
		{
		}

		public void Purchase(string productJSON, string developerPayload)
		{
		}

		private void FakePurchase(ProductDefinition product, string developerPayload)
		{
		}

		public void FinishTransaction(string productJSON, string transactionID)
		{
		}

		public override void FinishTransaction(ProductDefinition product, string transactionId)
		{
		}

		protected virtual bool StartUI<T>(object model, DialogType dialogType, Action<bool, T> callback)
		{
			return false;
		}
	}
}
