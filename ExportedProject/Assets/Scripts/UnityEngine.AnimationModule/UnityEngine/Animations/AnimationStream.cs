using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Animations
{
	[RequiredByNativeCode]
	[MovedFrom("UnityEngine.Experimental.Animations")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationStream.bindings.h")]
	[NativeHeader("Modules/Animation/Director/AnimationStream.h")]
	public struct AnimationStream
	{
		private uint m_AnimatorBindingsVersion;

		private IntPtr constant;

		private IntPtr input;

		private IntPtr output;

		private IntPtr workspace;

		private IntPtr inputStreamAccessor;

		private IntPtr animationHandleBinder;
	}
}
