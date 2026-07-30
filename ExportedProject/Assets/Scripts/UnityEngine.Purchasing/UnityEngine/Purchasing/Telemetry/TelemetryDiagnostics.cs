using System;

namespace UnityEngine.Purchasing.Telemetry
{
	internal class TelemetryDiagnostics : ITelemetryDiagnostics
	{
		private readonly ITelemetryDiagnosticsInstanceWrapper m_TelemetryDiagnosticsInstanceWrapper;

		public TelemetryDiagnostics(ITelemetryDiagnosticsInstanceWrapper telemetryDiagnosticsInstanceWrapper)
		{
		}

		public void SendDiagnostic(string diagnosticName, Exception e)
		{
		}
	}
}
