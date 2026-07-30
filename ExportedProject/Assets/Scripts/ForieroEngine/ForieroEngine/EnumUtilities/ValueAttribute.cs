using System;
using System.Runtime.CompilerServices;

namespace ForieroEngine.EnumUtilities
{
	public struct ValueAttribute<T, Y> where T : struct, IComparable, IFormattable, IConvertible where Y : Attribute
	{
		public readonly T Value;

		public readonly Y Attribute;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal ValueAttribute(T value, Y attribute)
		{
			Value = default(T);
			Attribute = null;
		}
	}
}
