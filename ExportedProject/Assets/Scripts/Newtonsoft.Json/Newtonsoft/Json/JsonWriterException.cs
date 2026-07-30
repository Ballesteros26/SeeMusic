using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Newtonsoft.Json
{
	[Serializable]
	public class JsonWriterException : JsonException
	{
		[CompilerGenerated]
		private readonly string? _003CPath_003Ek__BackingField;

		public JsonWriterException()
		{
		}

		public JsonWriterException(SerializationInfo info, StreamingContext context)
		{
		}

		public JsonWriterException(string message, string path, Exception? innerException)
		{
		}

		internal static JsonWriterException Create(JsonWriter writer, string message, Exception? ex)
		{
			return null;
		}

		internal static JsonWriterException Create(string path, string message, Exception? ex)
		{
			return null;
		}
	}
}
