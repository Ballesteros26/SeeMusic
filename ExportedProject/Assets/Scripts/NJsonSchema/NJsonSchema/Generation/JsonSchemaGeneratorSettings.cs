using System;
using System.Collections.Generic;
using NJsonSchema.Generation.TypeMappers;
using Namotion.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace NJsonSchema.Generation
{
	public class JsonSchemaGeneratorSettings : IXmlDocsSettings
	{
		private EnumHandling _defaultEnumHandling;

		private PropertyNameHandling _defaultPropertyNameHandling;

		private IContractResolver _contractResolver;

		private JsonSerializerSettings _serializerSettings;

		private object _serializerOptions;

		public ReferenceTypeNullHandling DefaultReferenceTypeNullHandling { get; set; }

		public ReferenceTypeNullHandling DefaultDictionaryValueReferenceTypeNullHandling { get; set; }

		public bool GenerateAbstractProperties { get; }

		public bool FlattenInheritanceHierarchy { get; set; }

		public bool GenerateAbstractSchemas { get; set; }

		public bool GenerateKnownTypes { get; }

		public bool GenerateXmlObjects { get; }

		public bool IgnoreObsoleteProperties { get; }

		public bool AllowReferencesWithProperties { get; }

		public bool GenerateEnumMappingDescription { get; }

		public bool AlwaysAllowAdditionalObjectProperties { get; }

		public bool GenerateExamples { get; set; }

		public SchemaType SchemaType { get; set; }

		[JsonIgnore]
		public JsonSerializerSettings SerializerSettings => null;

		[JsonIgnore]
		public object SerializerOptions => null;

		public string[] ExcludedTypeNames { get; set; }

		public bool UseXmlDocumentation { get; set; }

		public bool ResolveExternalXmlDocumentation { get; set; }

		public XmlDocsFormattingMode XmlDocumentationFormatting { get; set; }

		[JsonIgnore]
		public ITypeNameGenerator TypeNameGenerator { get; set; }

		[JsonIgnore]
		public ISchemaNameGenerator SchemaNameGenerator { get; set; }

		[JsonIgnore]
		public IReflectionService ReflectionService { get; set; }

		[JsonIgnore]
		public ICollection<ITypeMapper> TypeMappers { get; }

		[JsonIgnore]
		public ICollection<ISchemaProcessor> SchemaProcessors { get; }

		public bool GenerateCustomNullableProperties { get; }

		[JsonIgnore]
		[Obsolete("Use SerializerSettings directly instead. In NSwag.AspNetCore the property is set automatically.")]
		public IContractResolver ContractResolver
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete("Use SerializerSettings directly instead. In NSwag.AspNetCore the property is set automatically.")]
		public PropertyNameHandling DefaultPropertyNameHandling
		{
			get
			{
				return default(PropertyNameHandling);
			}
			set
			{
			}
		}

		[Obsolete("Use SerializerSettings directly instead. In NSwag.AspNetCore the property is set automatically.")]
		public EnumHandling DefaultEnumHandling
		{
			get
			{
				return default(EnumHandling);
			}
			set
			{
			}
		}

		[JsonIgnore]
		public IContractResolver ActualContractResolver { get; internal set; }

		[JsonIgnore]
		public JsonSerializerSettings ActualSerializerSettings { get; internal set; }

		public JsonContract ResolveContract(Type type)
		{
			return null;
		}

		public bool GetActualGenerateAbstractSchema(Type type)
		{
			return false;
		}

		public bool GetActualFlattenInheritanceHierarchy(Type type)
		{
			return false;
		}

		private void UpdateActualContractResolverAndSerializerSettings()
		{
		}

		private void UpdateActualSerializerSettings()
		{
		}
	}
}
