using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Function.Types
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum UploadType
	{
		[EnumMember(Value = "MEDIA")]
		Media = 2,
		[EnumMember(Value = "NOTEBOOK")]
		Notebook = 3,
		[EnumMember(Value = "VALUE")]
		Value = 1
	}
}
