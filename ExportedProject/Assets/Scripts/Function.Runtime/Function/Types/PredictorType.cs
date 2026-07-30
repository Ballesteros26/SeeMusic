using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Function.Types
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PredictorType
	{
		[EnumMember(Value = "CLOUD")]
		Cloud = 0,
		[EnumMember(Value = "EDGE")]
		Edge = 1
	}
}
