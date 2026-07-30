using System.Reflection;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[UsedByNativeCode]
	[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
	[DefaultMember("Item")]
	[NativeHeader("Modules/Animation/AnimatorOverrideController.h")]
	public class AnimatorOverrideController : RuntimeAnimatorController
	{
		internal delegate void OnOverrideControllerDirtyCallback();

		internal OnOverrideControllerDirtyCallback OnOverrideControllerDirty;

		[RequiredByNativeCode]
		[NativeConditional("UNITY_EDITOR")]
		internal static void OnInvalidateOverrideController(AnimatorOverrideController controller)
		{
		}
	}
}
