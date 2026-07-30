using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Models;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	internal class GooglePurchaseUpdatedListener : AndroidJavaProxy, IGooglePurchaseUpdatedListener
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CHandleUserCancelledPurchaseFailure_003Ed__14 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public GooglePurchaseUpdatedListener _003C_003E4__this;

			public IGoogleBillingResult billingResult;

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

		private readonly IGoogleLastKnownProductService m_LastKnownProductService;

		private readonly IGooglePurchaseCallback m_GooglePurchaseCallback;

		private readonly IGooglePurchaseBuilder m_PurchaseBuilder;

		private readonly IGoogleCachedQuerySkuDetailsService m_GoogleCachedQuerySkuDetailsService;

		private readonly IGooglePurchaseStateEnumProvider m_GooglePurchaseStateEnumProvider;

		private IGoogleQueryPurchasesService m_GoogleQueryPurchasesService;

		internal GooglePurchaseUpdatedListener(IGoogleLastKnownProductService googleLastKnownProductService, IGooglePurchaseCallback googlePurchaseCallback, IGooglePurchaseBuilder purchaseBuilder, IGoogleCachedQuerySkuDetailsService googleCachedQuerySkuDetailsService, IGooglePurchaseStateEnumProvider googlePurchaseStateEnumProvider, IGoogleQueryPurchasesService googleQueryPurchasesService = null)
			: base((string)null)
		{
		}

		public void SetGoogleQueryPurchaseService(IGoogleQueryPurchasesService googleFetchPurchases)
		{
		}

		[Preserve]
		private void onPurchasesUpdated(AndroidJavaObject billingResult, AndroidJavaObject javaPurchasesList)
		{
		}

		internal void OnPurchasesUpdated(IGoogleBillingResult result, List<IGooglePurchase> purchases)
		{
		}

		private void HandleResultOkCases(IGoogleBillingResult result, List<IGooglePurchase> purchases)
		{
		}

		private void HandleErrorCases(IGoogleBillingResult billingResult, List<IGooglePurchase> purchases)
		{
		}

		private void HandleErrorGoogleBillingResult(IGoogleBillingResult billingResult)
		{
		}

		[AsyncStateMachine(typeof(_003CHandleUserCancelledPurchaseFailure_003Ed__14))]
		private void HandleUserCancelledPurchaseFailure(IGoogleBillingResult billingResult)
		{
		}

		private void HandleUserCancelledPurchaseFailure(IGoogleBillingResult billingResult, List<IGooglePurchase> googlePurchases)
		{
		}

		private void ApplyOnPurchases(List<IGooglePurchase> purchases, Action<IGooglePurchase> action)
		{
		}

		private void ApplyOnPurchases(IEnumerable<IGooglePurchase> purchases, IGoogleBillingResult billingResult, Action<IGooglePurchase, string> action)
		{
		}

		private void OnPurchaseOk(IGooglePurchase googlePurchase)
		{
		}

		private void HandlePurchasedProduct(IGooglePurchase googlePurchase)
		{
		}

		private bool IsDeferredSubscriptionChange(IGooglePurchase googlePurchase)
		{
			return false;
		}

		private bool IsLastProrationModeDeferred()
		{
			return false;
		}

		private void OnPurchaseCancelled(IGoogleBillingResult billingResult)
		{
		}

		private void OnPurchaseCancelled(IGooglePurchase googlePurchase)
		{
		}

		private void OnPurchaseAlreadyOwned(IGooglePurchase googlePurchase)
		{
		}

		private void OnPurchaseFailed(IGooglePurchase googlePurchase, string debugMessage)
		{
		}
	}
}
