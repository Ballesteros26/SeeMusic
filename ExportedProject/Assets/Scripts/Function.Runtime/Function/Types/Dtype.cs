using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Function.Types
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum Dtype
	{
		[EnumMember(Value = "null")]
		Null = 0,
		[EnumMember(Value = "int8")]
		Int8 = 10,
		[EnumMember(Value = "int16")]
		Int16 = 2,
		[EnumMember(Value = "int32")]
		Int32 = 3,
		[EnumMember(Value = "int64")]
		Int64 = 4,
		[EnumMember(Value = "uint8")]
		Uint8 = 1,
		[EnumMember(Value = "uint16")]
		Uint16 = 11,
		[EnumMember(Value = "uint32")]
		Uint32 = 12,
		[EnumMember(Value = "uint64")]
		Uint64 = 13,
		[EnumMember(Value = "float16")]
		Float16 = 14,
		[EnumMember(Value = "float32")]
		Float32 = 5,
		[EnumMember(Value = "float64")]
		Float64 = 6,
		[EnumMember(Value = "bool")]
		Bool = 15,
		[EnumMember(Value = "string")]
		String = 7,
		[EnumMember(Value = "image")]
		Image = 16,
		[EnumMember(Value = "audio")]
		Audio = 18,
		[EnumMember(Value = "video")]
		Video = 19,
		[EnumMember(Value = "binary")]
		Binary = 17,
		[EnumMember(Value = "list")]
		List = 8,
		[EnumMember(Value = "dict")]
		Dict = 9
	}
}
