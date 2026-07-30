using System.Runtime.CompilerServices;

namespace System.Numerics
{
	public struct Vector4 : IEquatable<Vector4>, IFormattable
	{
		public float X;

		public float Y;

		public float Z;

		public float W;

		public static Vector4 One => default(Vector4);

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
		public static Vector4 Divide(Vector4 left, Vector4 right)
		{
			return default(Vector4);
		}

		[System.Runtime.CompilerServices.Intrinsic]
		public Vector4(float value)
		{
			X = 0f;
			Y = 0f;
			Z = 0f;
			W = 0f;
		}

		[System.Runtime.CompilerServices.Intrinsic]
		public Vector4(float x, float y, float z, float w)
		{
			X = 0f;
			Y = 0f;
			Z = 0f;
			W = 0f;
		}

		[System.Runtime.CompilerServices.Intrinsic]
		public bool Equals(Vector4 other)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[System.Runtime.CompilerServices.Intrinsic]
		public static float Dot(Vector4 vector1, Vector4 vector2)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[System.Runtime.CompilerServices.Intrinsic]
		public static Vector4 SquareRoot(Vector4 value)
		{
			return default(Vector4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[System.Runtime.CompilerServices.Intrinsic]
		public static Vector4 operator +(Vector4 left, Vector4 right)
		{
			return default(Vector4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[System.Runtime.CompilerServices.Intrinsic]
		public static Vector4 operator -(Vector4 left, Vector4 right)
		{
			return default(Vector4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[System.Runtime.CompilerServices.Intrinsic]
		public static Vector4 operator *(Vector4 left, Vector4 right)
		{
			return default(Vector4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[System.Runtime.CompilerServices.Intrinsic]
		public static Vector4 operator *(Vector4 left, float right)
		{
			return default(Vector4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[System.Runtime.CompilerServices.Intrinsic]
		public static Vector4 operator *(float left, Vector4 right)
		{
			return default(Vector4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[System.Runtime.CompilerServices.Intrinsic]
		public static Vector4 operator /(Vector4 left, Vector4 right)
		{
			return default(Vector4);
		}
	}
}
