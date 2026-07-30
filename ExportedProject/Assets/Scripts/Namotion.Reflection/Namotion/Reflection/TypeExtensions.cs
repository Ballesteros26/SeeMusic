using System;

namespace Namotion.Reflection
{
	public static class TypeExtensions
	{
		public static bool IsAssignableToTypeName(this CachedType type, string typeName, TypeNameStyle typeNameStyle)
		{
			return false;
		}

		public static bool IsAssignableToTypeName(this Type type, string typeName, TypeNameStyle typeNameStyle)
		{
			return false;
		}

		public static bool InheritsFromTypeName(this Type type, string typeName, TypeNameStyle typeNameStyle)
		{
			return false;
		}
	}
}
