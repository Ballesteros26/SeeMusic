using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace NatML.API.Types
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AccessMode
	{
		[EnumMember(Value = "PRIVATE")]
		Private = 0,
		[EnumMember(Value = "PUBLIC")]
		Public = 1
	}
}
