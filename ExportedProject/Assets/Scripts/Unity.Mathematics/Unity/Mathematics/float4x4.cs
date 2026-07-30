using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Unity.Mathematics
{
	[Serializable]
	[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
	[DefaultMember("Item")]
	public struct float4x4 : IEquatable<float4x4>, IFormattable
	{
		public float4 c0;

		public float4 c1;

		public float4 c2;

		public float4 c3;

		public static readonly float4x4 identity;

		public static readonly float4x4 zero;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public float4x4(float4 c0, float4 c1, float4 c2, float4 c3)
		{
			this.c0 = default(float4);
			this.c1 = default(float4);
			this.c2 = default(float4);
			this.c3 = default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public float4x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23, float m30, float m31, float m32, float m33)
		{
			c0 = default(float4);
			c1 = default(float4);
			c2 = default(float4);
			c3 = default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals(float4x4 rhs)
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

		public static implicit operator float4x4(Matrix4x4 m)
		{
			return default(float4x4);
		}

		public static implicit operator Matrix4x4(float4x4 m)
		{
			return default(Matrix4x4);
		}

		public float4x4(quaternion rotation, float3 translation)
		{
			c0 = default(float4);
			c1 = default(float4);
			c2 = default(float4);
			c3 = default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x4 TRS(float3 translation, quaternion rotation, float3 scale)
		{
			return default(float4x4);
		}
	}
}
