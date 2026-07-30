using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Video
{
	[NativeHeader("Modules/Video/Public/VideoPlayer.h")]
	[RequireComponent(typeof(Transform))]
	[RequiredByNativeCode]
	public sealed class VideoPlayer : Behaviour
	{
		public delegate void EventHandler(VideoPlayer source);

		public delegate void ErrorEventHandler(VideoPlayer source, string message);

		public delegate void FrameReadyEventHandler(VideoPlayer source, long frameIdx);

		public delegate void TimeEventHandler(VideoPlayer source, double seconds);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private EventHandler prepareCompleted;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private EventHandler loopPointReached;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private EventHandler frameDropped;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private TimeEventHandler clockResyncOccurred;

		[NativeName("VideoUrl")]
		public string url
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public VideoRenderMode renderMode
		{
			set
			{
			}
		}

		[NativeHeader("Runtime/Graphics/RenderTexture.h")]
		public RenderTexture targetTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public VideoAspectRatio aspectRatio
		{
			set
			{
			}
		}

		[NativeHeader("Runtime/Graphics/Texture.h")]
		public Texture texture => null;

		public bool isPrepared
		{
			[NativeName("IsPrepared")]
			get
			{
				return false;
			}
		}

		public bool waitForFirstFrame
		{
			set
			{
			}
		}

		public bool playOnAwake
		{
			set
			{
			}
		}

		public bool isPlaying
		{
			[NativeName("IsPlaying")]
			get
			{
				return false;
			}
		}

		[NativeName("SecPosition")]
		public double time
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		[NativeName("FramePosition")]
		public long frame => 0L;

		public float playbackSpeed
		{
			set
			{
			}
		}

		[NativeName("Loop")]
		public bool isLooping => false;

		public bool skipOnDrop
		{
			set
			{
			}
		}

		public ulong frameCount => 0uL;

		public float frameRate => 0f;

		[NativeName("Duration")]
		public double length => 0.0;

		public uint width => 0u;

		public uint height => 0u;

		public ushort audioTrackCount => 0;

		public static ushort controlledAudioTrackMaxCount => 0;

		public ushort controlledAudioTrackCount
		{
			set
			{
			}
		}

		public VideoAudioOutputMode audioOutputMode
		{
			set
			{
			}
		}

		public bool sendFrameReadyEvents
		{
			[NativeName("EnableFrameReadyEvents")]
			set
			{
			}
		}

		public event EventHandler started
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

		public event ErrorEventHandler errorReceived
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

		public event EventHandler seekCompleted
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

		public event FrameReadyEventHandler frameReady
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

		public void Prepare()
		{
		}

		public void Play()
		{
		}

		public void Pause()
		{
		}

		public void Stop()
		{
		}

		public void StepForward()
		{
		}

		private void SetControlledAudioTrackCount(ushort value)
		{
		}

		public void EnableAudioTrack(ushort trackIndex, bool enabled)
		{
		}

		public void SetTargetAudioSource(ushort trackIndex, AudioSource source)
		{
		}

		[RequiredByNativeCode]
		private static void InvokePrepareCompletedCallback_Internal(VideoPlayer source)
		{
		}

		[RequiredByNativeCode]
		private static void InvokeFrameReadyCallback_Internal(VideoPlayer source, long frameIdx)
		{
		}

		[RequiredByNativeCode]
		private static void InvokeLoopPointReachedCallback_Internal(VideoPlayer source)
		{
		}

		[RequiredByNativeCode]
		private static void InvokeStartedCallback_Internal(VideoPlayer source)
		{
		}

		[RequiredByNativeCode]
		private static void InvokeFrameDroppedCallback_Internal(VideoPlayer source)
		{
		}

		[RequiredByNativeCode]
		private static void InvokeErrorReceivedCallback_Internal(VideoPlayer source, string errorStr)
		{
		}

		[RequiredByNativeCode]
		private static void InvokeSeekCompletedCallback_Internal(VideoPlayer source)
		{
		}

		[RequiredByNativeCode]
		private static void InvokeClockResyncOccurredCallback_Internal(VideoPlayer source, double seconds)
		{
		}
	}
}
