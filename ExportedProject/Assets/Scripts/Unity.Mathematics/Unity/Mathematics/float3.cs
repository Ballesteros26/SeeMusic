using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Unity.Mathematics
{
	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
	[DefaultMember("Item")]
	public struct float3 : IEquatable<float3>, IFormattable
	{
		internal sealed class DebuggerProxy
		{
		}

		public float x;

		public float y;

		public float z;

		public static readonly float3 zero;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxxy
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(float4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzyz
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(float4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xyz
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(float3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yzx
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(float3);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public float3(float x, float y, float z)
		{
			this.x = 0f;
			this.y = 0f;
			this.z = 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public float3(float v)
		{
			x = 0f;
			y = 0f;
			z = 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 operator *(float3 lhs, float3 rhs)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 operator *(float3 lhs, float rhs)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 operator *(float lhs, float3 rhs)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 operator +(float3 lhs, float3 rhs)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 operator -(float3 lhs, float3 rhs)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals(float3 rhs)
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

		public static implicit operator Vector3(float3 v)
		{
			return default(Vector3);
		}

		public static implicit operator float3(Vector3 v)
		{
			return default(float3);
		}
	}
}
