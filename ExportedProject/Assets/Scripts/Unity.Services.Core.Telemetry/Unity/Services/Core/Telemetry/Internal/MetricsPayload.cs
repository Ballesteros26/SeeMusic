using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Unity.Services.Core.Telemetry.Internal
{
	[Serializable]
	internal struct MetricsPayload : ITelemetryPayload
	{
		[JsonProperty("metrics")]
		public List<Metric> Metrics;

		[JsonProperty("commonTags")]
		public Dictionary<string, string> CommonTags;

		[JsonProperty("metricsCommonTags")]
		public Dictionary<string, string> MetricsCommonTags;

		Dictionary<string, string> ITelemetryPayload.CommonTags => null;

		int ITelemetryPayload.Count => 0;

		void ITelemetryPayload.Add(ITelemetryEvent telemetryEvent)
		{
		}
	}
}
