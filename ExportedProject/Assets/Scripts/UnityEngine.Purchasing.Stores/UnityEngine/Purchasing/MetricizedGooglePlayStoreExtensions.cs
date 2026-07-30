using System;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Telemetry;

namespace UnityEngine.Purchasing
{
	internal class MetricizedGooglePlayStoreExtensions : GooglePlayStoreExtensions
	{
		private readonly ITelemetryMetricsService m_TelemetryMetricsService;

		internal MetricizedGooglePlayStoreExtensions(IGooglePlayStoreService googlePlayStoreService, IGooglePlayStoreFinishTransactionService googlePlayStoreFinishTransactionService, ILogger logger, ITelemetryDiagnostics telemetryDiagnostics, ITelemetryMetricsService telemetryMetricsService)
			: base(null, null, null, null)
		{
		}

		[Obsolete("RestoreTransactions(Action<bool> callback) is deprecated, please use RestoreTransactions(Action<bool, string> callback) instead.")]
		public override void RestoreTransactions(Action<bool>? callback)
		{
		}

		public override void RestoreTransactions(Action<bool, string?>? callback)
		{
		}
	}
}
