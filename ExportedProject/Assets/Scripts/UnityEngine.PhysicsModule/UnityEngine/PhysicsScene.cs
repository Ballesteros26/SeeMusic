using System;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
	[NativeHeader("Modules/Physics/Public/PhysicsSceneHandle.h")]
	public struct PhysicsScene : IEquatable<PhysicsScene>
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

		public bool Equals(PhysicsScene other)
		{
			return false;
		}

		public bool Raycast(Vector3 origin, Vector3 direction, [DefaultValue("Mathf.Infinity")] float maxDistance = float.PositiveInfinity, [DefaultValue("Physics.DefaultRaycastLayers")] int layerMask = -5, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
		{
			return false;
		}

		[NativeName("RaycastTest")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType.Dot)]
		private static bool Internal_RaycastTest(PhysicsScene physicsScene, Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return false;
		}

		public bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, [DefaultValue("Mathf.Infinity")] float maxDistance = float.PositiveInfinity, [DefaultValue("Physics.DefaultRaycastLayers")] int layerMask = -5, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
		{
			hitInfo = default(RaycastHit);
			return false;
		}

		[NativeName("Raycast")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType.Dot)]
		private static bool Internal_Raycast(PhysicsScene physicsScene, Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return false;
		}

		public int Raycast(Vector3 origin, Vector3 direction, RaycastHit[] raycastHits, [DefaultValue("Mathf.Infinity")] float maxDistance = float.PositiveInfinity, [DefaultValue("Physics.DefaultRaycastLayers")] int layerMask = -5, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
		{
			return 0;
		}

		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		[NativeName("RaycastNonAlloc")]
		private static int Internal_RaycastNonAlloc(PhysicsScene physicsScene, Ray ray, [Unmarshalled] RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return 0;
		}

		private static bool Internal_RaycastTest_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return false;
		}

		private static bool Internal_Raycast_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return false;
		}

		private static int Internal_RaycastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Ray ray, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return 0;
		}
	}
}
