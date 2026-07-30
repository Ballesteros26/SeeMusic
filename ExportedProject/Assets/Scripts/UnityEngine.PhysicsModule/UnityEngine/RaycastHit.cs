using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Modules/Physics/RaycastHit.h")]
	[NativeHeader("PhysicsScriptingClasses.h")]
	[NativeHeader("Runtime/Interfaces/IRaycast.h")]
	[UsedByNativeCode]
	public struct RaycastHit
	{
		[NativeName("point")]
		internal Vector3 m_Point;

		[NativeName("normal")]
		internal Vector3 m_Normal;

		[NativeName("faceID")]
		internal uint m_FaceID;

		[NativeName("distance")]
		internal float m_Distance;

		[NativeName("uv")]
		internal Vector2 m_UV;

		[NativeName("collider")]
		internal int m_Collider;

		public Collider collider => null;

		public Vector3 point => default(Vector3);

		public Vector3 normal => default(Vector3);

		public float distance => 0f;

		public Transform transform => null;

		public Rigidbody rigidbody => null;
	}
}
