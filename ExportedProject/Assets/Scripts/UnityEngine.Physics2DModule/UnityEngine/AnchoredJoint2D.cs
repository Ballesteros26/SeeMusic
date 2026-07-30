using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Modules/Physics2D/AnchoredJoint2D.h")]
	public class AnchoredJoint2D : Joint2D
	{
		public Vector2 anchor => default(Vector2);

		public Vector2 connectedAnchor => default(Vector2);

		[SpecialName]
		private void get_anchor_Injected(out Vector2 ret)
		{
			ret = default(Vector2);
		}

		[SpecialName]
		private void get_connectedAnchor_Injected(out Vector2 ret)
		{
			ret = default(Vector2);
		}
	}
}
