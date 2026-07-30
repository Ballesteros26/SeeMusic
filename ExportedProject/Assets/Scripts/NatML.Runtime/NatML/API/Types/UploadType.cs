using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace NatML.API.Types
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum UploadType
	{
		[EnumMember(Value = "DEMO")]
		Demo = 0,
		[EnumMember(Value = "FEATURE")]
		Feature = 1,
		[EnumMember(Value = "GRAPH")]
		Graph = 2,
		[EnumMember(Value = "MEDIA")]
		Media = 3,
		[EnumMember(Value = "NOTEBOOK")]
		Notebook = 4
	}
}
