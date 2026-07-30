namespace UnityEngine.Purchasing.Telemetry
{
	internal struct TelemetryMetricParams
	{
		internal TelemetryMetricTypes type;

		internal string name;

		internal double timeSeconds;

		internal TelemetryMetricParams(TelemetryMetricTypes metricType, string metricName, double metricTimeSeconds)
		{
			type = default(TelemetryMetricTypes);
			name = null;
			timeSeconds = 0.0;
		}
	}
}
