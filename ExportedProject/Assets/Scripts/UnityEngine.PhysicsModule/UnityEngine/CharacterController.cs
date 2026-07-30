using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Modules/Physics/CharacterController.h")]
	public class CharacterController : Collider
	{
		public CollisionFlags Move(Vector3 motion)
		{
			return default(CollisionFlags);
		}

		private CollisionFlags Move_Injected(ref Vector3 motion)
		{
			return default(CollisionFlags);
		}
	}
}
