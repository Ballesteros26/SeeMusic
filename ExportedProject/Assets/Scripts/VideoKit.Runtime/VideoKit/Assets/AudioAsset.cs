using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Function.Types;

namespace VideoKit.Assets
{
	public sealed class AudioAsset : MediaAsset
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCaption_003Ed__3 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

			public AudioAsset _003C_003E4__this;

			private Stream _003Cstream_003E5__2;

			private TaskAwaiter<Prediction> _003C_003Eu__1;

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
		private struct _003CToValue_003Ed__4 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Value> _003C_003Et__builder;

			public AudioAsset _003C_003E4__this;

			public int minUploadSize;

			private Stream _003Cstream_003E5__2;

			private TaskAwaiter<Value> _003C_003Eu__1;

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

		public readonly int sampleRate;

		public readonly int channelCount;

		public readonly float duration;

		[AsyncStateMachine(typeof(_003CCaption_003Ed__3))]
		public Task<string> Caption()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CToValue_003Ed__4))]
		public override Task<Value> ToValue(int minUploadSize = 4096)
		{
			return null;
		}

		internal AudioAsset(string path, int sampleRate, int channelCount, float duration)
		{
		}
	}
}
