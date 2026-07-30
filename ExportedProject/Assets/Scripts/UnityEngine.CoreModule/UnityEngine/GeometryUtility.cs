using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[StaticAccessor("GeometryUtilityScripting", StaticAccessorType.DoubleColon)]
	[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
	public sealed class GeometryUtility
	{
		public static Plane[] CalculateFrustumPlanes(Camera camera)
		{
			return null;
		}

		public static void CalculateFrustumPlanes(Camera camera, Plane[] planes)
		{
		}

		public static void CalculateFrustumPlanes(Matrix4x4 worldToProjectionMatrix, Plane[] planes)
		{
		}

		public static Bounds CalculateBounds(Vector3[] positions, Matrix4x4 transform)
		{
			return default(Bounds);
		}

		public static bool TestPlanesAABB(Plane[] planes, Bounds bounds)
		{
			return false;
		}

		[NativeName("ExtractPlanes")]
		private static void Internal_ExtractPlanes([Out] Plane[] planes, Matrix4x4 worldToProjectionMatrix)
		{
		}

		[NativeName("CalculateBounds")]
		private static Bounds Internal_CalculateBounds(Vector3[] positions, Matrix4x4 transform)
		{
			return default(Bounds);
		}

		private static bool TestPlanesAABB_Injected(Plane[] planes, ref Bounds bounds)
		{
			return false;
		}

		private static void Internal_ExtractPlanes_Injected([Out] Plane[] planes, ref Matrix4x4 worldToProjectionMatrix)
		{
		}

		private static void Internal_CalculateBounds_Injected(Vector3[] positions, ref Matrix4x4 transform, out Bounds ret)
		{
			ret = default(Bounds);
		}
	}
}
