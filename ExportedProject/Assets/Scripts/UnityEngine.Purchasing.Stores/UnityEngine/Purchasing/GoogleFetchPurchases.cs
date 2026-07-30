using System;
using System.Collections.Generic;
using Uniject;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;

namespace UnityEngine.Purchasing
{
	internal class GoogleFetchPurchases : IGoogleFetchPurchases
	{
		private readonly IGooglePlayStoreService m_GooglePlayStoreService;

		private IStoreCallback m_StoreCallback;

		private IUtil m_Util;

		internal GoogleFetchPurchases(IGooglePlayStoreService googlePlayStoreService, IUtil util)
		{
		}

		public void SetStoreCallback(IStoreCallback storeCallback)
		{
		}

		public void FetchPurchases()
		{
		}

		public void FetchPurchases(Action<List<Product>> onQueryPurchaseSucceed)
		{
		}

		private List<Product> FillProductsWithPurchases(IEnumerable<IGooglePurchase> purchases)
		{
			return null;
		}

		private IEnumerable<Product> BuildProductsFromPurchase(IGooglePurchase purchase)
		{
			return null;
		}

		private static Product CompleteProductInfoWithPurchase(Product product, IGooglePurchase purchase)
		{
			return null;
		}

		private void OnFetchedPurchase(List<IGooglePurchase> purchases)
		{
		}

		private static Func<IGooglePurchase, bool> PurchaseIsPurchased()
		{
			return null;
		}

		private static Func<IGooglePurchase, bool> PurchaseIsPending()
		{
			return null;
		}

		private void UpdateDeferredProductsByPurchases(List<IGooglePurchase> deferredPurchases)
		{
		}

		private void UpdateDeferredProductsByPurchase(IGooglePurchase deferredPurchase)
		{
		}

		private void UpdateDeferredProduct(IGooglePurchase deferredPurchase, string sku)
		{
		}
	}
}
