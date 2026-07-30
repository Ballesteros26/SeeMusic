using System;
using System.Collections.Generic;
using System.Reflection;

namespace Parse.Common.Internal
{
	public static class ReflectionHelpers
	{
		public static IEnumerable<PropertyInfo> GetProperties(Type type)
		{
			return null;
		}

		public static MethodInfo GetMethod(Type type, string name, Type[] parameters)
		{
			return null;
		}

		public static bool IsPrimitive(Type type)
		{
			return false;
		}

		public static IEnumerable<Type> GetInterfaces(Type type)
		{
			return null;
		}

		public static bool IsConstructedGenericType(Type type)
		{
			return false;
		}

		public static IEnumerable<ConstructorInfo> GetConstructors(Type type)
		{
			return null;
		}

		public static Type[] GetGenericTypeArguments(Type type)
		{
			return null;
		}

		public static PropertyInfo GetProperty(Type type, string name)
		{
			return null;
		}

		public static ConstructorInfo FindConstructor(this Type self, params Type[] parameterTypes)
		{
			return null;
		}

		public static bool IsNullable(Type t)
		{
			return false;
		}

		public static IEnumerable<T> GetCustomAttributes<T>(this Assembly assembly) where T : Attribute
		{
			return null;
		}
	}
}
