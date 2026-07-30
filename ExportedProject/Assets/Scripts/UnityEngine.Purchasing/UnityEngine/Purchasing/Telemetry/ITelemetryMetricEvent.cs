namespace UnityEngine.Purchasing.Telemetry
{
	internal interface ITelemetryMetricEvent
	{
		void StartMetric();

		void StopAndSendMetric();
	}
}
