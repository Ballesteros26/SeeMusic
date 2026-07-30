using System.Collections;
using System.Xml.Schema;

namespace System.Xml
{
	/// <summary>Represents an XML document.</summary>
	public class XmlDocument : XmlNode
	{
		private XmlImplementation implementation;

		private DomNameTable domNameTable;

		private XmlLinkedNode lastChild;

		private XmlNamedNodeMap entities;

		private Hashtable htElementIdMap;

		private Hashtable htElementIDAttrDecl;

		private SchemaInfo schemaInfo;

		private XmlSchemaSet schemas;

		private bool reportValidity;

		private bool actualLoadingStatus;

		private XmlNodeChangedEventHandler onNodeInsertingDelegate;

		private XmlNodeChangedEventHandler onNodeInsertedDelegate;

		private XmlNodeChangedEventHandler onNodeRemovingDelegate;

		private XmlNodeChangedEventHandler onNodeRemovedDelegate;

		private XmlNodeChangedEventHandler onNodeChangingDelegate;

		private XmlNodeChangedEventHandler onNodeChangedDelegate;

		internal bool fEntRefNodesPresent;

		internal bool fCDataNodesPresent;

		private bool preserveWhitespace;

		private bool isLoading;

		internal string strDocumentName;

		internal string strDocumentFragmentName;

		internal string strCommentName;

		internal string strTextName;

		internal string strCDataSectionName;

		internal string strEntityName;

		internal string strID;

		internal string strXmlns;

		internal string strXml;

		internal string strSpace;

		internal string strLang;

		internal string strEmpty;

		internal string strNonSignificantWhitespaceName;

		internal string strSignificantWhitespaceName;

		internal string strReservedXmlns;

		internal string strReservedXml;

		internal string baseURI;

		private XmlResolver resolver;

		internal bool bSetResolver;

		internal object objLock;

		internal static EmptyEnumerator EmptyEnumerator;

		internal static IXmlSchemaInfo NotKnownSchemaInfo;

		internal static IXmlSchemaInfo ValidSchemaInfo;

		internal static IXmlSchemaInfo InvalidSchemaInfo;

		internal SchemaInfo DtdSchemaInfo
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Gets the type of the current node.</summary>
		/// <returns>The node type. For XmlDocument nodes, this value is XmlNodeType.Document.</returns>
		public override XmlNodeType NodeType => default(XmlNodeType);

		/// <summary>Gets the parent node of this node (for nodes that can have parents).</summary>
		/// <returns>Always returns null.</returns>
		public override XmlNode ParentNode => null;

		/// <summary>Gets the node containing the DOCTYPE declaration.</summary>
		/// <returns>The <see cref="T:System.Xml.XmlNode" /> containing the DocumentType (DOCTYPE declaration).</returns>
		public virtual XmlDocumentType DocumentType => null;

		internal virtual XmlDeclaration Declaration => null;

		/// <summary>Gets the <see cref="T:System.Xml.XmlImplementation" /> object for the current document.</summary>
		/// <returns>The XmlImplementation object for the current document.</returns>
		public XmlImplementation Implementation => null;

		/// <summary>Gets the qualified name of the node.</summary>
		/// <returns>For XmlDocument nodes, the name is #document.</returns>
		public override string Name => null;

		/// <summary>Gets the local name of the node.</summary>
		/// <returns>For XmlDocument nodes, the local name is #document.</returns>
		public override string LocalName => null;

		/// <summary>Gets the root <see cref="T:System.Xml.XmlElement" /> for the document.</summary>
		/// <returns>The XmlElement that represents the root of the XML document tree. If no root exists, null is returned.</returns>
		public XmlElement DocumentElement => null;

		internal override bool IsContainer => false;

		internal override XmlLinkedNode LastNode
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Gets the <see cref="T:System.Xml.XmlDocument" /> to which the current node belongs.</summary>
		/// <returns>For XmlDocument nodes (<see cref="P:System.Xml.XmlDocument.NodeType" /> equals XmlNodeType.Document), this property always returns null.</returns>
		public override XmlDocument OwnerDocument => null;

		/// <summary>Gets or sets the <see cref="T:System.Xml.Schema.XmlSchemaSet" /> object associated with this <see cref="T:System.Xml.XmlDocument" />.</summary>
		/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaSet" /> object containing the XML Schema Definition Language (XSD) schemas associated with this <see cref="T:System.Xml.XmlDocument" />; otherwise, an empty <see cref="T:System.Xml.Schema.XmlSchemaSet" /> object.</returns>
		public XmlSchemaSet Schemas
		{
			set
			{
			}
		}

