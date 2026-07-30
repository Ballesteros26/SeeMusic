using System.Collections.Generic;
using NJsonSchema.Generation.TypeMappers;
using Namotion.Reflection;

namespace NJsonSchema.Generation
{
	public class JsonTypeDescription
	{
		public ContextualType ContextualType { get; }

		public JsonObjectType Type { get; private set; }

		public bool IsDictionary { get; private set; }

		public bool IsEnum { get; private set; }

		public string Format { get; private set; }

		public bool IsNullable { get; set; }

		private JsonTypeDescription(ContextualType type, JsonObjectType jsonType, bool isNullable)
		{
		}

		public static JsonTypeDescription Create(ContextualType type, JsonObjectType jsonType, bool isNullable, string format)
		{
			return null;
		}

		public static JsonTypeDescription CreateForDictionary(ContextualType type, JsonObjectType jsonType, bool isNullable)
		{
			return null;
		}

		public static JsonTypeDescription CreateForEnumeration(ContextualType type, JsonObjectType jsonType, bool isNullable)
		{
			return null;
		}

		public bool RequiresSchemaReference(IEnumerable<ITypeMapper> typeMappers)
		{
			return false;
		}

		public void ApplyType(JsonSchema schema)
		{
		}
	}
}
