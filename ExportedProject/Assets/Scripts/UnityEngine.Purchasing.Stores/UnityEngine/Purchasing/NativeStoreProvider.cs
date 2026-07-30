using Uniject;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	internal class NativeStoreProvider : INativeStoreProvider
	{
		public INativeStore GetAndroidStore(IUnityCallback callback, AppStore store, IPurchasingBinder binder, IUtil util)
		{
			return null;
		}

		private INativeStore GetAndroidStoreHelper(IUnityCallback callback, AppStore store, IPurchasingBinder binder, IUtil util)
		{
			return null;
		}

		public INativeAppleStore GetStorekit(IUnityCallback callback)
		{
			return null;
		}
	}
}
