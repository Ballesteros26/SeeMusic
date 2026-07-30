using System.Collections.Generic;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Models;

namespace UnityEngine.Purchasing
{
	internal class GooglePurchaseService : IGooglePurchaseService
	{
		private readonly IGoogleBillingClient m_BillingClient;

		private readonly IGooglePurchaseCallback m_GooglePurchaseCallback;

		private readonly IQuerySkuDetailsService m_QuerySkuDetailsService;

		internal GooglePurchaseService(IGoogleBillingClient billingClient, IGooglePurchaseCallback googlePurchaseCallback, IQuerySkuDetailsService querySkuDetailsService)
		{
		}

		public void Purchase(ProductDefinition product, Product? oldProduct, GooglePlayProrationMode? desiredProrationMode)
		{
		}

		private void OnQuerySkuDetailsResponse(List<AndroidJavaObject> skus, ProductDefinition productToBuy, Product? oldProduct, GooglePlayProrationMode? desiredProrationMode)
		{
		}

		private bool ValidateQuerySkuDetailsResponseParams(List<AndroidJavaObject> skus, ProductDefinition productToBuy, Product? oldProduct)
		{
			return false;
		}

		private bool ValidateSkus(List<AndroidJavaObject>? skus)
		{
			return false;
		}

		private static void VerifyAndWarnIfMoreThanOneSku(List<AndroidJavaObject>? skus)
		{
		}

		private void PurchaseFailedSkuNotFound(ProductDefinition productToBuy)
		{
		}

		private bool ValidateOldProduct(Product? oldProduct)
		{
			return false;
		}

		private void PurchaseFailedInvalidOldProduct(ProductDefinition productToBuy, Product? oldProduct)
		{
		}

		private void LaunchGoogleBillingFlow(AndroidJavaObject productToPurchase, Product? oldProduct, GooglePlayProrationMode? desiredProrationMode)
		{
		}

		private void HandleBillingFlowResult(IGoogleBillingResult billingResult, AndroidJavaObject sku)
		{
		}
	}
}
