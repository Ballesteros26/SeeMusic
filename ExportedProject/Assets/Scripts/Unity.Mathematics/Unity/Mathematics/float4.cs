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
	[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[DefaultMember("Item")]
	public struct float4 : IEquatable<float4>, IFormattable
	{
		internal sealed class DebuggerProxy
		{
		}

		public float x;

		public float y;

		public float z;

		public float w;

		public static readonly float4 zero;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyzx
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(float4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzxy
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(float4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzxz
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(float4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxyy
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(float4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxyz
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(float4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wwwx
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(float4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wwww
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
		public float3 yxw
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(float3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zwx
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(float3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 wzy
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(float3);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public float4(float x, float y, float z, float w)
		{
			this.x = 0f;
			this.y = 0f;
			this.z = 0f;
			this.w = 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public float4(float3 xyz, float w)
		{
			x = 0f;
			y = 0f;
			z = 0f;
			this.w = 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 operator *(float4 lhs, float4 rhs)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 operator *(float4 lhs, float rhs)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 operator +(float4 lhs, float4 rhs)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 operator -(float4 lhs, float4 rhs)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 operator /(float4 lhs, float rhs)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals(float4 rhs)
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

		public static implicit operator float4(Vector4 v)
		{
			return default(float4);
		}

		public static implicit operator Vector4(float4 v)
		{
			return default(Vector4);
		}
	}
}
