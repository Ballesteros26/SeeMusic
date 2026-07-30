using System.Collections;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.ComponentModel
{
	/// <summary>Provides information about the characteristics for a component, such as its attributes, properties, and events. This class cannot be inherited.</summary>
	public sealed class TypeDescriptor
	{
		private sealed class AttributeFilterCacheItem
		{
			private Attribute[] _filter;

			internal ICollection FilteredMembers;

			internal AttributeFilterCacheItem(Attribute[] filter, ICollection filteredMembers)
			{
			}

			internal bool IsValid(Attribute[] filter)
			{
				return false;
			}
		}

		private sealed class FilterCacheItem
		{
			private ITypeDescriptorFilterService _filterService;

			internal ICollection FilteredMembers;

			internal FilterCacheItem(ITypeDescriptorFilterService filterService, ICollection filteredMembers)
			{
			}

			internal bool IsValid(ITypeDescriptorFilterService filterService)
			{
				return false;
			}
		}

		private interface IUnimplemented
		{
		}

		private sealed class MemberDescriptorComparer : IComparer
		{
			public static readonly MemberDescriptorComparer Instance;

			public int Compare(object left, object right)
			{
				return 0;
			}
		}

		private sealed class MergedTypeDescriptor : ICustomTypeDescriptor
		{
			private ICustomTypeDescriptor _primary;

			private ICustomTypeDescriptor _secondary;

			internal MergedTypeDescriptor(ICustomTypeDescriptor primary, ICustomTypeDescriptor secondary)
			{
			}

			AttributeCollection ICustomTypeDescriptor.GetAttributes()
			{
				return null;
			}

			TypeConverter ICustomTypeDescriptor.GetConverter()
			{
				return null;
			}

			PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties()
			{
				return null;
			}

			PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes)
			{
				return null;
			}

			object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd)
			{
				return null;
			}
		}

		private sealed class TypeDescriptionNode : TypeDescriptionProvider
		{
			private struct DefaultExtendedTypeDescriptor : ICustomTypeDescriptor
			{
				private TypeDescriptionNode _node;

				private object _instance;

				internal DefaultExtendedTypeDescriptor(TypeDescriptionNode node, object instance)
				{
					_node = null;
					_instance = null;
				}

				AttributeCollection ICustomTypeDescriptor.GetAttributes()
				{
					return null;
				}

				TypeConverter ICustomTypeDescriptor.GetConverter()
				{
					return null;
				}

				PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties()
				{
					return null;
				}

				PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes)
				{
					return null;
				}

				object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd)
				{
					return null;
				}
			}

			private struct DefaultTypeDescriptor : ICustomTypeDescriptor
			{
				private TypeDescriptionNode _node;

				private Type _objectType;

				private object _instance;

				internal DefaultTypeDescriptor(TypeDescriptionNode node, Type objectType, object instance)
				{
					_node = null;
					_objectType = null;
					_instance = null;
				}

				AttributeCollection ICustomTypeDescriptor.GetAttributes()
				{
					return null;
				}

				TypeConverter ICustomTypeDescriptor.GetConverter()
				{
					return null;
				}

				PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties()
				{
					return null;
				}

				PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes)
				{
					return null;
				}

				object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd)
				{
					return null;
				}
			}

			internal TypeDescriptionNode Next;

			internal TypeDescriptionProvider Provider;

			internal TypeDescriptionNode(TypeDescriptionProvider provider)
			{
			}

			public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args)
			{
				return null;
			}

			public override IDictionary GetCache(object instance)
			{
				return null;
			}

			public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance)
			{
				return null;
			}

			protected internal override IExtenderProvider[] GetExtenderProviders(object instance)
			{
				return null;
			}

			public override Type GetReflectionType(Type objectType, object instance)
			{
				return null;
			}

			public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
			{
				return null;
			}
		}

		[TypeDescriptionProvider("System.Windows.Forms.ComponentModel.Com2Interop.ComNativeDescriptor, System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
		private sealed class TypeDescriptorComObject
		{
		}

		private sealed class TypeDescriptorInterface
		{
		}

		private static WeakHashtable _providerTable;

		private static Hashtable _providerTypeTable;

		private static Hashtable _defaultProviders;

		private static WeakHashtable _associationTable;

		private static int _metadataVersion;

		private static int _collisionIndex;

		private static BooleanSwitch TraceDescriptor;

		private static readonly Guid[] _pipelineInitializeKeys;

		private static readonly Guid[] _pipelineMergeKeys;

		private static readonly Guid[] _pipelineFilterKeys;

		private static readonly Guid[] _pipelineAttributeFilterKeys;

		private static object _internalSyncObject;

		[CompilerGenerated]
		private static RefreshEventHandler Refreshed;

		/// <summary>Gets the type of the Component Object Model (COM) object represented by the target component.</summary>
		/// <returns>The <see cref="T:System.Type" /> of the COM object represented by this component, or null for non-COM objects.</returns>
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static Type ComObjectType => null;

		/// <summary>Gets a type that represents a type description provider for all interface types. </summary>
		/// <returns>A <see cref="T:System.Type" /> that represents a custom type description provider for all interface types. </returns>
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static Type InterfaceType => null;

		internal static int MetadataVersion => 0;

		/// <summary>Adds a type description provider for a component class.</summary>
		/// <param name="provider">The <see cref="T:System.ComponentModel.TypeDescriptionProvider" /> to add.</param>
		/// <param name="type">The <see cref="T:System.Type" /> of the target component.</param>
		/// <exception cref="T:System.ArgumentNullException">One or both of the parameters are null.</exception>
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static void AddProvider(TypeDescriptionProvider provider, Type type)
		{
		}

		private static void CheckDefaultProvider(Type type)
		{
		}

		/// <summary>Creates an object that can substitute for another data type. </summary>
		/// <returns>An instance of the substitute data type if an associated <see cref="T:System.ComponentModel.TypeDescriptionProvider" /> is found; otherwise, null.</returns>
		/// <param name="provider">The service provider that provides a <see cref="T:System.ComponentModel.TypeDescriptionProvider" /> service. This parameter can be null.</param>
		/// <param name="objectType">The <see cref="T:System.Type" /> of object to create.</param>
		/// <param name="argTypes">An optional array of parameter types to be passed to the object's constructor. This parameter can be null or an array of zero length.</param>
		/// <param name="args">An optional array of parameter values to pass to the object's constructor. If not null, the number of elements must be the same as <paramref name="argTypes" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="objectType" /> is null, or <paramref name="args" /> is null when <paramref name="argTypes" /> is not null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="argTypes" /> and <paramref name="args" /> have different number of elements.</exception>
		public static object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args)
		{
			return null;
		}

		private static ArrayList FilterMembers(IList members, Attribute[] attributes)
		{
			return null;
		}

		/// <summary>Returns an instance of the type associated with the specified primary object.</summary>
		/// <returns>An instance of the secondary type that has been associated with the primary object if an association exists; otherwise, <paramref name="primary" /> if no specified association exists.</returns>
		/// <param name="type">The <see cref="T:System.Type" /> of the target component.</param>
		/// <param name="primary">The primary object of the association.</param>
		/// <exception cref="T:System.ArgumentNullException">One or both of the parameters are null.</exception>
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static object GetAssociation(Type type, object primary)
		{
			return null;
		}

		/// <summary>Returns a collection of attributes for the specified type of component.</summary>
		/// <returns>An <see cref="T:System.ComponentModel.AttributeCollection" /> with the attributes for the type of the component. If the component is null, this method returns an empty collection.</returns>
		/// <param name="componentType">The <see cref="T:System.Type" /> of the target component. </param>
		public static AttributeCollection GetAttributes(Type componentType)
		{
			return null;
		}

		/// <summary>Returns the collection of attributes for the specified component.</summary>
		/// <returns>An <see cref="T:System.ComponentModel.AttributeCollection" /> containing the attributes for the component. If <paramref name="component" /> is null, this method returns an empty collection.</returns>
		/// <param name="component">The component for which you want to get attributes. </param>
		public static AttributeCollection GetAttributes(object component)
		{
			return null;
		}

		/// <summary>Returns a collection of attributes for the specified component and a Boolean indicating that a custom type descriptor has been created.</summary>
		/// <returns>An <see cref="T:System.ComponentModel.AttributeCollection" /> with the attributes for the component. If the component is null, this method returns an empty collection.</returns>
		/// <param name="component">The component for which you want to get attributes. </param>
		/// <param name="noCustomTypeDesc">true to use a baseline set of attributes from the custom type descriptor if <paramref name="component" /> is of type <see cref="T:System.ComponentModel.ICustomTypeDescriptor" />; otherwise, false.</param>
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static AttributeCollection GetAttributes(object component, bool noCustomTypeDesc)
		{
			return null;
		}

		internal static IDictionary GetCache(object instance)
		{
			return null;
		}

		/// <summary>Returns a type converter for the specified type.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.TypeConverter" /> for the specified type.</returns>
		/// <param name="type">The <see cref="T:System.Type" /> of the target component. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="component" /> is null. </exception>
		public static TypeConverter GetConverter(Type type)
		{
			return null;
		}

		internal static ICustomTypeDescriptor GetDescriptor(Type type, string typeName)
		{
			return null;
		}

		internal static ICustomTypeDescriptor GetDescriptor(object component, bool noCustomTypeDesc)
		{
			return null;
		}

		internal static ICustomTypeDescriptor GetExtendedDescriptor(object component)
		{
			return null;
		}

		private static string GetExtenderCollisionSuffix(MemberDescriptor member)
		{
			return null;
		}

		private static Type GetNodeForBaseType(Type searchType)
		{
			return null;
		}

		/// <summary>Returns the collection of properties for a specified component.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> with the properties for the specified component.</returns>
		/// <param name="component">A component to get the properties for. </param>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="component" /> is a cross-process remoted object.</exception>
		public static PropertyDescriptorCollection GetProperties(object component)
		{
			return null;
		}

		/// <summary>Returns the collection of properties for a specified component using the default type descriptor.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> with the properties for a specified component.</returns>
		/// <param name="component">A component to get the properties for. </param>
		/// <param name="noCustomTypeDesc">true to not consider custom type description information; otherwise, false.</param>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="component" /> is a cross-process remoted object.</exception>
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static PropertyDescriptorCollection GetProperties(object component, bool noCustomTypeDesc)
		{
			return null;
		}

		/// <summary>Returns the collection of properties for a specified component using a specified array of attributes as a filter.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> with the properties that match the specified attributes for the specified component.</returns>
		/// <param name="component">A component to get the properties for. </param>
		/// <param name="attributes">An array of type <see cref="T:System.Attribute" /> to use as a filter. </param>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="component" /> is a cross-process remoted object.</exception>
		public static PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes)
		{
			return null;
		}

		/// <summary>Returns the collection of properties for a specified component using a specified array of attributes as a filter and using a custom type descriptor.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> with the events that match the specified attributes for the specified component.</returns>
		/// <param name="component">A component to get the properties for. </param>
		/// <param name="attributes">An array of type <see cref="T:System.Attribute" /> to use as a filter. </param>
		/// <param name="noCustomTypeDesc">true to consider custom type description information; otherwise, false.</param>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="component" /> is a cross-process remoted object.</exception>
		public static PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes, bool noCustomTypeDesc)
		{
			return null;
		}

		private static PropertyDescriptorCollection GetPropertiesImpl(object component, Attribute[] attributes, bool noCustomTypeDesc, bool noAttributes)
		{
			return null;
		}

		internal static TypeDescriptionProvider GetProviderRecursive(Type type)
		{
			return null;
		}

		/// <summary>Returns a <see cref="T:System.Type" /> that can be used to perform reflection, given a class type.</summary>
		/// <returns>A <see cref="T:System.Type" /> of the specified class.</returns>
		/// <param name="type">The <see cref="T:System.Type" /> of the target component.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="type" /> is null.</exception>
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static Type GetReflectionType(Type type)
		{
			return null;
		}

		private static TypeDescriptionNode NodeFor(Type type)
		{
			return null;
		}

		private static TypeDescriptionNode NodeFor(Type type, bool createDelegator)
		{
			return null;
		}

		private static TypeDescriptionNode NodeFor(object instance)
		{
			return null;
		}

		private static TypeDescriptionNode NodeFor(object instance, bool createDelegator)
		{
			return null;
		}

		private static ICollection PipelineAttributeFilter(int pipelineType, ICollection members, Attribute[] filter, object instance, IDictionary cache)
		{
			return null;
		}

		private static ICollection PipelineFilter(int pipelineType, ICollection members, object instance, IDictionary cache)
		{
			return null;
		}

		private static ICollection PipelineInitialize(int pipelineType, ICollection members, IDictionary cache)
		{
			return null;
		}

		private static ICollection PipelineMerge(int pipelineType, ICollection primary, ICollection secondary, object instance, IDictionary cache)
		{
			return null;
		}

		private static void RaiseRefresh(Type type)
		{
		}

		/// <summary>Clears the properties and events for the specified type of component from the cache.</summary>
		/// <param name="type">The <see cref="T:System.Type" /> of the target component.</param>
		public static void Refresh(Type type)
		{
		}

		private static bool ShouldHideMember(MemberDescriptor member, Attribute attribute)
		{
			return false;
		}

		/// <summary>Sorts descriptors using the name of the descriptor.</summary>
		/// <param name="infos">An <see cref="T:System.Collections.IList" /> that contains the descriptors to sort. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="infos" /> is null.</exception>
		public static void SortDescriptorArray(IList infos)
		{
		}
	}
}
