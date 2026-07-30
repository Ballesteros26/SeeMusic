using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Reflection
{
	/// <summary>Discovers the attributes of a field and provides access to field metadata. </summary>
	[Serializable]
	public abstract class FieldInfo : MemberInfo
	{
		/// <summary>Gets a <see cref="T:System.Reflection.MemberTypes" /> value indicating that this member is a field.</summary>
		/// <returns>A <see cref="T:System.Reflection.MemberTypes" /> value indicating that this member is a field.</returns>
		public override MemberTypes MemberType => default(MemberTypes);

		/// <summary>Gets the attributes associated with this field.</summary>
		/// <returns>The FieldAttributes for this field.</returns>
		public abstract FieldAttributes Attributes { get; }

		/// <summary>Gets the type of this field object.</summary>
		/// <returns>The type of this field object.</returns>
		public abstract Type FieldType { get; }

		/// <summary>Gets a value indicating whether the field can only be set in the body of the constructor.</summary>
		/// <returns>true if the field has the InitOnly attribute set; otherwise, false.</returns>
		public bool IsInitOnly => false;

		/// <summary>Gets a value indicating whether the value is written at compile time and cannot be changed.</summary>
		/// <returns>true if the field has the Literal attribute set; otherwise, false.</returns>
		public bool IsLiteral => false;

		/// <summary>Gets a value indicating whether this field has the NotSerialized attribute.</summary>
		/// <returns>true if the field has the NotSerialized attribute set; otherwise, false.</returns>
		public bool IsNotSerialized => false;

		/// <summary>Gets a value indicating whether the field is static.</summary>
		/// <returns>true if this field is static; otherwise, false.</returns>
		public bool IsStatic => false;

		/// <summary>Gets a value indicating whether the potential visibility of this field is described by <see cref="F:System.Reflection.FieldAttributes.Assembly" />; that is, the field is visible at most to other types in the same assembly, and is not visible to derived types outside the assembly.</summary>
		/// <returns>true if the visibility of this field is exactly described by <see cref="F:System.Reflection.FieldAttributes.Assembly" />; otherwise, false.</returns>
		public bool IsAssembly => false;

		/// <summary>Gets a value indicating whether the visibility of this field is described by <see cref="F:System.Reflection.FieldAttributes.Family" />; that is, the field is visible only within its class and derived classes.</summary>
		/// <returns>true if access to this field is exactly described by <see cref="F:System.Reflection.FieldAttributes.Family" />; otherwise, false.</returns>
		public bool IsFamily => false;

		/// <summary>Gets a value indicating whether the potential visibility of this field is described by <see cref="F:System.Reflection.FieldAttributes.FamORAssem" />; that is, the field can be accessed by derived classes wherever they are, and by classes in the same assembly.</summary>
		/// <returns>true if access to this field is exactly described by <see cref="F:System.Reflection.FieldAttributes.FamORAssem" />; otherwise, false.</returns>
		public bool IsFamilyOrAssembly => false;

		/// <summary>Gets a value indicating whether the field is private.</summary>
		/// <returns>true if the field is private; otherwise; false.</returns>
		public bool IsPrivate => false;

		/// <summary>Gets a value indicating whether the field is public.</summary>
		/// <returns>true if this field is public; otherwise, false.</returns>
		public bool IsPublic => false;

		/// <summary>Gets a RuntimeFieldHandle, which is a handle to the internal metadata representation of a field.</summary>
		/// <returns>A handle to the internal metadata representation of a field.</returns>
		public abstract RuntimeFieldHandle FieldHandle { get; }

		/// <summary>Initializes a new instance of the FieldInfo class.</summary>
		protected FieldInfo()
		{
		}

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

		/// <summary>Indicates whether two <see cref="T:System.Reflection.FieldInfo" /> objects are equal.</summary>
		/// <returns>true if <paramref name="left" /> is equal to <paramref name="right" />; otherwise, false.</returns>
		/// <param name="left">The first object to compare.</param>
		/// <param name="right">The second object to compare.</param>
		public static bool operator ==(FieldInfo left, FieldInfo right)
		{
			return false;
		}

		/// <summary>Indicates whether two <see cref="T:System.Reflection.FieldInfo" /> objects are not equal.</summary>
		/// <returns>true if <paramref name="left" /> is not equal to <paramref name="right" />; otherwise, false.</returns>
		/// <param name="left">The first object to compare.</param>
		/// <param name="right">The second object to compare.</param>
		public static bool operator !=(FieldInfo left, FieldInfo right)
		{
			return false;
		}

		/// <summary>When overridden in a derived class, returns the value of a field supported by a given object.</summary>
		/// <returns>An object containing the value of the field reflected by this instance.</returns>
		/// <param name="obj">The object whose field value will be returned. </param>
		/// <exception cref="T:System.Reflection.TargetException">NoteIn the .NET for Windows Store apps or the Portable Class Library, catch <see cref="T:System.Exception" /> instead.The field is non-static and <paramref name="obj" /> is null. </exception>
		/// <exception cref="T:System.NotSupportedException">A field is marked literal, but the field does not have one of the accepted literal types. </exception>
		/// <exception cref="T:System.FieldAccessException">NoteIn the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.MemberAccessException" />, instead.The caller does not have permission to access this field. </exception>
		/// <exception cref="T:System.ArgumentException">The method is neither declared nor inherited by the class of <paramref name="obj" />. </exception>
		public abstract object GetValue(object obj);

		/// <summary>Sets the value of the field supported by the given object.</summary>
		/// <param name="obj">The object whose field value will be set. </param>
		/// <param name="value">The value to assign to the field. </param>
		/// <exception cref="T:System.FieldAccessException">NoteIn the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.MemberAccessException" />, instead.The caller does not have permission to access this field. </exception>
		/// <exception cref="T:System.Reflection.TargetException">NoteIn the .NET for Windows Store apps or the Portable Class Library, catch <see cref="T:System.Exception" /> instead.The <paramref name="obj" /> parameter is null and the field is an instance field. </exception>
		/// <exception cref="T:System.ArgumentException">The field does not exist on the object.-or- The <paramref name="value" /> parameter cannot be converted and stored in the field. </exception>
		[DebuggerStepThrough]
		[DebuggerHidden]
		public void SetValue(object obj, object value)
		{
		}

		/// <summary>When overridden in a derived class, sets the value of the field supported by the given object.</summary>
		/// <param name="obj">The object whose field value will be set. </param>
		/// <param name="value">The value to assign to the field. </param>
		/// <param name="invokeAttr">A field of Binder that specifies the type of binding that is desired (for example, Binder.CreateInstance or Binder.ExactBinding). </param>
		/// <param name="binder">A set of properties that enables the binding, coercion of argument types, and invocation of members through reflection. If <paramref name="binder" /> is null, then Binder.DefaultBinding is used. </param>
		/// <param name="culture">The software preferences of a particular culture. </param>
		/// <exception cref="T:System.FieldAccessException">The caller does not have permission to access this field. </exception>
		/// <exception cref="T:System.Reflection.TargetException">The <paramref name="obj" /> parameter is null and the field is an instance field. </exception>
		/// <exception cref="T:System.ArgumentException">The field does not exist on the object.-or- The <paramref name="value" /> parameter cannot be converted and stored in the field. </exception>
		public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture);

		/// <summary>Sets the value of the field supported by the given object.</summary>
		/// <param name="obj">A <see cref="T:System.TypedReference" /> structure that encapsulates a managed pointer to a location and a runtime representation of the type that can be stored at that location. </param>
		/// <param name="value">The value to assign to the field. </param>
		/// <exception cref="T:System.NotSupportedException">The caller requires the Common Language Specification (CLS) alternative, but called this method instead. </exception>
		[CLSCompliant(false)]
		public virtual void SetValueDirect(TypedReference obj, object value)
		{
		}

		/// <summary>Returns a literal value associated with the field by a compiler. </summary>
		/// <returns>An <see cref="T:System.Object" /> that contains the literal value associated with the field. If the literal value is a class type with an element value of zero, the return value is null.</returns>
		/// <exception cref="T:System.InvalidOperationException">The Constant table in unmanaged metadata does not contain a constant value for the current field.</exception>
		/// <exception cref="T:System.FormatException">The type of the value is not one of the types permitted by the Common Language Specification (CLS). See the ECMA Partition II specification Metadata Logical Format: Other Structures, Element Types used in Signatures. </exception>
		/// <exception cref="T:System.NotSupportedException">The constant value for the field is not set. </exception>
		public virtual object GetRawConstantValue()
		{
			return null;
		}

		private static FieldInfo internal_from_handle_type(IntPtr field_handle, IntPtr type_handle)
		{
			return null;
		}

		/// <summary>Gets a <see cref="T:System.Reflection.FieldInfo" /> for the field represented by the specified handle.</summary>
		/// <returns>A <see cref="T:System.Reflection.FieldInfo" /> object representing the field specified by <paramref name="handle" />.</returns>
		/// <param name="handle">A <see cref="T:System.RuntimeFieldHandle" /> structure that contains the handle to the internal metadata representation of a field. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="handle" /> is invalid.</exception>
		public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle)
		{
			return null;
		}

		/// <summary>Gets a <see cref="T:System.Reflection.FieldInfo" /> for the field represented by the specified handle, for the specified generic type.</summary>
		/// <returns>A <see cref="T:System.Reflection.FieldInfo" /> object representing the field specified by <paramref name="handle" />, in the generic type specified by <paramref name="declaringType" />.</returns>
		/// <param name="handle">A <see cref="T:System.RuntimeFieldHandle" /> structure that contains the handle to the internal metadata representation of a field.</param>
		/// <param name="declaringType">A <see cref="T:System.RuntimeTypeHandle" /> structure that contains the handle to the generic type that defines the field.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="handle" /> is invalid.-or-<paramref name="declaringType" /> is not compatible with <paramref name="handle" />. For example, <paramref name="declaringType" /> is the runtime type handle of the generic type definition, and <paramref name="handle" /> comes from a constructed type. See Remarks.</exception>
		[ComVisible(false)]
		public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle, RuntimeTypeHandle declaringType)
		{
			return null;
		}

		internal virtual int GetFieldOffset()
		{
			return 0;
		}

		private MarshalAsAttribute get_marshal_info()
		{
			return null;
		}

		internal object[] GetPseudoCustomAttributes()
		{
			return null;
		}

		internal CustomAttributeData[] GetPseudoCustomAttributesData()
		{
			return null;
		}
	}
}
