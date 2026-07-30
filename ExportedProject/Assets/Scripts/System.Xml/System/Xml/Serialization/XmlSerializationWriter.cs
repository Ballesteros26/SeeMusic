using System.Collections;
using System.Runtime.Serialization;

namespace System.Xml.Serialization
{
	/// <summary>Represents an abstract class used for controlling serialization by the <see cref="T:System.Xml.Serialization.XmlSerializer" /> class.</summary>
	public abstract class XmlSerializationWriter : XmlSerializationGeneratedCode
	{
		private class WriteCallbackInfo
		{
			public Type Type;

			public string TypeName;

			public string TypeNs;

			public XmlSerializationWriteCallback Callback;
		}

		private ObjectIDGenerator idGenerator;

		private int qnameCount;

		private bool topLevelElement;

		private ArrayList namespaces;

		private XmlWriter writer;

		private Queue referencedElements;

		private Hashtable callbacks;

		private Hashtable serializedObjects;

		/// <summary>Gets or sets the <see cref="T:System.Xml.XmlWriter" /> that is being used by the <see cref="T:System.Xml.Serialization.XmlSerializationWriter" />.</summary>
		/// <returns>The <see cref="T:System.Xml.XmlWriter" /> used by the class instance.</returns>
		protected XmlWriter Writer => null;

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Serialization.XmlSerializationWriter" /> class.</summary>
		protected XmlSerializationWriter()
		{
		}

		internal void Initialize(XmlWriter writer, XmlSerializerNamespaces nss)
		{
		}

		/// <summary>Stores an implementation of the <see cref="T:System.Xml.Serialization.XmlSerializationWriteCallback" /> delegate and the type it applies to, for a later invocation.</summary>
		/// <param name="type">The <see cref="T:System.Type" /> of objects that are serialized.</param>
		/// <param name="typeName">The name of the type of objects that are serialized.</param>
		/// <param name="typeNs">The namespace of the type of objects that are serialized.</param>
		/// <param name="callback">An instance of the <see cref="T:System.Xml.Serialization.XmlSerializationWriteCallback" /> delegate.</param>
		protected void AddWriteCallback(Type type, string typeName, string typeNs, XmlSerializationWriteCallback callback)
		{
		}

		/// <summary>Creates an <see cref="T:System.InvalidOperationException" /> that indicates that an XML element that should adhere to the XML Schema any element declaration cannot be processed.</summary>
		/// <returns>The newly created exception.</returns>
		/// <param name="name">The XML element that cannot be processed.</param>
		/// <param name="ns">The namespace of the XML element.</param>
		protected Exception CreateUnknownAnyElementException(string name, string ns)
		{
			return null;
		}

		/// <summary>Creates an <see cref="T:System.InvalidOperationException" /> that indicates that a type being serialized is not being used in a valid manner or is unexpectedly encountered.</summary>
		/// <returns>The newly created exception.</returns>
		/// <param name="o">The object whose type cannot be serialized.</param>
		protected Exception CreateUnknownTypeException(object o)
		{
			return null;
		}

		/// <summary>Creates an <see cref="T:System.InvalidOperationException" /> that indicates that a type being serialized is not being used in a valid manner or is unexpectedly encountered.</summary>
		/// <returns>The newly created exception.</returns>
		/// <param name="type">The type that cannot be serialized.</param>
		protected Exception CreateUnknownTypeException(Type type)
		{
			return null;
		}

		/// <summary>Returns an XML qualified name, with invalid characters replaced by escape sequences.</summary>
		/// <returns>An XML qualified name, with invalid characters replaced by escape sequences.</returns>
		/// <param name="xmlQualifiedName">An <see cref="T:System.Xml.XmlQualifiedName" /> that represents the XML to be written.</param>
		protected string FromXmlQualifiedName(XmlQualifiedName xmlQualifiedName)
		{
			return null;
		}

		private string GetId(object o, bool addToReferencesList)
		{
			return null;
		}

		private bool AlreadyQueued(object ob)
		{
			return false;
		}

		private string GetNamespacePrefix(string ns)
		{
			return null;
		}

		private string GetQualifiedName(string name, string ns)
		{
			return null;
		}

		/// <summary>Initializes an instances of the <see cref="T:System.Xml.Serialization.XmlSerializationWriteCallback" /> delegate to serialize SOAP-encoded XML data.</summary>
		protected abstract void InitCallbacks();

		/// <summary>Initializes object references only while serializing a SOAP-encoded SOAP message.</summary>
		protected void TopLevelElement()
		{
		}

