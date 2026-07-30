using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Parse.Common.Internal
{
	public class Json
	{
		private class JsonStringParser
		{
			public string Input { get; private set; }

			public char[] InputAsArray { get; private set; }

			public int CurrentIndex { get; private set; }

			public void Skip(int skip)
			{
			}

			public JsonStringParser(string input)
			{
			}

			internal bool ParseObject(out object output)
			{
				output = null;
				return false;
			}

			private bool ParseMember(out object output)
			{
				output = null;
				return false;
			}

			internal bool ParseArray(out object output)
			{
				output = null;
				return false;
			}

			private bool ParseValue(out object output)
			{
				output = null;
				return false;
			}

			private bool ParseString(out object output)
			{
				output = null;
				return false;
			}

			private bool ParseNumber(out object output)
			{
				output = null;
				return false;
			}

			private bool Accept(Regex matcher, out Match match)
			{
				match = null;
				return false;
			}

			private bool Accept(char condition)
			{
				return false;
			}

			private bool Accept(char[] condition)
			{
				return false;
			}
		}

		private static readonly string startOfString;

		private static readonly char startObject;

		private static readonly char endObject;

		private static readonly char startArray;

		private static readonly char endArray;

		private static readonly char valueSeparator;

		private static readonly char nameSeparator;

		private static readonly char[] falseValue;

		private static readonly char[] trueValue;

		private static readonly char[] nullValue;

		private static readonly Regex numberValue;

		private static readonly Regex stringValue;

		private static readonly Regex escapePattern;

		public static object Parse(string input)
		{
			return null;
		}

		public static string Encode(IDictionary<string, object> dict)
		{
			return null;
		}

		public static string Encode(IList<object> list)
		{
			return null;
		}

		public static string Encode(object obj)
		{
			return null;
		}
	}
}
