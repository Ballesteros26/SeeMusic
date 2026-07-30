using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace NatML.API.Types
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum GraphStatus
	{
		[EnumMember(Value = "PROVISIONING")]
		Provisioning = 0,
		[EnumMember(Value = "ACTIVE")]
		Active = 1,
		[EnumMember(Value = "INVALID")]
		Invalid = 2
	}
}
