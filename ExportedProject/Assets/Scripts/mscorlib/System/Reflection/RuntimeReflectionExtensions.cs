using System.Collections.Generic;

namespace System.Reflection
{
	/// <summary>Provides methods that retrieve information about types at run time.</summary>
	public static class RuntimeReflectionExtensions
	{
		/// <summary>Retrieves a collection that represents all the fields defined on a specified type.</summary>
		/// <returns>A collection of fields for the specified type.</returns>
		/// <param name="type">The type that contains the fields.</param>
		public static IEnumerable<FieldInfo> GetRuntimeFields(this Type type)
		{
			return null;
		}

		/// <summary>Retrieves a collection that represents all methods defined on a specified type.</summary>
		/// <returns>A collection of methods for the specified type.</returns>
		/// <param name="type">The type that contains the methods.</param>
		public static IEnumerable<MethodInfo> GetRuntimeMethods(this Type type)
		{
			return null;
		}

		/// <summary>Retrieves a collection that represents all the properties defined on a specified type.</summary>
		/// <returns>A collection of properties for the specified type.</returns>
		/// <param name="type">The type that contains the properties.</param>
		public static IEnumerable<PropertyInfo> GetRuntimeProperties(this Type type)
		{
			return null;
		}

		/// <summary>Retrieves an object that represents a specified field.</summary>
		/// <returns>An object that represents the specified field, or null if the field is not found.</returns>
		/// <param name="type">The type that contains the field.</param>
		/// <param name="name">The name of the field.</param>
		public static FieldInfo GetRuntimeField(this Type type, string name)
		{
			return null;
		}

		/// <summary>Retrieves an object that represents a specified method.</summary>
		/// <returns>An object that represents the specified method, or null if the method is not found.</returns>
		/// <param name="type">The type that contains the method.</param>
		/// <param name="name">The name of the method.</param>
		/// <param name="parameters">An array that contains the method's parameters.</param>
		public static MethodInfo GetRuntimeMethod(this Type type, string name, Type[] parameters)
		{
			return null;
		}

		/// <summary>Retrieves an object that represents a specified property.</summary>
		/// <returns>An object that represents the specified property, or null if the property is not found.</returns>
		/// <param name="type">The type that contains the property.</param>
		/// <param name="name">The name of the property.</param>
		public static PropertyInfo GetRuntimeProperty(this Type type, string name)
		{
			return null;
		}

		/// <summary>Retrieves an object that represents the specified method on the direct or indirect base class where the method was first declared.</summary>
		/// <returns>An object that represents the specified method's initial declaration on a base class.</returns>
		/// <param name="method">The method to retrieve information about.</param>
		public static MethodInfo GetRuntimeBaseDefinition(this MethodInfo method)
		{
			return null;
		}
	}
}
