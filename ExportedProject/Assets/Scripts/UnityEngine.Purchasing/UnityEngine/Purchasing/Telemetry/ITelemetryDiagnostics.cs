using System;

namespace UnityEngine.Purchasing.Telemetry
{
	internal interface ITelemetryDiagnostics
	{
		void SendDiagnostic(string diagnosticName, Exception e);
	}
}
