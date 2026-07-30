using System.Collections.ObjectModel;
using Stores.Util;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	internal class JSONStore : AbstractStore, IUnityCallback, IStoreInternal, ITransactionHistoryExtensions, IStoreExtension
	{
		protected IStoreCallback unity;

		private INativeStore m_Store;

		private StandardPurchasingModule m_Module;

		protected ILogger m_Logger;

		protected JsonProductDescriptionsDeserializer m_ProductDescriptionsDeserializer;

		protected PurchaseFailureDescription m_LastPurchaseFailureDescription;

		private StoreSpecificPurchaseErrorCode m_LastPurchaseErrorCode;

		public void SetNativeStore(INativeStore native)
		{
		}

		void IStoreInternal.SetModule(StandardPurchasingModule module)
		{
		}

		public override void Initialize(IStoreCallback callback)
		{
		}

		public override void RetrieveProducts(ReadOnlyCollection<ProductDefinition> products)
		{
		}

		public override void Purchase(ProductDefinition product, string developerPayload)
		{
		}

		public override void FinishTransaction(ProductDefinition product, string transactionId)
		{
		}

		public void OnSetupFailed(string reason)
		{
		}

		public virtual void OnProductsRetrieved(string json)
		{
		}

		public virtual void OnPurchaseSucceeded(string id, string receipt, string transactionID)
		{
		}

		public void OnPurchaseFailed(string json)
		{
		}

		public void OnPurchaseFailed(PurchaseFailureDescription failure, string json = null)
		{
		}

		public PurchaseFailureDescription GetLastPurchaseFailureDescription()
		{
			return null;
		}

		public StoreSpecificPurchaseErrorCode GetLastStoreSpecificPurchaseErrorCode()
		{
			return default(StoreSpecificPurchaseErrorCode);
		}

		private StoreSpecificPurchaseErrorCode ParseStoreSpecificPurchaseErrorCode(string json)
		{
			return default(StoreSpecificPurchaseErrorCode);
		}
	}
}
