using UnityEngine.Bindings;

namespace UnityEngine
{
	[RequireComponent(typeof(Transform), typeof(Rigidbody2D))]
	[NativeHeader("Modules/Physics2D/Joint2D.h")]
	public class Joint2D : Behaviour
	{
		public Rigidbody2D connectedBody => null;
	}
}
