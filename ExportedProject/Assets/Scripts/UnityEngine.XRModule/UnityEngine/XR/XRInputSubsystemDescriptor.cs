using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.XR
{
	[UsedByNativeCode]
	[NativeConditional("ENABLE_XR")]
	[NativeType(Header = "Modules/XR/Subsystems/Input/XRInputSubsystemDescriptor.h")]
	[NativeHeader("Modules/XR/XRPrefix.h")]
	public class XRInputSubsystemDescriptor : IntegratedSubsystemDescriptor<XRInputSubsystem>
	{
	}
}
