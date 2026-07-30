using System;
using System.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
	[NativeHeader("Modules/Physics2D/Public/PhysicsSceneHandle2D.h")]
	public struct PhysicsScene2D : IEquatable<PhysicsScene2D>
	{
		private int m_Handle;

		public override string ToString()
		{
			return null;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object other)
		{
			return false;
		}

		public bool Equals(PhysicsScene2D other)
		{
			return false;
		}

		public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, [DefaultValue("Physics2D.DefaultRaycastLayers")] int layerMask = -5)
		{
			return default(RaycastHit2D);
		}

		public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter)
		{
			return default(RaycastHit2D);
		}

		[NativeMethod("Raycast_Binding")]
		[StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
		private static RaycastHit2D Raycast_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter)
		{
			return default(RaycastHit2D);
		}

		public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results)
		{
			return 0;
		}

		[NativeMethod("RaycastArray_Binding")]
		[StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
		private static int RaycastArray_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, [Unmarshalled][NotNull("ArgumentNullException")] RaycastHit2D[] results)
		{
			return 0;
		}

		public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results)
		{
			return 0;
		}

		[NativeMethod("RaycastList_Binding")]
		[StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
		private static int RaycastList_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, [NotNull("ArgumentNullException")] List<RaycastHit2D> results)
		{
			return 0;
		}

		public int GetRayIntersection(Ray ray, float distance, RaycastHit2D[] results, [DefaultValue("Physics2D.DefaultRaycastLayers")] int layerMask = -5)
		{
			return 0;
		}

		[NativeMethod("GetRayIntersectionArray_Binding")]
		[StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
		private static int GetRayIntersectionArray_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask, [NotNull("ArgumentNullException")][Unmarshalled] RaycastHit2D[] results)
		{
			return 0;
		}

		private static void Raycast_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, out RaycastHit2D ret)
		{
			ret = default(RaycastHit2D);
		}

		private static int RaycastArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, RaycastHit2D[] results)
		{
			return 0;
		}

		private static int RaycastList_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, List<RaycastHit2D> results)
		{
			return 0;
		}

		private static int GetRayIntersectionArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask, RaycastHit2D[] results)
		{
			return 0;
		}
	}
}
