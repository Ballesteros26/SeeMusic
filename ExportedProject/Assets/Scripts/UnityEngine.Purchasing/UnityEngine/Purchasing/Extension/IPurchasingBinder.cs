namespace UnityEngine.Purchasing.Extension
{
	public interface IPurchasingBinder
	{
		void RegisterStore(string name, IStore store);

		void RegisterExtension<T>(T instance) where T : IStoreExtension;

		void RegisterConfiguration<T>(T instance) where T : IStoreConfiguration;
	}
}
