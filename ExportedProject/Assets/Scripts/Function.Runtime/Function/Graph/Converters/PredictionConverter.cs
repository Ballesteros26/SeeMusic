using System;
using Newtonsoft.Json;

namespace Function.Graph.Converters
{
	internal class PredictionConverter : JsonConverter
	{
		public override bool CanWrite => false;

		public override bool CanRead => false;

		public override bool CanConvert(Type objectType)
		{
			return false;
		}

		public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
		{
		}

		public override object ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
		{
			return null;
		}
	}
}