		internal bool CanReportValidity => false;

		internal bool HasSetResolver => false;

		/// <summary>Sets the <see cref="T:System.Xml.XmlResolver" /> to use for resolving external resources.</summary>
		/// <returns>The XmlResolver to use.In version 1.1 of the.NET Framework, the caller must be fully trusted in order to specify an XmlResolver.</returns>
		/// <exception cref="T:System.Xml.XmlException">This property is set to null and an external DTD or entity is encountered. </exception>
		public virtual XmlResolver XmlResolver
		{
			set
			{
			}
		}

		/// <summary>Gets the <see cref="T:System.Xml.XmlNameTable" /> associated with this implementation.</summary>
		/// <returns>An XmlNameTable enabling you to get the atomized version of a string within the document.</returns>
		public XmlNameTable NameTable => null;

		/// <summary>Gets a value indicating whether the current node is read-only.</summary>
		/// <returns>true if the current node is read-only; otherwise false. XmlDocument nodes always return false.</returns>
		public override bool IsReadOnly => false;

		internal XmlNamedNodeMap Entities
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsLoading
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal bool ActualLoadingStatus => false;

		/// <summary>Gets the concatenated values of the node and all its child nodes.</summary>
		/// <returns>The concatenated values of the node and all its child nodes.</returns>
		/// <exception cref="T:System.InvalidOperationException">Setting the value on the <see cref="P:System.Xml.XmlDocument.InnerText" /> property is not allowed.</exception>
		public override string InnerText
		{
			set
			{
			}
		}

		/// <summary>Gets or sets the markup representing the children of the current node.</summary>
		/// <returns>The markup of the children of the current node.</returns>
		/// <exception cref="T:System.Xml.XmlException">The XML specified when setting this property is not well-formed. </exception>
		public override string InnerXml
		{
			set
			{
			}
		}

		internal string Version => null;

		internal string Encoding => null;

		internal string Standalone => null;

		/// <summary>Returns the Post-Schema-Validation-Infoset (PSVI) of the node.</summary>
		/// <returns>The <see cref="T:System.Xml.Schema.IXmlSchemaInfo" /> object representing the PSVI of the node.</returns>
		public override IXmlSchemaInfo SchemaInfo => null;

		/// <summary>Gets the base URI of the current node.</summary>
		/// <returns>The location from which the node was loaded.</returns>
		public override string BaseURI => null;

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlDocument" /> class.</summary>
		public XmlDocument()
		{
		}

		/// <summary>Initializes a new instance of the XmlDocument class with the specified <see cref="T:System.Xml.XmlNameTable" />.</summary>
		/// <param name="nt">The XmlNameTable to use. </param>
		public XmlDocument(XmlNameTable nt)
		{
		}

		/// <summary>Initializes a new instance of the XmlDocument class with the specified <see cref="T:System.Xml.XmlImplementation" />.</summary>
		/// <param name="imp">The XmlImplementation to use. </param>
		protected internal XmlDocument(XmlImplementation imp)
		{
		}

		internal static void CheckName(string name)
		{
		}

		internal XmlName AddXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo)
		{
			return null;
		}

