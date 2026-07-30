using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using NJsonSchema.Collections;
using NJsonSchema.Generation;
using NJsonSchema.Infrastructure;
using NJsonSchema.References;
using Newtonsoft.Json;

namespace NJsonSchema
{
	[JsonConverter(typeof(ExtensionDataDeserializationConverter))]
	public class JsonSchema : JsonReferenceBase<JsonSchema>, IDocumentPathProvider, IJsonReference, IJsonReferenceBase, IJsonExtensionObject
	{
		internal static readonly HashSet<string> JsonSchemaPropertiesCache;

		private static readonly Lazy<PropertyRenameAndIgnoreSerializerContractResolver> ContractResolver;

		private ObservableDictionary<string, JsonSchemaProperty> _properties;

		private ObservableDictionary<string, JsonSchemaProperty> _patternProperties;

		private ObservableDictionary<string, JsonSchema> _definitions;

		internal ObservableCollection<JsonSchema> _allOf;

		internal ObservableCollection<JsonSchema> _anyOf;

		internal ObservableCollection<JsonSchema> _oneOf;

		private JsonSchema _not;

		private JsonSchema _dictionaryKey;

		private JsonObjectType _type;

		private JsonSchema _item;

		internal ObservableCollection<JsonSchema> _items;

		private bool _allowAdditionalItems;

		private JsonSchema _additionalItemsSchema;

		private bool _allowAdditionalProperties;

		private JsonSchema _additionalPropertiesSchema;

		private static readonly string version;

		[CompilerGenerated]
		private string _003CFormat_003Ek__BackingField;

		[CompilerGenerated]
		private object _003CDefault_003Ek__BackingField;

		[CompilerGenerated]
		private decimal? _003CMaximum_003Ek__BackingField;

		[CompilerGenerated]
		private decimal? _003CMinimum_003Ek__BackingField;

		[CompilerGenerated]
		private int? _003CMaxLength_003Ek__BackingField;

		[CompilerGenerated]
		private int? _003CMinLength_003Ek__BackingField;

		[CompilerGenerated]
		private string _003CPattern_003Ek__BackingField;

		[CompilerGenerated]
		private int _003CMaxItems_003Ek__BackingField;

		[CompilerGenerated]
		private int _003CMinItems_003Ek__BackingField;

		[CompilerGenerated]
		private int _003CMaxProperties_003Ek__BackingField;

		[CompilerGenerated]
		private int _003CMinProperties_003Ek__BackingField;

		[CompilerGenerated]
		private bool _003CIsDeprecated_003Ek__BackingField;

		[CompilerGenerated]
		private string _003CDeprecatedMessage_003Ek__BackingField;

		[CompilerGenerated]
		private bool _003CIsAbstract_003Ek__BackingField;

		[CompilerGenerated]
		private bool _003CIsFlagEnumerable_003Ek__BackingField;

		[JsonIgnore]
		private JsonXmlObject _xmlObject;

		private static readonly JsonObjectType[] _jsonObjectTypeValues;

		private readonly NotifyCollectionChangedEventHandler _initializeSchemaCollectionEventHandler;

		private Lazy<object> _typeRaw;

		[JsonIgnore]
		public JsonSchema InheritedSchema => null;

		[JsonIgnore]
		public OpenApiDiscriminator ResponsibleDiscriminatorObject => null;

		[JsonIgnore]
		public bool HasActualProperties => false;

		[JsonProperty("$schema", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, Order = -99)]
		public string SchemaVersion { get; set; }

		[JsonProperty("title", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, Order = -97)]
		public string Title { get; set; }

		[JsonIgnore]
		public bool HasTypeNameTitle => false;

