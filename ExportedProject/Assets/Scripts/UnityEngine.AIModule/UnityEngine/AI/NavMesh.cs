using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.AI
{
	[MovedFrom("UnityEngine")]
	[StaticAccessor("NavMeshBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Modules/AI/NavMesh/NavMesh.bindings.h")]
	[NativeHeader("Modules/AI/NavMeshManager.h")]
	public static class NavMesh
	{
		public delegate void OnNavMeshPreUpdate();

		public static OnNavMeshPreUpdate onPreUpdate;

		[RequiredByNativeCode]
		private static void Internal_CallOnNavMeshPreUpdate()
		{
		}
	}
}
