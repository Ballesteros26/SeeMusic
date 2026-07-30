namespace Namotion.Reflection
{
	public class XmlDocsOptions
	{
		public static XmlDocsOptions Default { get; }

		public bool ResolveExternalXmlDocs { get; set; }

		public XmlDocsFormattingMode FormattingMode { get; set; }
	}
}
