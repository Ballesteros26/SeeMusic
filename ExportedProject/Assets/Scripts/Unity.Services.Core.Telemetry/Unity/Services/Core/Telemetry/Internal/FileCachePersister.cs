using Unity.Services.Core.Internal;
using Unity.Services.Core.Internal.Serialization;
using UnityEngine;

namespace Unity.Services.Core.Telemetry.Internal
{
	internal abstract class FileCachePersister
	{
		internal static bool IsAvailableFor(RuntimePlatform platform)
		{
			return false;
		}

		internal static string GetPersistentDataPathFor(RuntimePlatform platform)
		{
			return null;
		}
	}
	internal class FileCachePersister<TPayload> : FileCachePersister, ICachePersister<TPayload> where TPayload : ITelemetryPayload
	{
		private readonly IJsonSerializer m_Serializer;

		private readonly CoreDiagnostics m_Diagnostics;

		public string FilePath { get; }

		public bool CanPersist { get; }

		public FileCachePersister(string fileName, IJsonSerializer serializer, CoreDiagnostics diagnostics)
		{
		}

		public void Persist(CachedPayload<TPayload> cache)
		{
		}

		public bool TryFetch(out CachedPayload<TPayload> persistedCache)
		{
			persistedCache = null;
			return false;
		}

		public void Delete()
		{
		}
	}
}
