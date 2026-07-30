using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace NJsonSchema.Converters
{
	public class JsonInheritanceConverter : JsonConverter
	{
		private readonly Type _baseType;

		private readonly string _discriminatorName;

		private readonly bool _readTypeProperty;

		[ThreadStatic]
		private static bool _isReading;

		[ThreadStatic]
		private static bool _isWriting;

		public static string DefaultDiscriminatorName { get; }

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		public override bool CanConvert(Type objectType)
		{
			return false;
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		public virtual string GetDiscriminatorValue(Type type)
		{
			return null;
		}

		protected virtual Type GetDiscriminatorType(JObject jObject, Type objectType, string discriminatorValue)
		{
			return null;
		}

		private Type GetSubtypeFromKnownTypeAttributes(Type objectType, string discriminator)
		{
			return null;
		}

		private static Type GetObjectSubtype(Type baseType, string discriminatorName)
		{
			return null;
		}

		private static string GetSubtypeDiscriminator(Type objectType)
		{
			return null;
		}
	}
}
