using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace NJsonSchema.Generation
{
	public static class SystemTextJsonUtilities
	{
		private sealed class SystemTextJsonContractResolver : DefaultContractResolver
		{
		}

		public static JsonSerializerSettings ConvertJsonOptionsToNewtonsoftSettings(dynamic serializerOptions)
		{
			return null;
		}

		private static bool IsCamelCaseEnumNamingPolicy(object jsonStringEnumConverter)
		{
			return false;
		}
	}
}
