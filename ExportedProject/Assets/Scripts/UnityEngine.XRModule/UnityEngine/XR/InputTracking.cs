using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.XR
{
	[NativeConditional("ENABLE_VR")]
	[RequiredByNativeCode]
	[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputTrackingFacade.h")]
	[StaticAccessor("XRInputTrackingFacade::Get()", StaticAccessorType.Dot)]
	public static class InputTracking
	{
		private enum TrackingStateEventType
		{
			NodeAdded = 0,
			NodeRemoved = 1,
			TrackingAcquired = 2,
			TrackingLost = 3
		}

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<XRNodeState> trackingAcquired;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<XRNodeState> trackingLost;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<XRNodeState> nodeAdded;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<XRNodeState> nodeRemoved;

		[RequiredByNativeCode]
		private static void InvokeTrackingEvent(TrackingStateEventType eventType, XRNode nodeType, long uniqueID, bool tracked)
		{
		}

		[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputTracking.h")]
		[StaticAccessor("XRInputTracking::Get()", StaticAccessorType.Dot)]
		internal static ulong GetDeviceIdAtXRNode(XRNode node)
		{
			return 0uL;
		}
	}
}
