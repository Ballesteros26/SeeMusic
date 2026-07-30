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
	public struct int3 : IEquatable<int3>, IFormattable
	{
		internal sealed class DebuggerProxy
		{
		}

		public int x;

		public int y;

		public int z;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int3(int x, int y, int z)
		{
			this.x = 0;
			this.y = 0;
			this.z = 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals(int3 rhs)
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
