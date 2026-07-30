using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace NatML.Types
{
	public class MLAudioType : MLArrayType
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CFromStreamingAssets_003Ed__10 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<MLAudioType> _003C_003Et__builder;

			public string relativePath;

			private TaskAwaiter<string?> _003C_003Eu__1;

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

		public virtual int sampleRate { get; protected set; }

		public virtual int channelCount => 0;

		public virtual int frames => 0;

		public MLAudioType(int sampleRate, int channelCount, int sampleCount, string name = null)
			: base(null, null)
		{
		}

		public static MLAudioType FromFile(string path)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CFromStreamingAssets_003Ed__10))]
		public static Task<MLAudioType> FromStreamingAssets(string relativePath)
		{
			return null;
		}

		protected MLAudioType(int[] shape, string name = null)
			: base(null, null)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
