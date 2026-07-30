using System.Collections.ObjectModel;
using UnityEngine.Purchasing.Telemetry;

namespace UnityEngine.Purchasing
{
	internal class MetricizedJsonStore : JSONStore
	{
		private readonly ITelemetryMetricsService m_TelemetryMetricsService;

		public MetricizedJsonStore(ITelemetryMetricsService telemetryMetricsService)
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
