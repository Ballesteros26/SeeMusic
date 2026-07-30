using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AOT;
using VideoKit.Internal;
using VideoKit.Utilities;

namespace VideoKit.Devices
{
	public sealed class CameraDevice : MediaDevice
	{
		public enum ExposureMode
		{
			Continuous = 0,
			Locked = 1,
			Manual = 2
		}

		public enum FlashMode
		{
			Off = 0,
			On = 1,
			Auto = 2
		}

		public enum FocusMode
		{
			Continuous = 0,
			Locked = 1
		}

		public enum TorchMode
		{
			Off = 0,
			Maximum = 100
		}

		public enum VideoStabilizationMode
		{
			Off = 0,
			Standard = 1
		}

		public enum WhiteBalanceMode
		{
			Continuous = 0,
			Locked = 1
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CDiscover_003Ed__77 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<CameraDevice[]> _003C_003Et__builder;

			private TaskAwaiter<VideoKit.Internal.VideoKit.Status> _003C_003Eu__1;

			private TaskAwaiter<CameraDevice[]> _003C_003Eu__2;

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

		private GCHandle previewHandle;

		private LifecycleHelper lifecycleHelper;

		public bool frontFacing => false;

		public bool flashSupported => false;

		public bool torchSupported => false;

		public bool exposurePointSupported => false;

		public bool focusPointSupported => false;

		internal bool depthStreamingSupported => false;

		public (float width, float height) fieldOfView => default((float, float));

		public (float min, float max) exposureBiasRange => default((float, float));

		public (float min, float max) exposureDurationRange => default((float, float));

		public (float min, float max) ISORange => default((float, float));

		public (float min, float max) zoomRange => default((float, float));

		public (int width, int height) previewResolution
		{
			get
			{
				return default((int, int));
			}
			set
			{
			}
		}

		public (int width, int height) photoResolution
		{
			get
			{
				return default((int, int));
			}
			set
			{
			}
		}

		public int frameRate
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public ExposureMode exposureMode
		{
			get
			{
				return default(ExposureMode);
			}
			set
			{
			}
		}

		public float exposureBias
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float exposureDuration => 0f;

		public float ISO => 0f;

		public FlashMode flashMode
		{
			get
			{
				return default(FlashMode);
			}
			set
			{
			}
		}

		public FocusMode focusMode
		{
			get
			{
				return default(FocusMode);
			}
			set
			{
			}
		}

		public TorchMode torchMode
		{
			get
			{
				return default(TorchMode);
			}
			set
			{
			}
		}

		public WhiteBalanceMode whiteBalanceMode
		{
			get
			{
				return default(WhiteBalanceMode);
			}
			set
			{
			}
		}

		public VideoStabilizationMode videoStabilizationMode
		{
			get
			{
				return default(VideoStabilizationMode);
			}
			set
			{
			}
		}

		public float zoomRatio
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		private int priority => 0;

		public bool ExposureModeSupported(ExposureMode mode)
		{
			return false;
		}

		public bool FocusModeSupported(FocusMode mode)
		{
			return false;
		}

		public bool WhiteBalanceModeSupported(WhiteBalanceMode mode)
		{
			return false;
		}

		public bool VideoStabilizationModeSupported(VideoStabilizationMode mode)
		{
			return false;
		}

		public void SetExposureDuration(float duration, float ISO)
		{
		}

		public void SetExposurePoint(float x, float y)
		{
		}

		public void SetFocusPoint(float x, float y)
		{
		}

		public void StartRunning(Action<CameraImage> handler)
		{
		}

		internal void StartRunning(Action<CameraImage, CameraImage> handler)
		{
		}

		public override void StopRunning()
		{
		}

		public void CapturePhoto(Action<CameraImage> handler)
		{
		}

		public static Task<PermissionStatus> CheckPermissions(bool request = true)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CDiscover_003Ed__77))]
		public static Task<CameraDevice[]> Discover()
		{
			return null;
		}

		internal CameraDevice(IntPtr device)
			: base((IntPtr)0)
		{
		}

		public override string ToString()
		{
			return null;
		}

		private static Task<CameraDevice[]> DiscoverNative()
		{
			return null;
		}

		[MonoPInvokeCallback(typeof(VideoKit.Internal.VideoKit.DeviceDiscoveryHandler))]
		private static void OnDiscoverCameras(IntPtr context, IntPtr devices, int count)
		{
		}

		[MonoPInvokeCallback(typeof(VideoKit.Internal.VideoKit.SampleBufferHandler))]
		private static void OnPreviewImage(IntPtr context, IntPtr sampleBuffer)
		{
		}

		[MonoPInvokeCallback(typeof(VideoKit.Internal.VideoKit.SampleBufferHandler))]
		private static void OnPhotoImage(IntPtr context, IntPtr sampleBuffer)
		{
		}
	}
}
