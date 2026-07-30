using System.Collections;
using System.Reflection;

namespace System.ComponentModel
{
	internal sealed class ReflectTypeDescriptionProvider : TypeDescriptionProvider
	{
		private class ReflectedTypeData
		{
			private Type _type;

			private AttributeCollection _attributes;

			private EventDescriptorCollection _events;

			private PropertyDescriptorCollection _properties;

			private TypeConverter _converter;

			private object[] _editors;

			private Type[] _editorTypes;

			private int _editorCount;

			internal bool IsPopulated => false;

			internal ReflectedTypeData(Type type)
			{
			}

			internal AttributeCollection GetAttributes()
			{
				return null;
			}

			internal TypeConverter GetConverter(object instance)
			{
				return null;
			}

			internal PropertyDescriptorCollection GetProperties()
			{
				return null;
			}

			private Type GetTypeFromName(string typeName)
			{
				return null;
			}

			internal void Refresh()
			{
			}
		}

		private Hashtable _typeData;

		private static Type[] _typeConstructor;

		private static Hashtable _intrinsicTypeConverters;

		private static object _intrinsicReferenceKey;

		private static object _intrinsicNullableKey;

		private static object _dictionaryKey;

		private static Hashtable _propertyCache;

		private static Hashtable _attributeCache;

		private static Hashtable _extendedPropertyCache;

		private static readonly Guid _extenderProviderKey;

		private static readonly Guid _extenderPropertiesKey;

		private static readonly Guid _extenderProviderPropertiesKey;

		private static readonly Type[] _skipInterfaceAttributeList;

		private static object _internalSyncObject;

		private static Hashtable IntrinsicTypeConverters => null;

		internal ReflectTypeDescriptionProvider()
		{
		}

		public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args)
		{
			return null;
		}

		private static object CreateInstance(Type objectType, Type callingType)
		{
			return null;
		}

		internal AttributeCollection GetAttributes(Type type)
		{
			return null;
		}

		public override IDictionary GetCache(object instance)
		{
			return null;
		}

		internal TypeConverter GetConverter(Type type, object instance)
		{
			return null;
		}

		internal AttributeCollection GetExtendedAttributes(object instance)
		{
			return null;
		}

		internal TypeConverter GetExtendedConverter(object instance)
		{
			return null;
		}

		internal PropertyDescriptorCollection GetExtendedProperties(object instance)
		{
			return null;
		}

		protected internal override IExtenderProvider[] GetExtenderProviders(object instance)
		{
			return null;
		}

		private static IExtenderProvider[] GetExtenders(ICollection components, object instance, IDictionary cache)
		{
			return null;
		}

		internal object GetExtendedPropertyOwner(object instance, PropertyDescriptor pd)
		{
			return null;
		}

		public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance)
		{
			return null;
		}

		internal PropertyDescriptorCollection GetProperties(Type type)
		{
			return null;
		}

		internal object GetPropertyOwner(Type type, object instance, PropertyDescriptor pd)
		{
			return null;
		}

		public override Type GetReflectionType(Type objectType, object instance)
		{
			return null;
		}

		private ReflectedTypeData GetTypeData(Type type, bool createIfNeeded)
		{
			return null;
		}

		public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
		{
			return null;
		}

		private static Type GetTypeFromName(string typeName)
		{
			return null;
		}

		internal bool IsPopulated(Type type)
		{
			return false;
		}

		private static Attribute[] ReflectGetAttributes(Type type)
		{
			return null;
		}

		internal static Attribute[] ReflectGetAttributes(MemberInfo member)
		{
			return null;
		}

		private static PropertyDescriptor[] ReflectGetExtendedProperties(IExtenderProvider provider)
		{
			return null;
		}

		private static PropertyDescriptor[] ReflectGetProperties(Type type)
		{
			return null;
		}

		internal void Refresh(Type type)
		{
		}

		private static object SearchIntrinsicTable(Hashtable table, Type callingType)
		{
			return null;
		}
	}
}
