using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Models;
using UnityEngine.Purchasing.Telemetry;

namespace UnityEngine.Purchasing
{
	internal class GooglePlayStoreService : IGooglePlayStoreService
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CFetchPurchases_003Ed__31 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public GooglePlayStoreService _003C_003E4__this;

			public Action<List<IGooglePurchase>> onQueryPurchaseSucceed;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CTryFetchPurchases_003Ed__32 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public Action<List<IGooglePurchase>> onQueryPurchaseSucceed;

			public GooglePlayStoreService _003C_003E4__this;

			private TaskAwaiter<List<IGooglePurchase>> _003C_003Eu__1;

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

		private int m_CurrentConnectionAttempts;

		private readonly IGoogleBillingClient m_BillingClient;

		private readonly IBillingClientStateListener m_BillingClientStateListener;

		private readonly IQuerySkuDetailsService m_QuerySkuDetailsService;

		private readonly ConcurrentQueue<ProductDescriptionQuery> m_ProductsToQuery;

		private readonly ConcurrentQueue<Action<List<IGooglePurchase>>> m_OnPurchaseSucceededQueue;

		private readonly IGooglePurchaseService m_GooglePurchaseService;

		private readonly IGoogleFinishTransactionService m_GoogleFinishTransactionService;

		private readonly IGoogleQueryPurchasesService m_GoogleQueryPurchasesService;

		private readonly IGooglePriceChangeService m_GooglePriceChangeService;

		private readonly IGoogleLastKnownProductService m_GoogleLastKnownProductService;

		private readonly ITelemetryDiagnostics m_TelemetryDiagnostics;

		private readonly ILogger m_Logger;

		internal GooglePlayStoreService(IGoogleBillingClient billingClient, IQuerySkuDetailsService querySkuDetailsService, IGooglePurchaseService purchaseService, IGoogleFinishTransactionService finishTransactionService, IGoogleQueryPurchasesService queryPurchasesService, IBillingClientStateListener billingClientStateListener, IGooglePriceChangeService priceChangeService, IGoogleLastKnownProductService lastKnownProductService, ITelemetryDiagnostics telemetryDiagnostics, ILogger logger)
		{
		}

		internal void InitConnectionWithGooglePlay()
		{
		}

		private void StartConnection()
		{
		}

		public void ResumeConnection()
		{
		}

		private void OnConnected()
		{
		}

		protected virtual void DequeueQueryProducts(GoogleBillingResponseCode googleBillingResponseCode)
		{
		}

		protected virtual void DequeueFetchPurchases()
		{
		}

		private void OnDisconnected(GoogleBillingResponseCode googleBillingResponseCode)
		{
		}

		private void AttemptReconnection(GoogleBillingResponseCode googleBillingResponseCode)
		{
		}

		private bool AreConnectionAttemptsExhausted()
		{
			return false;
		}

		private void OnReconnectionFailure(GoogleBillingResponseCode googleBillingResponseCode)
		{
		}

		public virtual void RetrieveProducts(ReadOnlyCollection<ProductDefinition> products, Action<List<ProductDescription>> onProductsReceived, Action<GoogleRetrieveProductsFailureReason, GoogleBillingResponseCode> onRetrieveProductsFailed)
		{
		}

		private void HandleRetrieveProductsNotConnected(ReadOnlyCollection<ProductDefinition> products, Action<List<ProductDescription>> onProductsReceived, Action<GoogleRetrieveProductsFailureReason, GoogleBillingResponseCode> onRetrieveProductsFailed)
		{
		}

		public void Purchase(ProductDefinition product)
		{
		}

		public virtual void Purchase(ProductDefinition product, Product oldProduct, GooglePlayProrationMode? desiredProrationMode)
		{
		}

		public void FinishTransaction(ProductDefinition product, string purchaseToken, Action<IGoogleBillingResult, IGooglePurchase> onTransactionFinished)
		{
		}

		[AsyncStateMachine(typeof(_003CFetchPurchases_003Ed__31))]
		public void FetchPurchases(Action<List<IGooglePurchase>> onQueryPurchaseSucceed)
		{
		}

		[AsyncStateMachine(typeof(_003CTryFetchPurchases_003Ed__32))]
		private Task TryFetchPurchases(Action<List<IGooglePurchase>> onQueryPurchaseSucceed)
		{
			return null;
		}
	}
}