		[JsonProperty("description", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
		public virtual string Description { get; set; }

		[JsonIgnore]
		public JsonObjectType Type
		{
			get
			{
				return default(JsonObjectType);
			}
			set
			{
			}
		}

		[JsonIgnore]
		public JsonSchema ParentSchema => null;

		[JsonIgnore]
		public virtual object Parent { get; set; }

		[JsonProperty("format", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
		public string Format
		{
			[CompilerGenerated]
			set
			{
				_003CFormat_003Ek__BackingField = value;
			}
		}

		[JsonProperty("default", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
		public object Default
		{
			[CompilerGenerated]
			set
			{
				_003CDefault_003Ek__BackingField = value;
			}
		}

		[JsonProperty("multipleOf", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
		public decimal? MultipleOf { get; set; }

		[JsonProperty("maximum", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
		public decimal? Maximum
		{
			[CompilerGenerated]
			set
			{
				_003CMaximum_003Ek__BackingField = value;
			}
		}

		[JsonProperty("minimum", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
		public decimal? Minimum
		{
			[CompilerGenerated]
			set
			{
				_003CMinimum_003Ek__BackingField = value;
			}
		}

		[JsonProperty("maxLength", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
		public int? MaxLength
		{
			[CompilerGenerated]
			set
			{
				_003CMaxLength_003Ek__BackingField = value;
			}
		}

		[JsonProperty("minLength", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
		public int? MinLength
		{
			[CompilerGenerated]
			set
			{
				_003CMinLength_003Ek__BackingField = value;
			}
		}

		[JsonProperty("pattern", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
		public string Pattern
		{
			[CompilerGenerated]
			set
			{
				_003CPattern_003Ek__BackingField = value;
			}
		}

		[JsonProperty("maxItems", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
		public int MaxItems
		{
			[CompilerGenerated]
			set
			{
				_003CMaxItems_003Ek__BackingField = value;
			}
		}

		[JsonProperty("minItems", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
		public int MinItems
		{
			[CompilerGenerated]
			set
			{
				_003CMinItems_003Ek__BackingField = value;
			}
		}

		[JsonProperty("maxProperties", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
		public int MaxProperties
		{
			[CompilerGenerated]
			set
			{
				_003CMaxProperties_003Ek__BackingField = value;
			}
		}

		[JsonProperty("minProperties", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
		public int MinProperties
		{
			[CompilerGenerated]
			set
			{
				_003CMinProperties_003Ek__BackingField = value;
			}
		}

		[JsonProperty("x-deprecated", DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool IsDeprecated
		{
			[CompilerGenerated]
			set
			{
				_003CIsDeprecated_003Ek__BackingField = value;
			}
		}

		[JsonProperty("x-deprecatedMessage", DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string DeprecatedMessage
		{
			[CompilerGenerated]
			set
			{
				_003CDeprecatedMessage_003Ek__BackingField = value;
			}
		}

		[JsonProperty("x-abstract", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
		public bool IsAbstract
		{
			[CompilerGenerated]
			set
			{
				_003CIsAbstract_003Ek__BackingField = value;
			}
		}

		[JsonProperty("x-nullable", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
		public bool? IsNullableRaw { get; set; }

		[JsonProperty("x-example", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
		public object Example { get; set; }

		[JsonProperty("x-enumFlags", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
		public bool IsFlagEnumerable
		{
			[CompilerGenerated]
			set
			{
				_003CIsFlagEnumerable_003Ek__BackingField = value;
			}
		}

		[JsonIgnore]
		public ICollection<object> Enumeration { get; internal set; }

		[JsonIgnore]
		public bool IsEnumeration => false;

		[JsonIgnore]
		public ICollection<string> RequiredProperties { get; internal set; }

		[JsonProperty("x-dictionaryKey", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
		public JsonSchema DictionaryKey
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[JsonIgnore]
		public IDictionary<string, JsonSchemaProperty> Properties
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		[JsonProperty("xml", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
		public JsonXmlObject Xml
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[JsonIgnore]
		public IDictionary<string, JsonSchemaProperty> PatternProperties
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		[JsonIgnore]
		public JsonSchema Item
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[JsonIgnore]
		public ICollection<JsonSchema> Items
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		[JsonProperty("not", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
		public JsonSchema Not
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[JsonIgnore]
		public IDictionary<string, JsonSchema> Definitions
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		[JsonIgnore]
		public ICollection<JsonSchema> AllOf
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		[JsonIgnore]
		public ICollection<JsonSchema> AnyOf
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		[JsonIgnore]
		public ICollection<JsonSchema> OneOf
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		[JsonIgnore]
		public bool AllowAdditionalItems
		{
			set
			{
			}
		}

		[JsonIgnore]
		public JsonSchema AdditionalItemsSchema
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[JsonIgnore]
		public bool AllowAdditionalProperties
		{
			set
			{
			}
		}

		[JsonIgnore]
		public JsonSchema AdditionalPropertiesSchema
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[JsonIgnore]
		public bool IsArray => false;

		[JsonIgnore]
		public bool IsDictionary => false;

		[JsonIgnore]
		public virtual JsonSchema ActualSchema => null;

		[JsonIgnore]
		public virtual JsonSchema ActualTypeSchema => null;

		[JsonIgnore]
		public bool HasReference => false;

		[JsonIgnore]
		public bool HasAllOfSchemaReference => false;

		[JsonIgnore]
		public bool HasOneOfSchemaReference => false;

		[JsonIgnore]
		public bool HasAnyOfSchemaReference => false;

		[JsonIgnore]
		IJsonReference IJsonReference.ActualObject => null;

		[JsonIgnore]
		object IJsonReference.PossibleRoot => null;

		[JsonIgnore]
		public override JsonSchema Reference
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[JsonExtensionData]
		public IDictionary<string, object> ExtensionData { get; set; }

		[JsonIgnore]
		public string Discriminator
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[JsonIgnore]
		public OpenApiDiscriminator ActualDiscriminatorObject => null;

		[JsonIgnore]
		public OpenApiDiscriminator DiscriminatorObject { get; set; }

		[JsonProperty("discriminator", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, Order = -95)]
		internal object DiscriminatorRaw
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[JsonIgnore]
		public Collection<string> EnumerationNames { get; set; }

		public static JsonSchema CreateAnySchema()
		{
			return null;
		}

		public static JsonSchema FromType<TType>(JsonSchemaGeneratorSettings settings)
		{
			return null;
		}

		public virtual bool IsNullable(SchemaType schemaType)
		{
			return false;
		}

		public string ToJson()
		{
			return null;
		}

		public string ToJson(Formatting formatting)
		{
			return null;
		}

		private void Initialize()
		{
		}

		private static ObservableCollection<T> ToObservableCollection<T>(ICollection<T> value)
		{
			return null;
		}

		private static ObservableDictionary<string, T> ToObservableDictionary<T>(IDictionary<string, T> value)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private JsonSchema GetActualSchema(List<JsonSchema> checkedSchemas)
		{
			return null;
		}

		private JsonSchema GetActualSchemaReferences(List<JsonSchema> checkedSchemas)
		{
			return null;
		}

		public static PropertyRenameAndIgnoreSerializerContractResolver CreateJsonSerializerContractResolver(SchemaType schemaType)
		{
			return null;
		}

		[OnDeserialized]
		internal void OnDeserialized(StreamingContext ctx)
		{
		}

		private void ResetTypeRaw()
		{
		}

		private void RegisterProperties(ObservableDictionary<string, JsonSchemaProperty> oldCollection, ObservableDictionary<string, JsonSchemaProperty> newCollection)
		{
		}

		private void RegisterSchemaDictionary<T>(ObservableDictionary<string, T> oldCollection, ObservableDictionary<string, T> newCollection) where T : JsonSchema
		{
		}

		private void RegisterSchemaCollection(ObservableCollection<JsonSchema> oldCollection, ObservableCollection<JsonSchema> newCollection)
		{
		}

		private void InitializeSchemaCollection(object sender, NotifyCollectionChangedEventArgs e)
		{
		}
	}
}
