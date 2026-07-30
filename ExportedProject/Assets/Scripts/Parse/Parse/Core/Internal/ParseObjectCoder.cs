using System;
using System.Collections.Generic;

namespace Parse.Core.Internal
{
	public class ParseObjectCoder
	{
		public static ParseObjectCoder Instance { get; }

		private ParseObjectCoder()
		{
		}

		public IObjectState Decode(IDictionary<string, object> data, ParseDecoder decoder)
		{
			return null;
		}

		private T extractFromDictionary<T>(IDictionary<string, object> data, string key, Func<object, T> action)
		{
			return default(T);
		}
	}
}
