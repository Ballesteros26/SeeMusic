using System;
using System.Collections.Generic;
using Namotion.Reflection;
using Newtonsoft.Json.Serialization;

namespace NJsonSchema.Generation
{
	public class JsonSchemaGenerator
	{
		private static readonly Dictionary<string, string> DataTypeFormats;

		public JsonSchemaGeneratorSettings Settings { get; }

		public JsonSchemaGenerator(JsonSchemaGeneratorSettings settings)
		{
		}

		public JsonSchema Generate(Type type)
		{
			return null;
		}

		public JsonSchema Generate(Type type, JsonSchemaResolver schemaResolver)
		{
			return null;
		}

		public TSchemaType Generate<TSchemaType>(Type type, JsonSchemaResolver schemaResolver) where TSchemaType : JsonSchema, new()
		{
			return null;
		}

		public JsonSchema Generate(ContextualType contextualType, JsonSchemaResolver schemaResolver)
		{
			return null;
		}

		public TSchemaType Generate<TSchemaType>(ContextualType contextualType, JsonSchemaResolver schemaResolver) where TSchemaType : JsonSchema, new()
		{
			return null;
		}

		public virtual void Generate<TSchemaType>(TSchemaType schema, ContextualType contextualType, JsonSchemaResolver schemaResolver) where TSchemaType : JsonSchema, new()
		{
		}

		public TSchemaType GenerateWithReference<TSchemaType>(ContextualType contextualType, JsonSchemaResolver schemaResolver, Action<TSchemaType, JsonSchema> transformation = null) where TSchemaType : JsonSchema, new()
		{
			return null;
		}

		public TSchemaType GenerateWithReferenceAndNullability<TSchemaType>(ContextualType contextualType, JsonSchemaResolver schemaResolver, Action<TSchemaType, JsonSchema> transformation = null) where TSchemaType : JsonSchema, new()
		{
			return null;
		}

		public virtual TSchemaType GenerateWithReferenceAndNullability<TSchemaType>(ContextualType contextualType, bool isNullable, JsonSchemaResolver schemaResolver, Action<TSchemaType, JsonSchema> transformation = null) where TSchemaType : JsonSchema, new()
		{
			return null;
		}

		public virtual string GetPropertyName(JsonProperty jsonProperty, ContextualAccessorInfo accessorInfo)
		{
			return null;
		}

		public virtual void ApplyDataAnnotations(JsonSchema schema, JsonTypeDescription typeDescription)
		{
		}

		public virtual object ConvertDefaultValue(ContextualType type, object defaultValue)
		{
			return null;
		}

		public virtual object GenerateExample(ContextualType type)
		{
			return null;
		}

		public virtual object GenerateExample(ContextualAccessorInfo accessorInfo)
		{
			return null;
		}

		private object GenerateExample(string xmlDocs)
		{
			return null;
		}

		protected virtual void GenerateObject(JsonSchema schema, JsonTypeDescription typeDescription, JsonSchemaResolver schemaResolver)
		{
		}

		protected virtual string[] GetTypeProperties(Type type)
		{
			return null;
		}

		protected virtual void GenerateArray<TSchemaType>(TSchemaType schema, JsonTypeDescription typeDescription, JsonSchemaResolver schemaResolver) where TSchemaType : JsonSchema, new()
		{
		}

		protected virtual void GenerateDictionary<TSchemaType>(TSchemaType schema, JsonTypeDescription typeDescription, JsonSchemaResolver schemaResolver) where TSchemaType : JsonSchema, new()
		{
		}

		protected virtual void GenerateEnum(JsonSchema schema, JsonTypeDescription typeDescription)
		{
		}

		private TSchema GenerateDictionaryValueSchema<TSchema>(JsonSchemaResolver schemaResolver, ContextualType valueType) where TSchema : JsonSchema, new()
		{
			return null;
		}

		private void ApplyAdditionalProperties<TSchemaType>(TSchemaType schema, Type type, JsonSchemaResolver schemaResolver) where TSchemaType : JsonSchema, new()
		{
		}

		private void ApplySchemaProcessors(JsonSchema schema, ContextualType contextualType, JsonSchemaResolver schemaResolver)
		{
		}

		private bool TryHandleSpecialTypes<TSchemaType>(TSchemaType schema, ContextualType contextualType, JsonSchemaResolver schemaResolver) where TSchemaType : JsonSchema, new()
		{
			return false;
		}

		private void GenerateEnum<TSchemaType>(TSchemaType schema, JsonTypeDescription typeDescription, JsonSchemaResolver schemaResolver) where TSchemaType : JsonSchema, new()
		{
		}

		private void GenerateProperties(Type type, JsonSchema schema, JsonSchemaResolver schemaResolver)
		{
		}

		private bool IsAbstractProperty(ContextualMemberInfo memberInfo)
		{
			return false;
		}

		private void GenerateKnownTypes(Type type, JsonSchemaResolver schemaResolver)
		{
		}

		private void AddKnownType(Type type, JsonSchemaResolver schemaResolver)
		{
		}

		private JsonSchema GenerateInheritance(ContextualType type, JsonSchema schema, JsonSchemaResolver schemaResolver)
		{
			return null;
		}

		private void GenerateInheritanceDiscriminator(Type type, JsonSchema schema, JsonSchema typeSchema)
		{
		}

		private object TryGetInheritanceDiscriminatorConverter(Type type)
		{
			return null;
		}

		private string TryGetInheritanceDiscriminatorName(object jsonInheritanceConverter)
		{
			return null;
		}

		private void LoadPropertyOrField(JsonProperty jsonProperty, ContextualAccessorInfo accessorInfo, Type parentType, JsonSchema parentSchema, JsonSchemaResolver schemaResolver)
		{
		}

		protected virtual bool IsPropertyIgnored(ContextualAccessorInfo accessorInfo, Type parentType)
		{
			return false;
		}

		private bool IsPropertyIgnoredBySettings(ContextualAccessorInfo accessorInfo)
		{
			return false;
		}

		private object GetDataMemberAttribute(ContextualAccessorInfo accessorInfo, Type parentType)
		{
			return null;
		}

		private bool HasDataContractAttribute(Type parentType)
		{
			return false;
		}

		private void ApplyRangeAttribute(JsonSchema schema, IEnumerable<Attribute> parentAttributes)
		{
		}

		private void ApplyTypeExtensionDataAttributes<TSchemaType>(TSchemaType schema, ContextualType contextualType) where TSchemaType : JsonSchema, new()
		{
		}

		private void ApplyPropertyExtensionDataAttributes(ContextualAccessorInfo accessorInfo, JsonSchemaProperty propertySchema)
		{
		}
	}
}
