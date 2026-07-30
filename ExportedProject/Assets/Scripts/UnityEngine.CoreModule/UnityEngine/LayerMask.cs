using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	[NativeHeader("Runtime/BaseClasses/TagManager.h")]
	[NativeClass("BitField", "struct BitField;")]
	[NativeHeader("Runtime/BaseClasses/BitField.h")]
	public struct LayerMask
	{
		[NativeName("m_Bits")]
		private int m_Mask;

		public int value => 0;

		public static implicit operator int(LayerMask mask)
		{
			return 0;
		}

		public static implicit operator LayerMask(int intVal)
		{
			return default(LayerMask);
		}

		[NativeMethod("StringToLayer")]
		[StaticAccessor("GetTagManager()", StaticAccessorType.Dot)]
		public static int NameToLayer(string layerName)
		{
			return 0;
		}

		public static int GetMask(params string[] layerNames)
		{
			return 0;
		}
	}
}
