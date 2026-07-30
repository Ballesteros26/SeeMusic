using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AOT;
using VideoKit.Internal;

namespace VideoKit.Devices
{
	public abstract class MediaDevice
	{
		public enum Location
		{
			Unknown = 0,
			Internal = 1,
			External = 2
		}

		public enum PermissionStatus
		{
			Unknown = 0,
			Denied = 2,
			Authorized = 3
		}

		protected readonly IntPtr device;

		private readonly GCHandle weakSelf;

		public string uniqueID { get; protected set; }

		public string name { get; protected set; }

		public virtual Location location => default(Location);

		public virtual bool defaultForMediaType => false;

		public virtual bool running => false;

		public event Action onDisconnected
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

		public abstract void StopRunning();

		internal MediaDevice(IntPtr device)
		{
		}

		~MediaDevice()
		{
		}

		public static implicit operator IntPtr(MediaDevice device)
		{
			return (IntPtr)0;
		}

		protected static Task<PermissionStatus> CheckPermissions(VideoKit.Internal.VideoKit.PermissionType type, bool request)
		{
			return null;
		}

		[MonoPInvokeCallback(typeof(VideoKit.Internal.VideoKit.DeviceDisconnectHandler))]
		private static void OnDeviceDisconnect(IntPtr context)
		{
		}

		[MonoPInvokeCallback(typeof(VideoKit.Internal.VideoKit.PermissionResultHandler))]
		private static void OnPermissionResult(IntPtr context, PermissionStatus status)
		{
		}
	}
}
