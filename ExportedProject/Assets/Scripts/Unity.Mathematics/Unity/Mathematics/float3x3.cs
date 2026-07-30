using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
	[Serializable]
	[DefaultMember("Item")]
	[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
	public struct float3x3 : IEquatable<float3x3>, IFormattable
	{
		public float3 c0;

		public float3 c1;

		public float3 c2;

		public static readonly float3x3 identity;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public float3x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22)
		{
			c0 = default(float3);
			c1 = default(float3);
			c2 = default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals(float3x3 rhs)
		{
			return false;
		}

		public override bool Equals(object o)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override string ToString()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		public float3x3(quaternion q)
		{
			c0 = default(float3);
			c1 = default(float3);
			c2 = default(float3);
		}
	}
}
