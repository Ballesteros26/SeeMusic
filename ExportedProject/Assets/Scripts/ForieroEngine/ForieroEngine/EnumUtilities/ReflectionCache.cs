using System;
using System.Reflection;

namespace ForieroEngine.EnumUtilities
{
	internal static class ReflectionCache<T> where T : struct, IComparable, IFormattable, IConvertible
	{
		internal static readonly FieldInfo[] Fields;

		internal static readonly T[] FieldValues;

		static ReflectionCache()
		{
		}
	}
}
