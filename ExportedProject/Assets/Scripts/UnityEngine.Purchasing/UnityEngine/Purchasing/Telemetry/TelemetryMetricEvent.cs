using System.Diagnostics;

namespace UnityEngine.Purchasing.Telemetry
{
	internal class TelemetryMetricEvent : ITelemetryMetricEvent
	{
		private readonly ITelemetryMetricsInstanceWrapper m_TelemetryMetricsInstanceWrapper;

		private readonly TelemetryMetricTypes m_MetricType;

		private readonly string m_MetricName;

		private Stopwatch m_Stopwatch;

		internal TelemetryMetricEvent(ITelemetryMetricsInstanceWrapper telemetryMetricsInstanceWrapper, TelemetryMetricTypes metricType, string metricName)
		{
		}

		public void StartMetric()
		{
		}

		public void StopAndSendMetric()
		{
		}
	}
}
