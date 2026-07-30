using UnityEngine.Bindings;

namespace UnityEngine.Tilemaps
{
	[RequireComponent(typeof(Transform))]
	[NativeHeader("Modules/Grid/Public/GridMarshalling.h")]
	[NativeHeader("Modules/Grid/Public/Grid.h")]
	[NativeHeader("Runtime/Graphics/SpriteFrame.h")]
	[NativeHeader("Modules/Tilemap/Public/TilemapTile.h")]
	[NativeType(Header = "Modules/Tilemap/Public/Tilemap.h")]
	[NativeHeader("Modules/Tilemap/Public/TilemapMarshalling.h")]
	public sealed class Tilemap : GridLayout
	{
		[NativeMethod(Name = "RefreshTileAsset")]
		public void RefreshTile(Vector3Int position)
		{
		}

		[FreeFunction(Name = "TilemapBindings::RefreshTileAssetsNative", HasExplicitThis = true)]
		internal unsafe void RefreshTilesNative(void* positions, int count)
		{
		}

		private void RefreshTile_Injected(ref Vector3Int position)
		{
		}
	}
}
