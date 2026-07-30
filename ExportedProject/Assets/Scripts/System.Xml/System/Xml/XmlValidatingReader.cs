namespace System.Xml
{
	/// <summary>Represents a reader that provides document type definition (DTD), XML-Data Reduced (XDR) schema, and XML Schema definition language (XSD) validation.</summary>
	[Obsolete("Use XmlReader created by XmlReader.Create() method using appropriate XmlReaderSettings instead. https://go.microsoft.com/fwlink/?linkid=14202")]
	public class XmlValidatingReader : XmlReader
	{
		private XmlValidatingReaderImpl impl;

		/// <summary>Gets the type of the current node.</summary>
		/// <returns>One of the <see cref="T:System.Xml.XmlNodeType" /> values representing the type of the current node.</returns>
		public override XmlNodeType NodeType => default(XmlNodeType);

		/// <summary>Gets the local name of the current node.</summary>
		/// <returns>The name of the current node with the prefix removed. For example, LocalName is book for the element &lt;bk:book&gt;.For node types that do not have a name (like Text, Comment, and so on), this property returns String.Empty.</returns>
		public override string LocalName => null;

		/// <summary>Gets the namespace Uniform Resource Identifier (URI) (as defined in the World Wide Web Consortium (W3C) Namespace specification) of the node on which the reader is positioned.</summary>
		/// <returns>The namespace URI of the current node; otherwise an empty string.</returns>
		public override string NamespaceURI => null;

		/// <summary>Gets the namespace prefix associated with the current node.</summary>
		/// <returns>The namespace prefix associated with the current node.</returns>
		public override string Prefix => null;

		/// <summary>Gets the text value of the current node.</summary>
		/// <returns>The value returned depends on the <see cref="P:System.Xml.XmlValidatingReader.NodeType" /> of the node. The following table lists node types that have a value to return. All other node types return String.Empty.Node Type Value AttributeThe value of the attribute. CDATAThe content of the CDATA section. CommentThe content of the comment. DocumentTypeThe internal subset. ProcessingInstructionThe entire content, excluding the target. SignificantWhitespaceThe white space between markup in a mixed content model. TextThe content of the text node. WhitespaceThe white space between markup. XmlDeclarationThe content of the declaration. </returns>
		public override string Value => null;

		/// <summary>Gets the depth of the current node in the XML document.</summary>
		/// <returns>The depth of the current node in the XML document.</returns>
		public override int Depth => 0;

		/// <summary>Gets the base URI of the current node.</summary>
		/// <returns>The base URI of the current node.</returns>
		public override string BaseURI => null;

		/// <summary>Gets a value indicating whether the current node is an empty element (for example, &lt;MyElement/&gt;).</summary>
		/// <returns>true if the current node is an element (<see cref="P:System.Xml.XmlValidatingReader.NodeType" /> equals XmlNodeType.Element) that ends with /&gt;; otherwise, false.</returns>
		public override bool IsEmptyElement => false;

		/// <summary>Gets the number of attributes on the current node.</summary>
		/// <returns>The number of attributes on the current node. This number includes default attributes.</returns>
		public override int AttributeCount => 0;

		/// <summary>Gets a value indicating whether the reader is positioned at the end of the stream.</summary>
		/// <returns>true if the reader is positioned at the end of the stream; otherwise, false.</returns>
		public override bool EOF => false;

		/// <summary>Gets the state of the reader.</summary>
		/// <returns>One of the <see cref="T:System.Xml.ReadState" /> values.</returns>
		public override ReadState ReadState => default(ReadState);

		/// <summary>Gets the <see cref="T:System.Xml.XmlNameTable" /> associated with this implementation.</summary>
		/// <returns>XmlNameTable that enables you to get the atomized version of a string within the node.</returns>
		public override XmlNameTable NameTable => null;

		/// <summary>Gets or sets a value indicating whether to do namespace support.</summary>
		/// <returns>true to do namespace support; otherwise, false. The default is true.</returns>
		public bool Namespaces => false;

		/// <summary>Gets the value of the attribute with the specified name.</summary>
		/// <returns>The value of the specified attribute. If the attribute is not found, null is returned.</returns>
		/// <param name="name">The qualified name of the attribute. </param>
		public override string GetAttribute(string name)
		{
			return null;
		}

		/// <summary>Gets the value of the attribute with the specified local name and namespace Uniform Resource Identifier (URI).</summary>
		/// <returns>The value of the specified attribute. If the attribute is not found, null is returned. This method does not move the reader.</returns>
		/// <param name="localName">The local name of the attribute. </param>
		/// <param name="namespaceURI">The namespace URI of the attribute. </param>
		public override string GetAttribute(string localName, string namespaceURI)
		{
			return null;
		}

		/// <summary>Gets the value of the attribute with the specified index.</summary>
		/// <returns>The value of the specified attribute.</returns>
		/// <param name="i">The index of the attribute. The index is zero-based. (The first attribute has index 0.) </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="i" /> parameter is less than 0 or greater than or equal to <see cref="P:System.Xml.XmlValidatingReader.AttributeCount" />. </exception>
		public override string GetAttribute(int i)
		{
			return null;
		}

		/// <summary>Moves to the attribute with the specified name.</summary>
		/// <returns>true if the attribute is found; otherwise, false. If false, the position of the reader does not change.</returns>
		/// <param name="name">The qualified name of the attribute. </param>
		public override bool MoveToAttribute(string name)
		{
			return false;
		}

		/// <summary>Moves to the first attribute.</summary>
		/// <returns>true if an attribute exists (the reader moves to the first attribute); otherwise, false (the position of the reader does not change).</returns>
		public override bool MoveToFirstAttribute()
		{
			return false;
		}

		/// <summary>Moves to the next attribute.</summary>
		/// <returns>true if there is a next attribute; false if there are no more attributes.</returns>
		public override bool MoveToNextAttribute()
		{
			return false;
		}

		/// <summary>Moves to the element that contains the current attribute node.</summary>
		/// <returns>true if the reader is positioned on an attribute (the reader moves to the element that owns the attribute); false if the reader is not positioned on an attribute (the position of the reader does not change).</returns>
		public override bool MoveToElement()
		{
			return false;
		}

		/// <summary>Parses the attribute value into one or more Text, EntityReference, or EndEntity nodes.</summary>
		/// <returns>true if there are nodes to return.false if the reader is not positioned on an attribute node when the initial call is made or if all the attribute values have been read.An empty attribute, such as, misc="", returns true with a single node with a value of String.Empty.</returns>
		public override bool ReadAttributeValue()
		{
			return false;
		}

		/// <summary>Reads the next node from the stream.</summary>
		/// <returns>true if the next node was read successfully; false if there are no more nodes to read.</returns>
		public override bool Read()
		{
			return false;
		}

		/// <summary>Resolves a namespace prefix in the current element's scope.</summary>
		/// <returns>The namespace URI to which the prefix maps or null if no matching prefix is found.</returns>
		/// <param name="prefix">The prefix whose namespace Uniform Resource Identifier (URI) you want to resolve. To match the default namespace, pass an empty string. </param>
		public override string LookupNamespace(string prefix)
		{
			return null;
		}

		/// <summary>Resolves the entity reference for EntityReference nodes.</summary>
		/// <exception cref="T:System.InvalidOperationException">The reader is not positioned on an EntityReference node. </exception>
		public override void ResolveEntity()
		{
		}
	}
}
