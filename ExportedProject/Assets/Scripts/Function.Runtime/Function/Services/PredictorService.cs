using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Function.Graph;
using Function.Types;

namespace Function.Services
{
	public sealed class PredictorService
	{
		private sealed class PredictorInput
		{
			public string tag;
		}

		private sealed class PredictorsInput
		{
			public string? query;

			public int? offset;

			public int? count;
		}

		private sealed class UserPredictorsInput
		{
			public PredictorStatus? status;

			public int? offset;

			public int? count;
		}

		private sealed class CreatePredictorInput
		{
			public string tag;

			public string notebook;

			public PredictorType? type;

			public AccessMode? access;

			public string? description;

			public string? media;

			public Acceleration? acceleration;

			public EnvironmentVariableInput[]? environment;

			public string? license;

			public bool? overwrite;
		}

		private sealed class DeletePredictorInput
		{
			public string tag;
		}

		private sealed class ArchivePredictorInput
		{
			public string tag;
		}

		private sealed class EnvironmentVariableInput
		{
			public string name;

			public string value;
		}

		private sealed class UserWithPredictors
		{
			public Predictor[] predictors;
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CList_003Ed__1 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Predictor[]> _003C_003Et__builder;

			public PredictorService _003C_003E4__this;

			public string owner;

			public PredictorStatus? status;

			public int? offset;

			public int? count;

			private TaskAwaiter<UserWithPredictors?> _003C_003Eu__1;

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

		public Task<Predictor> Retrieve(string tag)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CList_003Ed__1))]
		public Task<Predictor?[]?>? List(string? owner = null, PredictorStatus? status = null, int? offset = null, int? count = null)
		{
			return null;
		}

		public Task<Predictor[]> Search(string? query = null, int? offset = null, int? count = null)
		{
			return null;
		}

		public Task<Predictor> Create(string tag, string notebook, PredictorType? type = null, AccessMode? access = null, string? description = null, string? media = null, Acceleration? acceleration = null, Dictionary<string, string>? environment = null, string? license = null, bool? overwrite = null)
		{
			return null;
		}

		public Task<bool> Delete(string tag)
		{
			return null;
		}

		public Task<Predictor> Archive(string tag)
		{
			return null;
		}

		internal PredictorService(IGraphClient client)
		{
		}
	}
}
