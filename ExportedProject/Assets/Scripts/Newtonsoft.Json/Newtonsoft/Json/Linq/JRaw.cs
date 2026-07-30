namespace Newtonsoft.Json.Linq
{
	public class JRaw : JValue
	{
		internal JRaw(JRaw other, JsonCloneSettings? settings)
			: base(null, default(JTokenType))
		{
		}

		public JRaw(object? rawJson)
			: base(null, default(JTokenType))
		{
		}

		public static JRaw Create(JsonReader reader)
		{
			return null;
		}

		internal override JToken CloneToken(JsonCloneSettings? settings)
		{
			return null;
		}
	}
}
