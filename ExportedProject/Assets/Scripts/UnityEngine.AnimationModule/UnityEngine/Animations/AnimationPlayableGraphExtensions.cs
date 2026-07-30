using UnityEngine.Bindings;
using UnityEngine.Playables;

namespace UnityEngine.Animations
{
	[NativeHeader("Modules/Animation/Animator.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationPlayableGraphExtensions.bindings.h")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[StaticAccessor("AnimationPlayableGraphExtensionsBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
	internal static class AnimationPlayableGraphExtensions
	{
		[NativeThrows]
		internal static bool InternalCreateAnimationOutput(ref PlayableGraph graph, string name, out PlayableOutputHandle handle)
		{
			handle = default(PlayableOutputHandle);
			return false;
		}
	}
}
