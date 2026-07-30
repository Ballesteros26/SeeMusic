using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.VFX
{
	[NativeHeader("Modules/VFX/Public/VisualEffect.h")]
	[NativeHeader("Modules/VFX/Public/ScriptBindings/VisualEffectBindings.h")]
	[RequireComponent(typeof(Transform))]
	public class VisualEffect : Behaviour
	{
		private VFXEventAttribute m_cachedEventAttribute;

		public Action<VFXOutputEventArgs> outputEventReceived;

		public float playRate
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public VisualEffectAsset visualEffectAsset
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public VFXEventAttribute CreateVFXEventAttribute()
		{
			return null;
		}

		private void CheckValidVFXEventAttribute(VFXEventAttribute eventAttribute)
		{
		}

		[FreeFunction(Name = "VisualEffectBindings::SendEventFromScript", HasExplicitThis = true)]
		private void SendEventFromScript(int eventNameID, VFXEventAttribute eventAttribute)
		{
		}

		public void SendEvent(int eventNameID, VFXEventAttribute eventAttribute)
		{
		}

		public void SendEvent(string eventName, VFXEventAttribute eventAttribute)
		{
		}

		public void SendEvent(int eventNameID)
		{
		}

		public void Play()
		{
		}

		public void Reinit()
		{
		}

		[FreeFunction(Name = "VisualEffectBindings::HasValueFromScript<bool>", HasExplicitThis = true)]
		public bool HasBool(int nameID)
		{
			return false;
		}

		[FreeFunction(Name = "VisualEffectBindings::HasValueFromScript<int>", HasExplicitThis = true)]
		public bool HasInt(int nameID)
		{
			return false;
		}

		[FreeFunction(Name = "VisualEffectBindings::HasValueFromScript<UInt32>", HasExplicitThis = true)]
		public bool HasUInt(int nameID)
		{
			return false;
		}

		[FreeFunction(Name = "VisualEffectBindings::HasValueFromScript<float>", HasExplicitThis = true)]
		public bool HasFloat(int nameID)
		{
			return false;
		}

		[FreeFunction(Name = "VisualEffectBindings::HasValueFromScript<Vector3f>", HasExplicitThis = true)]
		public bool HasVector3(int nameID)
		{
			return false;
		}

		[FreeFunction(Name = "VisualEffectBindings::HasValueFromScript<Vector4f>", HasExplicitThis = true)]
		public bool HasVector4(int nameID)
		{
			return false;
		}

		[FreeFunction(Name = "VisualEffectBindings::HasValueFromScript<Texture*>", HasExplicitThis = true)]
		public bool HasTexture(int nameID)
		{
			return false;
		}

		[FreeFunction(Name = "VisualEffectBindings::SetValueFromScript<bool>", HasExplicitThis = true)]
		public void SetBool(int nameID, bool b)
		{
		}

		[FreeFunction(Name = "VisualEffectBindings::SetValueFromScript<int>", HasExplicitThis = true)]
		public void SetInt(int nameID, int i)
		{
		}

		[FreeFunction(Name = "VisualEffectBindings::SetValueFromScript<UInt32>", HasExplicitThis = true)]
		public void SetUInt(int nameID, uint i)
		{
		}

		[FreeFunction(Name = "VisualEffectBindings::SetValueFromScript<float>", HasExplicitThis = true)]
		public void SetFloat(int nameID, float f)
		{
		}

		[FreeFunction(Name = "VisualEffectBindings::SetValueFromScript<Vector3f>", HasExplicitThis = true)]
		public void SetVector3(int nameID, Vector3 v)
		{
		}

		[FreeFunction(Name = "VisualEffectBindings::SetValueFromScript<Vector4f>", HasExplicitThis = true)]
		public void SetVector4(int nameID, Vector4 v)
		{
		}

		[FreeFunction(Name = "VisualEffectBindings::SetValueFromScript<Texture*>", HasExplicitThis = true)]
		public void SetTexture(int nameID, [NotNull("ArgumentNullException")] Texture t)
		{
		}

		[FreeFunction(Name = "VisualEffectBindings::GetValueFromScript<float>", HasExplicitThis = true)]
		public float GetFloat(int nameID)
		{
			return 0f;
		}

		public bool HasUInt(string name)
		{
			return false;
		}

		public bool HasFloat(string name)
		{
			return false;
		}

		public bool HasVector4(string name)
		{
			return false;
		}

		public bool HasTexture(string name)
		{
			return false;
		}

		public void SetInt(string name, int i)
		{
		}

		public void SetUInt(string name, uint i)
		{
		}

		public void SetFloat(string name, float f)
		{
		}

		public void SetVector4(string name, Vector4 v)
		{
		}

		public void SetTexture(string name, Texture t)
		{
		}

		public void SetBool(string name, bool b)
		{
		}

		public void Simulate(float stepDeltaTime, uint stepCount = 1u)
		{
		}

		[RequiredByNativeCode]
		private static VFXEventAttribute InvokeGetCachedEventAttributeForOutputEvent_Internal(VisualEffect source)
		{
			return null;
		}

		[RequiredByNativeCode]
		private static void InvokeOutputEventReceived_Internal(VisualEffect source, int eventNameId)
		{
		}

		private void SetVector3_Injected(int nameID, ref Vector3 v)
		{
		}

		private void SetVector4_Injected(int nameID, ref Vector4 v)
		{
		}
	}
}
