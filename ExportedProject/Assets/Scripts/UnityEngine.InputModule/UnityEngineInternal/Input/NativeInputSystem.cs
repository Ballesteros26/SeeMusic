using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngineInternal.Input
{
	[NativeHeader("Modules/Input/Private/InputModuleBindings.h")]
	[NativeHeader("Modules/Input/Private/InputInternal.h")]
	internal class NativeInputSystem
	{
		public static NativeUpdateCallback onUpdate;

		public static Action<NativeInputUpdateType> onBeforeUpdate;

		public static Func<NativeInputUpdateType, bool> onShouldRunUpdate;

		private static Action<int, string> s_OnDeviceDiscoveredCallback;

		internal static bool hasDeviceDiscoveredCallback
		{
			set
			{
			}
		}

		static NativeInputSystem()
		{
		}

		[RequiredByNativeCode]
		internal static void NotifyBeforeUpdate(NativeInputUpdateType updateType)
		{
		}

		[RequiredByNativeCode]
		internal static void NotifyUpdate(NativeInputUpdateType updateType, IntPtr eventBuffer)
		{
		}

		[RequiredByNativeCode]
		internal static void NotifyDeviceDiscovered(int deviceId, string deviceDescriptor)
		{
		}

		[RequiredByNativeCode]
		internal static void ShouldRunUpdate(NativeInputUpdateType updateType, out bool retval)
		{
			retval = default(bool);
		}
	}
}
