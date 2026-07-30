using System;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Security;
using UnityEngine.Purchasing.Telemetry;

namespace UnityEngine.Purchasing
{
	internal class GooglePlayStoreExtensions : IGooglePlayStoreExtensions, IStoreExtension, IGooglePlayStoreExtensionsInternal
	{
		private readonly IGooglePlayStoreService m_GooglePlayStoreService;

		private readonly IGooglePlayStoreFinishTransactionService m_GooglePlayStoreFinishTransactionService;

		private readonly ITelemetryDiagnostics m_TelemetryDiagnostics;

		private readonly ILogger m_Logger;

		private IStoreCallback? m_StoreCallback;

		internal GooglePlayStoreExtensions(IGooglePlayStoreService googlePlayStoreService, IGooglePlayStoreFinishTransactionService googlePlayStoreFinishTransactionService, ILogger logger, ITelemetryDiagnostics telemetryDiagnostics)
		{
		}

		[Obsolete("RestoreTransactions(Action<bool> callback) is deprecated, please use RestoreTransactions(Action<bool, string> callback) instead.")]
		public virtual void RestoreTransactions(Action<bool>? callback)
		{
		}

		public virtual void RestoreTransactions(Action<bool, string?>? callback)
		{
		}

		public void SetStoreCallback(IStoreCallback storeCallback)
		{
		}

		public bool IsPurchasedProductDeferred(Product product)
		{
			return false;
		}

		private bool TryIsPurchasedProductDeferred(Product product)
		{
			return false;
		}

		public GooglePurchaseState GetPurchaseState(Product product)
		{
			return default(GooglePurchaseState);
		}
	}
}
