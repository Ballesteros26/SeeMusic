using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
	[NativeHeader("Modules/Animation/AnimatorInfo.h")]
	[UsedByNativeCode]
	public struct AnimatorClipInfo
	{
		private int m_ClipInstanceID;

		private float m_Weight;
	}
}
