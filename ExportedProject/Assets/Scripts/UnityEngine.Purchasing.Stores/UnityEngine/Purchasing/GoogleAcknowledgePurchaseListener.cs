using System;
using UnityEngine.Purchasing.Models;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	internal class GoogleAcknowledgePurchaseListener : AndroidJavaProxy
	{
		private readonly Action<IGoogleBillingResult> m_OnAcknowledgePurchaseResponse;

		internal GoogleAcknowledgePurchaseListener(Action<IGoogleBillingResult> onAcknowledgePurchaseResponseAction)
			: base((string)null)
		{
		}

		[Preserve]
		private void onAcknowledgePurchaseResponse(AndroidJavaObject billingResult)
		{
		}
	}
}
