using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AOT;
using Unity.Collections;
using UnityEngine;
using VideoKit.Internal;

namespace VideoKit
{
	public sealed class MediaRecorder
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCreate_003Ed__10 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<MediaRecorder> _003C_003Et__builder;

			public MediaFormat format;

			public int width;

			public int height;

			public int sampleRate;

			public int channelCount;

			public float frameRate;

			public int videoBitRate;

			public int keyframeInterval;

			public int audioBitRate;

			public string prefix;

			public float compressionQuality;

			private TaskAwaiter<VideoKit.Internal.VideoKit.Status> _003C_003Eu__1;

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

		public readonly MediaFormat format;

		private readonly IntPtr recorder;

		private static string directory;

		private static readonly int[] ValidSampleRates;

		public (int width, int height) frameSize => default((int, int));

		public void CommitFrame<T>(T[] pixelBuffer, long timestamp) where T : struct
		{
		}

		public void CommitFrame<T>(NativeArray<T> pixelBuffer, long timestamp) where T : struct
		{
		}

		public unsafe void CommitFrame(void* pixelBuffer, long timestamp)
		{
		}

		public void CommitSamples(float[] sampleBuffer, long timestamp)
		{
		}

		public void CommitSamples(NativeArray<float> sampleBuffer, long timestamp)
		{
		}

		public unsafe void CommitSamples(float* sampleBuffer, int sampleCount, long timestamp)
		{
		}

		public Task<string> FinishWriting()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CCreate_003Ed__10))]
		public static Task<MediaRecorder> Create(MediaFormat format, int width = 0, int height = 0, float frameRate = 0f, int sampleRate = 0, int channelCount = 0, int videoBitRate = 10000000, int keyframeInterval = 2, float compressionQuality = 0.8f, int audioBitRate = 64000, string prefix = null)
		{
			return null;
		}

		private MediaRecorder(IntPtr recorder, MediaFormat format)
		{
		}

		public static implicit operator IntPtr(MediaRecorder recorder)
		{
			return (IntPtr)0;
		}

		private static MediaRecorder CreateMP4(int width, int height, float frameRate, int sampleRate, int channelCount, int videoBitRate, int keyframeInterval, int audioBitRate, string prefix)
		{
			return null;
		}

		private static MediaRecorder CreateHEVC(int width, int height, float frameRate, int sampleRate, int channelCount, int videoBitRate, int keyframeInterval, int audioBitRate, string prefix)
		{
			return null;
		}

		private static MediaRecorder CreateGIF(int width, int height, float frameRate, string prefix)
		{
			return null;
		}

		private static MediaRecorder CreateWAV(int sampleRate, int channelCount, string prefix)
		{
			return null;
		}

		private static MediaRecorder CreateWEBM(int width, int height, float frameRate, int sampleRate, int channelCount, int videoBitRate, int keyframeInterval, int audioBitRate, string prefix)
		{
			return null;
		}

		private static MediaRecorder CreateJPEG(int width, int height, float quality, string prefix)
		{
			return null;
		}

		internal static string? CreatePath(string? extension = null, string? prefix = null)
		{
			return null;
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void OnInitialize()
		{
		}

		[MonoPInvokeCallback(typeof(VideoKit.Internal.VideoKit.RecordingHandler))]
		private static void OnFinishWriting(IntPtr context, IntPtr path)
		{
		}
	}
}
