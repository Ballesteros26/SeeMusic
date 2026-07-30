namespace System.Xml.Linq
{
	/// <summary>Represents an XML document. </summary>
	public class XDocument : XContainer
	{
		private XDeclaration _declaration;

		/// <summary>Gets or sets the XML declaration for this document.</summary>
		/// <returns>An <see cref="T:System.Xml.Linq.XDeclaration" /> that contains the XML declaration for this document.</returns>
		public XDeclaration Declaration
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Gets the node type for this node.</summary>
		/// <returns>The node type. For <see cref="T:System.Xml.Linq.XDocument" /> objects, this value is <see cref="F:System.Xml.XmlNodeType.Document" />.</returns>
		public override XmlNodeType NodeType => default(XmlNodeType);

		/// <summary>Gets the root element of the XML Tree for this document.</summary>
		/// <returns>The root <see cref="T:System.Xml.Linq.XElement" /> of the XML tree.</returns>
		public XElement Root => null;

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Linq.XDocument" /> class. </summary>
		public XDocument()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Linq.XDocument" /> class from an existing <see cref="T:System.Xml.Linq.XDocument" /> object.</summary>
		/// <param name="other">The <see cref="T:System.Xml.Linq.XDocument" /> object that will be copied.</param>
		public XDocument(XDocument other)
		{
		}

		/// <summary>Creates a new <see cref="T:System.Xml.Linq.XDocument" /> from a file, optionally preserving white space, setting the base URI, and retaining line information.</summary>
		/// <returns>An <see cref="T:System.Xml.Linq.XDocument" /> that contains the contents of the specified file.</returns>
		/// <param name="uri">A URI string that references the file to load into a new <see cref="T:System.Xml.Linq.XDocument" />.</param>
		/// <param name="options">A <see cref="T:System.Xml.Linq.LoadOptions" /> that specifies white space behavior, and whether to load base URI and line information.</param>
		public static XDocument Load(string uri, LoadOptions options)
		{
			return null;
		}

		/// <summary>Loads an <see cref="T:System.Xml.Linq.XElement" /> from an <see cref="T:System.Xml.XmlReader" />, optionally setting the base URI, and retaining line information.</summary>
		/// <returns>An <see cref="T:System.Xml.Linq.XDocument" /> that contains the XML that was read from the specified <see cref="T:System.Xml.XmlReader" />.</returns>
		/// <param name="reader">A <see cref="T:System.Xml.XmlReader" /> that will be read for the content of the <see cref="T:System.Xml.Linq.XDocument" />.</param>
		/// <param name="options">A <see cref="T:System.Xml.Linq.LoadOptions" /> that specifies whether to load base URI and line information.</param>
		public static XDocument Load(XmlReader reader, LoadOptions options)
		{
			return null;
		}

		private static XDocument InitLoad(XmlReader reader, LoadOptions options)
		{
			return null;
		}

		/// <summary>Write this document to an <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="writer">An <see cref="T:System.Xml.XmlWriter" /> into which this method will write.</param>
		/// <filterpriority>2</filterpriority>
		public override void WriteTo(XmlWriter writer)
		{
		}

		internal override void AddAttribute(XAttribute a)
		{
		}

		internal override void AddAttributeSkipNotify(XAttribute a)
		{
		}

		internal override XNode CloneNode()
		{
			return null;
		}

		private T GetFirstNode<T>() where T : XNode
		{
			return null;
		}

		internal static bool IsWhitespace(string s)
		{
			return false;
		}

		internal override void ValidateNode(XNode node, XNode previous)
		{
		}

		private void ValidateDocument(XNode previous, XmlNodeType allowBefore, XmlNodeType allowAfter)
		{
		}

		internal override void ValidateString(string s)
		{
		}
	}
}
