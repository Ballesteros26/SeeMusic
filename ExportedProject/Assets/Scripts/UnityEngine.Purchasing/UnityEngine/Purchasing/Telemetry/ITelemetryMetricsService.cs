using System;

namespace UnityEngine.Purchasing.Telemetry
{
	internal interface ITelemetryMetricsService
	{
		void ExecuteTimedAction(Action timedAction, TelemetryMetricDefinition metricDefinition);
	}
}
