using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;
using VideoKit.Assets;
using VideoKit.Recorders.Clocks;
using VideoKit.Recorders.Inputs;

namespace VideoKit
{
	[Tooltip("VideoKit recorder for recording videos.")]
	[HelpURL("https://docs.videokit.ai/videokit/api/videokitrecorder")]
	[DisallowMultipleComponent]
	public sealed class VideoKitRecorder : MonoBehaviour
	{
		public enum VideoMode
		{
			None = 0,
			Camera = 1,
			Screen = 2,
			Texture = 3,
			CameraDevice = 4
		}

		[Flags]
		public enum AudioMode
		{
			None = 0,
			AudioListener = 1,
			AudioDevice = 2
		}

		public enum Resolution
		{
			_240xAuto = 11,
			_320xAuto = 5,
			_480xAuto = 6,
			_640xAuto = 0,
			_720xAuto = 7,
			_1080xAuto = 12,
			_1280xAuto = 1,
			_1920xAuto = 2,
			_2560xAuto = 3,
			_3840xAuto = 4,
			Screen = 9,
			HalfScreen = 10,
			Custom = 8
		}

		public enum Status
		{
			Idle = 0,
			Recording = 1,
			Paused = 2
		}

		public enum WatermarkMode
		{
			None = 0,
			BottomLeft = 1,
			BottomRight = 2,
			UpperLeft = 3,
			UpperRight = 4,
			Custom = 5
		}

		[Flags]
		public enum RecordingAction
		{
			None = 0,
			CameraRoll = 2,
			Share = 4,
			Playback = 8,
			Delete = 0x10,
			Custom = 0x20
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CStartRecording_003Ed__31 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public VideoKitRecorder _003C_003E4__this;

			private TaskAwaiter _003C_003Eu__1;

			private TaskAwaiter<MediaRecorder> _003C_003Eu__2;

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
		private struct _003CResumeRecording_003Ed__33 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public VideoKitRecorder _003C_003E4__this;

			private TaskAwaiter _003C_003Eu__1;

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
		private struct _003CStopRecording_003Ed__34 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public VideoKitRecorder _003C_003E4__this;

			private MediaAsset _003CmediaAsset_003E5__2;

			private TaskAwaiter<string> _003C_003Eu__1;

			private TaskAwaiter<MediaAsset> _003C_003Eu__2;

			private TaskAwaiter<bool> _003C_003Eu__3;

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
		private struct _003CAwake_003Ed__40 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public VideoKitRecorder _003C_003E4__this;

			private TaskAwaiter _003C_003Eu__1;

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
		private struct _003COnDestroy_003Ed__41 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public VideoKitRecorder _003C_003E4__this;

			private TaskAwaiter _003C_003Eu__1;

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
		private struct _003CPrepareEncoder_003Ed__50 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			private int _003Cwidth_003E5__2;

			private int _003Cheight_003E5__3;

			private FixedIntervalClock _003Cclock_003E5__4;

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

		[Header("Format")]
		[Tooltip("Recording format.")]
		public MediaFormat format;

		[Tooltip("Prepare the hardware encoders on awake. This prevents a noticeable stutter that occurs on the very first recording.")]
		public bool prepareOnAwake;

		[Header("Video")]
		[Tooltip("Video recording mode.")]
		public VideoMode videoMode;

		[Tooltip("Video recording resolution.")]
		public Resolution resolution;

		[Tooltip("Video recording custom resolution.")]
		public Vector2Int customResolution;

		[Tooltip("Game cameras to record.")]
		public Camera[] cameras;

		[Tooltip("Recording texture for recording video frames from a texture.")]
		public Texture texture;

		[Tooltip("Camera manager for recording video frames from a camera device.")]
		public VideoKitCameraManager cameraManager;

		[Range(5f, 30f)]
		[Tooltip("Frame rate for animated GIF images.")]
		public float frameRate;

		[Tooltip("Number of successive camera frames to skip while recording.")]
		[Range(0f, 5f)]
		public int frameSkip;

		[Header("Watermark")]
		[Tooltip("Recording watermark mode for adding a watermark to videos.")]
		public WatermarkMode watermarkMode;

		[Tooltip("Recording watermark.")]
		public Texture watermark;

		[Tooltip("Watermark display rect when `watermarkMode` is set to `WatermarkMode.Custom`")]
		public RectInt watermarkRect;

		[Header("Audio")]
		[Tooltip("Audio recording mode.")]
		public AudioMode audioMode;

		[Tooltip("Audio manager for recording audio sample buffers from an audio device.")]
		public VideoKitAudioManager audioManager;

		[Tooltip("Whether the recorder can configure the audio manager for recording.")]
		public bool configureAudioManager;

		[Range(1f, 5f)]
		[Tooltip("Audio device gain when recording both game and microphone audio.")]
		public float audioDeviceGain;

		[Tooltip("Recording action.")]
		[Header("Recording")]
		public RecordingAction recordingAction;

		[Tooltip("Event raised when a recording session is completed.")]
		public UnityEvent<MediaAsset> OnRecordingCompleted;

		[HideInInspector]
		public string mediaPathPrefix;

		[HideInInspector]
		public int videoBitRate;

		[HideInInspector]
		public int keyframeInterval;

		[HideInInspector]
		public int audioBitRate;

		private MediaRecorder recorder;

		private RealtimeClock clock;

		private IDisposable videoInput;

		private IDisposable audioInput;

		public Status status => default(Status);

		[AsyncStateMachine(typeof(_003CStartRecording_003Ed__31))]
		public Task StartRecording()
		{
			return null;
		}

		public void PauseRecording()
		{
		}

		[AsyncStateMachine(typeof(_003CResumeRecording_003Ed__33))]
		public void ResumeRecording()
		{
		}

		[AsyncStateMachine(typeof(_003CStopRecording_003Ed__34))]
		public Task StopRecording()
		{
			return null;
		}

		private void Reset()
		{
		}

		[AsyncStateMachine(typeof(_003CAwake_003Ed__40))]
		private void Awake()
		{
		}

		[AsyncStateMachine(typeof(_003COnDestroy_003Ed__41))]
		private void OnDestroy()
		{
		}

		private (int, int) CreateVideoFormat()
		{
			return default((int, int));
		}

		private int GetVideoWidth()
		{
			return 0;
		}

		private float GetVideoAspect()
		{
			return 0f;
		}

		private (int, int) CreateAudioFormat()
		{
			return default((int, int));
		}

		private RecorderTextureInput CreateTextureInput()
		{
			return null;
		}

		private IDisposable CreateVideoInput()
		{
			return null;
		}

		private IDisposable CreateAudioInput()
		{
			return null;
		}

		private static RectInt CreateWatermarkRect(MediaRecorder recorder, WatermarkMode mode, RectInt customRect)
		{
			return default(RectInt);
		}

		[AsyncStateMachine(typeof(_003CPrepareEncoder_003Ed__50))]
		private static Task PrepareEncoder()
		{
			return null;
		}
	}
}
