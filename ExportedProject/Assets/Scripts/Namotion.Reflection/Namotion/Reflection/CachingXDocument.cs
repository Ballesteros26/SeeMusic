using System.Collections.Generic;
using System.Xml.Linq;

namespace Namotion.Reflection
{
	internal sealed class CachingXDocument
	{
		private static readonly XName XNameDoc;

		private static readonly XName XNameMembers;

		private static readonly XName XNameMember;

		private static readonly XName XNameName;

		private readonly object _lock;

		private readonly Dictionary<string, XElement?> _elementByNameCache;

		private readonly XDocument _document;

		internal CachingXDocument(string? pathToXmlFile)
		{
		}

		internal XElement GetXmlDocsElement(string name)
		{
			return null;
		}

		internal static XElement GetXmlDocsElement(XDocument document, string name)
		{
			return null;
		}
	}
}
