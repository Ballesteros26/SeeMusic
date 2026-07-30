using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Unity.Services.Core.Telemetry.Internal
{
	[Serializable]
	internal struct DiagnosticsPayload : ITelemetryPayload
	{
		[JsonProperty("diagnostics")]
		public List<Diagnostic> Diagnostics;

		[JsonProperty("commonTags")]
		public Dictionary<string, string> CommonTags;

		[JsonProperty("diagnosticsCommonTags")]
		public Dictionary<string, string> DiagnosticsCommonTags;

		Dictionary<string, string> ITelemetryPayload.CommonTags => null;

		int ITelemetryPayload.Count => 0;

		void ITelemetryPayload.Add(ITelemetryEvent telemetryEvent)
		{
		}
	}
}
