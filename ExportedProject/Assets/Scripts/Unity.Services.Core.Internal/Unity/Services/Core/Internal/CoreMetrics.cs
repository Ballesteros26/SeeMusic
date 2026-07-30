using System;
using System.Collections.Generic;
using Unity.Services.Core.Configuration.Internal;
using Unity.Services.Core.Telemetry.Internal;

namespace Unity.Services.Core.Internal
{
	internal class CoreMetrics
	{
		public static CoreMetrics Instance { get; internal set; }

		internal IMetrics Metrics { get; set; }

		internal IDictionary<Type, IMetrics> AllPackageMetrics { get; }

		public void SendAllPackagesInitSuccessMetric()
		{
		}

		public void SendAllPackagesInitTimeMetric(double initTimeSeconds)
		{
		}

		public void SendInitTimeMetricForPackage(Type packageType, double initTimeSeconds)
		{
		}

		public void Initialize(IProjectConfiguration configuration, IMetricsFactory factory, Type corePackageType)
		{
		}

		internal void FindAndCacheAllPackageMetrics(IProjectConfiguration configuration, IMetricsFactory factory)
		{
		}
	}
}
