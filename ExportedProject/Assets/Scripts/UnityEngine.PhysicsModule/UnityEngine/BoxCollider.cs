using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[RequiredByNativeCode]
	[NativeHeader("Modules/Physics/BoxCollider.h")]
	public class BoxCollider : Collider
	{
		public Vector3 center
		{
			set
			{
			}
		}

		public Vector3 size
		{
			set
			{
			}
		}

		[SpecialName]
		private void set_center_Injected(ref Vector3 value)
		{
		}

		[SpecialName]
		private void set_size_Injected(ref Vector3 value)
		{
		}
	}
}
