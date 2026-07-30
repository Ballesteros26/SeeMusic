using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Function.Types
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum Acceleration
	{
		CPU = 0,
		A40 = 1,
		A100 = 2
	}
}
