using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.VFX
{
	[StructLayout((LayoutKind)0)]
	[NativeType(Header = "Modules/VFX/Public/VFXExpressionValues.h")]
	[RequiredByNativeCode]
	public class VFXExpressionValues
	{
		internal IntPtr m_Ptr;

		private VFXExpressionValues()
		{
		}

		[RequiredByNativeCode]
		internal static VFXExpressionValues CreateExpressionValuesWrapper(IntPtr ptr)
		{
			return null;
		}

		[NativeThrows]
		[NativeName("GetValueFromScript<bool>")]
		public bool GetBool(int nameID)
		{
			return false;
		}

		[NativeName("GetValueFromScript<int>")]
		[NativeThrows]
		public int GetInt(int nameID)
		{
			return 0;
		}

		[NativeName("GetValueFromScript<UInt32>")]
		[NativeThrows]
		public uint GetUInt(int nameID)
		{
			return 0u;
		}

		[NativeName("GetValueFromScript<float>")]
		[NativeThrows]
		public float GetFloat(int nameID)
		{
			return 0f;
		}

		[NativeName("GetValueFromScript<Vector3f>")]
		[NativeThrows]
		public Vector3 GetVector3(int nameID)
		{
			return default(Vector3);
		}

		private void GetVector3_Injected(int nameID, out Vector3 ret)
		{
			ret = default(Vector3);
		}
	}
}
