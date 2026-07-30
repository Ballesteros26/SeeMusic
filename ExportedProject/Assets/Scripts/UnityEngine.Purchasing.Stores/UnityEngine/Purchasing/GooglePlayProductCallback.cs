using UnityEngine.Purchasing.Interfaces;

namespace UnityEngine.Purchasing
{
	internal class GooglePlayProductCallback : IGoogleProductCallback
	{
		private IGooglePlayConfigurationInternal? m_GooglePlayConfigurationInternal;

		public void SetStoreConfiguration(IGooglePlayConfigurationInternal configuration)
		{
		}

		public void NotifyQueryProductDetailsFailed(int retryCount)
		{
		}
	}
}
