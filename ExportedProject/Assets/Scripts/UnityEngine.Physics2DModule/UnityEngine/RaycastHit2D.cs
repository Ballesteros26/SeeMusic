using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeClass("RaycastHit2D", "struct RaycastHit2D;")]
	[NativeHeader("Runtime/Interfaces/IPhysics2D.h")]
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	public struct RaycastHit2D
	{
		[NativeName("centroid")]
		private Vector2 m_Centroid;

		[NativeName("point")]
		private Vector2 m_Point;

		[NativeName("normal")]
		private Vector2 m_Normal;

		[NativeName("distance")]
		private float m_Distance;

		[NativeName("fraction")]
		private float m_Fraction;

		[NativeName("collider")]
		private int m_Collider;

		public Vector2 point => default(Vector2);

		public Vector2 normal => default(Vector2);

		public float distance => 0f;

		public Collider2D collider => null;
	}
}
