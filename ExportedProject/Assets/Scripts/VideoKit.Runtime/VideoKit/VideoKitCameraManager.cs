using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using NatML;
using NatML.Features;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Events;
using VideoKit.AI;
using VideoKit.Devices;
using VideoKit.Devices.Outputs;

namespace VideoKit
{
	[Tooltip("VideoKit camera manager for streaming video from camera devices.")]
	[HelpURL("https://docs.videokit.ai/videokit/api/videokitcameramanager")]
	[DisallowMultipleComponent]
	public sealed class VideoKitCameraManager : VideoKitDeviceManager<CameraDevice>
	{
		[Flags]
		public enum Capabilities
		{
			Depth = 1,
			AI = 2,
			HumanTexture = 6,
			PoseDetection = 0xA,
			FaceDetection = 0x12
		}

		public enum Facing
		{
			PreferUser = 0,
			PreferWorld = 1,
			RequireUser = 2,
			RequireWorld = 3
		}

		public enum Resolution
		{
			Default = 0,
			Lowest = 1,
			_640x480 = 2,
			_1280x720 = 3,
			_1920x1080 = 4,
			_4K = 5,
			Highest = 10
		}

		public enum FrameRate
		{
			Default = 0,
			Lowest = 1,
			_15 = 15,
			_30 = 30,
			_60 = 60,
			_120 = 120,
			_240 = 240
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CStartRunning_003Ed__33 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public VideoKitCameraManager _003C_003E4__this;

			private TaskAwaiter<MediaDevice.PermissionStatus> _003C_003Eu__1;

			private TaskAwaiter<CameraDevice[]> _003C_003Eu__2;

			private TaskAwaiter<MatteKitPredictor> _003C_003Eu__3;

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
		private struct _003CAwake_003Ed__42 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public VideoKitCameraManager _003C_003E4__this;

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

		[Tooltip("Desired camera capabilities.")]
		[Header("Configuration")]
		public Capabilities capabilities;

		[Tooltip("Whether to start the camera preview as soon as the component awakes.")]
		public bool playOnAwake;

		[Header("Camera Settings")]
		[Tooltip("Desired camera facing.")]
		[SerializeField]
		private Facing _facing;

		[Tooltip("Desired camera resolution.")]
		public Resolution resolution;

		[Tooltip("Desired camera frame rate.")]
		public FrameRate frameRate;

		[Tooltip("Desired camera focus mode.")]
		public CameraDevice.FocusMode focusMode;

		[Tooltip("Desired camera exposure mode.")]
		public CameraDevice.ExposureMode exposureMode;

		[Header("Events")]
		[Tooltip("Event raised when a new camera frame is available.")]
		public UnityEvent OnCameraFrame;

		private CameraDevice[] devices;

		private CameraDevice _device;

		private CameraOutput output;

		private MatteKitPredictor matteKit;

		private readonly MLEdgeModel.Configuration matteKitConfiguration;

		public override CameraDevice device
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Facing facing
		{
			get
			{
				return default(Facing);
			}
			set
			{
			}
		}

		public CameraImage image => default(CameraImage);

		public Texture texture => null;

		public NativeArray<byte> pixelBuffer => default(NativeArray<byte>);

		public MLImageFeature imageFeature => null;

		public Texture2D humanTexture => null;

		public override bool running => false;

		private (int width, int height) frameSize => default((int, int));

		public event Action<CameraImage> OnCameraImage
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

		[AsyncStateMachine(typeof(_003CStartRunning_003Ed__33))]
		public override Task StartRunning()
		{
			return null;
		}

		public override void StopRunning()
		{
		}

		[AsyncStateMachine(typeof(_003CAwake_003Ed__42))]
		private void Awake()
		{
		}

		private void UpdateCameraImage(CameraImage image)
		{
		}

		private void OnCameraTexture(TextureOutput output)
		{
		}

		private void OnCameraTexture(RenderTextureOutput output)
		{
		}

		private void OnDestroy()
		{
		}

		internal (int, int) GetPreviewSize()
		{
			return default((int, int));
		}

		private CameraDevice GetDefaultCameraDevice(Facing facing)
		{
			return null;
		}
	}
}
