using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[RequireComponent(typeof(Transform))]
	[NativeHeader("Runtime/Graphics/Mesh/MeshFilter.h")]
	public sealed class MeshFilter : Component
	{
		public Mesh sharedMesh
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Mesh mesh
		{
			[NativeName("SetInstantiatedMesh")]
			set
			{
			}
		}

		[RequiredByNativeCode]
		private void DontStripMeshFilter()
		{
		}
	}
}
