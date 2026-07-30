using System.Collections.ObjectModel;
using Uniject;
using UnityEngine.Purchasing.Default;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	internal class WinRTStore : AbstractStore, IWindowsIAPCallback, IMicrosoftExtensions, IStoreExtension
	{
		private IWindowsIAP win8;

		private IStoreCallback callback;

		private readonly IUtil util;

		private readonly ILogger logger;

		private bool m_CanReceivePurchases;

		public WinRTStore(IWindowsIAP win8, IUtil util, ILogger logger)
		{
		}

		public override void Initialize(IStoreCallback biller)
		{
		}

		public override void RetrieveProducts(ReadOnlyCollection<ProductDefinition> productDefs)
		{
		}

		public override void FinishTransaction(ProductDefinition product, string transactionId)
		{
		}

		private void init(int delay)
		{
		}

		public override void Purchase(ProductDefinition product, string developerPayload)
		{
		}

		public void restoreTransactions(bool pausing)
		{
		}

		public void RestoreTransactions()
		{
		}
	}
}
