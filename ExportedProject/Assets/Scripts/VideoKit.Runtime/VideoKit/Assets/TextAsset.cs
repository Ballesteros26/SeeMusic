using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Function.Types;

namespace VideoKit.Assets
{
	public sealed class TextAsset : MediaAsset
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CTo_003Ed__1<T> : IAsyncStateMachine where T : struct
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<T?> _003C_003Et__builder;

			public TextAsset _003C_003E4__this;

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
		private struct _003CToValue_003Ed__2 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Value> _003C_003Et__builder;

			public TextAsset _003C_003E4__this;

			public int minUploadSize;

			private MemoryStream _003Cstream_003E5__2;

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

		public readonly string text;

		[AsyncStateMachine(typeof(_003CTo_003Ed__1<>))]
		public Task<T?> To<T>() where T : struct
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CToValue_003Ed__2))]
		public override Task<Value> ToValue(int minUploadSize = 4096)
		{
			return null;
		}

		public override Task<string?>? Share(string? message = null)
		{
			return null;
		}

		public override Task<bool> SaveToCameraRoll(string? album = null)
		{
			return null;
		}

		internal TextAsset(string text)
		{
		}

		public static implicit operator string(TextAsset asset)
		{
			return null;
		}
	}
}