		/// <summary>Writes an XML attribute.</summary>
		/// <param name="localName">The local name of the XML attribute.</param>
		/// <param name="ns">The namespace of the XML attribute.</param>
		/// <param name="value">The value of the XML attribute as a string.</param>
		protected void WriteAttribute(string localName, string ns, string value)
		{
		}

		/// <summary>Writes an XML attribute where the namespace prefix is provided manually.</summary>
		/// <param name="prefix">The namespace prefix to write.</param>
		/// <param name="localName">The local name of the XML attribute.</param>
		/// <param name="ns">The namespace represented by the prefix.</param>
		/// <param name="value">The value of the XML attribute as a string.</param>
		protected void WriteAttribute(string prefix, string localName, string ns, string value)
		{
		}

		private void WriteXmlNode(XmlNode node)
		{
		}

		/// <summary>Writes an XML node object within the body of a named XML element.</summary>
		/// <param name="node">The XML node to write, possibly a child XML element.</param>
		/// <param name="name">The local name of the parent XML element to write.</param>
		/// <param name="ns">The namespace of the parent XML element to write.</param>
		/// <param name="isNullable">true to write an xsi:nil='true' attribute if the object to serialize is null; otherwise, false.</param>
		/// <param name="any">true to indicate that the node, if an XML element, adheres to an XML Schema any element declaration; otherwise, false.</param>
		protected void WriteElementEncoded(XmlNode node, string name, string ns, bool isNullable, bool any)
		{
		}

		/// <summary>Instructs an <see cref="T:System.Xml.XmlWriter" /> object to write an <see cref="T:System.Xml.XmlNode" /> object within the body of a named XML element.</summary>
		/// <param name="node">The XML node to write, possibly a child XML element.</param>
		/// <param name="name">The local name of the parent XML element to write.</param>
		/// <param name="ns">The namespace of the parent XML element to write.</param>
		/// <param name="isNullable">true to write an xsi:nil='true' attribute if the object to serialize is null; otherwise, false.</param>
		/// <param name="any">true to indicate that the node, if an XML element, adheres to an XML Schema any element declaration; otherwise, false.</param>
		protected void WriteElementLiteral(XmlNode node, string name, string ns, bool isNullable, bool any)
		{
		}

		/// <summary>Writes an XML element with a specified qualified name in its body.</summary>
		/// <param name="localName">The local name of the XML element.</param>
		/// <param name="ns">The namespace of the XML element.</param>
		/// <param name="value">The name to write, using its prefix if namespace-qualified, in the element text.</param>
		protected void WriteElementQualifiedName(string localName, string ns, XmlQualifiedName value)
		{
		}

		/// <summary>Writes an XML element with a specified qualified name in its body.</summary>
		/// <param name="localName">The local name of the XML element.</param>
		/// <param name="ns">The namespace of the XML element.</param>
		/// <param name="value">The name to write, using its prefix if namespace-qualified, in the element text.</param>
		/// <param name="xsiType">The name of the XML Schema data type to be written to the xsi:type attribute.</param>
		protected void WriteElementQualifiedName(string localName, string ns, XmlQualifiedName value, XmlQualifiedName xsiType)
		{
		}

		/// <summary>Writes an XML element with a specified value in its body.</summary>
		/// <param name="localName">The local name of the XML element.</param>
		/// <param name="ns">The namespace of the XML element.</param>
		/// <param name="value">The text value of the XML element.</param>
		protected void WriteElementString(string localName, string ns, string value)
		{
		}

		/// <summary>Writes an XML element with a specified value in its body.</summary>
		/// <param name="localName">The local name of the XML element.</param>
		/// <param name="ns">The namespace of the XML element.</param>
		/// <param name="value">The text value of the XML element.</param>
		/// <param name="xsiType">The name of the XML Schema data type to be written to the xsi:type attribute.</param>
		protected void WriteElementString(string localName, string ns, string value, XmlQualifiedName xsiType)
		{
		}

		/// <summary>Writes a &lt;closing&gt; element tag.</summary>
		protected void WriteEndElement()
		{
		}

		/// <summary>Writes a &lt;closing&gt; element tag.</summary>
		/// <param name="o">The object being serialized.</param>
		protected void WriteEndElement(object o)
		{
		}

		/// <summary>Writes the namespace declaration attributes.</summary>
		/// <param name="xmlns">The XML namespaces to declare.</param>
		protected void WriteNamespaceDeclarations(XmlSerializerNamespaces xmlns)
		{
		}

