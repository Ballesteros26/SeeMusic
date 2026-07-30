using System;
using System.Runtime.CompilerServices;

namespace ForieroEngine.EnumUtilities
{
	public struct NameAttribute<Y> where Y : Attribute
	{
		public readonly string Name;

		public readonly Y Attribute;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal NameAttribute(string name, Y attribute)
		{
			Name = null;
			Attribute = null;
		}
	}
}
