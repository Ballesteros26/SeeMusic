using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("TerrainScriptingClasses.h")]
	[NativeHeader("Modules/Terrain/Public/TerrainDataScriptingInterface.h")]
	[UsedByNativeCode]
	public sealed class TerrainData : Object
	{
		private enum BoundaryValueType
		{
			MaxHeightmapRes = 0,
			MinDetailResPerPatch = 1,
			MaxDetailResPerPatch = 2,
			MaxDetailPatchCount = 3,
			MaxDetailsPerRes = 4,
			MinAlphamapRes = 5,
			MaxAlphamapRes = 6,
			MinBaseMapRes = 7,
			MaxBaseMapRes = 8
		}

		internal static readonly int k_MaximumResolution;

		internal static readonly int k_MinimumDetailResolutionPerPatch;

		internal static readonly int k_MaximumDetailResolutionPerPatch;

		internal static readonly int k_MaximumDetailPatchCount;

		internal static readonly int k_MaximumDetailsPerRes;

		internal static readonly int k_MinimumAlphamapResolution;

		internal static readonly int k_MaximumAlphamapResolution;

		internal static readonly int k_MinimumBaseMapResolution;

		internal static readonly int k_MaximumBaseMapResolution;

		public RenderTexture heightmapTexture
		{
			[NativeName("GetHeightmap().GetHeightmapTexture")]
			get
			{
				return null;
			}
		}

		public Vector3 heightmapScale
		{
			[NativeName("GetHeightmap().GetScale")]
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 size
		{
			[NativeName("GetHeightmap().GetSize")]
			get
			{
				return default(Vector3);
			}
		}

		public Bounds bounds
		{
			[NativeName("GetHeightmap().CalculateBounds")]
			get
			{
				return default(Bounds);
			}
		}

		internal Terrain[] users => null;

		[ThreadSafe]
		[StaticAccessor("TerrainDataScriptingInterface", StaticAccessorType.DoubleColon)]
		private static int GetBoundaryValue(BoundaryValueType type)
		{
			return 0;
		}

		[FreeFunction("TerrainDataScriptingInterface::Create")]
		private static void Internal_Create([Writable] TerrainData terrainData)
		{
		}

		[NativeName("GetSplatDatabase().GetAlphamapResolution")]
		[RequiredByNativeCode]
		internal float GetAlphamapResolutionInternal()
		{
			return 0f;
		}

		[SpecialName]
		private void get_heightmapScale_Injected(out Vector3 ret)
		{
			ret = default(Vector3);
		}

		[SpecialName]
		private void get_size_Injected(out Vector3 ret)
		{
			ret = default(Vector3);
		}

		[SpecialName]
		private void get_bounds_Injected(out Bounds ret)
		{
			ret = default(Bounds);
		}
	}
}
