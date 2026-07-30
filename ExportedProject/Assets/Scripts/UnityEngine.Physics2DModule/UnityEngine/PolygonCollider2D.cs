using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Modules/Physics2D/Public/PolygonCollider2D.h")]
	public sealed class PolygonCollider2D : Collider2D
	{
		public Vector2[] points
		{
			[NativeMethod("GetPoints_Binding")]
			get
			{
				return null;
			}
		}
	}
}
