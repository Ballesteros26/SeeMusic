using UnityEngine;

namespace MakeIt.Random
{
	public static class RandomGeometry
	{
		private static ulong sinApprox9thOrderA;

		private static ulong sinApprox9thOrderB;

		private static ulong sinApprox9thOrderC;

		private static ulong sinApprox9thOrderD;

		private static ulong sinApprox9thOrderE;

		public static Vector2 UnitVector2(this IRandom random)
		{
			return default(Vector2);
		}

		public static void UnitVector2(this IRandom random, out Vector2 vec)
		{
			vec = default(Vector2);
		}

		public static Vector3 UnitVector3(this IRandom random)
		{
			return default(Vector3);
		}

		public static void UnitVector3(this IRandom random, out Vector3 vec)
		{
			vec = default(Vector3);
		}

		public static Vector4 UnitVector4(this IRandom random)
		{
			return default(Vector4);
		}

		public static void UnitVector4(this IRandom random, out Vector4 vec)
		{
			vec = default(Vector4);
		}

		public static Vector2 ScaledVector2(this IRandom random, float radius)
		{
			return default(Vector2);
		}

		public static Vector3 ScaledVector3(this IRandom random, float radius)
		{
			return default(Vector3);
		}

		public static Vector4 ScaledVector4(this IRandom random, float radius)
		{
			return default(Vector4);
		}

		public static Vector2 PointWithinCircle(this IRandom random)
		{
			return default(Vector2);
		}

		public static void PointWithinCircle(this IRandom random, out Vector2 vec)
		{
			vec = default(Vector2);
		}

		public static Vector2 PointWithinCircle(this IRandom random, float radius)
		{
			return default(Vector2);
		}

		public static Vector2 PointWithinCircularShell(this IRandom random, float innerRadius, float outerRadius)
		{
			return default(Vector2);
		}

		public static Vector3 PointWithinSphere(this IRandom random)
		{
			return default(Vector3);
		}

		public static void PointWithinSphere(this IRandom random, out Vector3 vec)
		{
			vec = default(Vector3);
		}

		public static Vector3 PointWithinSphere(this IRandom random, float radius)
		{
			return default(Vector3);
		}

		public static Vector3 PointWithinSphericalShell(this IRandom random, float innerRadius, float outerRadius)
		{
			return default(Vector3);
		}

		public static Vector2 PointWithinSquare(this IRandom random)
		{
			return default(Vector2);
		}

		public static Vector2 PointWithinSquare(this IRandom random, float sideLength)
		{
			return default(Vector2);
		}

		public static Vector2 PointWithinRectangle(this IRandom random, Vector2 size)
		{
			return default(Vector2);
		}

		public static Vector2 PointWithinParallelogram(this IRandom random, Vector2 axis0, Vector2 axis1)
		{
			return default(Vector2);
		}

		public static Vector2 PointWithinParallelogram(this IRandom random, Vector2 root, Vector2 side0, Vector2 side1)
		{
			return default(Vector2);
		}

		public static Vector3 PointWithinParallelogram(this IRandom random, Vector3 axis0, Vector3 axis1)
		{
			return default(Vector3);
		}

		public static Vector3 PointWithinParallelogram(this IRandom random, Vector3 root, Vector3 side0, Vector3 side1)
		{
			return default(Vector3);
		}

		public static Vector2 PointWithinTriangle(this IRandom random, Vector2 axis0, Vector2 axis1)
		{
			return default(Vector2);
		}

		public static Vector2 PointWithinTriangle(this IRandom random, Vector2 point0, Vector2 point1, Vector2 point2)
		{
			return default(Vector2);
		}

		public static Vector3 PointWithinTriangle(this IRandom random, Vector3 axis0, Vector3 axis1)
		{
			return default(Vector3);
		}

		public static Vector3 PointWithinTriangle(this IRandom random, Vector3 point0, Vector3 point1, Vector3 point2)
		{
			return default(Vector3);
		}

		public static Vector3 PointWithinCube(this IRandom random)
		{
			return default(Vector3);
		}

		public static Vector3 PointWithinCube(this IRandom random, float sideLength)
		{
			return default(Vector3);
		}

		public static Vector3 PointWithinBox(this IRandom random, Vector3 size)
		{
			return default(Vector3);
		}

		public static Vector3 PointWithinBox(this IRandom random, Bounds box)
		{
			return default(Vector3);
		}

		public static Vector3 PointWithinRhomboid(this IRandom random, Vector3 axis0, Vector3 axis1, Vector3 axis2)
		{
			return default(Vector3);
		}

		public static Quaternion Rotation(this IRandom random)
		{
			return default(Quaternion);
		}

		public static void Rotation(this IRandom random, out Quaternion quat)
		{
			quat = default(Quaternion);
		}
	}
}
