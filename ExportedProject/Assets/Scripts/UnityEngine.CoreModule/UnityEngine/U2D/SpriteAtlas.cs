using UnityEngine.Bindings;

namespace UnityEngine.U2D
{
	[NativeType(Header = "Runtime/2D/SpriteAtlas/SpriteAtlas.h")]
	[NativeHeader("Runtime/Graphics/SpriteFrame.h")]
	public class SpriteAtlas : Object
	{
		public bool CanBindTo([NotNull("ArgumentNullException")] Sprite sprite)
		{
			return false;
		}
	}
}