		internal XmlName GetXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo)
		{
			return null;
		}

		internal XmlName AddAttrXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo)
		{
			return null;
		}

		internal bool AddIdInfo(XmlName eleName, XmlName attrName)
		{
			return false;
		}

		private XmlName GetIDInfoByElement_(XmlName eleName)
		{
			return null;
		}

		internal XmlName GetIDInfoByElement(XmlName eleName)
		{
			return null;
		}

		private WeakReference GetElement(ArrayList elementList, XmlElement elem)
		{
			return null;
		}

		internal void AddElementWithId(string id, XmlElement elem)
		{
		}

		internal void RemoveElementWithId(string id, XmlElement elem)
		{
		}

		/// <summary>Creates a duplicate of this node.</summary>
		/// <returns>The cloned XmlDocument node.</returns>
		/// <param name="deep">true to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
		public override XmlNode CloneNode(bool deep)
		{
			return null;
		}

		internal XmlResolver GetResolver()
		{
			return null;
		}

		internal override bool IsValidChildType(XmlNodeType type)
		{
			return false;
		}

		private bool HasNodeTypeInPrevSiblings(XmlNodeType nt, XmlNode refNode)
		{
			return false;
		}

		private bool HasNodeTypeInNextSiblings(XmlNodeType nt, XmlNode refNode)
		{
			return false;
		}

		internal override bool CanInsertBefore(XmlNode newChild, XmlNode refChild)
		{
			return false;
		}

		internal override bool CanInsertAfter(XmlNode newChild, XmlNode refChild)
		{
			return false;
		}

		/// <summary>Creates an <see cref="T:System.Xml.XmlAttribute" /> with the specified <see cref="P:System.Xml.XmlDocument.Name" />.</summary>
		/// <returns>The new XmlAttribute.</returns>
		/// <param name="name">The qualified name of the attribute. If the name contains a colon, the <see cref="P:System.Xml.XmlNode.Prefix" /> property reflects the part of the name preceding the first colon and the <see cref="P:System.Xml.XmlDocument.LocalName" /> property reflects the part of the name following the first colon. The <see cref="P:System.Xml.XmlNode.NamespaceURI" /> remains empty unless the prefix is a recognized built-in prefix such as xmlns. In this case NamespaceURI has a value of http://www.w3.org/2000/xmlns/. </param>
		public XmlAttribute CreateAttribute(string name)
		{
			return null;
		}

		internal void SetDefaultNamespace(string prefix, string localName, ref string namespaceURI)
		{
		}

		/// <summary>Creates an <see cref="T:System.Xml.XmlCDataSection" /> containing the specified data.</summary>
		/// <returns>The new XmlCDataSection.</returns>
		/// <param name="data">The content of the new XmlCDataSection. </param>
		public virtual XmlCDataSection CreateCDataSection(string data)
		{
			return null;
		}

		/// <summary>Creates an <see cref="T:System.Xml.XmlComment" /> containing the specified data.</summary>
		/// <returns>The new XmlComment.</returns>
		/// <param name="data">The content of the new XmlComment. </param>
		public virtual XmlComment CreateComment(string data)
		{
			return null;
		}

		/// <summary>Returns a new <see cref="T:System.Xml.XmlDocumentType" /> object.</summary>
		/// <returns>The new XmlDocumentType.</returns>
		/// <param name="name">Name of the document type. </param>
		/// <param name="publicId">The public identifier of the document type or null. You can specify a public URI and also a system identifier to identify the location of the external DTD subset.</param>
		/// <param name="systemId">The system identifier of the document type or null. Specifies the URL of the file location for the external DTD subset.</param>
		/// <param name="internalSubset">The DTD internal subset of the document type or null. </param>
		public virtual XmlDocumentType CreateDocumentType(string name, string publicId, string systemId, string internalSubset)
		{
			return null;
		}

		/// <summary>Creates an <see cref="T:System.Xml.XmlDocumentFragment" />.</summary>
		/// <returns>The new XmlDocumentFragment.</returns>
		public virtual XmlDocumentFragment CreateDocumentFragment()
		{
			return null;
		}

		/// <summary>Creates an element with the specified name.</summary>
		/// <returns>The new XmlElement.</returns>
		/// <param name="name">The qualified name of the element. If the name contains a colon then the <see cref="P:System.Xml.XmlNode.Prefix" /> property reflects the part of the name preceding the colon and the <see cref="P:System.Xml.XmlDocument.LocalName" /> property reflects the part of the name after the colon. The qualified name cannot include a prefix of'xmlns'. </param>
		public XmlElement CreateElement(string name)
		{
			return null;
		}

		internal void AddDefaultAttributes(XmlElement elem)
		{
		}

		private SchemaElementDecl GetSchemaElementDecl(XmlElement elem)
		{
			return null;
		}

		private XmlAttribute PrepareDefaultAttribute(SchemaAttDef attdef, string attrPrefix, string attrLocalname, string attrNamespaceURI)
		{
			return null;
		}

		/// <summary>Creates an <see cref="T:System.Xml.XmlEntityReference" /> with the specified name.</summary>
		/// <returns>The new XmlEntityReference.</returns>
		/// <param name="name">The name of the entity reference. </param>
		/// <exception cref="T:System.ArgumentException">The name is invalid (for example, names starting with'#' are invalid.) </exception>
		public virtual XmlEntityReference CreateEntityReference(string name)
		{
			return null;
		}

		/// <summary>Creates an <see cref="T:System.Xml.XmlProcessingInstruction" /> with the specified name and data.</summary>
		/// <returns>The new XmlProcessingInstruction.</returns>
		/// <param name="target">The name of the processing instruction. </param>
		/// <param name="data">The data for the processing instruction. </param>
		public virtual XmlProcessingInstruction CreateProcessingInstruction(string target, string data)
		{
			return null;
		}

		/// <summary>Creates an <see cref="T:System.Xml.XmlDeclaration" /> node with the specified values.</summary>
		/// <returns>The new XmlDeclaration node.</returns>
		/// <param name="version">The version must be "1.0". </param>
		/// <param name="encoding">The value of the encoding attribute. This is the encoding that is used when you save the <see cref="T:System.Xml.XmlDocument" /> to a file or a stream; therefore, it must be set to a string supported by the <see cref="T:System.Text.Encoding" /> class, otherwise <see cref="M:System.Xml.XmlDocument.Save(System.String)" /> fails. If this is null or String.Empty, the Save method does not write an encoding attribute on the XML declaration and therefore the default encoding, UTF-8, is used.Note: If the XmlDocument is saved to either a <see cref="T:System.IO.TextWriter" /> or an <see cref="T:System.Xml.XmlTextWriter" />, this encoding value is discarded. Instead, the encoding of the TextWriter or the XmlTextWriter is used. This ensures that the XML written out can be read back using the correct encoding. </param>
		/// <param name="standalone">The value must be either "yes" or "no". If this is null or String.Empty, the Save method does not write a standalone attribute on the XML declaration. </param>
		/// <exception cref="T:System.ArgumentException">The values of <paramref name="version" /> or <paramref name="standalone" /> are something other than the ones specified above. </exception>
		public virtual XmlDeclaration CreateXmlDeclaration(string version, string encoding, string standalone)
		{
			return null;
		}

		/// <summary>Creates an <see cref="T:System.Xml.XmlText" /> with the specified text.</summary>
		/// <returns>The new XmlText node.</returns>
		/// <param name="text">The text for the Text node. </param>
		public virtual XmlText CreateTextNode(string text)
		{
			return null;
		}

		/// <summary>Creates an <see cref="T:System.Xml.XmlSignificantWhitespace" /> node.</summary>
		/// <returns>A new XmlSignificantWhitespace node.</returns>
		/// <param name="text">The string must contain only the following characters &amp;#20; &amp;#10; &amp;#13; and &amp;#9; </param>
		public virtual XmlSignificantWhitespace CreateSignificantWhitespace(string text)
		{
			return null;
		}

		/// <summary>Creates an <see cref="T:System.Xml.XmlWhitespace" /> node.</summary>
		/// <returns>A new XmlWhitespace node.</returns>
		/// <param name="text">The string must contain only the following characters &amp;#20; &amp;#10; &amp;#13; and &amp;#9; </param>
		public virtual XmlWhitespace CreateWhitespace(string text)
		{
			return null;
		}

		/// <summary>Creates an <see cref="T:System.Xml.XmlAttribute" /> with the specified qualified name and <see cref="P:System.Xml.XmlNode.NamespaceURI" />.</summary>
		/// <returns>The new XmlAttribute.</returns>
		/// <param name="qualifiedName">The qualified name of the attribute. If the name contains a colon then the <see cref="P:System.Xml.XmlNode.Prefix" /> property will reflect the part of the name preceding the colon and the <see cref="P:System.Xml.XmlDocument.LocalName" /> property will reflect the part of the name after the colon. </param>
		/// <param name="namespaceURI">The namespaceURI of the attribute. If the qualified name includes a prefix of xmlns, then this parameter must be http://www.w3.org/2000/xmlns/. </param>
		public XmlAttribute CreateAttribute(string qualifiedName, string namespaceURI)
		{
			return null;
		}

		/// <summary>Creates an <see cref="T:System.Xml.XmlElement" /> with the qualified name and <see cref="P:System.Xml.XmlNode.NamespaceURI" />.</summary>
		/// <returns>The new XmlElement.</returns>
		/// <param name="qualifiedName">The qualified name of the element. If the name contains a colon then the <see cref="P:System.Xml.XmlNode.Prefix" /> property will reflect the part of the name preceding the colon and the <see cref="P:System.Xml.XmlDocument.LocalName" /> property will reflect the part of the name after the colon. The qualified name cannot include a prefix of'xmlns'. </param>
		/// <param name="namespaceURI">The namespace URI of the element. </param>
		public XmlElement CreateElement(string qualifiedName, string namespaceURI)
		{
			return null;
		}

		private XmlNode ImportNodeInternal(XmlNode node, bool deep)
		{
			return null;
		}

		private void ImportAttributes(XmlNode fromElem, XmlNode toElem)
		{
		}

		private void ImportChildren(XmlNode fromNode, XmlNode toNode, bool deep)
		{
		}

		/// <summary>Creates an <see cref="T:System.Xml.XmlAttribute" /> with the specified <see cref="P:System.Xml.XmlNode.Prefix" />, <see cref="P:System.Xml.XmlDocument.LocalName" />, and <see cref="P:System.Xml.XmlNode.NamespaceURI" />.</summary>
		/// <returns>The new XmlAttribute.</returns>
		/// <param name="prefix">The prefix of the attribute (if any). String.Empty and null are equivalent. </param>
		/// <param name="localName">The local name of the attribute. </param>
		/// <param name="namespaceURI">The namespace URI of the attribute (if any). String.Empty and null are equivalent. If <paramref name="prefix" /> is xmlns, then this parameter must be http://www.w3.org/2000/xmlns/; otherwise an exception is thrown. </param>
		public virtual XmlAttribute CreateAttribute(string prefix, string localName, string namespaceURI)
		{
			return null;
		}

		/// <summary>Creates a default attribute with the specified prefix, local name and namespace URI.</summary>
		/// <returns>The new <see cref="T:System.Xml.XmlAttribute" />.</returns>
		/// <param name="prefix">The prefix of the attribute (if any). </param>
		/// <param name="localName">The local name of the attribute. </param>
		/// <param name="namespaceURI">The namespace URI of the attribute (if any). </param>
		protected internal virtual XmlAttribute CreateDefaultAttribute(string prefix, string localName, string namespaceURI)
		{
			return null;
		}

		/// <summary>Creates an element with the specified <see cref="P:System.Xml.XmlNode.Prefix" />, <see cref="P:System.Xml.XmlDocument.LocalName" />, and <see cref="P:System.Xml.XmlNode.NamespaceURI" />.</summary>
		/// <returns>The new <see cref="T:System.Xml.XmlElement" />.</returns>
		/// <param name="prefix">The prefix of the new element (if any). String.Empty and null are equivalent. </param>
		/// <param name="localName">The local name of the new element. </param>
		/// <param name="namespaceURI">The namespace URI of the new element (if any). String.Empty and null are equivalent. </param>
		public virtual XmlElement CreateElement(string prefix, string localName, string namespaceURI)
		{
			return null;
		}

		/// <summary>Creates an <see cref="T:System.Xml.XmlNode" /> object based on the information in the <see cref="T:System.Xml.XmlReader" />. The reader must be positioned on a node or attribute.</summary>
		/// <returns>The new XmlNode or null if no more nodes exist.</returns>
		/// <param name="reader">The XML source </param>
		/// <exception cref="T:System.NullReferenceException">The reader is positioned on a node type that does not translate to a valid DOM node (for example, EndElement or EndEntity). </exception>
		public virtual XmlNode ReadNode(XmlReader reader)
		{
			return null;
		}

		private XmlTextReader SetupReader(XmlTextReader tr)
		{
			return null;
		}

		/// <summary>Loads the XML document from the specified <see cref="T:System.Xml.XmlReader" />.</summary>
		/// <param name="reader">The XmlReader used to feed the XML data into the document. </param>
		/// <exception cref="T:System.Xml.XmlException">There is a load or parse error in the XML. In this case, the document remains empty. </exception>
		public virtual void Load(XmlReader reader)
		{
		}

		/// <summary>Loads the XML document from the specified string.</summary>
		/// <param name="xml">String containing the XML document to load. </param>
		/// <exception cref="T:System.Xml.XmlException">There is a load or parse error in the XML. In this case, the document remains empty. </exception>
		public virtual void LoadXml(string xml)
		{
		}

		/// <summary>Saves the XML document to the specified <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="w">The XmlWriter to which you want to save. </param>
		/// <exception cref="T:System.Xml.XmlException">The operation would not result in a well formed XML document (for example, no document element or duplicate XML declarations). </exception>
		public virtual void Save(XmlWriter w)
		{
		}

		/// <summary>Saves the XmlDocument node to the specified <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="w">The XmlWriter to which you want to save. </param>
		public override void WriteTo(XmlWriter w)
		{
		}

		/// <summary>Saves all the children of the XmlDocument node to the specified <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="xw">The XmlWriter to which you want to save. </param>
		public override void WriteContentTo(XmlWriter xw)
		{
		}

		internal override XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action)
		{
			return null;
		}

		internal XmlNodeChangedEventArgs GetInsertEventArgsForLoad(XmlNode node, XmlNode newParent)
		{
			return null;
		}

		internal override void BeforeEvent(XmlNodeChangedEventArgs args)
		{
		}

		internal override void AfterEvent(XmlNodeChangedEventArgs args)
		{
		}

		internal XmlAttribute GetDefaultAttribute(XmlElement elem, string attrPrefix, string attrLocalname, string attrNamespaceURI)
		{
			return null;
		}

		internal XmlEntity GetEntityNode(string name)
		{
			return null;
		}

		internal void SetBaseURI(string inBaseURI)
		{
		}

		internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc)
		{
			return null;
		}
	}
}
