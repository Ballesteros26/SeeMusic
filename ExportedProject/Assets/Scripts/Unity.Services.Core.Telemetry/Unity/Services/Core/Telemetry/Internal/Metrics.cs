using System.Collections.Generic;

namespace Unity.Services.Core.Telemetry.Internal
{
	internal class Metrics : IMetrics
	{
		internal MetricsHandler Handler { get; }

		internal IDictionary<string, string> PackageTags { get; }

		public Metrics(MetricsHandler handler, IDictionary<string, string> packageTags)
		{
		}

		internal Metric CreateMetric(string name, double value, MetricType type, IDictionary<string, string> tags)
		{
			return default(Metric);
		}

		void IMetrics.SendGaugeMetric(string name, double value, IDictionary<string, string> tags)
		{
		}

		void IMetrics.SendHistogramMetric(string name, double time, IDictionary<string, string> tags)
		{
		}

		void IMetrics.SendSumMetric(string name, double value, IDictionary<string, string> tags)
		{
		}
	}
}
