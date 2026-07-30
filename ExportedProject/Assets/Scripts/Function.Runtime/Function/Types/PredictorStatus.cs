using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Function.Types
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PredictorStatus
	{
		[EnumMember(Value = "PROVISIONING")]
		Provisioning = 0,
		[EnumMember(Value = "ACTIVE")]
		Active = 1,
		[EnumMember(Value = "INVALID")]
		Invalid = 2,
		[EnumMember(Value = "ARCHIVED")]
		Archived = 3
	}
}
