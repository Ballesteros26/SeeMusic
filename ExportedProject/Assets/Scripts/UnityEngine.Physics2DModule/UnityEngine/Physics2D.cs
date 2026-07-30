using System.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[StaticAccessor("GetPhysicsManager2D()", StaticAccessorType.Arrow)]
	[NativeHeader("Physics2DScriptingClasses.h")]
	[NativeHeader("Modules/Physics2D/PhysicsManager2D.h")]
	[NativeHeader("Physics2DScriptingClasses.h")]
	public class Physics2D
	{
		private static List<Rigidbody2D> m_LastDisabledRigidbody2D;

		public static PhysicsScene2D defaultPhysicsScene => default(PhysicsScene2D);

		[StaticAccessor("GetPhysics2DSettings()")]
		public static bool queriesHitTriggers => false;

		[ExcludeFromDocs]
		public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction)
		{
			return default(RaycastHit2D);
		}

		[ExcludeFromDocs]
		public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance)
		{
			return default(RaycastHit2D);
		}

		[RequiredByNativeCode]
		[ExcludeFromDocs]
		public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask)
		{
			return default(RaycastHit2D);
		}

		[ExcludeFromDocs]
		public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth)
		{
			return default(RaycastHit2D);
		}

		public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			return default(RaycastHit2D);
		}

		[ExcludeFromDocs]
		public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results)
		{
			return 0;
		}

		public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, [DefaultValue("Mathf.Infinity")] float distance)
		{
			return 0;
		}

		public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, [DefaultValue("Mathf.Infinity")] float distance = float.PositiveInfinity)
		{
			return 0;
		}

		[ExcludeFromDocs]
		public static RaycastHit2D[] RaycastAll(Vector2 origin, Vector2 direction, float distance, int layerMask)
		{
			return null;
		}

		[NativeMethod("RaycastAll_Binding")]
		[StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
		private static RaycastHit2D[] RaycastAll_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter)
		{
			return null;
		}

		[ExcludeFromDocs]
		public static RaycastHit2D[] GetRayIntersectionAll(Ray ray)
		{
			return null;
		}

		[ExcludeFromDocs]
		public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance)
		{
			return null;
		}

		[RequiredByNativeCode]
		public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask)
		{
			return null;
		}

		[StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
		[NativeMethod("GetRayIntersectionAll_Binding")]
		private static RaycastHit2D[] GetRayIntersectionAll_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask)
		{
			return null;
		}

		[ExcludeFromDocs]
		public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results)
		{
			return 0;
		}

		[ExcludeFromDocs]
		public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance)
		{
			return 0;
		}

		[RequiredByNativeCode]
		public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask)
		{
			return 0;
		}

		private static RaycastHit2D[] RaycastAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter)
		{
			return null;
		}

		private static RaycastHit2D[] GetRayIntersectionAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask)
		{
			return null;
		}
	}
}
