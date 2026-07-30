using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	internal class UDPImpl : JSONStore, IUDPExtensions, IStoreExtension
	{
		private INativeUDPStore m_Bindings;

		private object m_UserInfo;

		private string m_LastInitError;

		private bool m_Initialized;

		private Action<Product> m_DeferredCallback;

		public void SetNativeStore(INativeUDPStore nativeUdpStore)
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

		private void OnPurchaseDeferred(string productId)
		{
		}

		public override void FinishTransaction(ProductDefinition product, string transactionId)
		{
		}

		private static void DictionaryToStringProperty(Dictionary<string, object> dic, object info)
		{
		}
	}
}
