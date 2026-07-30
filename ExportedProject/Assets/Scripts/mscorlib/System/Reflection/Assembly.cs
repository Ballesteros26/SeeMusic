using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Policy;
using System.Threading;

namespace System.Reflection
{
	/// <summary>Represents an assembly, which is a reusable, versionable, and self-describing building block of a common language runtime application.</summary>
	[Serializable]
	[StructLayout((LayoutKind)0)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	[ComDefaultInterface(typeof(_Assembly))]
	public class Assembly : ICustomAttributeProvider, ISerializable, _Assembly
	{
		internal class ResolveEventHolder
		{
		}

		/// <summary>Gets the location of the assembly as specified originally, for example, in an <see cref="T:System.Reflection.AssemblyName" /> object.</summary>
		/// <returns>The location of the assembly as specified originally.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public virtual string CodeBase => null;

		/// <summary>Gets the display name of the assembly.</summary>
		/// <returns>The display name of the assembly.</returns>
		public virtual string FullName => null;

		internal virtual IntPtr MonoAssembly => (IntPtr)0;

		/// <summary>Gets the full path or UNC location of the loaded file that contains the manifest.</summary>
		/// <returns>The location of the loaded file that contains the manifest. If the loaded file was shadow-copied, the location is that of the file after being shadow-copied. If the assembly is loaded from a byte array, such as when using the <see cref="M:System.Reflection.Assembly.Load(System.Byte[])" /> method overload, the value returned is an empty string ("").</returns>
		/// <exception cref="T:System.NotSupportedException">The current assembly is a dynamic assembly, represented by an <see cref="T:System.Reflection.Emit.AssemblyBuilder" /> object. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public virtual string Location => null;

		/// <summary>Gets a value that indicates whether the current assembly is loaded with full trust.</summary>
		/// <returns>true if the current assembly is loaded with full trust; otherwise, false.</returns>
		[MonoTODO]
		public bool IsFullyTrusted => false;

		/// <summary>Gets serialization information with all of the data needed to reinstantiate this assembly.</summary>
		/// <param name="info">The object to be populated with serialization information. </param>
		/// <param name="context">The destination context of the serialization. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="info" /> is null. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="SerializationFormatter" />
		/// </PermissionSet>
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		/// <summary>Indicates whether or not a specified attribute has been applied to the assembly.</summary>
		/// <returns>true if the attribute has been applied to the assembly; otherwise, false.</returns>
		/// <param name="attributeType">The type of the attribute to be checked for this assembly. </param>
		/// <param name="inherit">This argument is ignored for objects of this type. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="attributeType" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="attributeType" /> uses an invalid type.</exception>
		public virtual bool IsDefined(Type attributeType, bool inherit)
		{
			return false;
		}

		/// <summary>Gets all the custom attributes for this assembly.</summary>
		/// <returns>An array that contains the custom attributes for this assembly.</returns>
		/// <param name="inherit">This argument is ignored for objects of type <see cref="T:System.Reflection.Assembly" />. </param>
		public virtual object[] GetCustomAttributes(bool inherit)
		{
			return null;
		}

		/// <summary>Gets the custom attributes for this assembly as specified by type.</summary>
		/// <returns>An array that contains the custom attributes for this assembly as specified by <paramref name="attributeType" />.</returns>
		/// <param name="attributeType">The type for which the custom attributes are to be returned. </param>
		/// <param name="inherit">This argument is ignored for objects of type <see cref="T:System.Reflection.Assembly" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="attributeType" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="attributeType" /> is not a runtime type. </exception>
		public virtual object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			return null;
		}

		internal virtual Type[] GetTypes(bool exportedOnly)
		{
			return null;
		}

		/// <summary>Gets the types defined in this assembly.</summary>
		/// <returns>An array that contains all the types that are defined in this assembly.</returns>
		/// <exception cref="T:System.Reflection.ReflectionTypeLoadException">The assembly contains one or more types that cannot be loaded. The array returned by the <see cref="P:System.Reflection.ReflectionTypeLoadException.Types" /> property of this exception contains a <see cref="T:System.Type" /> object for each type that was loaded and null for each type that could not be loaded, while the <see cref="P:System.Reflection.ReflectionTypeLoadException.LoaderExceptions" /> property contains an exception for each type that could not be loaded.</exception>
		public virtual Type[] GetTypes()
		{
			return null;
		}

		/// <summary>Gets the <see cref="T:System.Type" /> object with the specified name in the assembly instance.</summary>
		/// <returns>An object that represents the specified class, or null if the class is not found.</returns>
		/// <param name="name">The full name of the type. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="name" /> is invalid. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> is null. </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="name" /> requires a dependent assembly that could not be found. </exception>
		/// <exception cref="T:System.IO.FileLoadException">NoteIn the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.IO.IOException" />, instead.<paramref name="name" /> requires a dependent assembly that was found but could not be loaded.-or-The current assembly was loaded into the reflection-only context, and <paramref name="name" /> requires a dependent assembly that was not preloaded. </exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="name" /> requires a dependent assembly, but the file is not a valid assembly. -or-<paramref name="name" /> requires a dependent assembly which was compiled for a version of the runtime later than the currently loaded version. </exception>
		public virtual Type GetType(string name)
		{
			return null;
		}

		internal Type InternalGetType(Module module, string name, bool throwOnError, bool ignoreCase)
		{
			return null;
		}

		/// <summary>Gets an <see cref="T:System.Reflection.AssemblyName" /> for this assembly, setting the codebase as specified by <paramref name="copiedName" />.</summary>
		/// <returns>An object that contains the fully parsed display name for this assembly.</returns>
		/// <param name="copiedName">true to set the <see cref="P:System.Reflection.Assembly.CodeBase" /> to the location of the assembly after it was shadow copied; false to set <see cref="P:System.Reflection.Assembly.CodeBase" /> to the original location. </param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public virtual AssemblyName GetName(bool copiedName)
		{
			return null;
		}

		/// <summary>Gets an <see cref="T:System.Reflection.AssemblyName" /> for this assembly.</summary>
		/// <returns>An object that contains the fully parsed display name for this assembly.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public virtual AssemblyName GetName()
		{
			return null;
		}

		/// <summary>Returns the full name of the assembly, also known as the display name.</summary>
		/// <returns>The full name of the assembly, or the class name if the full name of the assembly cannot be determined.</returns>
		public override string ToString()
		{
			return null;
		}

		/// <summary>Gets the currently loaded assembly in which the specified class is defined.</summary>
		/// <returns>The assembly in which the specified class is defined.</returns>
		/// <param name="type">An object representing a class in the assembly that will be returned. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="type" /> is null. </exception>
		public static Assembly GetAssembly(Type type)
		{
			return null;
		}

		private static Assembly LoadFrom(string assemblyFile, bool refOnly, ref StackCrawlMark stackMark)
		{
			return null;
		}

		/// <summary>Loads an assembly given its file name or path and supplying security evidence.</summary>
		/// <returns>The loaded assembly.</returns>
		/// <param name="assemblyFile">The name or path of the file that contains the manifest of the assembly. </param>
		/// <param name="securityEvidence">Evidence for loading the assembly. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="assemblyFile" /> is null. </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="assemblyFile" /> is not found, or the module you are trying to load does not specify a filename extension. </exception>
		/// <exception cref="T:System.IO.FileLoadException">A file that was found could not be loaded.-or-The <paramref name="securityEvidence" /> is not ambiguous and is determined to be invalid.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyFile" /> is not a valid assembly; for example, a 32-bit assembly in a 64-bit process. See the exception topic for more information. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="assemblyFile" /> was compiled with a later version.</exception>
		/// <exception cref="T:System.Security.SecurityException">A codebase that does not start with "file://" was specified without the required <see cref="T:System.Net.WebPermission" />. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="assemblyFile" /> parameter is an empty string (""). </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The assembly name is longer than MAX_PATH characters.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" />
		/// </PermissionSet>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Obsolete]
		public static Assembly LoadFrom(string assemblyFile, Evidence securityEvidence)
		{
			return null;
		}

		/// <summary>Loads an assembly given the long form of its name.</summary>
		/// <returns>The loaded assembly.</returns>
		/// <param name="assemblyString">The long form of the assembly name. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="assemblyString" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="assemblyString" /> is a zero-length string. </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="assemblyString" /> is not found. </exception>
		/// <exception cref="T:System.IO.FileLoadException">A file that was found could not be loaded. </exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyString" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="assemblyString" /> was compiled with a later version.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" />
		/// </PermissionSet>
		public static Assembly Load(string assemblyString)
		{
			return null;
		}

		/// <summary>Loads an assembly given its <see cref="T:System.Reflection.AssemblyName" />.</summary>
		/// <returns>The loaded assembly.</returns>
		/// <param name="assemblyRef">The object that describes the assembly to be loaded. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="assemblyRef" /> is null. </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="assemblyRef" /> is not found. </exception>
		/// <exception cref="T:System.IO.FileLoadException">NoteIn the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.IO.IOException" />, instead.A file that was found could not be loaded. </exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyRef" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="assemblyRef" /> was compiled with a later version.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" />
		/// </PermissionSet>
		public static Assembly Load(AssemblyName assemblyRef)
		{
			return null;
		}

		/// <summary>Loads an assembly into the reflection-only context, given its display name.</summary>
		/// <returns>The loaded assembly.</returns>
		/// <param name="assemblyString">The display name of the assembly, as returned by the <see cref="P:System.Reflection.AssemblyName.FullName" /> property.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="assemblyString" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="assemblyString" /> is an empty string (""). </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="assemblyString" /> is not found. </exception>
		/// <exception cref="T:System.IO.FileLoadException">
		///   <paramref name="assemblyString" /> is found, but cannot be loaded. </exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyString" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="assemblyString" /> was compiled with a later version.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" />
		/// </PermissionSet>
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Assembly ReflectionOnlyLoad(string assemblyString)
		{
			return null;
		}

		/// <summary>Loads an assembly from the application directory or from the global assembly cache using a partial name.</summary>
		/// <returns>The loaded assembly. If <paramref name="partialName" /> is not found, this method returns null.</returns>
		/// <param name="partialName">The display name of the assembly. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="partialName" /> parameter is null. </exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyFile" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="partialName" /> was compiled with a later version.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" />
		/// </PermissionSet>
		[Obsolete("This method has been deprecated. Please use Assembly.Load() instead. http://go.microsoft.com/fwlink/?linkid=14202")]
		public static Assembly LoadWithPartialName(string partialName)
		{
			return null;
		}

		private static Assembly load_with_partial_name(string name, Evidence e)
		{
			return null;
		}

		/// <summary>Loads an assembly from the application directory or from the global assembly cache using a partial name. The assembly is loaded into the domain of the caller using the supplied evidence.</summary>
		/// <returns>The loaded assembly. If <paramref name="partialName" /> is not found, this method returns null.</returns>
		/// <param name="partialName">The display name of the assembly. </param>
		/// <param name="securityEvidence">Evidence for loading the assembly. </param>
		/// <exception cref="T:System.IO.FileLoadException">An assembly or module was loaded twice with two different sets of evidence. </exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="partialName" /> parameter is null. </exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyFile" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="partialName" /> was compiled with a later version.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" />
		/// </PermissionSet>
		[Obsolete("This method has been deprecated. Please use Assembly.Load() instead. http://go.microsoft.com/fwlink/?linkid=14202")]
		public static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence)
		{
			return null;
		}

