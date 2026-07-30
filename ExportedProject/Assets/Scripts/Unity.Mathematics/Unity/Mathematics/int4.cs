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
	public struct int4 : IEquatable<int4>, IFormattable
	{
		internal sealed class DebuggerProxy
		{
		}

		public int x;

		public int y;

		public int z;

		public int w;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int4(int x, int y, int z, int w)
		{
			this.x = 0;
			this.y = 0;
			this.z = 0;
			this.w = 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals(int4 rhs)
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
