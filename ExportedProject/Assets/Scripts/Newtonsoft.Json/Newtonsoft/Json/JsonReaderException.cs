using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Newtonsoft.Json
{
	[Serializable]
	public class JsonReaderException : JsonException
	{
		[CompilerGenerated]
		private readonly int _003CLineNumber_003Ek__BackingField;

		[CompilerGenerated]
		private readonly int _003CLinePosition_003Ek__BackingField;

		[CompilerGenerated]
		private readonly string? _003CPath_003Ek__BackingField;

		public JsonReaderException()
		{
		}

		public JsonReaderException(SerializationInfo info, StreamingContext context)
		{
		}

		public JsonReaderException(string message, string path, int lineNumber, int linePosition, Exception? innerException)
		{
		}

		internal static JsonReaderException Create(JsonReader reader, string message)
		{
			return null;
		}

		internal static JsonReaderException Create(JsonReader reader, string message, Exception? ex)
		{
			return null;
		}

		internal static JsonReaderException Create(IJsonLineInfo? lineInfo, string path, string message, Exception? ex)
		{
			return null;
		}
	}
}
