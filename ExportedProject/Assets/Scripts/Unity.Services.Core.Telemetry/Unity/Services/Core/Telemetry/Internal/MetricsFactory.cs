using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Services.Core.Configuration.Internal;
using Unity.Services.Core.Internal;

namespace Unity.Services.Core.Telemetry.Internal
{
	internal class MetricsFactory : IMetricsFactory, IServiceComponent
	{
		private readonly IProjectConfiguration m_ProjectConfig;

		[CompilerGenerated]
		private readonly IReadOnlyDictionary<string, string> _003CCommonTags_003Ek__BackingField;

		internal MetricsHandler Handler { get; }

		public MetricsFactory(MetricsHandler handler, IProjectConfiguration projectConfig)
		{
		}

		public IMetrics Create(string packageName)
		{
			return null;
		}
	}
}
