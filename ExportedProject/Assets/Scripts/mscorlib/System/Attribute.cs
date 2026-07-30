using System.Reflection;

namespace System
{
	/// <summary>Represents the base class for custom attributes.</summary>
	/// <filterpriority>1</filterpriority>
	[Serializable]
	[AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = false)]
	public abstract class Attribute
	{
		/// <summary>When implemented in a derived class, gets a unique identifier for this <see cref="T:System.Attribute" />.</summary>
		/// <returns>An <see cref="T:System.Object" /> that is a unique identifier for the attribute.</returns>
		/// <filterpriority>2</filterpriority>
		public virtual object TypeId => null;

		private static Attribute[] InternalGetCustomAttributes(PropertyInfo element, Type type, bool inherit)
		{
			return null;
		}

		private static Attribute[] InternalGetCustomAttributes(EventInfo element, Type type, bool inherit)
		{
			return null;
		}

		private static Attribute[] InternalParamGetCustomAttributes(ParameterInfo parameter, Type attributeType, bool inherit)
		{
			return null;
		}

		private static bool InternalIsDefined(PropertyInfo element, Type attributeType, bool inherit)
		{
			return false;
		}

		private static bool InternalIsDefined(EventInfo element, Type attributeType, bool inherit)
		{
			return false;
		}

		/// <summary>Retrieves an array of the custom attributes applied to a member of a type. Parameters specify the member, and the type of the custom attribute to search for.</summary>
		/// <returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes of type <paramref name="type" /> applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns>
		/// <param name="element">An object derived from the <see cref="T:System.Reflection.MemberInfo" /> class that describes a constructor, event, field, method, or property member of a class. </param>
		/// <param name="type">The type, or a base type, of the custom attribute to search for.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="element" /> or <paramref name="type" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="type" /> is not derived from <see cref="T:System.Attribute" />. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="element" /> is not a constructor, method, property, event, type, or field. </exception>
		/// <exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded. </exception>
		/// <filterpriority>1</filterpriority>
		public static Attribute[] GetCustomAttributes(MemberInfo element, Type type)
		{
			return null;
		}

		/// <summary>Retrieves an array of the custom attributes applied to a member of a type. Parameters specify the member, the type of the custom attribute to search for, and whether to search ancestors of the member.</summary>
		/// <returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes of type <paramref name="type" /> applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns>
		/// <param name="element">An object derived from the <see cref="T:System.Reflection.MemberInfo" /> class that describes a constructor, event, field, method, or property member of a class. </param>
		/// <param name="type">The type, or a base type, of the custom attribute to search for.</param>
		/// <param name="inherit">If true, specifies to also search the ancestors of <paramref name="element" /> for custom attributes. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="element" /> or <paramref name="type" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="type" /> is not derived from <see cref="T:System.Attribute" />. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="element" /> is not a constructor, method, property, event, type, or field. </exception>
		/// <exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded. </exception>
		/// <filterpriority>1</filterpriority>
		public static Attribute[] GetCustomAttributes(MemberInfo element, Type type, bool inherit)
		{
			return null;
		}

		/// <summary>Retrieves an array of the custom attributes applied to a member of a type. A parameter specifies the member.</summary>
		/// <returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns>
		/// <param name="element">An object derived from the <see cref="T:System.Reflection.MemberInfo" /> class that describes a constructor, event, field, method, or property member of a class. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="element" /> is null. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="element" /> is not a constructor, method, property, event, type, or field. </exception>
		/// <exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded. </exception>
		/// <filterpriority>1</filterpriority>
		public static Attribute[] GetCustomAttributes(MemberInfo element)
		{
			return null;
		}

		/// <summary>Retrieves an array of the custom attributes applied to a member of a type. Parameters specify the member, the type of the custom attribute to search for, and whether to search ancestors of the member.</summary>
		/// <returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns>
		/// <param name="element">An object derived from the <see cref="T:System.Reflection.MemberInfo" /> class that describes a constructor, event, field, method, or property member of a class. </param>
		/// <param name="inherit">If true, specifies to also search the ancestors of <paramref name="element" /> for custom attributes. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="element" /> is null. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="element" /> is not a constructor, method, property, event, type, or field. </exception>
		/// <exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded. </exception>
		/// <filterpriority>1</filterpriority>
		public static Attribute[] GetCustomAttributes(MemberInfo element, bool inherit)
		{
			return null;
		}

		/// <summary>Determines whether any custom attributes are applied to a member of a type. Parameters specify the member, and the type of the custom attribute to search for.</summary>
		/// <returns>true if a custom attribute of type <paramref name="attributeType" /> is applied to <paramref name="element" />; otherwise, false.</returns>
		/// <param name="element">An object derived from the <see cref="T:System.Reflection.MemberInfo" /> class that describes a constructor, event, field, method, type, or property member of a class. </param>
		/// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="element" /> or <paramref name="attributeType" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="element" /> is not a constructor, method, property, event, type, or field. </exception>
		/// <filterpriority>1</filterpriority>
		public static bool IsDefined(MemberInfo element, Type attributeType)
		{
			return false;
		}

		/// <summary>Determines whether any custom attributes are applied to a member of a type. Parameters specify the member, the type of the custom attribute to search for, and whether to search ancestors of the member.</summary>
		/// <returns>true if a custom attribute of type <paramref name="attributeType" /> is applied to <paramref name="element" />; otherwise, false.</returns>
		/// <param name="element">An object derived from the <see cref="T:System.Reflection.MemberInfo" /> class that describes a constructor, event, field, method, type, or property member of a class. </param>
		/// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
		/// <param name="inherit">If true, specifies to also search the ancestors of <paramref name="element" /> for custom attributes. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="element" /> or <paramref name="attributeType" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="element" /> is not a constructor, method, property, event, type, or field. </exception>
		/// <filterpriority>1</filterpriority>
		public static bool IsDefined(MemberInfo element, Type attributeType, bool inherit)
		{
			return false;
		}

		/// <summary>Retrieves a custom attribute applied to a member of a type. Parameters specify the member, and the type of the custom attribute to search for.</summary>
		/// <returns>A reference to the single custom attribute of type <paramref name="attributeType" /> that is applied to <paramref name="element" />, or null if there is no such attribute.</returns>
		/// <param name="element">An object derived from the <see cref="T:System.Reflection.MemberInfo" /> class that describes a constructor, event, field, method, or property member of a class. </param>
		/// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="element" /> or <paramref name="attributeType" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="element" /> is not a constructor, method, property, event, type, or field. </exception>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one of the requested attributes was found. </exception>
		/// <exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded. </exception>
		/// <filterpriority>1</filterpriority>
		public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType)
		{
			return null;
		}

		/// <summary>Retrieves a custom attribute applied to a member of a type. Parameters specify the member, the type of the custom attribute to search for, and whether to search ancestors of the member.</summary>
		/// <returns>A reference to the single custom attribute of type <paramref name="attributeType" /> that is applied to <paramref name="element" />, or null if there is no such attribute.</returns>
		/// <param name="element">An object derived from the <see cref="T:System.Reflection.MemberInfo" /> class that describes a constructor, event, field, method, or property member of a class. </param>
		/// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
		/// <param name="inherit">If true, specifies to also search the ancestors of <paramref name="element" /> for custom attributes. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="element" /> or <paramref name="attributeType" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="element" /> is not a constructor, method, property, event, type, or field. </exception>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one of the requested attributes was found. </exception>
		/// <exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded. </exception>
		/// <filterpriority>1</filterpriority>
		public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType, bool inherit)
		{
			return null;
		}

		/// <summary>Retrieves an array of the custom attributes applied to a method parameter. Parameters specify the method parameter, the type of the custom attribute to search for, and whether to search ancestors of the method parameter.</summary>
		/// <returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes of type <paramref name="attributeType" /> applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns>
		/// <param name="element">An object derived from the <see cref="T:System.Reflection.ParameterInfo" /> class that describes a parameter of a member of a class. </param>
		/// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
		/// <param name="inherit">If true, specifies to also search the ancestors of <paramref name="element" /> for custom attributes. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="element" /> or <paramref name="attributeType" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />. </exception>
		/// <exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded. </exception>
		/// <filterpriority>1</filterpriority>
		public static Attribute[] GetCustomAttributes(ParameterInfo element, Type attributeType, bool inherit)
		{
			return null;
		}

		/// <summary>Retrieves an array of the custom attributes applied to a method parameter. Parameters specify the method parameter, and whether to search ancestors of the method parameter.</summary>
		/// <returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns>
		/// <param name="element">An object derived from the <see cref="T:System.Reflection.ParameterInfo" /> class that describes a parameter of a member of a class. </param>
		/// <param name="inherit">If true, specifies to also search the ancestors of <paramref name="element" /> for custom attributes. </param>
		/// <exception cref="T:System.ArgumentException">The <see cref="P:System.Reflection.ParameterInfo.Member" /> property of <paramref name="element" /> is null. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="element" /> is null. </exception>
		/// <exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded. </exception>
		/// <filterpriority>1</filterpriority>
		public static Attribute[] GetCustomAttributes(ParameterInfo element, bool inherit)
		{
			return null;
		}

		/// <summary>Retrieves a custom attribute applied to a method parameter. Parameters specify the method parameter, and the type of the custom attribute to search for.</summary>
		/// <returns>A reference to the single custom attribute of type <paramref name="attributeType" /> that is applied to <paramref name="element" />, or null if there is no such attribute.</returns>
		/// <param name="element">An object derived from the <see cref="T:System.Reflection.ParameterInfo" /> class that describes a parameter of a member of a class. </param>
		/// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="element" /> or <paramref name="attributeType" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />. </exception>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one of the requested attributes was found. </exception>
		/// <exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded. </exception>
		/// <filterpriority>1</filterpriority>
		public static Attribute GetCustomAttribute(ParameterInfo element, Type attributeType)
		{
			return null;
		}

		/// <summary>Retrieves a custom attribute applied to a method parameter. Parameters specify the method parameter, the type of the custom attribute to search for, and whether to search ancestors of the method parameter.</summary>
		/// <returns>A reference to the single custom attribute of type <paramref name="attributeType" /> that is applied to <paramref name="element" />, or null if there is no such attribute.</returns>
		/// <param name="element">An object derived from the <see cref="T:System.Reflection.ParameterInfo" /> class that describes a parameter of a member of a class. </param>
		/// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
		/// <param name="inherit">If true, specifies to also search the ancestors of <paramref name="element" /> for custom attributes. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="element" /> or <paramref name="attributeType" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />. </exception>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one of the requested attributes was found. </exception>
		/// <exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded. </exception>
		/// <filterpriority>1</filterpriority>
		public static Attribute GetCustomAttribute(ParameterInfo element, Type attributeType, bool inherit)
		{
			return null;
		}

		/// <summary>Retrieves an array of the custom attributes applied to a module. Parameters specify the module, and an ignored search option.</summary>
		/// <returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns>
		/// <param name="element">An object derived from the <see cref="T:System.Reflection.Module" /> class that describes a portable executable file. </param>
		/// <param name="inherit">This parameter is ignored, and does not affect the operation of this method. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="element" /> or <paramref name="attributeType" /> is null. </exception>
		/// <filterpriority>1</filterpriority>
		public static Attribute[] GetCustomAttributes(Module element, bool inherit)
		{
			return null;
		}

		/// <summary>Retrieves an array of the custom attributes applied to a module. Parameters specify the module, the type of the custom attribute to search for, and an ignored search option.</summary>
		/// <returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes of type <paramref name="attributeType" /> applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns>
		/// <param name="element">An object derived from the <see cref="T:System.Reflection.Module" /> class that describes a portable executable file. </param>
		/// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
		/// <param name="inherit">This parameter is ignored, and does not affect the operation of this method. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="element" /> or <paramref name="attributeType" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />. </exception>
		/// <filterpriority>1</filterpriority>
		public static Attribute[] GetCustomAttributes(Module element, Type attributeType, bool inherit)
		{
			return null;
		}

		/// <summary>Retrieves an array of the custom attributes applied to an assembly. Parameters specify the assembly, and the type of the custom attribute to search for.</summary>
		/// <returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes of type <paramref name="attributeType" /> applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns>
		/// <param name="element">An object derived from the <see cref="T:System.Reflection.Assembly" /> class that describes a reusable collection of modules. </param>
		/// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="element" /> or <paramref name="attributeType" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />. </exception>
		/// <filterpriority>1</filterpriority>
		public static Attribute[] GetCustomAttributes(Assembly element, Type attributeType)
		{
			return null;
		}

		/// <summary>Retrieves an array of the custom attributes applied to an assembly. Parameters specify the assembly, the type of the custom attribute to search for, and an ignored search option.</summary>
		/// <returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes of type <paramref name="attributeType" /> applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns>
		/// <param name="element">An object derived from the <see cref="T:System.Reflection.Assembly" /> class that describes a reusable collection of modules. </param>
		/// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
		/// <param name="inherit">This parameter is ignored, and does not affect the operation of this method. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="element" /> or <paramref name="attributeType" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />. </exception>
		/// <filterpriority>1</filterpriority>
		public static Attribute[] GetCustomAttributes(Assembly element, Type attributeType, bool inherit)
		{
			return null;
		}

		/// <summary>Retrieves an array of the custom attributes applied to an assembly. A parameter specifies the assembly.</summary>
		/// <returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns>
		/// <param name="element">An object derived from the <see cref="T:System.Reflection.Assembly" /> class that describes a reusable collection of modules. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="element" /> is null. </exception>
		/// <filterpriority>1</filterpriority>
		public static Attribute[] GetCustomAttributes(Assembly element)
		{
			return null;
		}

		/// <summary>Retrieves an array of the custom attributes applied to an assembly. Parameters specify the assembly, and an ignored search option.</summary>
		/// <returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns>
		/// <param name="element">An object derived from the <see cref="T:System.Reflection.Assembly" /> class that describes a reusable collection of modules. </param>
		/// <param name="inherit">This parameter is ignored, and does not affect the operation of this method. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="element" /> or <paramref name="attributeType" /> is null. </exception>
		/// <filterpriority>1</filterpriority>
		public static Attribute[] GetCustomAttributes(Assembly element, bool inherit)
		{
			return null;
		}

		/// <summary>Retrieves a custom attribute applied to a specified assembly. Parameters specify the assembly and the type of the custom attribute to search for.</summary>
		/// <returns>A reference to the single custom attribute of type <paramref name="attributeType" /> that is applied to <paramref name="element" />, or null if there is no such attribute.</returns>
		/// <param name="element">An object derived from the <see cref="T:System.Reflection.Assembly" /> class that describes a reusable collection of modules. </param>
		/// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="element" /> or <paramref name="attributeType" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />. </exception>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one of the requested attributes was found. </exception>
		/// <filterpriority>1</filterpriority>
		public static Attribute GetCustomAttribute(Assembly element, Type attributeType)
		{
			return null;
		}

		/// <summary>Retrieves a custom attribute applied to an assembly. Parameters specify the assembly, the type of the custom attribute to search for, and an ignored search option.</summary>
		/// <returns>A reference to the single custom attribute of type <paramref name="attributeType" /> that is applied to <paramref name="element" />, or null if there is no such attribute.</returns>
		/// <param name="element">An object derived from the <see cref="T:System.Reflection.Assembly" /> class that describes a reusable collection of modules. </param>
		/// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
		/// <param name="inherit">This parameter is ignored, and does not affect the operation of this method. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="element" /> or <paramref name="attributeType" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />. </exception>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one of the requested attributes was found. </exception>
		/// <filterpriority>1</filterpriority>
		public static Attribute GetCustomAttribute(Assembly element, Type attributeType, bool inherit)
		{
			return null;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Attribute" /> class.</summary>
		protected Attribute()
		{
		}

		/// <summary>Returns a value that indicates whether this instance is equal to a specified object.</summary>
		/// <returns>true if <paramref name="obj" /> equals the type and value of this instance; otherwise, false.</returns>
		/// <param name="obj">An <see cref="T:System.Object" /> to compare with this instance or null. </param>
		/// <filterpriority>2</filterpriority>
		public override bool Equals(object obj)
		{
			return false;
		}

		private static bool AreFieldValuesEqual(object thisValue, object thatValue)
		{
			return false;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		/// <filterpriority>2</filterpriority>
		public override int GetHashCode()
		{
			return 0;
		}

		/// <summary>When overridden in a derived class, returns a value that indicates whether this instance equals a specified object.</summary>
		/// <returns>true if this instance equals <paramref name="obj" />; otherwise, false.</returns>
		/// <param name="obj">An <see cref="T:System.Object" /> to compare with this instance of <see cref="T:System.Attribute" />. </param>
		/// <filterpriority>2</filterpriority>
		public virtual bool Match(object obj)
		{
			return false;
		}

		/// <summary>When overridden in a derived class, indicates whether the value of this instance is the default value for the derived class.</summary>
		/// <returns>true if this instance is the default attribute for the class; otherwise, false.</returns>
		/// <filterpriority>2</filterpriority>
		public virtual bool IsDefaultAttribute()
		{
			return false;
		}
	}
}
