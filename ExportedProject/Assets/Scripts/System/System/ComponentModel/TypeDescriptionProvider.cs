using System.Collections;

namespace System.ComponentModel
{
	/// <summary>Provides supplemental metadata to the <see cref="T:System.ComponentModel.TypeDescriptor" />.</summary>
	public abstract class TypeDescriptionProvider
	{
		private sealed class EmptyCustomTypeDescriptor : CustomTypeDescriptor
		{
		}

		private readonly TypeDescriptionProvider _parent;

		private EmptyCustomTypeDescriptor _emptyDescriptor;

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.TypeDescriptionProvider" /> class.</summary>
		protected TypeDescriptionProvider()
		{
		}

		/// <summary>Creates an object that can substitute for another data type.</summary>
		/// <returns>The substitute <see cref="T:System.Object" />.</returns>
		/// <param name="provider">An optional service provider.</param>
		/// <param name="objectType">The type of object to create. This parameter is never null.</param>
		/// <param name="argTypes">An optional array of types that represent the parameter types to be passed to the object's constructor. This array can be null or of zero length.</param>
		/// <param name="args">An optional array of parameter values to pass to the object's constructor.</param>
		public virtual object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args)
		{
			return null;
		}

		/// <summary>Gets a per-object cache, accessed as an <see cref="T:System.Collections.IDictionary" /> of key/value pairs.</summary>
		/// <returns>An <see cref="T:System.Collections.IDictionary" /> if the provided object supports caching; otherwise, null.</returns>
		/// <param name="instance">The object for which to get the cache.</param>
		public virtual IDictionary GetCache(object instance)
		{
			return null;
		}

		/// <summary>Gets an extended custom type descriptor for the given object.</summary>
		/// <returns>An <see cref="T:System.ComponentModel.ICustomTypeDescriptor" /> that can provide extended metadata for the object.</returns>
		/// <param name="instance">The object for which to get the extended type descriptor.</param>
		public virtual ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance)
		{
			return null;
		}

		/// <summary>Gets the extender providers for the specified object.</summary>
		/// <returns>An array of extender providers for <paramref name="instance" />.</returns>
		/// <param name="instance">The object to get extender providers for.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="instance" /> is null.</exception>
		protected internal virtual IExtenderProvider[] GetExtenderProviders(object instance)
		{
			return null;
		}

		/// <summary>Performs normal reflection against a type.</summary>
		/// <returns>The type of reflection for this <paramref name="objectType" />.</returns>
		/// <param name="objectType">The type of object for which to retrieve the <see cref="T:System.Reflection.IReflect" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="objectType" /> is null.</exception>
		public Type GetReflectionType(Type objectType)
		{
			return null;
		}

		/// <summary>Performs normal reflection against the given object with the given type.</summary>
		/// <returns>The type of reflection for this <paramref name="objectType" />.</returns>
		/// <param name="objectType">The type of object for which to retrieve the <see cref="T:System.Reflection.IReflect" />.</param>
		/// <param name="instance">An instance of the type. Can be null.</param>
		public virtual Type GetReflectionType(Type objectType, object instance)
		{
			return null;
		}

		/// <summary>Gets a custom type descriptor for the given type.</summary>
		/// <returns>An <see cref="T:System.ComponentModel.ICustomTypeDescriptor" /> that can provide metadata for the type.</returns>
		/// <param name="objectType">The type of object for which to retrieve the type descriptor.</param>
		public ICustomTypeDescriptor GetTypeDescriptor(Type objectType)
		{
			return null;
		}

		/// <summary>Gets a custom type descriptor for the given object.</summary>
		/// <returns>An <see cref="T:System.ComponentModel.ICustomTypeDescriptor" /> that can provide metadata for the type.</returns>
		/// <param name="instance">An instance of the type. Can be null if no instance was passed to the <see cref="T:System.ComponentModel.TypeDescriptor" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="instance" /> is null.</exception>
		public ICustomTypeDescriptor GetTypeDescriptor(object instance)
		{
			return null;
		}

		/// <summary>Gets a custom type descriptor for the given type and object.</summary>
		/// <returns>An <see cref="T:System.ComponentModel.ICustomTypeDescriptor" /> that can provide metadata for the type.</returns>
		/// <param name="objectType">The type of object for which to retrieve the type descriptor.</param>
		/// <param name="instance">An instance of the type. Can be null if no instance was passed to the <see cref="T:System.ComponentModel.TypeDescriptor" />.</param>
		public virtual ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
		{
			return null;
		}
	}
}
