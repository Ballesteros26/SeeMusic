using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine;
using VideoKit.Devices;

namespace VideoKit
{
	[Tooltip("VideoKit audio manager for streaming audio from audio devices.")]
	[HelpURL("https://docs.videokit.ai/videokit/api/videokitaudiomanager")]
	[DisallowMultipleComponent]
	public sealed class VideoKitAudioManager : VideoKitDeviceManager<AudioDevice>
	{
		public enum SampleRate
		{
			MatchUnity = 0,
			_8000 = 8000,
			_16000 = 16000,
			_22050 = 22050,
			_24000 = 24000,
			_44100 = 44100,
			_48000 = 48000
		}

		public enum ChannelCount
		{
			MatchUnity = 0,
			Mono = 1,
			Stereo = 2
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CStartRunning_003Ed__14 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public VideoKitAudioManager _003C_003E4__this;

			private TaskAwaiter<MediaDevice.PermissionStatus> _003C_003Eu__1;

			private TaskAwaiter<AudioDevice[]> _003C_003Eu__2;

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

		[Header("Configuration")]
		[Tooltip("Configure the application audio session on awake. This only applies on iOS.")]
		public bool configureOnAwake;

		[Header("Format")]
		[Tooltip("Audio sample rate.")]
		public SampleRate sampleRate;

		[Tooltip("Audio channel count.")]
		public ChannelCount channelCount;

		[Tooltip("Request echo cancellation if the device supports it.")]
		public bool echoCancellation;

		private AudioDevice _device;

		public override AudioDevice device
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override bool running => false;

		public event Action<AudioBuffer> OnAudioBuffer
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		[AsyncStateMachine(typeof(_003CStartRunning_003Ed__14))]
		public override Task StartRunning()
		{
			return null;
		}

		public override void StopRunning()
		{
		}

		private void Awake()
		{
		}

		private void OnSampleBuffer(AudioBuffer audioBuffer)
		{
		}

		private void OnDestroy()
		{
		}
	}
}
