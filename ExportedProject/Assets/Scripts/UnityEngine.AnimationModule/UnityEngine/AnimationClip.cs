using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeType("Modules/Animation/AnimationClip.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationClip.bindings.h")]
	public sealed class AnimationClip : Motion
	{
		[NativeProperty("Length", false, TargetType.Function)]
		public float length => 0f;

		[NativeProperty("SampleRate", false, TargetType.Function)]
		public float frameRate
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool legacy
		{
			[NativeMethod("IsLegacy")]
			get
			{
				return false;
			}
			[NativeMethod("SetLegacy")]
			set
			{
			}
		}

		public bool empty
		{
			[NativeMethod("IsEmpty")]
			get
			{
				return false;
			}
		}

		public bool hasGenericRootTransform
		{
			[NativeMethod("HasGenericRootTransform")]
			get
			{
				return false;
			}
		}

		public bool hasMotionCurves
		{
			[NativeMethod("HasMotionCurves")]
			get
			{
				return false;
			}
		}

		public bool hasRootCurves
		{
			[NativeMethod("HasRootCurves")]
			get
			{
				return false;
			}
		}

		internal bool hasRootMotion
		{
			[FreeFunction(Name = "AnimationClipBindings::Internal_GetHasRootMotion", HasExplicitThis = true)]
			get
			{
				return false;
			}
		}

		[FreeFunction("AnimationClipBindings::Internal_CreateAnimationClip")]
		private static void Internal_CreateAnimationClip([Writable] AnimationClip self)
		{
		}
	}
}
