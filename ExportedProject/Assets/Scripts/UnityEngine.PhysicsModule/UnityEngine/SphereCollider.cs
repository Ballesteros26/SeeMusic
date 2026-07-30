using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Modules/Physics/SphereCollider.h")]
	[RequiredByNativeCode]
	public class SphereCollider : Collider
	{
		public Vector3 center => default(Vector3);

		public float radius => 0f;

		[SpecialName]
		private void get_center_Injected(out Vector3 ret)
		{
			ret = default(Vector3);
		}
	}
}
