using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Runtime/Graphics/Mesh/Mesh.h")]
	[NativeHeader("Modules/Physics/MeshCollider.h")]
	[RequiredByNativeCode]
	public class MeshCollider : Collider
	{
		public Mesh sharedMesh
		{
			set
			{
			}
		}

		public bool convex
		{
			set
			{
			}
		}
	}
}
