using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace NatML.API.Types
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum GraphFormat
	{
		[EnumMember(Value = "COREML")]
		CoreML = 0,
		[EnumMember(Value = "ONNX")]
		ONNX = 1,
		[EnumMember(Value = "TFLITE")]
		TFLite = 2
	}
}
