using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Services.Core.Internal;

namespace Unity.Services.Core.Telemetry.Internal
{
	internal class DisabledMetricsFactory : IMetricsFactory, IServiceComponent
	{
		[CompilerGenerated]
		private readonly IReadOnlyDictionary<string, string> _003CUnity_002EServices_002ECore_002ETelemetry_002EInternal_002EIMetricsFactory_002ECommonTags_003Ek__BackingField;

		IMetrics IMetricsFactory.Create(string packageName)
		{
			return null;
		}
	}
}
