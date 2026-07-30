using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using NatML.API.Graph;
using NatML.API.Types;

namespace NatML.API.Services
{
	public sealed class GraphService
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass0_0
		{
			public string variant;

			public GraphFormat format;

			internal bool _003CRetrieve_003Eb__0(NatML.API.Types.Graph graph)
			{
				return false;
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CRetrieve_003Ed__0 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<NatML.API.Types.Graph> _003C_003Et__builder;

			public GraphFormat format;

			public string tag;

			public GraphService _003C_003E4__this;

			private _003C_003Ec__DisplayClass0_0 _003C_003E8__1;

			private TaskAwaiter<NatML.API.Types.Graph[]?> _003C_003Eu__1;

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
		private struct _003CList_003Ed__1 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<NatML.API.Types.Graph[]> _003C_003Et__builder;

			public GraphService _003C_003E4__this;

			public string tag;

			private TaskAwaiter<Predictor?> _003C_003Eu__1;

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

		private readonly IGraphClient client;

		private const string Fields = "\n        variant\n        format\n        status\n        encrypted\n        created\n        error\n        ";

		[AsyncStateMachine(typeof(_003CRetrieve_003Ed__0))]
		public Task<NatML.API.Types.Graph> Retrieve(string tag, GraphFormat format)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CList_003Ed__1))]
		public Task<NatML.API.Types.Graph[]> List(string tag)
		{
			return null;
		}

		public Task<NatML.API.Types.Graph> Create(string tag, string graph, GraphFormat format)
		{
			return null;
		}

		public Task<bool> Delete(string tag, GraphFormat format)
		{
			return null;
		}

		internal GraphService(IGraphClient client)
		{
		}
	}
}
