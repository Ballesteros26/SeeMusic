using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Unity.Mathematics
{
	[Serializable]
	[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
	public struct quaternion : IEquatable<quaternion>, IFormattable
	{
		public float4 value;

		public static readonly quaternion identity;

		public static implicit operator quaternion(Quaternion q)
		{
			return default(quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public quaternion(float x, float y, float z, float w)
		{
			value = default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public quaternion(float4 value)
		{
			this.value = default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion EulerXYZ(float3 xyz)
		{
			return default(quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion EulerXYZ(float x, float y, float z)
		{
			return default(quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals(quaternion x)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override bool Equals(object x)
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
	}
}
