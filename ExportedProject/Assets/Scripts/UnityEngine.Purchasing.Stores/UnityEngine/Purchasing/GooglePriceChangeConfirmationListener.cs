using System;
using UnityEngine.Purchasing.Models;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	internal class GooglePriceChangeConfirmationListener : AndroidJavaProxy
	{
		private readonly Action<IGoogleBillingResult> m_OnPriceChangeConfirmationResult;

		[Preserve]
		private void onPriceChangeConfirmationResult(AndroidJavaObject javaBillingResult)
		{
		}
	}
}
