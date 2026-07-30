using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	public class CodelessIAPStoreListener : IDetailedStoreListener, IStoreListener
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCreateCodelessIAPStoreListenerInstance_003Ed__17 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		private static CodelessIAPStoreListener instance;

		private readonly List<IAPButton> activeButtons;

		private readonly List<CodelessIAPButton> activeCodelessButtons;

		private readonly List<IAPListener> activeListeners;

		private static bool unityPurchasingInitialized;

		protected IStoreController controller;

		protected IExtensionProvider extensions;

		private ConfigurationBuilder m_Builder;

		protected ProductCatalog catalog;

		public static bool initializationComplete;

		public static CodelessIAPStoreListener Instance => null;

		public IStoreController StoreController => null;

		[RuntimeInitializeOnLoadMethod]
		private static void InitializeCodelessPurchasingOnLoad()
		{
		}

		private static void InitializePurchasing()
		{
		}

		public T GetStoreConfiguration<T>() where T : IStoreConfiguration
		{
			return default(T);
		}

		public T GetStoreExtensions<T>() where T : IStoreExtension
		{
			return default(T);
		}

		private CodelessIAPStoreListener()
		{
		}

		[AsyncStateMachine(typeof(_003CCreateCodelessIAPStoreListenerInstance_003Ed__17))]
		private static void CreateCodelessIAPStoreListenerInstance()
		{
		}

		private static Task AutoInitializeUnityGamingServicesIfEnabled()
		{
			return null;
		}

		private static bool ShouldAutoInitUgs()
		{
			return false;
		}

		public bool HasProductInCatalog(string productID)
		{
			return false;
		}

		public Product GetProduct(string productID)
		{
			return null;
		}

		[Obsolete("CodelessIAPStoreListener.AddButton(IAPButton button) is deprecated, please use CodelessIAPStoreListener.AddButton(CodelessIAPButton button) instead.", false)]
		public void AddButton(IAPButton button)
		{
		}

		public void AddButton(CodelessIAPButton button)
		{
		}

		[Obsolete("CodelessIAPStoreListener.RemoveButton(IAPButton button) is deprecated, please use CodelessIAPStoreListener.RemoveButton(CodelessIAPButton button) instead.", false)]
		public void RemoveButton(IAPButton button)
		{
		}

		public void RemoveButton(CodelessIAPButton button)
		{
		}

		public void AddListener(IAPListener listener)
		{
		}

		public void RemoveListener(IAPListener listener)
		{
		}

		public void InitiatePurchase(string productID)
		{
		}

		private void SendPurchaseFailedEventsToAllButtons(string productID)
		{
		}

		public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
		{
		}

		private void HandleOnInitForAllButtons()
		{
		}

		[Obsolete("OnInitializeFailed(InitializationFailureReason error) is deprecated, please use OnInitializeFailed(InitializationFailureReason error, string message) instead.")]
		public void OnInitializeFailed(InitializationFailureReason error)
		{
		}

		public void OnInitializeFailed(InitializationFailureReason error, string message)
		{
		}

		public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs e)
		{
			return default(PurchaseProcessingResult);
		}

		public void OnPurchaseFailed(Product product, PurchaseFailureReason reason)
		{
		}

		public void OnPurchaseFailed(Product product, PurchaseFailureDescription description)
		{
		}
	}
}
