using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[RequireComponent(typeof(Transform))]
	[RequiredByNativeCode(Optional = true)]
	[NativeHeader("Modules/Physics2D/Public/Collider2D.h")]
	public class Collider2D : Behaviour
	{
		public bool isTrigger => false;

		public Vector2 offset => default(Vector2);

		public Bounds bounds => default(Bounds);

		public bool OverlapPoint(Vector2 point)
		{
			return false;
		}

		[SpecialName]
		private void get_offset_Injected(out Vector2 ret)
		{
			ret = default(Vector2);
		}

		[SpecialName]
		private void get_bounds_Injected(out Bounds ret)
		{
			ret = default(Bounds);
		}

		private bool OverlapPoint_Injected(ref Vector2 point)
		{
			return false;
		}
	}
}
