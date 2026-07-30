namespace UnityEngine.Purchasing.Telemetry
{
	internal struct TelemetryMetricDefinition
	{
		public TelemetryMetricTypes MetricType { get; }

		public string MetricName { get; }

		public TelemetryMetricDefinition(string metricName, TelemetryMetricTypes metricType = TelemetryMetricTypes.Histogram)
		{
			MetricType = default(TelemetryMetricTypes);
			MetricName = null;
		}

		public static implicit operator TelemetryMetricDefinition(string name)
		{
			return default(TelemetryMetricDefinition);
		}
	}
}
