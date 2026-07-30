using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Runtime/Graphics/Mesh/MeshRenderer.h")]
	public class MeshRenderer : Renderer
	{
		[RequiredByNativeCode]
		private void DontStripMeshRenderer()
		{
		}
	}
}
