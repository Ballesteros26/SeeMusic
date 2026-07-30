using System.Runtime.CompilerServices;

namespace System.Numerics
{
	public struct Vector2 : IEquatable<Vector2>, IFormattable
	{
		public float X;

		public float Y;

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

		[System.Runtime.CompilerServices.Intrinsic]
		public Vector2(float x, float y)
		{
			X = 0f;
			Y = 0f;
		}

		[System.Runtime.CompilerServices.Intrinsic]
		public bool Equals(Vector2 other)
		{
			return false;
		}
	}
}
