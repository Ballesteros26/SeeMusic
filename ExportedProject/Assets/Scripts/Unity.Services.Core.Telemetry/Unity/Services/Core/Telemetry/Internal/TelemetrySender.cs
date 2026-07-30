using System.Threading.Tasks;
using JetBrains.Annotations;
using Unity.Services.Core.Internal.Serialization;
using Unity.Services.Core.Scheduler.Internal;
using UnityEngine.Networking;

namespace Unity.Services.Core.Telemetry.Internal
{
	internal class TelemetrySender
	{
		private readonly ExponentialBackOffRetryPolicy m_RetryPolicy;

		private readonly IActionScheduler m_Scheduler;

		private readonly IUnityWebRequestSender m_RequestSender;

		public string TargetUrl { get; }

		internal IJsonSerializer Serializer { get; }

		public TelemetrySender([NotNull] string targetUrl, [NotNull] string servicePath, [NotNull] IActionScheduler scheduler, [NotNull] ExponentialBackOffRetryPolicy retryPolicy, [NotNull] IUnityWebRequestSender requestSender, [NotNull] IJsonSerializer serializer)
		{
		}

		public Task SendAsync<TPayload>(TPayload payload) where TPayload : ITelemetryPayload
		{
			return null;
		}

		internal byte[] SerializePayload<TPayload>(TPayload payload) where TPayload : ITelemetryPayload
		{
			return null;
		}

		internal UnityWebRequest CreateRequest(byte[] serializedPayload)
		{
			return null;
		}
	}
}
