using System;
using System.Collections.Generic;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	internal class PurchasingFactory : IPurchasingBinder, IExtensionProvider
	{
		private readonly Dictionary<Type, IStoreConfiguration> m_ConfigMap;

		private readonly Dictionary<Type, IStoreExtension> m_ExtensionMap;

		private IStore m_Store;

		private ICatalogProvider m_CatalogProvider;

		public string storeName { get; private set; }

		public IStore service
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public PurchasingFactory(IPurchasingModule first, params IPurchasingModule[] remainingModules)
		{
		}

		public void RegisterStore(string name, IStore s)
		{
		}

		public void RegisterExtension<T>(T instance) where T : IStoreExtension
		{
		}

		public void RegisterConfiguration<T>(T instance) where T : IStoreConfiguration
		{
		}

		public T GetConfig<T>() where T : IStoreConfiguration
		{
			return default(T);
		}

		public T GetExtension<T>() where T : IStoreExtension
		{
			return default(T);
		}

		internal ICatalogProvider GetCatalogProvider()
		{
			return null;
		}
	}
}
