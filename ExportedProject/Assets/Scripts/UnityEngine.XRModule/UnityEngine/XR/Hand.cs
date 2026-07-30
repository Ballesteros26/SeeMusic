using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.XR
{
	[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
	[NativeHeader("XRScriptingClasses.h")]
	[StaticAccessor("XRInputDevices::Get()", StaticAccessorType.Dot)]
	[RequiredByNativeCode]
	[NativeConditional("ENABLE_VR")]
	[NativeHeader("Modules/XR/XRPrefix.h")]
	public struct Hand : IEquatable<Hand>
	{
		private ulong m_DeviceId;

		private uint m_FeatureIndex;

		internal ulong deviceId => 0uL;

		internal uint featureIndex => 0u;

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(Hand other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
