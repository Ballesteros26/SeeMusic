namespace UnityEngine.Purchasing
{
	internal class StoreConfiguration
	{
		public AppStore androidStore { get; private set; }

		public StoreConfiguration(AppStore store)
		{
		}

		public static StoreConfiguration Deserialize(string json)
		{
			return null;
		}
	}
}
