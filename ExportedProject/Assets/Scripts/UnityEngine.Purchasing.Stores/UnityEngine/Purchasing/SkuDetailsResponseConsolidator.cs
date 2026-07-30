using System;
using System.Collections.Generic;
using Uniject;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Models;
using UnityEngine.Purchasing.Telemetry;

namespace UnityEngine.Purchasing
{
	internal class SkuDetailsResponseConsolidator : ISkuDetailsResponseConsolidator
	{
		private int m_NumberReceivedCallbacks;

		private readonly Action<ISkuDetailsQueryResponse> m_OnSkuDetailsResponseConsolidated;

		private readonly ISkuDetailsQueryResponse m_Responses;

		private readonly IUtil m_Util;

		private readonly ITelemetryDiagnostics m_TelemetryDiagnostics;

		internal SkuDetailsResponseConsolidator(IUtil util, ITelemetryDiagnostics telemetryDiagnostics, Action<ISkuDetailsQueryResponse> onSkuDetailsResponseConsolidated)
		{
		}

		public void Consolidate(IGoogleBillingResult billingResult, IEnumerable<AndroidJavaObject> skuDetails)
		{
		}
	}
}
