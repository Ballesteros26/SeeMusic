using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.XR
{
	[NativeConditional("ENABLE_VR")]
	public static class XRDevice
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<string> deviceLoaded;

		[RequiredByNativeCode]
		private static void InvokeDeviceLoaded(string loadedDeviceName)
		{
		}
	}
}
