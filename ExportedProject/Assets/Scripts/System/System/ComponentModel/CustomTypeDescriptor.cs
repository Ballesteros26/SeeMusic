namespace System.ComponentModel
{
	/// <summary>Provides a simple default implementation of the <see cref="T:System.ComponentModel.ICustomTypeDescriptor" /> interface.</summary>
	public abstract class CustomTypeDescriptor : ICustomTypeDescriptor
	{
		private readonly ICustomTypeDescriptor _parent;

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.CustomTypeDescriptor" /> class.</summary>
		protected CustomTypeDescriptor()
		{
		}

		/// <summary>Returns a collection of custom attributes for the type represented by this type descriptor.</summary>
		/// <returns>An <see cref="T:System.ComponentModel.AttributeCollection" /> containing the attributes for the type. The default is <see cref="F:System.ComponentModel.AttributeCollection.Empty" />.</returns>
		public virtual AttributeCollection GetAttributes()
		{
			return null;
		}

		/// <summary>Returns a type converter for the type represented by this type descriptor.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.TypeConverter" /> for the type represented by this type descriptor. The default is a newly created <see cref="T:System.ComponentModel.TypeConverter" />.</returns>
		public virtual TypeConverter GetConverter()
		{
			return null;
		}

		/// <summary>Returns a collection of property descriptors for the object represented by this type descriptor.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> containing the property descriptions for the object represented by this type descriptor. The default is <see cref="F:System.ComponentModel.PropertyDescriptorCollection.Empty" />.</returns>
		public virtual PropertyDescriptorCollection GetProperties()
		{
			return null;
		}

		/// <summary>Returns a filtered collection of property descriptors for the object represented by this type descriptor.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> containing the property descriptions for the object represented by this type descriptor. The default is <see cref="F:System.ComponentModel.PropertyDescriptorCollection.Empty" />.</returns>
		/// <param name="attributes">An array of attributes to use as a filter. This can be null.</param>
		public virtual PropertyDescriptorCollection GetProperties(Attribute[] attributes)
		{
			return null;
		}

		/// <summary>Returns an object that contains the property described by the specified property descriptor.</summary>
		/// <returns>An <see cref="T:System.Object" /> that owns the given property specified by the type descriptor. The default is null.</returns>
		/// <param name="pd">The property descriptor for which to retrieve the owning object.</param>
		public virtual object GetPropertyOwner(PropertyDescriptor pd)
		{
			return null;
		}
	}
}
