using System;
using Newtonsoft.Json;

namespace NJsonSchema
{
	internal sealed class ExtensionDataDeserializationConverter : JsonConverter
	{
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		public override bool CanConvert(Type objectType)
		{
			return false;
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		internal void DeserializeExtensionDataSchemas(IJsonExtensionObject extensionObject, JsonSerializer serializer)
		{
		}

		private object TryDeserializeValueSchemas(object value, JsonSerializer serializer)
		{
			return null;
		}
	}
}
