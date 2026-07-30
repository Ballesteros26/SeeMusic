using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace NatML.Types
{
	public class MLVideoType : MLImageType
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CFromStreamingAssets_003Ed__12 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<MLVideoType> _003C_003Et__builder;

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

		public override int width => 0;

		public override int height => 0;

		public override int channels => 0;

		public virtual int frames => 0;

		public MLVideoType(int width, int height, int frames)
			: base(0, 0, 0)
		{
		}

		public MLVideoType(int width, int height, int frames, Type type)
			: base(0, 0, 0)
		{
		}

		public MLVideoType(int[] shape, Type type, string name = null)
			: base(0, 0, 0)
		{
		}

		public static MLVideoType FromFile(string path)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CFromStreamingAssets_003Ed__12))]
		public static Task<MLVideoType> FromStreamingAssets(string relativePath)
		{
			return null;
		}
	}
}
