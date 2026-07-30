using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace NatML.API.Types
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AspectMode
	{
		[EnumMember(Value = "SCALE_TO_FIT")]
		ScaleToFit = 0,
		[EnumMember(Value = "ASPECT_FILL")]
		AspectFill = 1,
		[EnumMember(Value = "ASPECT_FIT")]
		AspectFit = 2
	}
}
