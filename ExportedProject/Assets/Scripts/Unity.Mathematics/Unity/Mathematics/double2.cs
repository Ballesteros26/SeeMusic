using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
	[Serializable]
	[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
	[DefaultMember("Item")]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	public struct double2 : IEquatable<double2>, IFormattable
	{
		internal sealed class DebuggerProxy
		{
		}

		public double x;

		public double y;

		public static readonly double2 zero;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public double2(double x, double y)
		{
			this.x = 0.0;
			this.y = 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public double2(float2 v)
		{
			x = 0.0;
			y = 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static implicit operator double2(float2 v)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 operator -(double2 lhs, double2 rhs)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals(double2 rhs)
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
