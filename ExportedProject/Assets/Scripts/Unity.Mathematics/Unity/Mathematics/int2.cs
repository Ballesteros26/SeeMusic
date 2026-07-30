using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
	[Serializable]
	[DefaultMember("Item")]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
	public struct int2 : IEquatable<int2>, IFormattable
	{
		internal sealed class DebuggerProxy
		{
		}

		public int x;

		public int y;

		public static readonly int2 zero;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int2(int x, int y)
		{
			this.x = 0;
			this.y = 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 operator *(int2 lhs, int rhs)
		{
			return default(int2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 operator *(int lhs, int2 rhs)
		{
			return default(int2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 operator +(int2 lhs, int rhs)
		{
			return default(int2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 operator -(int2 lhs, int rhs)
		{
			return default(int2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 operator /(int2 lhs, int rhs)
		{
			return default(int2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals(int2 rhs)
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
	}
}
