using System.Diagnostics;
using System.Globalization;

namespace System.Reflection
{
	/// <summary>Discovers the attributes of a property and provides access to property metadata.</summary>
	[Serializable]
	public abstract class PropertyInfo : MemberInfo
	{
		/// <summary>Gets a <see cref="T:System.Reflection.MemberTypes" /> value indicating that this member is a property.</summary>
		/// <returns>A <see cref="T:System.Reflection.MemberTypes" /> value indicating that this member is a property.</returns>
		public override MemberTypes MemberType => default(MemberTypes);

		/// <summary>Gets the type of this property.</summary>
		/// <returns>The type of this property.</returns>
		public abstract Type PropertyType { get; }

		/// <summary>Gets a value indicating whether the property can be read.</summary>
		/// <returns>true if this property can be read; otherwise, false.</returns>
		public abstract bool CanRead { get; }

		/// <summary>Gets a value indicating whether the property can be written to.</summary>
		/// <returns>true if this property can be written to; otherwise, false.</returns>
		public abstract bool CanWrite { get; }

		/// <summary>Gets the get accessor for this property.</summary>
		/// <returns>The get accessor for this property.</returns>
		public virtual MethodInfo GetMethod => null;

		/// <summary>Gets the set accessor for this property.</summary>
		/// <returns>The set accessor for this property.</returns>
		public virtual MethodInfo SetMethod => null;

		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.PropertyInfo" /> class.</summary>
		protected PropertyInfo()
		{
		}

		/// <summary>When overridden in a derived class, returns an array of all the index parameters for the property.</summary>
		/// <returns>An array of type ParameterInfo containing the parameters for the indexes. If the property is not indexed, the array has 0 (zero) elements.</returns>
		public abstract ParameterInfo[] GetIndexParameters();

		/// <summary>Returns the public get accessor for this property.</summary>
		/// <returns>A MethodInfo object representing the public get accessor for this property, or null if the get accessor is non-public or does not exist.</returns>
		public MethodInfo GetGetMethod()
		{
			return null;
		}

		/// <summary>When overridden in a derived class, returns the public or non-public get accessor for this property.</summary>
		/// <returns>A MethodInfo object representing the get accessor for this property, if <paramref name="nonPublic" /> is true. Returns null if <paramref name="nonPublic" /> is false and the get accessor is non-public, or if <paramref name="nonPublic" /> is true but no get accessors exist.</returns>
		/// <param name="nonPublic">Indicates whether a non-public get accessor should be returned. true if a non-public accessor is to be returned; otherwise, false. </param>
		/// <exception cref="T:System.Security.SecurityException">The requested method is non-public and the caller does not have <see cref="T:System.Security.Permissions.ReflectionPermission" /> to reflect on this non-public method. </exception>
		public abstract MethodInfo GetGetMethod(bool nonPublic);

		/// <summary>Returns the public set accessor for this property.</summary>
		/// <returns>The MethodInfo object representing the Set method for this property if the set accessor is public, or null if the set accessor is not public.</returns>
		public MethodInfo GetSetMethod()
		{
			return null;
		}

		/// <summary>When overridden in a derived class, returns the set accessor for this property.</summary>
		/// <returns>Value Condition A <see cref="T:System.Reflection.MethodInfo" /> object representing the Set method for this property. The set accessor is public.-or- <paramref name="nonPublic" /> is true and the set accessor is non-public. null<paramref name="nonPublic" /> is true, but the property is read-only.-or- <paramref name="nonPublic" /> is false and the set accessor is non-public.-or- There is no set accessor. </returns>
		/// <param name="nonPublic">Indicates whether the accessor should be returned if it is non-public. true if a non-public accessor is to be returned; otherwise, false. </param>
		/// <exception cref="T:System.Security.SecurityException">The requested method is non-public and the caller does not have <see cref="T:System.Security.Permissions.ReflectionPermission" /> to reflect on this non-public method. </exception>
		public abstract MethodInfo GetSetMethod(bool nonPublic);

