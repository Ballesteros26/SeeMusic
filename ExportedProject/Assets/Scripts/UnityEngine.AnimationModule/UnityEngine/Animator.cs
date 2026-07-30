using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Modules/Animation/ScriptBindings/Animator.bindings.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerParameter.bindings.h")]
	[UsedByNativeCode]
	[NativeHeader("Modules/Animation/Animator.h")]
	public class Animator : Behaviour
	{
		public bool isHuman
		{
			[NativeMethod("IsHuman")]
			get
			{
				return false;
			}
		}

		public bool hasRootMotion
		{
			[NativeMethod("HasRootMotion")]
			get
			{
				return false;
			}
		}

		public float speed
		{
			set
			{
			}
		}

		public RuntimeAnimatorController runtimeAnimatorController => null;

		public bool hasBoundPlayables
		{
			[NativeMethod("HasBoundPlayables")]
			get
			{
				return false;
			}
		}

		public Avatar avatar => null;

		public void SetTrigger(string name)
		{
		}

		public void ResetTrigger(string name)
		{
		}

		private void GetAnimatorStateInfo(int layerIndex, StateInfoIndex stateInfoIndex, out AnimatorStateInfo info)
		{
			info = default(AnimatorStateInfo);
		}

		public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex)
		{
			return default(AnimatorStateInfo);
		}

		public void Play(string stateName)
		{
		}

		public void Play(string stateName, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime)
		{
		}

		[FreeFunction(Name = "AnimatorBindings::Play", HasExplicitThis = true)]
		public void Play(int stateNameHash, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime)
		{
		}

		public void StopPlayback()
		{
		}

		[NativeMethod(Name = "ScriptingStringToCRC32", IsThreadSafe = true)]
		public static int StringToHash(string name)
		{
			return 0;
		}

		[FreeFunction(Name = "AnimatorBindings::SetTriggerString", HasExplicitThis = true)]
		private void SetTriggerString(string name)
		{
		}

		[FreeFunction(Name = "AnimatorBindings::ResetTriggerString", HasExplicitThis = true)]
		private void ResetTriggerString(string name)
		{
		}
	}
}
