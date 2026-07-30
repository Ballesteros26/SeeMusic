using System;
using System.Collections.Generic;

namespace Parse.Utilities
{
	public static class Conversion
	{
		private static readonly Dictionary<Tuple<Type, Type>, Type> interfaceLookupCache;

		public static T As<T>(object value) where T : class
		{
			return null;
		}

		public static T To<T>(object value)
		{
			return default(T);
		}

		internal static object ConvertTo<T>(object value)
		{
			return null;
		}

		private static Type GetInterfaceType(Type objType, Type genericInterfaceType)
		{
			return null;
		}
	}
}