		/// <summary>Returns the property value of a specified object.</summary>
		/// <returns>The property value of the specified object.</returns>
		/// <param name="obj">The object whose property value will be returned.</param>
		[DebuggerHidden]
		[DebuggerStepThrough]
		public object GetValue(object obj)
		{
			return null;
		}

		/// <summary>Returns the property value of a specified object with optional index values for indexed properties.</summary>
		/// <returns>The property value of the specified object.</returns>
		/// <param name="obj">The object whose property value will be returned. </param>
		/// <param name="index">Optional index values for indexed properties. This value should be null for non-indexed properties. </param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="index" /> array does not contain the type of arguments needed.-or- The property's get accessor is not found. </exception>
		/// <exception cref="T:System.Reflection.TargetException">NoteIn the .NET for Windows Store apps or the Portable Class Library, catch <see cref="T:System.Exception" /> instead.The object does not match the target type, or a property is an instance property but <paramref name="obj" /> is null. </exception>
		/// <exception cref="T:System.Reflection.TargetParameterCountException">The number of parameters in <paramref name="index" /> does not match the number of parameters the indexed property takes. </exception>
		/// <exception cref="T:System.MethodAccessException">NoteIn the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.MemberAccessException" />, instead.There was an illegal attempt to access a private or protected method inside a class. </exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">An error occurred while retrieving the property value. For example, an index value specified for an indexed property is out of range. The <see cref="P:System.Exception.InnerException" /> property indicates the reason for the error.</exception>
		[DebuggerHidden]
		[DebuggerStepThrough]
		public virtual object GetValue(object obj, object[] index)
		{
			return null;
		}

		/// <summary>When overridden in a derived class, returns the property value of a specified object that has the specified binding, index, and culture-specific information.</summary>
		/// <returns>The property value of the specified object.</returns>
		/// <param name="obj">The object whose property value will be returned. </param>
		/// <param name="invokeAttr">A bitwise combination of the following enumeration members that specify the invocation attribute: InvokeMethod, CreateInstance, Static, GetField, SetField, GetProperty, and SetProperty. You must specify a suitable invocation attribute. For example, to invoke a static member, set the Static flag. </param>
		/// <param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of <see cref="T:System.Reflection.MemberInfo" /> objects through reflection. If <paramref name="binder" /> is null, the default binder is used. </param>
		/// <param name="index">Optional index values for indexed properties. This value should be null for non-indexed properties. </param>
		/// <param name="culture">The culture for which the resource is to be localized. If the resource is not localized for this culture, the <see cref="P:System.Globalization.CultureInfo.Parent" /> property will be called successively in search of a match. If this value is null, the culture-specific information is obtained from the <see cref="P:System.Globalization.CultureInfo.CurrentUICulture" /> property. </param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="index" /> array does not contain the type of arguments needed.-or- The property's get accessor is not found. </exception>
		/// <exception cref="T:System.Reflection.TargetException">The object does not match the target type, or a property is an instance property but <paramref name="obj" /> is null. </exception>
		/// <exception cref="T:System.Reflection.TargetParameterCountException">The number of parameters in <paramref name="index" /> does not match the number of parameters the indexed property takes. </exception>
		/// <exception cref="T:System.MethodAccessException">There was an illegal attempt to access a private or protected method inside a class. </exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">An error occurred while retrieving the property value. For example, an index value specified for an indexed property is out of range. The <see cref="P:System.Exception.InnerException" /> property indicates the reason for the error.</exception>
		public abstract object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);

		/// <summary>Sets the property value of a specified object.</summary>
		/// <param name="obj">The object whose property value will be set.</param>
		/// <param name="value">The new property value.</param>
		[DebuggerStepThrough]
		[DebuggerHidden]
		public void SetValue(object obj, object value)
		{
		}

