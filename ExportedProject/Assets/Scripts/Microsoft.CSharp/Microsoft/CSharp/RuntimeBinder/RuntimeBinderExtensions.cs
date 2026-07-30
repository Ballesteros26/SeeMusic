using System;
using System.Reflection;

namespace Microsoft.CSharp.RuntimeBinder
{
	internal static class RuntimeBinderExtensions
	{
		private static Func<MemberInfo, MemberInfo, bool> s_MemberEquivalence;

		public static bool IsNullableType(this Type type)
		{
			return false;
		}

		public static bool IsEquivalentTo(this MemberInfo mi1, MemberInfo mi2)
		{
			return false;
		}

		private static bool AreParametersEquivalent(this MethodBase method1, MethodBase method2)
		{
			return false;
		}

		private static bool IsEquivalentTo(this ParameterInfo pi1, ParameterInfo pi2, MethodBase method1, MethodBase method2)
		{
			return false;
		}

		private static bool IsGenericallyEqual(this Type t1, Type t2)
		{
			return false;
		}

		private static bool IsGenericallyEquivalentTo(this Type t1, Type t2, MemberInfo member1, MemberInfo member2)
		{
			return false;
		}

		private static bool IsTypeParameterEquivalentToTypeInst(this Type typeParam, Type typeInst, MemberInfo member)
		{
			return false;
		}

		public static string GetIndexerName(this Type type)
		{
			return null;
		}

		private static string GetTypeIndexerName(Type type)
		{
			return null;
		}
	}
}
