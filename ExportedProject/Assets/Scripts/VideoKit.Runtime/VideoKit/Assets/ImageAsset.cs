using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Function.Types;
using UnityEngine;
using UnityEngine.Networking;

namespace VideoKit.Assets
{
	public sealed class ImageAsset : MediaAsset
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CToTexture_003Ed__2 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Texture2D> _003C_003Et__builder;

			public ImageAsset _003C_003E4__this;

			private UnityWebRequest _003Crequest_003E5__2;

			private YieldAwaitable.YieldAwaiter _003C_003Eu__1;

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
		private struct _003CToValue_003Ed__3 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Value> _003C_003Et__builder;

			public ImageAsset _003C_003E4__this;

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

		public readonly int width;

		public readonly int height;

		[AsyncStateMachine(typeof(_003CToTexture_003Ed__2))]
		public Task<Texture2D> ToTexture()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CToValue_003Ed__3))]
		public override Task<Value> ToValue(int minUploadSize = 4096)
		{
			return null;
		}

		internal ImageAsset(string path, int width, int height)
		{
		}
	}
}
