using System;
using UnityEngine.Purchasing.Models;

namespace UnityEngine.Purchasing.Interfaces
{
	internal interface IGoogleFinishTransactionService
	{
		void FinishTransaction(ProductDefinition product, string purchaseToken, Action<IGoogleBillingResult, IGooglePurchase> onTransactionFinished);
	}
}
