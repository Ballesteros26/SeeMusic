using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("ParticleSystemScriptingClasses.h")]
	[RequireComponent(typeof(Transform))]
	[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemRendererScriptBindings.h")]
	[NativeHeader("Modules/ParticleSystem/ParticleSystemRenderer.h")]
	public sealed class ParticleSystemRenderer : Renderer
	{
		[RequiredByNativeCode]
		[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetMeshes", HasExplicitThis = true)]
		public int GetMeshes([Out][NotNull("ArgumentNullException")] Mesh[] meshes)
		{
			return 0;
		}
	}
}
