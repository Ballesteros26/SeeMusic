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
	public sealed class AudioDevice : MediaDevice
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CDiscover_003Ed__14 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<AudioDevice[]> _003C_003Et__builder;

			public bool configureAudioSession;

			private TaskAwaiter<VideoKit.Internal.VideoKit.Status> _003C_003Eu__1;

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

		private GCHandle streamHandle;

		private LifecycleHelper lifecycleHelper;

		public bool echoCancellationSupported => false;

		public bool echoCancellation
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int sampleRate
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int channelCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		private int priority => 0;

		public void StartRunning(Action<AudioBuffer> handler)
		{
		}

		public override void StopRunning()
		{
		}

		public static Task<PermissionStatus> CheckPermissions(bool request = true)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CDiscover_003Ed__14))]
		public static Task<AudioDevice[]> Discover(bool configureAudioSession = true)
		{
			return null;
		}

		internal AudioDevice(IntPtr device)
			: base((IntPtr)0)
		{
		}

		public override string ToString()
		{
			return null;
		}

		private static Task<AudioDevice[]> DiscoverNative()
		{
			return null;
		}

		[MonoPInvokeCallback(typeof(VideoKit.Internal.VideoKit.DeviceDiscoveryHandler))]
		private static void OnDiscoverMicrophones(IntPtr context, IntPtr devices, int count)
		{
		}

		[MonoPInvokeCallback(typeof(VideoKit.Internal.VideoKit.SampleBufferHandler))]
		private static void OnAudioBuffer(IntPtr context, IntPtr sampleBuffer)
		{
		}
	}
}
