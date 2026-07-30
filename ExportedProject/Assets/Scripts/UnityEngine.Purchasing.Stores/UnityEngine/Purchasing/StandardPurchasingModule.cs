using System.Collections.Generic;
using Uniject;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Telemetry;

namespace UnityEngine.Purchasing
{
	public class StandardPurchasingModule : AbstractPurchasingModule, IAndroidStoreSelection, IStoreConfiguration
	{
		internal class StoreInstance
		{
			internal string storeName { get; }

			internal IStore instance { get; }

			internal StoreInstance(string name, IStore instance)
			{
			}
		}

		private class MicrosoftConfiguration : IMicrosoftConfiguration, IStoreConfiguration
		{
			private readonly StandardPurchasingModule module;

			public MicrosoftConfiguration(StandardPurchasingModule module)
			{
			}
		}

		internal readonly string k_Version;

		private readonly INativeStoreProvider m_NativeStoreProvider;

		private readonly RuntimePlatform m_RuntimePlatform;

		private static StandardPurchasingModule ModuleInstance;

		private static readonly Dictionary<AppStore, string> AndroidStoreNameMap;

		private WinRTStore windowsStore;

		internal IUtil util { get; private set; }

		internal ILogger logger { get; private set; }

		internal StoreInstance storeInstance { get; private set; }

		internal ITelemetryMetricsInstanceWrapper telemetryMetricsInstanceWrapper { get; set; }

		internal ITelemetryDiagnosticsInstanceWrapper telemetryDiagnosticsInstanceWrapper { get; set; }

		public AppStore appStore { get; private set; }

		public FakeStoreUIMode useFakeStoreUIMode { get; set; }

		public bool useFakeStoreAlways { get; set; }

		internal StandardPurchasingModule(IUtil util, ILogger logger, INativeStoreProvider nativeStoreProvider, RuntimePlatform platform, AppStore android, ITelemetryDiagnosticsInstanceWrapper telemetryDiagnosticsInstanceWrapper, ITelemetryMetricsInstanceWrapper telemetryMetricsInstanceWrapper)
		{
		}

		public static StandardPurchasingModule Instance()
		{
			return null;
		}

		public static StandardPurchasingModule Instance(AppStore androidStore)
		{
			return null;
		}

		public override void Configure()
		{
		}

		private StoreInstance InstantiateStore()
		{
			return null;
		}

		private IStore InstantiateAndroid()
		{
			return null;
		}

		private IStore InstantiateGoogleStore()
		{
			return null;
		}

		private void BindGoogleExtension(GooglePlayStoreExtensions googlePlayStoreExtensions)
		{
		}

		private static GooglePlayConfiguration BuildGooglePlayStoreConfiguration(IGooglePlayStoreService googlePlayStoreService, IGooglePurchaseCallback googlePurchaseCallback, IGoogleProductCallback googleProductCallback)
		{
			return null;
		}

		private void BindGoogleConfiguration(GooglePlayConfiguration googlePlayConfiguration)
		{
		}

		private IGooglePlayStoreService BuildAndInitGooglePlayStoreServiceAar(IGooglePurchaseCallback googlePurchaseCallback, IGoogleProductCallback googleProductCallback)
		{
			return null;
		}

		private IStore InstantiateUDP()
		{
			return null;
		}

		private IStore InstantiateAndroidHelper(JSONStore store)
		{
			return null;
		}

		private INativeStore GetAndroidNativeStore(JSONStore store)
		{
			return null;
		}

		private IStore InstantiateApple()
		{
			return null;
		}

		private IStore instantiateWindowsStore()
		{
			return null;
		}

		private IStore InstantiateFakeStore()
		{
			return null;
		}
	}
}