		/// <summary>Writes an XML element whose body contains a valid XML qualified name. <see cref="T:System.Xml.XmlWriter" /> inserts an xsi:nil='true' attribute if the string's value is null.</summary>
		/// <param name="name">The local name of the XML element to write.</param>
		/// <param name="ns">The namespace of the XML element to write.</param>
		/// <param name="value">The XML qualified name to write in the body of the XML element.</param>
		/// <param name="xsiType">The name of the XML Schema data type to be written to the xsi:type attribute.</param>
		protected void WriteNullableQualifiedNameEncoded(string name, string ns, XmlQualifiedName value, XmlQualifiedName xsiType)
		{
		}

		/// <summary>Writes an XML element whose body contains a valid XML qualified name. <see cref="T:System.Xml.XmlWriter" /> inserts an xsi:nil='true' attribute if the string's value is null.</summary>
		/// <param name="name">The local name of the XML element to write.</param>
		/// <param name="ns">The namespace of the XML element to write.</param>
		/// <param name="value">The XML qualified name to write in the body of the XML element.</param>
		protected void WriteNullableQualifiedNameLiteral(string name, string ns, XmlQualifiedName value)
		{
		}

		/// <summary>Writes an XML element that contains a string as the body. <see cref="T:System.Xml.XmlWriter" /> inserts an xsi:nil='true' attribute if the string's value is null.</summary>
		/// <param name="name">The local name of the XML element to write.</param>
		/// <param name="ns">The namespace of the XML element to write.</param>
		/// <param name="value">The string to write in the body of the XML element.</param>
		/// <param name="xsiType">The name of the XML Schema data type to be written to the xsi:type attribute.</param>
		protected void WriteNullableStringEncoded(string name, string ns, string value, XmlQualifiedName xsiType)
		{
		}

		/// <summary>Writes an XML element that contains a string as the body. <see cref="T:System.Xml.XmlWriter" /> inserts an xsi:nil='true' attribute if the string's value is null.</summary>
		/// <param name="name">The local name of the XML element to write.</param>
		/// <param name="ns">The namespace of the XML element to write.</param>
		/// <param name="value">The string to write in the body of the XML element.</param>
		protected void WriteNullableStringLiteral(string name, string ns, string value)
		{
		}

		/// <summary>Writes an XML element with an xsi:nil='true' attribute.</summary>
		/// <param name="name">The local name of the XML element to write.</param>
		/// <param name="ns">The namespace of the XML element to write.</param>
		protected void WriteNullTagEncoded(string name, string ns)
		{
		}

		/// <summary>Writes an XML element with an xsi:nil='true' attribute.</summary>
		/// <param name="name">The local name of the XML element to write.</param>
		/// <param name="ns">The namespace of the XML element to write.</param>
		protected void WriteNullTagLiteral(string name, string ns)
		{
		}

		/// <summary>Writes a SOAP message XML element that can contain a reference to a multiRef XML element for a given object.</summary>
		/// <param name="n">The local name of the XML element to write.</param>
		/// <param name="ns">The namespace of the XML element to write.</param>
		/// <param name="o">The object being serialized either in the current XML element or a multiRef element that referenced by the current element.</param>
		/// <param name="ambientType">The type stored in the object's type mapping (as opposed to the object's type found directly through the typeof operation).</param>
		/// <param name="suppressReference">true to serialize the object directly into the XML element rather than make the element reference another element that contains the data; otherwise, false.</param>
		/// <param name="isNullable">true to write an xsi:nil='true' attribute if the object to serialize is null; otherwise, false.</param>
		protected void WritePotentiallyReferencingElement(string n, string ns, object o, Type ambientType, bool suppressReference, bool isNullable)
		{
		}

		/// <summary>Serializes objects into SOAP-encoded multiRef XML elements in a SOAP message.</summary>
		protected void WriteReferencedElements()
		{
		}

		private bool IsPrimitiveArray(TypeData td)
		{
			return false;
		}

		private void WriteArray(object o, TypeData td)
		{
		}

		/// <summary>Writes a SOAP message XML element that contains a reference to a multiRef element for a given object.</summary>
		/// <param name="n">The local name of the referencing element being written.</param>
		/// <param name="ns">The namespace of the referencing element being written.</param>
		/// <param name="o">The object being serialized.</param>
		/// <param name="isNullable">true to write an xsi:nil='true' attribute if the object to serialize is null; otherwise, false.</param>
		protected void WriteReferencingElement(string n, string ns, object o, bool isNullable)
		{
		}

		private void CheckReferenceQueue()
		{
		}

