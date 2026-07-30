using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Services.Core.Internal;

namespace Unity.Services.Core.Telemetry.Internal
{
	internal class DisabledDiagnosticsFactory : IDiagnosticsFactory, IServiceComponent
	{
		[CompilerGenerated]
		private readonly IReadOnlyDictionary<string, string> _003CUnity_002EServices_002ECore_002ETelemetry_002EInternal_002EIDiagnosticsFactory_002ECommonTags_003Ek__BackingField;

		IDiagnostics IDiagnosticsFactory.Create(string packageName)
		{
			return null;
		}
	}
}
