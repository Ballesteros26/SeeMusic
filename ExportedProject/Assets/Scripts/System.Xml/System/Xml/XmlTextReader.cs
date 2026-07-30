using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace System.Xml
{
	/// <summary>Represents a reader that provides fast, non-cached, forward-only access to XML data.</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class XmlTextReader : XmlReader, IXmlLineInfo, IXmlNamespaceResolver
	{
		private XmlTextReaderImpl impl;

		/// <summary>Gets the type of the current node.</summary>
		/// <returns>One of the <see cref="T:System.Xml.XmlNodeType" /> values representing the type of the current node.</returns>
		public override XmlNodeType NodeType => default(XmlNodeType);

		/// <summary>Gets the qualified name of the current node.</summary>
		/// <returns>The qualified name of the current node. For example, Name is bk:book for the element &lt;bk:book&gt;.The name returned is dependent on the <see cref="P:System.Xml.XmlTextReader.NodeType" /> of the node. The following node types return the listed values. All other node types return an empty string.Node Type Name AttributeThe name of the attribute. DocumentTypeThe document type name. ElementThe tag name. EntityReferenceThe name of the entity referenced. ProcessingInstructionThe target of the processing instruction. XmlDeclarationThe literal string xml. </returns>
		public override string Name => null;

		/// <summary>Gets the local name of the current node.</summary>
		/// <returns>The name of the current node with the prefix removed. For example, LocalName is book for the element &lt;bk:book&gt;.For node types that do not have a name (like Text, Comment, and so on), this property returns String.Empty.</returns>
		public override string LocalName => null;

		/// <summary>Gets the namespace URI (as defined in the W3C Namespace specification) of the node on which the reader is positioned.</summary>
		/// <returns>The namespace URI of the current node; otherwise an empty string.</returns>
		public override string NamespaceURI => null;

		/// <summary>Gets the namespace prefix associated with the current node.</summary>
		/// <returns>The namespace prefix associated with the current node.</returns>
		public override string Prefix => null;

		/// <summary>Gets the text value of the current node.</summary>
		/// <returns>The value returned depends on the <see cref="P:System.Xml.XmlTextReader.NodeType" /> of the node. The following table lists node types that have a value to return. All other node types return String.Empty.Node Type Value AttributeThe value of the attribute. CDATAThe content of the CDATA section. CommentThe content of the comment. DocumentTypeThe internal subset. ProcessingInstructionThe entire content, excluding the target. SignificantWhitespaceThe white space within an xml:space= 'preserve' scope. TextThe content of the text node. WhitespaceThe white space between markup. XmlDeclarationThe content of the declaration. </returns>
		public override string Value => null;

		/// <summary>Gets the depth of the current node in the XML document.</summary>
		/// <returns>The depth of the current node in the XML document.</returns>
		public override int Depth => 0;

		/// <summary>Gets the base URI of the current node.</summary>
		/// <returns>The base URI of the current node.</returns>
		public override string BaseURI => null;

		/// <summary>Gets a value indicating whether the current node is an empty element (for example, &lt;MyElement/&gt;).</summary>
		/// <returns>true if the current node is an element (<see cref="P:System.Xml.XmlTextReader.NodeType" /> equals XmlNodeType.Element) that ends with /&gt;; otherwise, false.</returns>
		public override bool IsEmptyElement => false;

		/// <summary>Gets a value indicating whether the current node is an attribute that was generated from the default value defined in the DTD or schema.</summary>
		/// <returns>This property always returns false. (<see cref="T:System.Xml.XmlTextReader" /> does not expand default attributes.) </returns>
		public override bool IsDefault => false;

		/// <summary>Gets the quotation mark character used to enclose the value of an attribute node.</summary>
		/// <returns>The quotation mark character (" or ') used to enclose the value of an attribute node.</returns>
		public override char QuoteChar => '\0';

		/// <summary>Gets the current xml:space scope.</summary>
		/// <returns>One of the <see cref="T:System.Xml.XmlSpace" /> values. If no xml:space scope exists, this property defaults to XmlSpace.None.</returns>
		public override XmlSpace XmlSpace => default(XmlSpace);

		/// <summary>Gets the current xml:lang scope.</summary>
		/// <returns>The current xml:lang scope.</returns>
		public override string XmlLang => null;

		/// <summary>Gets the number of attributes on the current node.</summary>
		/// <returns>The number of attributes on the current node.</returns>
		public override int AttributeCount => 0;

		/// <summary>Gets a value indicating whether the reader is positioned at the end of the stream.</summary>
		/// <returns>true if the reader is positioned at the end of the stream; otherwise, false.</returns>
		public override bool EOF => false;

		/// <summary>Gets the state of the reader.</summary>
		/// <returns>One of the <see cref="T:System.Xml.ReadState" /> values.</returns>
		public override ReadState ReadState => default(ReadState);

		/// <summary>Gets the <see cref="T:System.Xml.XmlNameTable" /> associated with this implementation.</summary>
		/// <returns>The XmlNameTable enabling you to get the atomized version of a string within the node.</returns>
		public override XmlNameTable NameTable => null;

		/// <summary>Gets a value indicating whether this reader can parse and resolve entities.</summary>
		/// <returns>true if the reader can parse and resolve entities; otherwise, false. The XmlTextReader class always returns true.</returns>
		public override bool CanResolveEntity => false;

		/// <summary>Gets a value indicating whether the <see cref="T:System.Xml.XmlTextReader" /> implements the <see cref="M:System.Xml.XmlReader.ReadValueChunk(System.Char[],System.Int32,System.Int32)" /> method.</summary>
		/// <returns>true if the <see cref="T:System.Xml.XmlTextReader" /> implements the <see cref="M:System.Xml.XmlReader.ReadValueChunk(System.Char[],System.Int32,System.Int32)" /> method; otherwise false. The <see cref="T:System.Xml.XmlTextReader" /> class always returns false.</returns>
		public override bool CanReadValueChunk => false;

		/// <summary>Gets the current line number.</summary>
		/// <returns>The current line number.</returns>
		public int LineNumber => 0;

		/// <summary>Gets the current line position.</summary>
		/// <returns>The current line position.</returns>
		public int LinePosition => 0;

		/// <summary>Gets or sets a value indicating whether to do namespace support.</summary>
		/// <returns>true to do namespace support; otherwise, false. The default is true.</returns>
		/// <exception cref="T:System.InvalidOperationException">Setting this property after a read operation has occurred (<see cref="P:System.Xml.XmlTextReader.ReadState" /> is not ReadState.Initial). </exception>
		public bool Namespaces => false;

		/// <summary>Gets or sets a value indicating whether to normalize white space and attribute values.</summary>
		/// <returns>true to normalize; otherwise, false. The default is false.</returns>
		/// <exception cref="T:System.InvalidOperationException">Setting this property when the reader is closed (<see cref="P:System.Xml.XmlTextReader.ReadState" /> is ReadState.Closed). </exception>
		public bool Normalization
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets a value that specifies how white space is handled.</summary>
		/// <returns>One of the <see cref="T:System.Xml.WhitespaceHandling" /> values. The default is WhitespaceHandling.All (returns Whitespace and SignificantWhitespace nodes).</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Invalid value specified. </exception>
		/// <exception cref="T:System.InvalidOperationException">Setting this property when the reader is closed (<see cref="P:System.Xml.XmlTextReader.ReadState" /> is ReadState.Closed). </exception>
		public WhitespaceHandling WhitespaceHandling
		{
			set
			{
			}
		}

		/// <summary>Gets or sets a value that specifies how the reader handles entities.</summary>
		/// <returns>One of the <see cref="T:System.Xml.EntityHandling" /> values. If no EntityHandling is specified, it defaults to EntityHandling.ExpandCharEntities.</returns>
		public EntityHandling EntityHandling
		{
			set
			{
			}
		}

		/// <summary>Sets the <see cref="T:System.Xml.XmlResolver" /> used for resolving DTD references.</summary>
		/// <returns>The XmlResolver to use. If set to null, external resources are not resolved.In version 1.1 of the .NET Framework, the caller must be fully trusted in order to specify an XmlResolver.</returns>
		public XmlResolver XmlResolver
		{
			set
			{
			}
		}

		internal XmlTextReaderImpl Impl => null;

		internal override XmlNamespaceManager NamespaceManager => null;

		internal bool XmlValidatingReaderCompatibilityMode
		{
			set
			{
			}
		}

		internal override IDtdInfo DtdInfo => null;

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlTextReader" /> class with the specified stream.</summary>
		/// <param name="input">The stream containing the XML data to read. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="input" /> is null. </exception>
		public XmlTextReader(Stream input)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlTextReader" /> class with the specified URL, stream and <see cref="T:System.Xml.XmlNameTable" />.</summary>
		/// <param name="url">The URL to use for resolving external resources. The <see cref="P:System.Xml.XmlTextReader.BaseURI" /> is set to this value. If <paramref name="url" /> is null, BaseURI is set to String.Empty. </param>
		/// <param name="input">The stream containing the XML data to read. </param>
		/// <param name="nt">The XmlNameTable to use. </param>
		/// <exception cref="T:System.NullReferenceException">The <paramref name="input" /> or <paramref name="nt" /> value is null. </exception>
		public XmlTextReader(string url, Stream input, XmlNameTable nt)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlTextReader" /> class with the specified <see cref="T:System.IO.TextReader" />.</summary>
		/// <param name="input">The TextReader containing the XML data to read. </param>
		public XmlTextReader(TextReader input)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlTextReader" /> class with the specified <see cref="T:System.IO.TextReader" /> and <see cref="T:System.Xml.XmlNameTable" />.</summary>
		/// <param name="input">The TextReader containing the XML data to read. </param>
		/// <param name="nt">The XmlNameTable to use. </param>
		/// <exception cref="T:System.NullReferenceException">The <paramref name="nt" /> value is null. </exception>
		public XmlTextReader(TextReader input, XmlNameTable nt)
		{
		}

		/// <summary>Gets the value of the attribute with the specified name.</summary>
		/// <returns>The value of the specified attribute. If the attribute is not found, null is returned.</returns>
		/// <param name="name">The qualified name of the attribute. </param>
		public override string GetAttribute(string name)
		{
			return null;
		}

		/// <summary>Gets the value of the attribute with the specified local name and namespace URI.</summary>
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
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="i" /> parameter is less than 0 or greater than or equal to <see cref="P:System.Xml.XmlTextReader.AttributeCount" />. </exception>
		public override string GetAttribute(int i)
		{
			return null;
		}

		/// <summary>Moves to the attribute with the specified name.</summary>
		/// <returns>true if the attribute is found; otherwise, false. If false, the reader's position does not change.</returns>
		/// <param name="name">The qualified name of the attribute. </param>
		public override bool MoveToAttribute(string name)
		{
			return false;
		}

		/// <summary>Moves to the attribute with the specified index.</summary>
		/// <param name="i">The index of the attribute. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="i" /> parameter is less than 0 or greater than or equal to <see cref="P:System.Xml.XmlReader.AttributeCount" />. </exception>
		public override void MoveToAttribute(int i)
		{
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
		/// <exception cref="T:System.Xml.XmlException">An error occurred while parsing the XML. </exception>
		public override bool Read()
		{
			return false;
		}

		/// <summary>Changes the <see cref="P:System.Xml.XmlReader.ReadState" /> to Closed.</summary>
		public override void Close()
		{
		}

		/// <summary>Skips the children of the current node.</summary>
		public override void Skip()
		{
		}

		/// <summary>Resolves a namespace prefix in the current element's scope.</summary>
		/// <returns>The namespace URI to which the prefix maps or null if no matching prefix is found.</returns>
		/// <param name="prefix">The prefix whose namespace URI you want to resolve. To match the default namespace, pass an empty string. This string does not have to be atomized. </param>
		/// <exception cref="T:System.ArgumentNullException">The <see cref="P:System.Xml.XmlTextReader.Namespaces" /> property is set to true and the <paramref name="prefix" /> value is null. </exception>
		public override string LookupNamespace(string prefix)
		{
			return null;
		}

		/// <summary>Resolves the entity reference for EntityReference nodes.</summary>
		public override void ResolveEntity()
		{
		}

		/// <summary>Reads the contents of an element or a text node as a string.</summary>
		/// <returns>The contents of the element or text node. This can be an empty string if the reader is positioned on something other than an element or text node, or if there is no more text content to return in the current context.Note: The text node can be either an element or an attribute text node.</returns>
		/// <exception cref="T:System.Xml.XmlException">An error occurred while parsing the XML. </exception>
		/// <exception cref="T:System.InvalidOperationException">An invalid operation was attempted. </exception>
		public override string ReadString()
		{
			return null;
		}

		/// <summary>Gets a value indicating whether the class can return line information.</summary>
		/// <returns>true if the class can return line information; otherwise, false.</returns>
		public bool HasLineInfo()
		{
			return false;
		}

		/// <summary>For a description of this member, see <see cref="M:System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope)" />.</summary>
		/// <returns>An <see cref="T:System.Collections.IDictionary" /> that contains the current in-scope namespaces.</returns>
		/// <param name="scope">An <see cref="T:System.Xml.XmlNamespaceScope" /> value that specifies the type of namespace nodes to return.</param>
		IDictionary<string, string> IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope)
		{
			return null;
		}

		/// <summary>For a description of this member, see <see cref="M:System.Xml.IXmlNamespaceResolver.LookupNamespace(System.String)" />.</summary>
		/// <returns>The namespace URI that is mapped to the prefix; null if the prefix is not mapped to a namespace URI.</returns>
		/// <param name="prefix">The prefix whose namespace URI you wish to find.</param>
		string IXmlNamespaceResolver.LookupNamespace(string prefix)
		{
			return null;
		}

		/// <summary>For a description of this member, see <see cref="M:System.Xml.IXmlNamespaceResolver.LookupPrefix(System.String)" />.</summary>
		/// <returns>The prefix that is mapped to the namespace URI; null if the namespace URI is not mapped to a prefix.</returns>
		/// <param name="namespaceName">The namespace URI whose prefix you wish to find.</param>
		string IXmlNamespaceResolver.LookupPrefix(string namespaceName)
		{
			return null;
		}
	}
}
