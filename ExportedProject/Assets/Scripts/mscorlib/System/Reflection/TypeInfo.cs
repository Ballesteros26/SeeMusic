using System.Collections.Generic;

namespace System.Reflection
{
	/// <summary>Represents type declarations for class types, interface types, array types, value types, enumeration types, type parameters, generic type definitions, and open or closed constructed generic types. </summary>
	public abstract class TypeInfo : Type, IReflectableType
	{
		private const BindingFlags DeclaredOnlyLookup = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;

		/// <summary>Gets a collection of the constructors declared by the current type.</summary>
		/// <returns>A collection of the constructors declared by the current type.</returns>
		public virtual IEnumerable<ConstructorInfo> DeclaredConstructors => null;

		/// <summary>Gets a collection of the fields defined by the current type.</summary>
		/// <returns>A collection of the fields defined by the current type.</returns>
		public virtual IEnumerable<FieldInfo> DeclaredFields => null;

		/// <summary>Gets a collection of the members defined by the current type.</summary>
		/// <returns>A collection of the members defined by the current type.</returns>
		public virtual IEnumerable<MemberInfo> DeclaredMembers => null;

		/// <summary>Gets a collection of the properties defined by the current type. </summary>
		/// <returns>A collection of the properties defined by the current type.</returns>
		public virtual IEnumerable<PropertyInfo> DeclaredProperties => null;

		/// <summary>Gets a collection of the interfaces implemented by the current type.</summary>
		/// <returns>A collection of the interfaces implemented by the current type.</returns>
		public virtual IEnumerable<Type> ImplementedInterfaces => null;

		/// <summary>Returns a representation of the current type as a <see cref="T:System.Reflection.TypeInfo" /> object.</summary>
		/// <returns>A reference to the current type.</returns>
		TypeInfo IReflectableType.GetTypeInfo()
		{
			return null;
		}

		/// <summary>Returns the current type as a <see cref="T:System.Type" /> object.</summary>
		/// <returns>The current type.</returns>
		public virtual Type AsType()
		{
			return null;
		}

		/// <summary>Returns a value that indicates whether the specified type can be assigned to the current type.</summary>
		/// <returns>true if the specified type can be assigned to this type; otherwise, false.</returns>
		/// <param name="typeInfo">The type to check.</param>
		public virtual bool IsAssignableFrom(TypeInfo typeInfo)
		{
			return false;
		}
	}
}
