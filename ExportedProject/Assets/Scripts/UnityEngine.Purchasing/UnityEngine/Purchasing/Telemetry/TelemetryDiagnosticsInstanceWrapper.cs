using Uniject;
using Unity.Services.Core.Telemetry.Internal;

namespace UnityEngine.Purchasing.Telemetry
{
	internal class TelemetryDiagnosticsInstanceWrapper : ITelemetryDiagnosticsInstanceWrapper
	{
		private IDiagnostics m_Instance;

		private ILogger m_Logger;

		private IUtil m_Util;

		private readonly TelemetryQueue<TelemetryDiagnosticParams> m_Queue;

		public TelemetryDiagnosticsInstanceWrapper(ILogger logger, IUtil util)
		{
		}

		public void SetDiagnosticsInstance(IDiagnostics diagnosticsInstance)
		{
		}

		public void SendDiagnostic(string diagnosticName, string diagnosticException)
		{
		}

		private void SendDiagnosticOnMainThread(TelemetryDiagnosticParams diagnosticParams)
		{
		}

		private void SendDiagnosticAndCatchExceptions(TelemetryDiagnosticParams diagnosticParams)
		{
		}
	}
}
