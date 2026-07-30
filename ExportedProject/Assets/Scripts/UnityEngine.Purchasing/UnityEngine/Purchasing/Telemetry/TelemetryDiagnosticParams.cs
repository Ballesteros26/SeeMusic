namespace UnityEngine.Purchasing.Telemetry
{
	internal struct TelemetryDiagnosticParams
	{
		internal string name;

		internal string exception;

		internal TelemetryDiagnosticParams(string diagnosticName, string diagnosticException)
		{
			name = null;
			exception = null;
		}
	}
}
