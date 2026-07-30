using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Namotion.Reflection
{
	internal static class XmlDocsFormatting
	{
		private static readonly Dictionary<XmlDocsFormattingMode, Func<StringBuilder, XElement, StringBuilder>> formattingFunctions;

		private static readonly Dictionary<string, Func<StringBuilder, XElement, StringBuilder>> htmlTagMap;

		private static readonly Dictionary<string, Func<StringBuilder, XElement, StringBuilder>> markdownTagMap;

		public static StringBuilder AppendFormattedElement(this StringBuilder stringBuilder, XElement element, XmlDocsFormattingMode formattingMode)
		{
			return null;
		}

		private static StringBuilder AppendUnformattedElement(this StringBuilder stringBuilder, XElement element)
		{
			return null;
		}

		private static StringBuilder AppendHtmlFormattedElement(StringBuilder stringBuilder, XElement element)
		{
			return null;
		}

		private static StringBuilder AppendMarkdownFormattedElement(StringBuilder stringBuilder, XElement element)
		{
			return null;
		}

		private static StringBuilder AppendMapFormattedElement(StringBuilder stringBuilder, XElement element, Dictionary<string, Func<StringBuilder, XElement, StringBuilder>> map)
		{
			return null;
		}

		private static StringBuilder AppendSimpleTaggedElement(StringBuilder stringBuilder, XElement element, string startTag, string endTag)
		{
			return null;
		}
	}
}