		/// <summary>Writes an object that uses custom XML formatting as an XML element.</summary>
		/// <param name="serializable">An object that implements the <see cref="T:System.Xml.Serialization.IXmlSerializable" /> interface that uses custom XML formatting.</param>
		/// <param name="name">The local name of the XML element to write.</param>
		/// <param name="ns">The namespace of the XML element to write.</param>
		/// <param name="isNullable">true to write an xsi:nil='true' attribute if the <see cref="T:System.Xml.Serialization.IXmlSerializable" /> class object is null; otherwise, false.</param>
		protected void WriteSerializable(IXmlSerializable serializable, string name, string ns, bool isNullable)
		{
		}

		/// <summary>Instructs <see cref="T:System.Xml.XmlNode" /> to write an object that uses custom XML formatting as an XML element.</summary>
		/// <param name="serializable">An object that implements the <see cref="T:System.Xml.Serialization.IXmlSerializable" /> interface that uses custom XML formatting.</param>
		/// <param name="name">The local name of the XML element to write.</param>
		/// <param name="ns">The namespace of the XML element to write.</param>
		/// <param name="isNullable">true to write an xsi:nil='true' attribute if the <see cref="T:System.Xml.Serialization.IXmlSerializable" /> object is null; otherwise, false.</param>
		/// <param name="wrapped">true to ignore writing the opening element tag; otherwise, false to write the opening element tag.</param>
		protected void WriteSerializable(IXmlSerializable serializable, string name, string ns, bool isNullable, bool wrapped)
		{
		}

		/// <summary>Writes the XML declaration if the writer is positioned at the start of an XML document.</summary>
		protected void WriteStartDocument()
		{
		}

		/// <summary>Writes an opening element tag, including any attributes.</summary>
		/// <param name="name">The local name of the XML element to write.</param>
		/// <param name="ns">The namespace of the XML element to write.</param>
		protected void WriteStartElement(string name, string ns)
		{
		}

		/// <summary>Writes an opening element tag, including any attributes.</summary>
		/// <param name="name">The local name of the XML element to write.</param>
		/// <param name="ns">The namespace of the XML element to write.</param>
		/// <param name="writePrefixed">true to write the element name with a prefix if none is available for the specified namespace; otherwise, false.</param>
		protected void WriteStartElement(string name, string ns, bool writePrefixed)
		{
		}

		/// <summary>Writes an opening element tag, including any attributes.</summary>
		/// <param name="name">The local name of the XML element to write.</param>
		/// <param name="ns">The namespace of the XML element to write.</param>
		/// <param name="o">The object being serialized as an XML element.</param>
		protected void WriteStartElement(string name, string ns, object o)
		{
		}

		/// <summary>Writes an opening element tag, including any attributes.</summary>
		/// <param name="name">The local name of the XML element to write.</param>
		/// <param name="ns">The namespace of the XML element to write.</param>
		/// <param name="o">The object being serialized as an XML element.</param>
		/// <param name="writePrefixed">true to write the element name with a prefix if none is available for the specified namespace; otherwise, false.</param>
		protected void WriteStartElement(string name, string ns, object o, bool writePrefixed)
		{
		}

		private void WriteStartElement(string name, string ns, object o, bool writePrefixed, ICollection namespaces)
		{
		}

		/// <summary>Writes an XML element whose text body is a value of a simple XML Schema data type.</summary>
		/// <param name="name">The local name of the element to write.</param>
		/// <param name="ns">The namespace of the element to write.</param>
		/// <param name="o">The object to be serialized in the element body.</param>
		/// <param name="xsiType">true if the XML element explicitly specifies the text value's type using the xsi:type attribute; otherwise, false.</param>
		protected void WriteTypedPrimitive(string name, string ns, object o, bool xsiType)
		{
		}

		/// <summary>Writes a specified string value.</summary>
		/// <param name="value">The value of the string to write.</param>
		protected void WriteValue(string value)
		{
		}

		/// <summary>Writes the specified <see cref="T:System.Xml.XmlNode" /> object as an XML attribute.</summary>
		/// <param name="node">The XML node to write.</param>
		/// <param name="container">An <see cref="T:System.Xml.Schema.XmlSchemaObject" /> object (or null) used to generate a qualified name value for an arrayType attribute from the Web Services Description Language (WSDL) namespace ("http://schemas.xmlsoap.org/wsdl/").</param>
		protected void WriteXmlAttribute(XmlNode node, object container)
		{
		}

		/// <summary>Writes an xsi:type attribute for an XML element that is being serialized into a document.</summary>
		/// <param name="name">The local name of an XML Schema data type.</param>
		/// <param name="ns">The namespace of an XML Schema data type.</param>
		protected void WriteXsiType(string name, string ns)
		{
		}
	}
}
