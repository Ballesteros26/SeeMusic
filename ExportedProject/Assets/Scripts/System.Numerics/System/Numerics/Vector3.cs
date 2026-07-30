using System.Runtime.CompilerServices;

namespace System.Numerics
{
	public struct Vector3 : IEquatable<Vector3>, IFormattable
	{
		public float X;

		public float Y;

		public float Z;

		public static Vector3 One => default(Vector3);

		public override int GetHashCode()
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override bool Equals(object obj)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}

		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Multiply(Vector3 left, float right)
		{
			return default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Divide(Vector3 left, Vector3 right)
		{
			return default(Vector3);
		}

		[System.Runtime.CompilerServices.Intrinsic]
		public Vector3(float value)
		{
			X = 0f;
			Y = 0f;
			Z = 0f;
		}

		[System.Runtime.CompilerServices.Intrinsic]
		public Vector3(float x, float y, float z)
		{
			X = 0f;
			Y = 0f;
			Z = 0f;
		}

		[System.Runtime.CompilerServices.Intrinsic]
		public bool Equals(Vector3 other)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[System.Runtime.CompilerServices.Intrinsic]
		public static Vector3 operator +(Vector3 left, Vector3 right)
		{
			return default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[System.Runtime.CompilerServices.Intrinsic]
		public static Vector3 operator -(Vector3 left, Vector3 right)
		{
			return default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[System.Runtime.CompilerServices.Intrinsic]
		public static Vector3 operator *(Vector3 left, Vector3 right)
		{
			return default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[System.Runtime.CompilerServices.Intrinsic]
		public static Vector3 operator *(Vector3 left, float right)
		{
			return default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[System.Runtime.CompilerServices.Intrinsic]
		public static Vector3 operator /(Vector3 left, Vector3 right)
		{
			return default(Vector3);
		}
	}
}
