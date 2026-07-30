using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Services.Core.Configuration.Internal;
using Unity.Services.Core.Internal;

namespace Unity.Services.Core.Telemetry.Internal
{
	internal class DiagnosticsFactory : IDiagnosticsFactory, IServiceComponent
	{
		private readonly IProjectConfiguration m_ProjectConfig;

		[CompilerGenerated]
		private readonly IReadOnlyDictionary<string, string> _003CCommonTags_003Ek__BackingField;

		internal DiagnosticsHandler Handler { get; }

		public DiagnosticsFactory(DiagnosticsHandler handler, IProjectConfiguration projectConfig)
		{
		}

		public IDiagnostics Create(string packageName)
		{
			return null;
		}
	}
}
