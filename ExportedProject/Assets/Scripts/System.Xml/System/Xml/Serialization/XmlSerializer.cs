using System.CodeDom.Compiler;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Security.Policy;

namespace System.Xml.Serialization
{
	/// <summary>Serializes and deserializes objects into and from XML documents. The <see cref="T:System.Xml.Serialization.XmlSerializer" /> enables you to control how objects are encoded into XML.</summary>
	public class XmlSerializer
	{
		internal class SerializerData
		{
			public MethodInfo ReaderMethod;

			public Type WriterType;

			public MethodInfo WriterMethod;

			public GenerationBatch Batch;

			public XmlSerializerImplementation Implementation;

			public XmlSerializationWriter CreateWriter()
			{
				return null;
			}
		}

		internal class GenerationBatch
		{
			public XmlMapping[] Maps;

			public SerializerData[] Datas;
		}

		internal const string WsdlNamespace = "http://schemas.xmlsoap.org/wsdl/";

		internal const string EncodingNamespace = "http://schemas.xmlsoap.org/soap/encoding/";

		internal const string WsdlTypesNamespace = "http://microsoft.com/wsdl/types/";

		private static int generationThreshold;

		private static bool backgroundGeneration;

		private static bool deleteTempFiles;

		private static bool generatorFallback;

		private bool customSerializer;

		private XmlMapping typeMapping;

		private SerializerData serializerData;

		private static Hashtable serializerTypes;

		private UnreferencedObjectEventHandler onUnreferencedObject;

		private XmlAttributeEventHandler onUnknownAttribute;

		private XmlElementEventHandler onUnknownElement;

		private XmlNodeEventHandler onUnknownNode;

		internal XmlMapping Mapping => null;

		/// <summary>Occurs when the <see cref="T:System.Xml.Serialization.XmlSerializer" /> encounters an XML attribute of unknown type during deserialization.</summary>
		public event XmlAttributeEventHandler UnknownAttribute
		{
			add
			{
			}
			remove
			{
			}
		}

		/// <summary>Occurs when the <see cref="T:System.Xml.Serialization.XmlSerializer" /> encounters an XML element of unknown type during deserialization.</summary>
		public event XmlElementEventHandler UnknownElement
		{
			add
			{
			}
			remove
			{
			}
		}

		/// <summary>Occurs when the <see cref="T:System.Xml.Serialization.XmlSerializer" /> encounters an XML node of unknown type during deserialization.</summary>
		public event XmlNodeEventHandler UnknownNode
		{
			add
			{
			}
			remove
			{
			}
		}

		/// <summary>Occurs during deserialization of a SOAP-encoded XML stream, when the <see cref="T:System.Xml.Serialization.XmlSerializer" /> encounters a recognized type that is not used or is unreferenced.</summary>
		public event UnreferencedObjectEventHandler UnreferencedObject
		{
			add
			{
			}
			remove
			{
			}
		}

		static XmlSerializer()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Serialization.XmlSerializer" /> class.</summary>
		protected XmlSerializer()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Serialization.XmlSerializer" /> class that can serialize objects of the specified type into XML documents, and deserialize XML documents into objects of the specified type.</summary>
		/// <param name="type">The type of the object that this <see cref="T:System.Xml.Serialization.XmlSerializer" /> can serialize. </param>
		public XmlSerializer(Type type)
		{
		}

		/// <summary>Initializes an instance of the <see cref="T:System.Xml.Serialization.XmlSerializer" /> class using an object that maps one type to another.</summary>
		/// <param name="xmlTypeMapping">An <see cref="T:System.Xml.Serialization.XmlTypeMapping" /> that maps one type to another. </param>
		public XmlSerializer(XmlTypeMapping xmlTypeMapping)
		{
		}

