using System;

namespace UnityEngine.Purchasing.Telemetry
{
	internal class TelemetryMetricsService : ITelemetryMetricsService
	{
		private readonly ITelemetryMetricsInstanceWrapper m_TelemetryMetricsInstanceWrapper;

		public TelemetryMetricsService(ITelemetryMetricsInstanceWrapper telemetryMetricsInstanceWrapper)
		{
		}

		public void ExecuteTimedAction(Action timedAction, TelemetryMetricDefinition metricDefinition)
		{
		}

		public ITelemetryMetricEvent CreateAndStartMetricEvent(TelemetryMetricDefinition metricDefinition)
		{
			return null;
		}
	}
}
