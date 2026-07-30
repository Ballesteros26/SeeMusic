using System;

namespace Parse.Core.Internal
{
	public class ParseDecoder
	{
		public static ParseDecoder Instance { get; }

		private ParseDecoder()
		{
		}

		public object Decode(object data)
		{
			return null;
		}

		protected virtual object DecodePointer(string className, string objectId)
		{
			return null;
		}

		public static DateTime ParseDate(string input)
		{
			return default(DateTime);
		}
	}
}
