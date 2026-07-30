using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AOT;
using Function.Types;
using UnityEngine;
using VideoKit.Internal;

namespace VideoKit.Assets
{
	public abstract class MediaAsset
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CFromAudioClip_003Ed__11 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<AudioAsset> _003C_003Et__builder;

			public AudioClip clip;

			private float[] _003CsampleBuffer_003E5__2;

			private TaskAwaiter<MediaRecorder> _003C_003Eu__1;

			private TaskAwaiter<string> _003C_003Eu__2;

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
		private struct _003CFromSequence_003Ed__14 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<MediaAsset> _003C_003Et__builder;

			public string[] paths;

			private string _003Cpath_003E5__2;

			private TaskAwaiter<MediaAsset[]> _003C_003Eu__1;

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

		public string path { get; protected set; }

		public abstract Task<Value> ToValue(int minUploadSize = 4096);

		public virtual Task<string?>? Share(string? message = null)
		{
			return null;
		}

		public virtual Task<bool> SaveToCameraRoll(string? album = null)
		{
			return null;
		}

		public virtual void Delete()
		{
		}

		public static Task<MediaAsset> FromFile(string path)
		{
			return null;
		}

		public static Task<ImageAsset> FromTexture(Texture2D texture)
		{
			return null;
		}

		public static Task<TextAsset> FromText(string text)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CFromAudioClip_003Ed__11))]
		public static Task<AudioAsset> FromAudioClip(AudioClip clip)
		{
			return null;
		}

		public static Task<MediaAsset> FromCameraRoll<T>() where T : MediaAsset
		{
			return null;
		}

		protected Stream OpenReadStream()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CFromSequence_003Ed__14))]
		private static Task<MediaAsset> FromSequence(string[] paths)
		{
			return null;
		}

		[MonoPInvokeCallback(typeof(VideoKit.Internal.VideoKit.AssetLoadHandler))]
		private static void OnLoad(IntPtr context, IntPtr rawPath, VideoKit.Internal.VideoKit.AssetType type, int width, int height, float frameRate, int sampleRate, int channelCount, float duration)
		{
		}

		[MonoPInvokeCallback(typeof(VideoKit.Internal.VideoKit.AssetShareHandler))]
		private static void OnShare(IntPtr context, IntPtr receiver)
		{
		}

		[MonoPInvokeCallback(typeof(VideoKit.Internal.VideoKit.AssetShareHandler))]
		private static void OnSaveToCameraRoll(IntPtr context, IntPtr receiver)
		{
		}

		private static VideoKit.Internal.VideoKit.AssetType GetAssetType<T>() where T : MediaAsset
		{
			return default(VideoKit.Internal.VideoKit.AssetType);
		}
	}
}
