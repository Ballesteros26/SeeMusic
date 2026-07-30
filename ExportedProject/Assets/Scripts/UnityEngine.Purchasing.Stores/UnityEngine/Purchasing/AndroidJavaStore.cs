namespace UnityEngine.Purchasing
{
	internal class AndroidJavaStore : INativeStore
	{
		private readonly AndroidJavaObject m_Store;

		public AndroidJavaStore(AndroidJavaObject store)
		{
		}

		public void RetrieveProducts(string json)
		{
		}

		public virtual void Purchase(string productJSON, string developerPayload)
		{
		}

		public virtual void FinishTransaction(string productJSON, string transactionID)
		{
		}
	}
}
