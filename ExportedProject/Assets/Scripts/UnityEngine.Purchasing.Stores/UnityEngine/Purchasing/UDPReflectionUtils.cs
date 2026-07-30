using System;
using System.Collections.Generic;
using System.Reflection;

namespace UnityEngine.Purchasing
{
	internal class UDPReflectionUtils
	{
		private static readonly Dictionary<Assembly, Type[]> s_assemblyTypeCache;

		private static readonly Dictionary<string, Type> s_typeCache;

		private static readonly string[] k_whiteListedAssemblies;

		internal static Type GetTypeByName(string typeName)
		{
			return null;
		}

		private static IEnumerable<Assembly> GetAllAssemblies()
		{
			return null;
		}

		private static IEnumerable<Type> GetTypes(Assembly assembly)
		{
			return null;
		}
	}
}
