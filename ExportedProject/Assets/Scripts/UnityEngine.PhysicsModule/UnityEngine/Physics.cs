using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[StaticAccessor("GetPhysicsManager()", StaticAccessorType.Dot)]
	[NativeHeader("Modules/Physics/PhysicsManager.h")]
	public class Physics
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<PhysicsScene, NativeArray<ModifiableContactPair>> ContactModifyEvent;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<PhysicsScene, NativeArray<ModifiableContactPair>> ContactModifyEventCCD;

		[NativeProperty("DefaultPhysicsSceneHandle", true, TargetType.Function, true)]
		public static PhysicsScene defaultPhysicsScene => default(PhysicsScene);

		[RequiredByNativeCode]
		private static void OnSceneContactModify(PhysicsScene scene, IntPtr buffer, int count, bool isCCD)
		{
		}

		public static bool Raycast(Vector3 origin, Vector3 direction, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return false;
		}

		[ExcludeFromDocs]
		public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask)
		{
			return false;
		}

		[ExcludeFromDocs]
		public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance)
		{
			return false;
		}

		[ExcludeFromDocs]
		public static bool Raycast(Vector3 origin, Vector3 direction)
		{
			return false;
		}

		public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			hitInfo = default(RaycastHit);
			return false;
		}

		[RequiredByNativeCode]
		[ExcludeFromDocs]
		public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask)
		{
			hitInfo = default(RaycastHit);
			return false;
		}

		[ExcludeFromDocs]
		public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance)
		{
			hitInfo = default(RaycastHit);
			return false;
		}

		[ExcludeFromDocs]
		public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo)
		{
			hitInfo = default(RaycastHit);
			return false;
		}

		public static bool Raycast(Ray ray, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return false;
		}

		[ExcludeFromDocs]
		public static bool Raycast(Ray ray, float maxDistance, int layerMask)
		{
			return false;
		}

		[ExcludeFromDocs]
		public static bool Raycast(Ray ray, float maxDistance)
		{
			return false;
		}

		[ExcludeFromDocs]
		public static bool Raycast(Ray ray)
		{
			return false;
		}

		public static bool Raycast(Ray ray, out RaycastHit hitInfo, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			hitInfo = default(RaycastHit);
			return false;
		}

		[ExcludeFromDocs]
		public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask)
		{
			hitInfo = default(RaycastHit);
			return false;
		}

		[ExcludeFromDocs]
		public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance)
		{
			hitInfo = default(RaycastHit);
			return false;
		}

		[ExcludeFromDocs]
		public static bool Raycast(Ray ray, out RaycastHit hitInfo)
		{
			hitInfo = default(RaycastHit);
			return false;
		}

		[NativeName("RaycastAll")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType.Dot)]
		private static RaycastHit[] Internal_RaycastAll(PhysicsScene physicsScene, Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return null;
		}

		public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return null;
		}

		[ExcludeFromDocs]
		public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask)
		{
			return null;
		}

		[ExcludeFromDocs]
		public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance)
		{
			return null;
		}

		[ExcludeFromDocs]
		public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction)
		{
			return null;
		}

		public static RaycastHit[] RaycastAll(Ray ray, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return null;
		}

		[RequiredByNativeCode]
		[ExcludeFromDocs]
		public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask)
		{
			return null;
		}

		[ExcludeFromDocs]
		public static RaycastHit[] RaycastAll(Ray ray, float maxDistance)
		{
			return null;
		}

		[ExcludeFromDocs]
		public static RaycastHit[] RaycastAll(Ray ray)
		{
			return null;
		}

		public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return 0;
		}

		[RequiredByNativeCode]
		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask)
		{
			return 0;
		}

		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance)
		{
			return 0;
		}

		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Ray ray, RaycastHit[] results)
		{
			return 0;
		}

		public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return 0;
		}

		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask)
		{
			return 0;
		}

		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance)
		{
			return 0;
		}

		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results)
		{
			return 0;
		}

		[SpecialName]
		private static void get_defaultPhysicsScene_Injected(out PhysicsScene ret)
		{
			ret = default(PhysicsScene);
		}

		private static RaycastHit[] Internal_RaycastAll_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return null;
		}
	}
}
