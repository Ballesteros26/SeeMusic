using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[RequiredByNativeCode]
	[NativeHeader("Modules/Physics/CapsuleCollider.h")]
	public class CapsuleCollider : Collider
	{
		public float height
		{
			set
			{
			}
		}
	}
}