		/// <summary>Sets the property value of a specified object with optional index values for index properties.</summary>
		/// <param name="obj">The object whose property value will be set. </param>
		/// <param name="value">The new property value. </param>
		/// <param name="index">Optional index values for indexed properties. This value should be null for non-indexed properties. </param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="index" /> array does not contain the type of arguments needed.-or- The property's set accessor is not found. </exception>
		/// <exception cref="T:System.Reflection.TargetException">NoteIn the .NET for Windows Store apps or the Portable Class Library, catch <see cref="T:System.Exception" /> instead.The object does not match the target type, or a property is an instance property but <paramref name="obj" /> is null. </exception>
		/// <exception cref="T:System.Reflection.TargetParameterCountException">The number of parameters in <paramref name="index" /> does not match the number of parameters the indexed property takes. </exception>
		/// <exception cref="T:System.MethodAccessException">NoteIn the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.MemberAccessException" />, instead.There was an illegal attempt to access a private or protected method inside a class. </exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">An error occurred while setting the property value. For example, an index value specified for an indexed property is out of range. The <see cref="P:System.Exception.InnerException" /> property indicates the reason for the error.</exception>
		[DebuggerHidden]
		[DebuggerStepThrough]
		public virtual void SetValue(object obj, object value, object[] index)
		{
		}

		/// <summary>When overridden in a derived class, sets the property value for a specified object that has the specified binding, index, and culture-specific information.</summary>
		/// <param name="obj">The object whose property value will be set. </param>
		/// <param name="value">The new property value. </param>
		/// <param name="invokeAttr">A bitwise combination of the following enumeration members that specify the invocation attribute: InvokeMethod, CreateInstance, Static, GetField, SetField, GetProperty, or SetProperty. You must specify a suitable invocation attribute. For example, to invoke a static member, set the Static flag. </param>
		/// <param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of <see cref="T:System.Reflection.MemberInfo" /> objects through reflection. If <paramref name="binder" /> is null, the default binder is used. </param>
		/// <param name="index">Optional index values for indexed properties. This value should be null for non-indexed properties. </param>
		/// <param name="culture">The culture for which the resource is to be localized. If the resource is not localized for this culture, the <see cref="P:System.Globalization.CultureInfo.Parent" /> property will be called successively in search of a match. If this value is null, the culture-specific information is obtained from the <see cref="P:System.Globalization.CultureInfo.CurrentUICulture" /> property. </param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="index" /> array does not contain the type of arguments needed.-or- The property's set accessor is not found. </exception>
		/// <exception cref="T:System.Reflection.TargetException">The object does not match the target type, or a property is an instance property but <paramref name="obj" /> is null. </exception>
		/// <exception cref="T:System.Reflection.TargetParameterCountException">The number of parameters in <paramref name="index" /> does not match the number of parameters the indexed property takes. </exception>
		/// <exception cref="T:System.MethodAccessException">There was an illegal attempt to access a private or protected method inside a class. </exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">An error occurred while setting the property value. For example, an index value specified for an indexed property is out of range. The <see cref="P:System.Exception.InnerException" /> property indicates the reason for the error.</exception>
		public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);

		/// <summary>Returns a value that indicates whether this instance is equal to a specified object.</summary>
		/// <returns>true if <paramref name="obj" /> equals the type and value of this instance; otherwise, false.</returns>
		/// <param name="obj">An object to compare with this instance, or null.</param>
		public override bool Equals(object obj)
		{
			return false;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		public override int GetHashCode()
		{
			return 0;
		}

		/// <summary>Indicates whether two <see cref="T:System.Reflection.PropertyInfo" /> objects are equal.</summary>
		/// <returns>true if <paramref name="left" /> is equal to <paramref name="right" />; otherwise, false.</returns>
		/// <param name="left">The first object to compare.</param>
		/// <param name="right">The second object to compare.</param>
		public static bool operator ==(PropertyInfo left, PropertyInfo right)
		{
			return false;
		}

		/// <summary>Indicates whether two <see cref="T:System.Reflection.PropertyInfo" /> objects are not equal.</summary>
		/// <returns>true if <paramref name="left" /> is not equal to <paramref name="right" />; otherwise, false.</returns>
		/// <param name="left">The first object to compare.</param>
		/// <param name="right">The second object to compare.</param>
		public static bool operator !=(PropertyInfo left, PropertyInfo right)
		{
			return false;
		}
	}
}
