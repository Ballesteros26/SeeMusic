using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace NJsonSchema.Infrastructure
{
	public class JsonSchemaSerialization
	{
		[ThreadStatic]
		private static SchemaType _currentSchemaType;

		[ThreadStatic]
		private static bool _isWriting;

		[ThreadStatic]
		private static JsonSerializerSettings _currentSerializerSettings;

		public static SchemaType CurrentSchemaType
		{
			get
			{
				return default(SchemaType);
			}
			private set
			{
			}
		}

		public static JsonSerializerSettings CurrentSerializerSettings
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		private static bool IsWriting
		{
			set
			{
			}
		}

		public static string ToJson(object obj, SchemaType schemaType, IContractResolver contractResolver, Formatting formatting)
		{
			return null;
		}
	}
}
