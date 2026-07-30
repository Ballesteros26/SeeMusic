using System;
using System.Collections.Generic;
using Uniject;
using UnityEngine.Purchasing.Models;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	internal class SkuDetailsResponseListener : AndroidJavaProxy
	{
		private readonly Action<IGoogleBillingResult, List<AndroidJavaObject>> m_OnSkuDetailsResponse;

		private readonly IUtil m_Util;

		private readonly ITelemetryDiagnostics m_TelemetryDiagnostics;

		internal SkuDetailsResponseListener(Action<IGoogleBillingResult, List<AndroidJavaObject>> onSkuDetailsResponseAction, IUtil util, ITelemetryDiagnostics telemetryDiagnostics)
			: base((string)null)
		{
		}

		[Preserve]
		internal void onSkuDetailsResponse(AndroidJavaObject billingResult, AndroidJavaObject? skuDetails)
		{
		}
	}
}
