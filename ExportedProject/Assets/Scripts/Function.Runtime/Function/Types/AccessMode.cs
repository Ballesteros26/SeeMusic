using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Function.Types
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AccessMode
	{
		[EnumMember(Value = "PUBLIC")]
		Public = 0,
		[EnumMember(Value = "PRIVATE")]
		Private = 1
	}
}
