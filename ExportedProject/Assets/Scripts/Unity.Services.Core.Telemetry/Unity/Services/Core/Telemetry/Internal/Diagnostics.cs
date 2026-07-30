using System.Collections.Generic;

namespace Unity.Services.Core.Telemetry.Internal
{
	internal class Diagnostics : IDiagnostics
	{
		internal DiagnosticsHandler Handler { get; }

		internal IDictionary<string, string> PackageTags { get; }

		public Diagnostics(DiagnosticsHandler handler, IDictionary<string, string> packageTags)
		{
		}

		public void SendDiagnostic(string name, string message, IDictionary<string, string> tags = null)
		{
		}
	}
}
