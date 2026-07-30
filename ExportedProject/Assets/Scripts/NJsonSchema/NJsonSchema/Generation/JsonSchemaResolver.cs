using System;
using System.Collections.Generic;

namespace NJsonSchema.Generation
{
	public class JsonSchemaResolver : JsonSchemaAppender
	{
		private readonly Dictionary<string, JsonSchema> _mappings;

		private readonly JsonSchemaGeneratorSettings _settings;

		public JsonSchemaResolver(object rootObject, JsonSchemaGeneratorSettings settings)
			: base(null, null)
		{
		}

		public bool HasSchema(Type type, bool isIntegerEnumeration)
		{
			return false;
		}

		public JsonSchema GetSchema(Type type, bool isIntegerEnumeration)
		{
			return null;
		}

		public virtual void AddSchema(Type type, bool isIntegerEnumeration, JsonSchema schema)
		{
		}

		protected virtual string GetTypeKey(Type type, bool isIntegerEnum)
		{
			return null;
		}
	}
}
