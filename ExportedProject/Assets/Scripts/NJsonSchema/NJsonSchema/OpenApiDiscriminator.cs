using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NJsonSchema
{
	public class OpenApiDiscriminator
	{
		private sealed class DiscriminatorMappingConverter : JsonConverter
		{
			public override bool CanConvert(Type objectType)
			{
				return false;
			}

			public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
			{
				return null;
			}

			public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
			{
			}
		}

		[JsonProperty("propertyName", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
		public string PropertyName { get; set; }

		[JsonProperty("mapping", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
		[JsonConverter(typeof(DiscriminatorMappingConverter))]
		public IDictionary<string, JsonSchema> Mapping { get; }

		[JsonIgnore]
		public object JsonInheritanceConverter { get; set; }

		public void AddMapping(Type type, JsonSchema schema)
		{
		}
	}
}
