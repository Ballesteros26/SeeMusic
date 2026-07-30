namespace UnityEngine.Purchasing.Extension
{
	public abstract class AbstractPurchasingModule : IPurchasingModule
	{
		protected IPurchasingBinder m_Binder;

		public void Configure(IPurchasingBinder binder)
		{
		}

		protected void RegisterStore(string name, IStore store)
		{
		}

		protected void BindExtension<T>(T instance) where T : IStoreExtension
		{
		}

		protected void BindConfiguration<T>(T instance) where T : IStoreConfiguration
		{
		}

		public abstract void Configure();
	}
}
