using Unity.Services.Core.Telemetry.Internal;

namespace UnityEngine.Purchasing.Telemetry
{
	internal interface ITelemetryMetricsInstanceWrapper
	{
		void SetMetricsInstance(IMetrics metricsInstance);

		void SendMetric(TelemetryMetricTypes telemetryMetricTypes, string metricName, double metricTimeSeconds);
	}
}
