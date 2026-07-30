using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using NatML.API.Graph;
using NatML.API.Types;

namespace NatML.API.Services
{
	public sealed class PredictorService
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CList_003Ed__1 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Predictor[]> _003C_003Et__builder;

			public PredictorService _003C_003E4__this;

			public bool? mine;

			public PredictorStatus? status;

			public int? offset;

			public int? count;

			private TaskAwaiter<Predictor[]?> _003C_003Eu__1;

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

		private const string Fields = "\n        tag\n        owner {\n            username\n            created\n            name\n            avatar\n            bio\n            website\n            github\n        }\n        name\n        description\n        status\n        access\n        license\n        topics\n        created\n        media\n        ";

		public Task<Predictor> Retrieve(string tag)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CList_003Ed__1))]
		public Task<Predictor[]> List(bool? mine = null, PredictorStatus? status = null, int? offset = null, int? count = null)
		{
			return null;
		}

		public Task<Predictor[]> Search(string query, int? offset = null, int? count = null)
		{
			return null;
		}

		public Task<Predictor> Create(string tag, string? description = null, AccessMode? access = null)
		{
			return null;
		}

		public Task<Predictor?>? Update(string tag, string? description = null, AccessMode? access = null, string? license = null, string[]? topics = null, string? media = null, string[]? labels = null, Normalization? normalization = null, AspectMode? aspectMode = null, AudioFormat? audioFormat = null)
		{
			return null;
		}

		public Task<bool> Delete(string tag)
		{
			return null;
		}

		public Task<Predictor> Publish(string tag)
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
