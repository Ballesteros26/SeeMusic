using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	public class AmazonAppStoreStoreExtensions : IAmazonExtensions, IStoreExtension, IAmazonConfiguration, IStoreConfiguration
	{
		private readonly AndroidJavaObject android;

		public AmazonAppStoreStoreExtensions(AndroidJavaObject a)
		{
		}
	}
}
