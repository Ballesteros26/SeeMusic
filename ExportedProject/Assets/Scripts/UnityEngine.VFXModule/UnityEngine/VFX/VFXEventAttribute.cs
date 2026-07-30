using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.VFX
{
	[StructLayout((LayoutKind)0)]
	[RequiredByNativeCode]
	[NativeType(Header = "Modules/VFX/Public/VFXEventAttribute.h")]
	public sealed class VFXEventAttribute : IDisposable
	{
		private IntPtr m_Ptr;

		private bool m_Owner;

		private VisualEffectAsset m_VfxAsset;

		internal VisualEffectAsset vfxAsset => null;

		private VFXEventAttribute(IntPtr ptr, bool owner, VisualEffectAsset vfxAsset)
		{
		}

		private VFXEventAttribute()
		{
		}

		internal static VFXEventAttribute CreateEventAttributeWrapper()
		{
			return null;
		}

		internal void SetWrapValue(IntPtr ptrToEventAttribute)
		{
		}

		internal static IntPtr Internal_Create()
		{
			return (IntPtr)0;
		}

		internal static VFXEventAttribute Internal_InstanciateVFXEventAttribute(VisualEffectAsset vfxAsset)
		{
			return null;
		}

		internal void Internal_InitFromAsset(VisualEffectAsset vfxAsset)
		{
		}

		private void Release()
		{
		}

		~VFXEventAttribute()
		{
		}

		public void Dispose()
		{
		}

		[NativeMethod(IsThreadSafe = true)]
		internal static void Internal_Destroy(IntPtr ptr)
		{
		}

		[NativeName("SetValueFromScript<bool>")]
		public void SetBool(int nameID, bool b)
		{
		}

		[NativeName("SetValueFromScript<int>")]
		public void SetInt(int nameID, int i)
		{
		}

		[NativeName("SetValueFromScript<UInt32>")]
		public void SetUint(int nameID, uint i)
		{
		}

		[NativeName("SetValueFromScript<float>")]
		public void SetFloat(int nameID, float f)
		{
		}

		[NativeName("SetValueFromScript<Vector2f>")]
		public void SetVector2(int nameID, Vector2 v)
		{
		}

		[NativeName("SetValueFromScript<Vector3f>")]
		public void SetVector3(int nameID, Vector3 v)
		{
		}

		[NativeName("SetValueFromScript<Vector4f>")]
		public void SetVector4(int nameID, Vector4 v)
		{
		}

		public void SetVector3(string name, Vector3 v)
		{
		}

		private void SetVector2_Injected(int nameID, ref Vector2 v)
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
