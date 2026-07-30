using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Function.Graph;
using Function.Types;

namespace Function.Services
{
	public sealed class EnvironmentVariableService
	{
		private sealed class CreateEnvironmentVariableInput
		{
			public string name;

			public string value;

			public string? organization;
		}

		private sealed class DeleteEnvironmentVariableInput
		{
			public string name;

			public string? organization;
		}

		private sealed class UserWithEnvironmentVariables
		{
			public EnvironmentVariable[] environmentVariables;
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CList_003Ed__0 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<EnvironmentVariable[]> _003C_003Et__builder;

			public EnvironmentVariableService _003C_003E4__this;

			public string organization;

			private TaskAwaiter<UserWithEnvironmentVariables?> _003C_003Eu__1;

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

		public static string Fields;

		[AsyncStateMachine(typeof(_003CList_003Ed__0))]
		public Task<EnvironmentVariable?[]?>? List(string? organization = null)
		{
			return null;
		}

		public Task<EnvironmentVariable> Create(string name, string value, string? organization = null)
		{
			return null;
		}

		public Task<bool> Delete(string name, string? organization = null)
		{
			return null;
		}

		internal EnvironmentVariableService(IGraphClient client)
		{
		}
	}
}
