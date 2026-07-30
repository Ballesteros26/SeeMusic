using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Newtonsoft.Json
{
	[Serializable]
	public class JsonSerializationException : JsonException
	{
		[CompilerGenerated]
		private readonly int _003CLineNumber_003Ek__BackingField;

		[CompilerGenerated]
		private readonly int _003CLinePosition_003Ek__BackingField;

		[CompilerGenerated]
		private readonly string? _003CPath_003Ek__BackingField;

		public JsonSerializationException()
		{
		}

		public JsonSerializationException(string message)
		{
		}

		public JsonSerializationException(string message, Exception innerException)
		{
		}

		public JsonSerializationException(SerializationInfo info, StreamingContext context)
		{
		}

		public JsonSerializationException(string message, string path, int lineNumber, int linePosition, Exception? innerException)
		{
		}

		internal static JsonSerializationException Create(JsonReader reader, string message)
		{
			return null;
		}

		internal static JsonSerializationException Create(JsonReader reader, string message, Exception? ex)
		{
			return null;
		}

		internal static JsonSerializationException Create(IJsonLineInfo? lineInfo, string path, string message, Exception? ex)
		{
			return null;
		}
	}
}
