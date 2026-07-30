using Uniject;
using Unity.Services.Core.Telemetry.Internal;

namespace UnityEngine.Purchasing.Telemetry
{
	internal class TelemetryMetricsInstanceWrapper : ITelemetryMetricsInstanceWrapper
	{
		private IMetrics m_Instance;

		private ILogger m_Logger;

		private IUtil m_Util;

		private readonly TelemetryQueue<TelemetryMetricParams> m_Queue;

		public TelemetryMetricsInstanceWrapper(ILogger logger, IUtil util)
		{
		}

		public void SetMetricsInstance(IMetrics metricsInstance)
		{
		}

		public void SendMetric(TelemetryMetricTypes metricType, string metricName, double metricTimeSeconds)
		{
		}

		private void SendMetricOnMainThread(TelemetryMetricParams metricParams)
		{
		}

		private void SendMetricByTypeAndCatchExceptions(TelemetryMetricParams metricParams)
		{
		}

		private void SendMetricByType(TelemetryMetricParams metricParams)
		{
		}
	}
}
