using System;
using System.Reflection;
using UnityEngine;

namespace MakeIt.Core
{
	public static class GeneralUtility
	{
		public static void Swap<T>(ref T lhs, ref T rhs)
		{
		}

		public static string GetPrettyName(this Type type, bool includeNamespaces = false, bool useBuiltInNames = true)
		{
			return null;
		}

		public static T SetName<T>(this T obj, string name) where T : UnityEngine.Object
		{
			return null;
		}

		private static TAttribute GetAttribute<TAttribute>(object[] attributes) where TAttribute : Attribute
		{
			return null;
		}

		private static TAttribute[] GetAttributes<TAttribute>(object[] attributes) where TAttribute : Attribute
		{
			return null;
		}

		public static TAttribute GetAttribute<TAttribute>(Type type, bool inherit = true) where TAttribute : Attribute
		{
			return null;
		}

		public static TAttribute[] GetAttributes<TAttribute>(Type type, bool inherit = true) where TAttribute : Attribute
		{
			return null;
		}

		public static TAttribute GetAttribute<TAttribute>(FieldInfo field) where TAttribute : Attribute
		{
			return null;
		}

		public static TAttribute[] GetAttributes<TAttribute>(FieldInfo field) where TAttribute : Attribute
		{
			return null;
		}

		public static void DisableAndThrowOnUnassignedClassInstance<TField>(this MonoBehaviour component, TField field, string message) where TField : class
		{
		}

		public static void DisableAndThrowOnUnassignedReference<TField>(this MonoBehaviour component, TField field, string message) where TField : UnityEngine.Object
		{
		}

		public static void DisableAndThrowOnMissingComponent<TField>(this MonoBehaviour component, TField field, string message) where TField : Component
		{
		}
	}
}