		internal static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence, bool oldBehavior)
		{
			return null;
		}

		internal virtual Module[] GetModulesInternal()
		{
			return null;
		}

		/// <summary>Gets the assembly that contains the code that is currently executing.</summary>
		/// <returns>The assembly that contains the code that is currently executing. </returns>
		public static Assembly GetExecutingAssembly()
		{
			return null;
		}

		/// <summary>Returns the <see cref="T:System.Reflection.Assembly" /> of the method that invoked the currently executing method.</summary>
		/// <returns>The Assembly object of the method that invoked the currently executing method.</returns>
		public static Assembly GetCallingAssembly()
		{
			return null;
		}

		internal static IntPtr InternalGetReferencedAssemblies(Assembly module)
		{
			return (IntPtr)0;
		}

		internal static AssemblyName[] GetReferencedAssemblies(Assembly module)
		{
			return null;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		public override int GetHashCode()
		{
			return 0;
		}

		/// <summary>Determines whether this assembly and the specified object are equal.</summary>
		/// <returns>true if <paramref name="o" /> is equal to this instance; otherwise, false.</returns>
		/// <param name="o">The object to compare with this instance. </param>
		public override bool Equals(object o)
		{
			return false;
		}

		private static Exception CreateNIE()
		{
			return null;
		}

		/// <summary>Gets the <see cref="T:System.Type" /> object with the specified name in the assembly instance, with the options of ignoring the case, and of throwing an exception if the type is not found.</summary>
		/// <returns>An object that represents the specified class.</returns>
		/// <param name="name">The full name of the type. </param>
		/// <param name="throwOnError">true to throw an exception if the type is not found; false to return null. </param>
		/// <param name="ignoreCase">true to ignore the case of the type name; otherwise, false. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="name" /> is invalid.-or- The length of <paramref name="name" /> exceeds 1024 characters. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> is null. </exception>
		/// <exception cref="T:System.TypeLoadException">
		///   <paramref name="throwOnError" /> is true, and the type cannot be found.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="name" /> requires a dependent assembly that could not be found. </exception>
		/// <exception cref="T:System.IO.FileLoadException">
		///   <paramref name="name" /> requires a dependent assembly that was found but could not be loaded.-or-The current assembly was loaded into the reflection-only context, and <paramref name="name" /> requires a dependent assembly that was not preloaded. </exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="name" /> requires a dependent assembly, but the file is not a valid assembly. -or-<paramref name="name" /> requires a dependent assembly which was compiled for a version of the runtime later than the currently loaded version.</exception>
		public virtual Type GetType(string name, bool throwOnError, bool ignoreCase)
		{
			return null;
		}

		/// <summary>Gets the specified module in this assembly.</summary>
		/// <returns>The module being requested, or null if the module is not found.</returns>
		/// <param name="name">The name of the module being requested. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is null. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="name" /> parameter is an empty string (""). </exception>
		/// <exception cref="T:System.IO.FileLoadException">A file that was found could not be loaded. </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="name" /> was not found. </exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="name" /> is not a valid assembly. </exception>
		public virtual Module GetModule(string name)
		{
			return null;
		}

		/// <summary>Gets the <see cref="T:System.Reflection.AssemblyName" /> objects for all the assemblies referenced by this assembly.</summary>
		/// <returns>An array that contains the fully parsed display names of all the assemblies referenced by this assembly.</returns>
		public virtual AssemblyName[] GetReferencedAssemblies()
		{
			return null;
		}

		/// <summary>Gets all the modules that are part of this assembly, specifying whether to include resource modules.</summary>
		/// <returns>An array of modules.</returns>
		/// <param name="getResourceModules">true to include resource modules; otherwise, false. </param>
		public virtual Module[] GetModules(bool getResourceModules)
		{
			return null;
		}

		/// <summary>Indicates whether two <see cref="T:System.Reflection.Assembly" /> objects are equal.</summary>
		/// <returns>true if <paramref name="left" /> is equal to <paramref name="right" />; otherwise, false.</returns>
		/// <param name="left">The assembly to compare to <paramref name="right" />. </param>
		/// <param name="right">The assembly to compare to <paramref name="left" />.</param>
		public static bool operator ==(Assembly left, Assembly right)
		{
			return false;
		}

		/// <summary>Indicates whether two <see cref="T:System.Reflection.Assembly" /> objects are not equal.</summary>
		/// <returns>true if <paramref name="left" /> is not equal to <paramref name="right" />; otherwise, false.</returns>
		/// <param name="left">The assembly to compare to <paramref name="right" />.</param>
		/// <param name="right">The assembly to compare to <paramref name="left" />.</param>
		public static bool operator !=(Assembly left, Assembly right)
		{
			return false;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.Assembly" /> class.</summary>
		public Assembly()
		{
		}
	}
}
