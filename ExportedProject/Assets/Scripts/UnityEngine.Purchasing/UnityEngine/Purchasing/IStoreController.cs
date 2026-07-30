namespace UnityEngine.Purchasing
{
	public interface IStoreController
	{
		ProductCollection products { get; }

		void InitiatePurchase(string productId);
	}
}
