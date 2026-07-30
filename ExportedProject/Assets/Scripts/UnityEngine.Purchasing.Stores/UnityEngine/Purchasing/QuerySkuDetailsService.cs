using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Uniject;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Stores.Util;
using UnityEngine.Purchasing.Telemetry;

namespace UnityEngine.Purchasing
{
	internal class QuerySkuDetailsService : IQuerySkuDetailsService
	{
		private readonly IGoogleBillingClient m_BillingClient;

		private readonly IGoogleCachedQuerySkuDetailsService m_GoogleCachedQuerySkuDetailsService;

		private readonly ISkuDetailsConverter m_SkuDetailsConverter;

		private readonly IRetryPolicy m_RetryPolicy;

		private readonly IGoogleProductCallback m_GoogleProductCallback;

		private readonly IUtil m_Util;

		private readonly ITelemetryDiagnostics m_TelemetryDiagnostics;

		internal QuerySkuDetailsService(IGoogleBillingClient billingClient, IGoogleCachedQuerySkuDetailsService googleCachedQuerySkuDetailsService, ISkuDetailsConverter skuDetailsConverter, IRetryPolicy retryPolicy, IGoogleProductCallback googleProductCallback, IUtil util, ITelemetryDiagnostics telemetryDiagnostics)
		{
		}

		public void QueryAsyncSku(ProductDefinition product, Action<List<AndroidJavaObject>> onSkuDetailsResponse)
		{
		}

		public void QueryAsyncSku(ReadOnlyCollection<ProductDefinition> products, Action<List<ProductDescription>> onSkuDetailsResponse)
		{
		}

		public void QueryAsyncSku(ReadOnlyCollection<ProductDefinition> products, Action<List<AndroidJavaObject>> onSkuDetailsResponse)
		{
		}

		private void QueryAsyncSkuWithRetries(IReadOnlyCollection<ProductDefinition> products, Action<List<AndroidJavaObject>> onSkuDetailsResponse, Action retryQuery)
		{
		}

		private void TryQueryAsyncSkuWithRetries(IReadOnlyCollection<ProductDefinition> products, Action<List<AndroidJavaObject>> onSkuDetailsResponse, Action retryQuery)
		{
		}

		private bool ShouldRetryQuery(IEnumerable<ProductDefinition> requestedProducts, ISkuDetailsQueryResponse queryResponse)
		{
			return false;
		}

		private bool AreAllSkuDetailsCached(IEnumerable<ProductDefinition> products)
		{
			return false;
		}

		private IEnumerable<AndroidJavaObject> GetCachedSkuDetails(IEnumerable<ProductDefinition> products)
		{
			return null;
		}

		private void QueryInAppsAsync(IEnumerable<ProductDefinition> products, ISkuDetailsResponseConsolidator consolidator)
		{
		}

		private void QuerySubsAsync(IEnumerable<ProductDefinition> products, ISkuDetailsResponseConsolidator consolidator)
		{
		}

		private void QuerySkuDetails(List<string> skus, string type, ISkuDetailsResponseConsolidator consolidator)
		{
		}
	}
}
