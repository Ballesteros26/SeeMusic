using System.Threading.Tasks;
using Unity.Services.Core.Internal;
using UnityEngine.Purchasing.Telemetry;

namespace UnityEngine.Purchasing.Registration
{
	internal class IapCoreInitializeCallback : IInitializablePackage
	{
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void Register()
		{
		}

		public Task Initialize(CoreRegistry registry)
		{
			return null;
		}

		private static void CacheInitializedEnvironment(CoreRegistry registry)
		{
		}

		private static string GetCurrentEnvironment(CoreRegistry registry)
		{
			return null;
		}

		private static void InitializeTelemetryComponents(ITelemetryMetricsInstanceWrapper metricsInstanceWrapper, ITelemetryDiagnosticsInstanceWrapper diagnosticsInstanceWrapper)
		{
		}
	}
}
