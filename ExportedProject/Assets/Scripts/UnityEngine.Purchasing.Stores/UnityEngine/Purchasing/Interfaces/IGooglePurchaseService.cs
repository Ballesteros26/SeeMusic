namespace UnityEngine.Purchasing.Interfaces
{
	internal interface IGooglePurchaseService
	{
		void Purchase(ProductDefinition product, Product oldProduct, GooglePlayProrationMode? desiredProrationMode);
	}
}
