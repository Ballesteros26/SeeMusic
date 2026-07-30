using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Unity.Mathematics
{
	[Serializable]
	[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[DefaultMember("Item")]
	public struct float2 : IEquatable<float2>, IFormattable
	{
		internal sealed class DebuggerProxy
		{
		}

		public float x;

		public float y;

		public static readonly float2 zero;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public float2(float x, float y)
		{
			this.x = 0f;
			this.y = 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 operator *(float2 lhs, float2 rhs)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 operator *(float2 lhs, float rhs)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 operator +(float2 lhs, float2 rhs)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 operator -(float2 lhs, float2 rhs)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 operator /(float2 lhs, float rhs)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals(float2 rhs)
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

		public static implicit operator float2(Vector2 v)
		{
			return default(float2);
		}
	}
}
