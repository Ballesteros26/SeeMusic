using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Windows.WebCam
{
	[MovedFrom("UnityEngine.XR.WSA.WebCam")]
	[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
	[NativeHeader("PlatformDependent/Win/Webcam/PhotoCaptureFrame.h")]
	public sealed class PhotoCaptureFrame : IDisposable
	{
		private IntPtr m_NativePtr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _003ChasLocationData_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private CapturePixelFormat _003CpixelFormat_003Ek__BackingField;

		public int dataLength { get; private set; }

		private bool hasLocationData
		{
			[CompilerGenerated]
			set
			{
				_003ChasLocationData_003Ek__BackingField = value;
			}
		}

		private CapturePixelFormat pixelFormat
		{
			[CompilerGenerated]
			set
			{
				_003CpixelFormat_003Ek__BackingField = value;
			}
		}

		[ThreadAndSerializationSafe]
		private int GetDataLength()
		{
			return 0;
		}

		[ThreadAndSerializationSafe]
		private bool GetHasLocationData()
		{
			return false;
		}

		[ThreadAndSerializationSafe]
		private CapturePixelFormat GetCapturePixelFormat()
		{
			return default(CapturePixelFormat);
		}

		internal PhotoCaptureFrame(IntPtr nativePtr)
		{
		}

		private void Cleanup()
		{
		}

		[NativeName("Dispose")]
		[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
		[ThreadAndSerializationSafe]
		private void Dispose_Internal()
		{
		}

		public void Dispose()
		{
		}

		~PhotoCaptureFrame()
		{
		}
	}
}
