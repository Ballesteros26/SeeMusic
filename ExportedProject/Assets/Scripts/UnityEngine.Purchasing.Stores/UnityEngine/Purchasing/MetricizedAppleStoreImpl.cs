using System;
using System.Collections.ObjectModel;
using Uniject;
using UnityEngine.Purchasing.Telemetry;

namespace UnityEngine.Purchasing
{
	internal class MetricizedAppleStoreImpl : AppleStoreImpl
	{
		private readonly ITelemetryMetricsService m_TelemetryMetricsService;

		public MetricizedAppleStoreImpl(IUtil util, ITelemetryDiagnostics telemetryDiagnostics, ITelemetryMetricsService telemetryMetricsService)
			: base(null, null)
		{
		}

		[Obsolete("RestoreTransactions(Action<bool> callback) is deprecated, please use RestoreTransactions(Action<bool, string> callback) instead.")]
		public override void RestoreTransactions(Action<bool>? callback)
		{
		}

		public override void RestoreTransactions(Action<bool, string?>? callback)
		{
		}

		public override void RetrieveProducts(ReadOnlyCollection<ProductDefinition> products)
		{
		}

		public override void Purchase(ProductDefinition product, string developerPayload)
		{
		}
	}
}
