using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Models;

namespace UnityEngine.Purchasing
{
	internal class GoogleFinishTransactionService : IGoogleFinishTransactionService
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CFinishTransaction_003Ed__3 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public GoogleFinishTransactionService _003C_003E4__this;

			public string purchaseToken;

			public ProductDefinition product;

			public Action<IGoogleBillingResult, IGooglePurchase> onTransactionFinished;

			private TaskAwaiter<IGooglePurchase> _003C_003Eu__1;

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

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass4_0
		{
			public string purchaseToken;

			internal bool _003CFindPurchase_003Eb__0(IGooglePurchase purchase)
			{
				return false;
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CFindPurchase_003Ed__4 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<IGooglePurchase> _003C_003Et__builder;

			public string purchaseToken;

			public GoogleFinishTransactionService _003C_003E4__this;

			private _003C_003Ec__DisplayClass4_0 _003C_003E8__1;

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

		private readonly IGoogleBillingClient m_BillingClient;

		private readonly IGoogleQueryPurchasesService m_GoogleQueryPurchasesService;

		internal GoogleFinishTransactionService(IGoogleBillingClient billingClient, IGoogleQueryPurchasesService googleQueryPurchasesService)
		{
		}

		[AsyncStateMachine(typeof(_003CFinishTransaction_003Ed__3))]
		public void FinishTransaction(ProductDefinition product, string purchaseToken, Action<IGoogleBillingResult, IGooglePurchase> onTransactionFinished)
		{
		}

		[AsyncStateMachine(typeof(_003CFindPurchase_003Ed__4))]
		private Task<IGooglePurchase> FindPurchase(string purchaseToken)
		{
			return null;
		}

		private void FinishTransactionForPurchase(IGooglePurchase purchase, ProductDefinition product, string purchaseToken, Action<IGoogleBillingResult, IGooglePurchase> onTransactionFinished)
		{
		}
	}
}
