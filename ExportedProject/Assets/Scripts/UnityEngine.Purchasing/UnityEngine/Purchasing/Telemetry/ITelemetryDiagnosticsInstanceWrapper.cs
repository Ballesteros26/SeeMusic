using Unity.Services.Core.Telemetry.Internal;

namespace UnityEngine.Purchasing.Telemetry
{
	internal interface ITelemetryDiagnosticsInstanceWrapper
	{
		void SetDiagnosticsInstance(IDiagnostics diagnosticsInstance);

		void SendDiagnostic(string diagnosticName, string diagnosticException);
	}
}
