using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Function.Types;
using UnityEngine;

namespace VideoKit.Assets
{
	public sealed class VideoAsset : MediaAsset
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CToValue_003Ed__11 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Value> _003C_003Et__builder;

			public VideoAsset _003C_003E4__this;

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

		public readonly float frameRate;

		public readonly int sampleRate;

		public readonly int channelCount;

		public readonly float duration;

		public void Playback()
		{
		}

		internal Task<Texture2D> CreateThumbnail(float time = 0f)
		{
			return null;
		}

		internal Task<VideoAsset> Trim(float start = 0f, float duration = -1f)
		{
			return null;
		}

		internal Task<VideoAsset> Reverse()
		{
			return null;
		}

		internal Task<AudioAsset> ExtractAudio()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CToValue_003Ed__11))]
		public override Task<Value> ToValue(int minUploadSize = 4096)
		{
			return null;
		}

		internal VideoAsset(string path, int width, int height, float frameRate, int sampleRate, int channelCount, float duration)
		{
		}
	}
}
