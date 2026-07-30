using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using NatML.API.Graph;
using NatML.API.Types;

namespace NatML.API.Services
{
	public sealed class UserService
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CRetrieve_003Ed__0 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<User> _003C_003Et__builder;

			public string username;

			public UserService _003C_003E4__this;

			private TaskAwaiter<User?> _003C_003Eu__1;

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

		[AsyncStateMachine(typeof(_003CRetrieve_003Ed__0))]
		public Task<User?>? Retrieve(string? username = null)
		{
			return null;
		}

		internal UserService(IGraphClient client)
		{
		}
	}
}