		internal XmlSerializer(XmlMapping mapping, SerializerData data)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Serialization.XmlSerializer" /> class that can serialize objects of the specified type into XML documents, and deserialize XML documents into objects of the specified type. Specifies the default namespace for all the XML elements.</summary>
		/// <param name="type">The type of the object that this <see cref="T:System.Xml.Serialization.XmlSerializer" /> can serialize. </param>
		/// <param name="defaultNamespace">The default namespace to use for all the XML elements. </param>
		public XmlSerializer(Type type, string defaultNamespace)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Serialization.XmlSerializer" /> class that can serialize objects of the specified type into XML documents, and deserialize XML documents into object of a specified type. If a property or field returns an array, the <paramref name="extraTypes" /> parameter specifies objects that can be inserted into the array.</summary>
		/// <param name="type">The type of the object that this <see cref="T:System.Xml.Serialization.XmlSerializer" /> can serialize. </param>
		/// <param name="extraTypes">A <see cref="T:System.Type" /> array of additional object types to serialize. </param>
		public XmlSerializer(Type type, Type[] extraTypes)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Serialization.XmlSerializer" /> class that can serialize objects of type <see cref="T:System.Object" /> into XML document instances, and deserialize XML document instances into objects of type <see cref="T:System.Object" />. Each object to be serialized can itself contain instances of classes, which this overload overrides with other classes. This overload also specifies the default namespace for all the XML elements and the class to use as the XML root element.</summary>
		/// <param name="type">The type of the object that this <see cref="T:System.Xml.Serialization.XmlSerializer" /> can serialize.</param>
		/// <param name="overrides">An <see cref="T:System.Xml.Serialization.XmlAttributeOverrides" /> that extends or overrides the behavior of the class specified in the <paramref name="type" /> parameter.</param>
		/// <param name="extraTypes">A <see cref="T:System.Type" /> array of additional object types to serialize.</param>
		/// <param name="root">An <see cref="T:System.Xml.Serialization.XmlRootAttribute" /> that defines the XML root element properties.</param>
		/// <param name="defaultNamespace">The default namespace of all XML elements in the XML document.</param>
		/// <param name="location">The location of the types.</param>
		public XmlSerializer(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace, string location)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Serialization.XmlSerializer" /> class that can serialize objects of the specified type into XML documents, and deserialize XML documents into objects of the specified type. Each object to be serialized can itself contain instances of classes, which this overload can override with other classes.</summary>
		/// <param name="type">The type of the object to serialize. </param>
		/// <param name="overrides">An <see cref="T:System.Xml.Serialization.XmlAttributeOverrides" />. </param>
		public XmlSerializer(Type type, XmlAttributeOverrides overrides)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Serialization.XmlSerializer" /> class that can serialize objects of the specified type into XML documents, and deserialize an XML document into object of the specified type. It also specifies the class to use as the XML root element.</summary>
		/// <param name="type">The type of the object that this <see cref="T:System.Xml.Serialization.XmlSerializer" /> can serialize. </param>
		/// <param name="root">An <see cref="T:System.Xml.Serialization.XmlRootAttribute" /> that represents the XML root element. </param>
		public XmlSerializer(Type type, XmlRootAttribute root)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Serialization.XmlSerializer" /> class that can serialize objects of type <see cref="T:System.Object" /> into XML document instances, and deserialize XML document instances into objects of type <see cref="T:System.Object" />. Each object to be serialized can itself contain instances of classes, which this overload overrides with other classes. This overload also specifies the default namespace for all the XML elements and the class to use as the XML root element.</summary>
		/// <param name="type">The type of the object that this <see cref="T:System.Xml.Serialization.XmlSerializer" /> can serialize. </param>
		/// <param name="overrides">An <see cref="T:System.Xml.Serialization.XmlAttributeOverrides" /> that extends or overrides the behavior of the class specified in the <paramref name="type" /> parameter. </param>
		/// <param name="extraTypes">A <see cref="T:System.Type" /> array of additional object types to serialize. </param>
		/// <param name="root">An <see cref="T:System.Xml.Serialization.XmlRootAttribute" /> that defines the XML root element properties. </param>
		/// <param name="defaultNamespace">The default namespace of all XML elements in the XML document. </param>
		public XmlSerializer(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Serialization.XmlSerializer" /> class that can serialize objects of the specified type into XML document instances, and deserialize XML document instances into objects of the specified type. This overload allows you to supply other types that can be encountered during a serialization or deserialization operation, as well as a default namespace for all XML elements, the class to use as the XML root element, its location, and credentials required for access.</summary>
		/// <param name="type">The type of the object that this <see cref="T:System.Xml.Serialization.XmlSerializer" /> can serialize.</param>
		/// <param name="overrides">An <see cref="T:System.Xml.Serialization.XmlAttributeOverrides" /> that extends or overrides the behavior of the class specified in the <paramref name="type" /> parameter.</param>
		/// <param name="extraTypes">A <see cref="T:System.Type" /> array of additional object types to serialize.</param>
		/// <param name="root">An <see cref="T:System.Xml.Serialization.XmlRootAttribute" /> that defines the XML root element properties.</param>
		/// <param name="defaultNamespace">The default namespace of all XML elements in the XML document.</param>
		/// <param name="location">The location of the types.</param>
		/// <param name="evidence">An instance of the <see cref="T:System.Security.Policy.Evidence" /> class that contains credentials required to access types.</param>
		[System.MonoTODO]
		public XmlSerializer(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace, string location, Evidence evidence)
		{
		}

		internal virtual void OnUnknownAttribute(XmlAttributeEventArgs e)
		{
		}

		internal virtual void OnUnknownElement(XmlElementEventArgs e)
		{
		}

		internal virtual void OnUnknownNode(XmlNodeEventArgs e)
		{
		}

		internal virtual void OnUnreferencedObject(UnreferencedObjectEventArgs e)
		{
		}

		/// <summary>Gets a value that indicates whether this <see cref="T:System.Xml.Serialization.XmlSerializer" /> can deserialize a specified XML document.</summary>
		/// <returns>true if this <see cref="T:System.Xml.Serialization.XmlSerializer" /> can deserialize the object that the <see cref="T:System.Xml.XmlReader" /> points to; otherwise, false.</returns>
		/// <param name="xmlReader">An <see cref="T:System.Xml.XmlReader" /> that points to the document to deserialize. </param>
		public virtual bool CanDeserialize(XmlReader xmlReader)
		{
			return false;
		}

		/// <summary>Returns an object used to read the XML document to be serialized.</summary>
		/// <returns>An <see cref="T:System.Xml.Serialization.XmlSerializationReader" /> used to read the XML document.</returns>
		/// <exception cref="T:System.NotImplementedException">Any attempt is made to access the method when the method is not overridden in a descendant class. </exception>
		protected virtual XmlSerializationReader CreateReader()
		{
			return null;
		}

		/// <summary>When overridden in a derived class, returns a writer used to serialize the object.</summary>
		/// <returns>An instance that implements the <see cref="T:System.Xml.Serialization.XmlSerializationWriter" /> class.</returns>
		/// <exception cref="T:System.NotImplementedException">Any attempt is made to access the method when the method is not overridden in a descendant class. </exception>
		protected virtual XmlSerializationWriter CreateWriter()
		{
			return null;
		}

		/// <summary>Deserializes the XML document contained by the specified <see cref="T:System.IO.Stream" />.</summary>
		/// <returns>The <see cref="T:System.Object" /> being deserialized.</returns>
		/// <param name="stream">The <see cref="T:System.IO.Stream" /> that contains the XML document to deserialize. </param>
		public object Deserialize(Stream stream)
		{
			return null;
		}

		/// <summary>Deserializes the XML document contained by the specified <see cref="T:System.IO.TextReader" />.</summary>
		/// <returns>The <see cref="T:System.Object" /> being deserialized.</returns>
		/// <param name="textReader">The <see cref="T:System.IO.TextReader" /> that contains the XML document to deserialize. </param>
		/// <exception cref="T:System.InvalidOperationException">An error occurred during deserialization. The original exception is available using the <see cref="P:System.Exception.InnerException" /> property. </exception>
		public object Deserialize(TextReader textReader)
		{
			return null;
		}

		/// <summary>Deserializes the XML document contained by the specified <see cref="T:System.xml.XmlReader" />.</summary>
		/// <returns>The <see cref="T:System.Object" /> being deserialized.</returns>
		/// <param name="xmlReader">The <see cref="T:System.xml.XmlReader" /> that contains the XML document to deserialize. </param>
		/// <exception cref="T:System.InvalidOperationException">An error occurred during deserialization. The original exception is available using the <see cref="P:System.Exception.InnerException" /> property. </exception>
		public object Deserialize(XmlReader xmlReader)
		{
			return null;
		}

		/// <summary>Deserializes the XML document contained by the specified <see cref="T:System.Xml.Serialization.XmlSerializationReader" />.</summary>
		/// <returns>The deserialized object.</returns>
		/// <param name="reader">The <see cref="T:System.Xml.Serialization.XmlSerializationReader" /> that contains the XML document to deserialize. </param>
		/// <exception cref="T:System.NotImplementedException">Any attempt is made to access the method when the method is not overridden in a descendant class. </exception>
		protected virtual object Deserialize(XmlSerializationReader reader)
		{
			return null;
		}

		/// <summary>Returns an array of <see cref="T:System.Xml.Serialization.XmlSerializer" /> objects created from an array of <see cref="T:System.Xml.Serialization.XmlTypeMapping" /> objects.</summary>
		/// <returns>An array of <see cref="T:System.Xml.Serialization.XmlSerializer" /> objects.</returns>
		/// <param name="mappings">An array of <see cref="T:System.Xml.Serialization.XmlTypeMapping" /> that maps one type to another. </param>
		public static XmlSerializer[] FromMappings(XmlMapping[] mappings)
		{
			return null;
		}

		/// <summary>Returns an array of <see cref="T:System.Xml.Serialization.XmlSerializer" /> objects created from an array of types.</summary>
		/// <returns>An array of <see cref="T:System.Xml.Serialization.XmlSerializer" /> objects.</returns>
		/// <param name="types">An array of <see cref="T:System.Type" /> objects. </param>
		public static XmlSerializer[] FromTypes(Type[] types)
		{
			return null;
		}

		/// <summary>Serializes the specified <see cref="T:System.Object" /> and writes the XML document to a file using the specified <see cref="T:System.Xml.Serialization.XmlSerializationWriter" />.</summary>
		/// <param name="o">The <see cref="T:System.Object" /> to serialize. </param>
		/// <param name="writer">The <see cref="T:System.Xml.Serialization.XmlSerializationWriter" /> used to write the XML document. </param>
		/// <exception cref="T:System.NotImplementedException">Any attempt is made to access the method when the method is not overridden in a descendant class. </exception>
		protected virtual void Serialize(object o, XmlSerializationWriter writer)
		{
		}

		/// <summary>Serializes the specified <see cref="T:System.Object" /> and writes the XML document to a file using the specified <see cref="T:System.IO.Stream" />.</summary>
		/// <param name="stream">The <see cref="T:System.IO.Stream" /> used to write the XML document. </param>
		/// <param name="o">The <see cref="T:System.Object" /> to serialize. </param>
		/// <exception cref="T:System.InvalidOperationException">An error occurred during serialization. The original exception is available using the <see cref="P:System.Exception.InnerException" /> property. </exception>
		public void Serialize(Stream stream, object o)
		{
		}

		/// <summary>Serializes the specified <see cref="T:System.Object" /> and writes the XML document to a file using the specified <see cref="T:System.IO.TextWriter" />.</summary>
		/// <param name="textWriter">The <see cref="T:System.IO.TextWriter" /> used to write the XML document. </param>
		/// <param name="o">The <see cref="T:System.Object" /> to serialize. </param>
		public void Serialize(TextWriter textWriter, object o)
		{
		}

		/// <summary>Serializes the specified <see cref="T:System.Object" /> and writes the XML document to a file using the specified <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="xmlWriter">The <see cref="T:System.xml.XmlWriter" /> used to write the XML document. </param>
		/// <param name="o">The <see cref="T:System.Object" /> to serialize. </param>
		/// <exception cref="T:System.InvalidOperationException">An error occurred during serialization. The original exception is available using the <see cref="P:System.Exception.InnerException" /> property. </exception>
		public void Serialize(XmlWriter xmlWriter, object o)
		{
		}

		/// <summary>Serializes the specified <see cref="T:System.Object" /> and writes the XML document to a file using the specified <see cref="T:System.IO.Stream" />that references the specified namespaces.</summary>
		/// <param name="stream">The <see cref="T:System.IO.Stream" /> used to write the XML document. </param>
		/// <param name="o">The <see cref="T:System.Object" /> to serialize. </param>
		/// <param name="namespaces">The <see cref="T:System.Xml.Serialization.XmlSerializerNamespaces" /> referenced by the object. </param>
		/// <exception cref="T:System.InvalidOperationException">An error occurred during serialization. The original exception is available using the <see cref="P:System.Exception.InnerException" /> property. </exception>
		public void Serialize(Stream stream, object o, XmlSerializerNamespaces namespaces)
		{
		}

		/// <summary>Serializes the specified <see cref="T:System.Object" /> and writes the XML document to a file using the specified <see cref="T:System.IO.TextWriter" /> and references the specified namespaces.</summary>
		/// <param name="textWriter">The <see cref="T:System.IO.TextWriter" /> used to write the XML document. </param>
		/// <param name="o">The <see cref="T:System.Object" /> to serialize. </param>
		/// <param name="namespaces">The <see cref="T:System.Xml.Serialization.XmlSerializerNamespaces" /> that contains namespaces for the generated XML document. </param>
		/// <exception cref="T:System.InvalidOperationException">An error occurred during serialization. The original exception is available using the <see cref="P:System.Exception.InnerException" /> property. </exception>
		public void Serialize(TextWriter textWriter, object o, XmlSerializerNamespaces namespaces)
		{
		}

		/// <summary>Serializes the specified <see cref="T:System.Object" /> and writes the XML document to a file using the specified <see cref="T:System.Xml.XmlWriter" /> and references the specified namespaces.</summary>
		/// <param name="xmlWriter">The <see cref="T:System.xml.XmlWriter" /> used to write the XML document. </param>
		/// <param name="o">The <see cref="T:System.Object" /> to serialize. </param>
		/// <param name="namespaces">The <see cref="T:System.Xml.Serialization.XmlSerializerNamespaces" /> referenced by the object. </param>
		/// <exception cref="T:System.InvalidOperationException">An error occurred during serialization. The original exception is available using the <see cref="P:System.Exception.InnerException" /> property. </exception>
		public void Serialize(XmlWriter xmlWriter, object o, XmlSerializerNamespaces namespaces)
		{
		}

		/// <summary>Deserializes the object using the data contained by the specified <see cref="T:System.Xml.XmlReader" />.</summary>
		/// <returns>The object being deserialized.</returns>
		/// <param name="xmlReader">An instance of the <see cref="T:System.Xml.XmlReader" /> class used to read the document.</param>
		/// <param name="encodingStyle">The encoding used.</param>
		/// <param name="events">An instance of the <see cref="T:System.Xml.Serialization.XmlDeserializationEvents" /> class. </param>
		[System.MonoTODO]
		public object Deserialize(XmlReader xmlReader, string encodingStyle, XmlDeserializationEvents events)
		{
			return null;
		}

		/// <summary>Deserializes the XML document contained by the specified <see cref="T:System.xml.XmlReader" /> and encoding style.</summary>
		/// <returns>The deserialized object.</returns>
		/// <param name="xmlReader">The <see cref="T:System.xml.XmlReader" /> that contains the XML document to deserialize. </param>
		/// <param name="encodingStyle">The encoding style of the serialized XML. </param>
		/// <exception cref="T:System.InvalidOperationException">An error occurred during deserialization. The original exception is available using the <see cref="P:System.Exception.InnerException" /> property. </exception>
		[System.MonoTODO]
		public object Deserialize(XmlReader xmlReader, string encodingStyle)
		{
			return null;
		}

		/// <summary>Deserializes an XML document contained by the specified <see cref="T:System.Xml.XmlReader" /> and allows the overriding of events that occur during deserialization.</summary>
		/// <returns>The <see cref="T:System.Object" /> being deserialized.</returns>
		/// <param name="xmlReader">The <see cref="T:System.Xml.XmlReader" /> that contains the document to deserialize.</param>
		/// <param name="events">An instance of the <see cref="T:System.Xml.Serialization.XmlDeserializationEvents" /> class. </param>
		[System.MonoTODO]
		public object Deserialize(XmlReader xmlReader, XmlDeserializationEvents events)
		{
			return null;
		}

		/// <summary>Returns an instance of the <see cref="T:System.Xml.Serialization.XmlSerializer" /> class created from mappings of one XML type to another.</summary>
		/// <returns>An instance of the <see cref="T:System.Xml.Serialization.XmlSerializer" /> class.</returns>
		/// <param name="mappings">An array of <see cref="T:System.Xml.Serialization.XmlMapping" /> objects used to map one type to another.</param>
		/// <param name="evidence">An instance of the <see cref="T:System.Security.Policy.Evidence" /> class that contains host and assembly data presented to the common language runtime policy system.</param>
		[System.MonoTODO]
		public static XmlSerializer[] FromMappings(XmlMapping[] mappings, Evidence evidence)
		{
			return null;
		}

		/// <summary>Returns an instance of the <see cref="T:System.Xml.Serialization.XmlSerializer" /> class from the specified mappings.</summary>
		/// <returns>An instance of the <see cref="T:System.Xml.Serialization.XmlSerializer" /> class.</returns>
		/// <param name="mappings">An array of <see cref="T:System.Xml.Serialization.XmlMapping" /> objects.</param>
		/// <param name="type">The <see cref="T:System.Type" /> of the deserialized object.</param>
		[System.MonoTODO]
		public static XmlSerializer[] FromMappings(XmlMapping[] mappings, Type type)
		{
			return null;
		}

		/// <summary>Returns the name of the assembly that contains one or more versions of the <see cref="T:System.Xml.Serialization.XmlSerializer" /> especially created to serialize or deserialize the specified type.</summary>
		/// <returns>The name of the assembly that contains an <see cref="T:System.Xml.Serialization.XmlSerializer" /> for the type.</returns>
		/// <param name="type">The <see cref="T:System.Type" /> you are deserializing.</param>
		public static string GetXmlSerializerAssemblyName(Type type)
		{
			return null;
		}

		/// <summary>Returns the name of the assembly that contains the serializer for the specified type in the specified namespace.</summary>
		/// <returns>The name of the assembly that contains specially built serializers.</returns>
		/// <param name="type">The <see cref="T:System.Type" /> you are interested in.</param>
		/// <param name="defaultNamespace">The namespace of the type.</param>
		public static string GetXmlSerializerAssemblyName(Type type, string defaultNamespace)
		{
			return null;
		}

		/// <summary>Serializes the specified object and writes the XML document to a file using the specified <see cref="T:System.Xml.XmlWriter" /> and references the specified namespaces and encoding style.</summary>
		/// <param name="xmlWriter">The <see cref="T:System.xml.XmlWriter" /> used to write the XML document. </param>
		/// <param name="o">The object to serialize. </param>
		/// <param name="namespaces">The <see cref="T:System.Xml.Serialization.XmlSerializerNamespaces" /> referenced by the object. </param>
		/// <param name="encodingStyle">The encoding style of the serialized XML. </param>
		/// <exception cref="T:System.InvalidOperationException">An error occurred during serialization. The original exception is available using the <see cref="P:System.Exception.InnerException" /> property. </exception>
		[System.MonoTODO]
		public void Serialize(XmlWriter xmlWriter, object o, XmlSerializerNamespaces namespaces, string encodingStyle)
		{
		}

		/// <summary>Serializes the specified <see cref="T:System.Object" /> and writes the XML document to a file using the specified <see cref="T:System.Xml.XmlWriter" />, XML namespaces, and encoding. </summary>
		/// <param name="xmlWriter">The <see cref="T:System.Xml.XmlWriter" /> used to write the XML document.</param>
		/// <param name="o">The object to serialize.</param>
		/// <param name="namespaces">An instance of the XmlSerializaerNamespaces that contains namespaces and prefixes to use.</param>
		/// <param name="encodingStyle">The encoding used in the document.</param>
		/// <param name="id">For SOAP encoded messages, the base used to generate id attributes. </param>
		[System.MonoNotSupported(null)]
		public void Serialize(XmlWriter xmlWriter, object o, XmlSerializerNamespaces namespaces, string encodingStyle, string id)
		{
		}

		private XmlSerializationWriter CreateWriter(XmlMapping typeMapping)
		{
			return null;
		}

		private XmlSerializationReader CreateReader(XmlMapping typeMapping)
		{
			return null;
		}

		private void CheckGeneratedTypes(XmlMapping typeMapping)
		{
		}

		private void GenerateSerializersAsync(GenerationBatch batch)
		{
		}

		private void RunSerializerGeneration(object obj)
		{
		}

		private GenerationBatch LoadFromSatelliteAssembly(GenerationBatch batch)
		{
			return null;
		}

		/// <summary>Returns an assembly that contains custom-made serializers used to serialize or deserialize the specified type or types, using the specified mappings.</summary>
		/// <returns>An <see cref="T:System.Reflection.Assembly" /> object that contains serializers for the supplied types and mappings.</returns>
		/// <param name="types">A collection of types.</param>
		/// <param name="mappings">A collection of <see cref="T:System.Xml.Serialization.XmlMapping" /> objects used to convert one type to another.</param>
		public static Assembly GenerateSerializer(Type[] types, XmlMapping[] mappings)
		{
			return null;
		}

		/// <summary>Returns an assembly that contains custom-made serializers used to serialize or deserialize the specified type or types, using the specified mappings and compiler settings and options. </summary>
		/// <returns>An <see cref="T:System.Reflection.Assembly" /> that contains special versions of the <see cref="T:System.Xml.Serialization.XmlSerializer" />.</returns>
		/// <param name="types">An array of type <see cref="T:System.Type" /> that contains objects used to serialize and deserialize data.</param>
		/// <param name="mappings">An array of type <see cref="T:System.Xml.Serialization.XmlMapping" /> that maps the XML data to the type data.</param>
		/// <param name="parameters">An instance of the <see cref="T:System.CodeDom.Compiler.CompilerParameters" /> class that represents the parameters used to invoke a compiler.</param>
		public static Assembly GenerateSerializer(Type[] types, XmlMapping[] mappings, CompilerParameters parameters)
		{
			return null;
		}
	}
}
