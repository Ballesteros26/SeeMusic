using System.Collections.Generic;

namespace Newtonsoft.Json.Linq
{
	public static class Extensions
	{
		public static U? Value<U>(this IEnumerable<JToken> value)
		{
			return default(U);
		}

		public static U Value<T, U>(this IEnumerable<T> value) where T : notnull, JToken where U : notnull
		{
			return default(U);
		}

		internal static U? Convert<T, U>(this T token) where T : JToken?
		{
			return default(U);
		}
	}
}
