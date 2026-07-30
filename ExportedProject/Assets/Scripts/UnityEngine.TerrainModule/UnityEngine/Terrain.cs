using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Runtime/Interfaces/ITerrainManager.h")]
	[UsedByNativeCode]
	[NativeHeader("Modules/Terrain/Public/Terrain.h")]
	[StaticAccessor("GetITerrainManager()", StaticAccessorType.Arrow)]
	[NativeHeader("TerrainScriptingClasses.h")]
	public sealed class Terrain : Behaviour
	{
		public TerrainData terrainData => null;

		public bool allowAutoConnect => false;

		public int groupingID => 0;

		[NativeProperty("ActiveTerrainsScriptingArray")]
		public static Terrain[] activeTerrains => null;

		public void SetNeighbors(Terrain left, Terrain top, Terrain right, Terrain bottom)
		{
		}
	}
}
