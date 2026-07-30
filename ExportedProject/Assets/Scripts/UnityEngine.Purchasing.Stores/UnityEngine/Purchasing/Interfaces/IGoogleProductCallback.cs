namespace UnityEngine.Purchasing.Interfaces
{
	internal interface IGoogleProductCallback
	{
		void SetStoreConfiguration(IGooglePlayConfigurationInternal configuration);

		void NotifyQueryProductDetailsFailed(int retryCount);
	}
}
