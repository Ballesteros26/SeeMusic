using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Runtime/Graphics/Renderer.h")]
	[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
	[RequireComponent(typeof(Transform))]
	[UsedByNativeCode]
	public class Renderer : Component
	{
		public Bounds bounds
		{
			[FreeFunction(Name = "RendererScripting::GetWorldBounds", HasExplicitThis = true)]
			get
			{
				return default(Bounds);
			}
		}

		public bool enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public ShadowCastingMode shadowCastingMode
		{
			set
			{
			}
		}

		public bool receiveShadows
		{
			set
			{
			}
		}

		public bool forceRenderingOff
		{
			set
			{
			}
		}

		public LightProbeUsage lightProbeUsage
		{
			set
			{
			}
		}

		public ReflectionProbeUsage reflectionProbeUsage
		{
			set
			{
			}
		}

		public uint renderingLayerMask
		{
			set
			{
			}
		}

		public int sortingLayerID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int sortingOrder
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		internal int sortingGroupID => 0;

		internal int sortingGroupOrder => 0;

		[NativeProperty("IsDynamicOccludee")]
		public bool allowOcclusionWhenDynamic
		{
			set
			{
			}
		}

		public Material[] materials => null;

		public Material material
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Material sharedMaterial
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Material[] sharedMaterials
		{
			set
			{
			}
		}

		[FreeFunction(Name = "RendererScripting::GetMaterial", HasExplicitThis = true)]
		private Material GetMaterial()
		{
			return null;
		}

		[FreeFunction(Name = "RendererScripting::GetSharedMaterial", HasExplicitThis = true)]
		private Material GetSharedMaterial()
		{
			return null;
		}

		[FreeFunction(Name = "RendererScripting::SetMaterial", HasExplicitThis = true)]
		private void SetMaterial(Material m)
		{
		}

		[FreeFunction(Name = "RendererScripting::GetMaterialArray", HasExplicitThis = true)]
		private Material[] GetMaterialArray()
		{
			return null;
		}

		[FreeFunction(Name = "RendererScripting::SetMaterialArray", HasExplicitThis = true)]
		private void SetMaterialArray([NotNull("ArgumentNullException")] Material[] m)
		{
		}

		[FreeFunction(Name = "RendererScripting::SetPropertyBlock", HasExplicitThis = true)]
		internal void Internal_SetPropertyBlock(MaterialPropertyBlock properties)
		{
		}

		[FreeFunction(Name = "RendererScripting::GetPropertyBlock", HasExplicitThis = true)]
		internal void Internal_GetPropertyBlock([NotNull("ArgumentNullException")] MaterialPropertyBlock dest)
		{
		}

		public void SetPropertyBlock(MaterialPropertyBlock properties)
		{
		}

		public void GetPropertyBlock(MaterialPropertyBlock properties)
		{
		}

		[SpecialName]
		private void get_bounds_Injected(out Bounds ret)
		{
			ret = default(Bounds);
		}
	}
}
