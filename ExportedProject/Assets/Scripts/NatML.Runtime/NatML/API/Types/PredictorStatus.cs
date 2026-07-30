using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace NatML.API.Types
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PredictorStatus
	{
		[EnumMember(Value = "DRAFT")]
		Draft = 0,
		[EnumMember(Value = "PUBLISHED")]
		Published = 1,
		[EnumMember(Value = "ARCHIVED")]
		Archived = 2
	}
}
