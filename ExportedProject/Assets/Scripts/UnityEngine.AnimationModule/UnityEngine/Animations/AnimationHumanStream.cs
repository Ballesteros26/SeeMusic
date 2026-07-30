using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Animations
{
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationHumanStream.bindings.h")]
	[NativeHeader("Modules/Animation/Director/AnimationHumanStream.h")]
	[RequiredByNativeCode]
	[MovedFrom("UnityEngine.Experimental.Animations")]
	public struct AnimationHumanStream
	{
		private IntPtr stream;
	}
}
