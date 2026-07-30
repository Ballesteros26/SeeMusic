using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.XR
{
	[StructLayout((LayoutKind)0)]
	[NativeConditional("ENABLE_VR")]
	[UsedByNativeCode]
	[StaticAccessor("XRInputDevices::Get()", StaticAccessorType.Dot)]
	[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
	public class InputDevices
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<InputDevice> deviceConnected;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<InputDevice> deviceDisconnected;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<InputDevice> deviceConfigChanged;

		public static InputDevice GetDeviceAtXRNode(XRNode node)
		{
			return default(InputDevice);
		}

		public static void GetDevices(List<InputDevice> inputDevices)
		{
		}

		[RequiredByNativeCode]
		private static void InvokeConnectionEvent(ulong deviceId, ConnectionChangeType change)
		{
		}

		private static void GetDevices_Internal([NotNull("ArgumentNullException")] List<InputDevice> inputDevices)
		{
		}

		internal static string GetDeviceName(ulong deviceId)
		{
			return null;
		}

		internal static string GetDeviceManufacturer(ulong deviceId)
		{
			return null;
		}
	}
}
