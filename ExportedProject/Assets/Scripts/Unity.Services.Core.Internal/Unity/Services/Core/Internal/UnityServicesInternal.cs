using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace Unity.Services.Core.Internal
{
	internal class UnityServicesInternal : IUnityServices
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInitializeAsync_003Ed__20 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public UnityServicesInternal _003C_003E4__this;

			public InitializationOptions options;

			private TaskAwaiter<object> _003C_003Eu__1;

			private TaskAwaiter _003C_003Eu__2;

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
		private sealed class _003C_003Ec__DisplayClass22_0
		{
			public DependencyTree dependencyTree;

			public List<int> sortedPackageTypeHashes;

			public UnityServicesInternal _003C_003E4__this;

			public Stopwatch initStopwatch;
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInitializeServicesAsync_003Ed__22 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public UnityServicesInternal _003C_003E4__this;

			private _003C_003Ec__DisplayClass22_0 _003C_003E8__1;

			private TaskAwaiter<List<PackageInitializationInfo>> _003C_003Eu__1;

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
		private struct _003CEnableInitializationAsync_003Ed__24 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public UnityServicesInternal _003C_003E4__this;

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

		internal bool CanInitialize;

		private TaskCompletionSource<object> m_Initialization;

		public ServicesInitializationState State { get; private set; }

		public InitializationOptions Options { get; internal set; }

		[NotNull]
		private CoreRegistry Registry { get; }

		[NotNull]
		private CoreMetrics Metrics { get; }

		[NotNull]
		private CoreDiagnostics Diagnostics { get; }

		public UnityServicesInternal([NotNull] CoreRegistry registry, [NotNull] CoreMetrics metrics, [NotNull] CoreDiagnostics diagnostics)
		{
		}

		[AsyncStateMachine(typeof(_003CInitializeAsync_003Ed__20))]
		public Task InitializeAsync(InitializationOptions options)
		{
			return null;
		}

		private bool HasRequestedInitialization()
		{
			return false;
		}

		[AsyncStateMachine(typeof(_003CInitializeServicesAsync_003Ed__22))]
		private Task InitializeServicesAsync()
		{
			return null;
		}

		internal void SendInitializationMetrics(List<PackageInitializationInfo> packageInitInfos)
		{
		}

		[AsyncStateMachine(typeof(_003CEnableInitializationAsync_003Ed__24))]
		internal Task EnableInitializationAsync()
		{
			return null;
		}
	}
}
