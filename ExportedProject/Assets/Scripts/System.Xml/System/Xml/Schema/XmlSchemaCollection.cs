using System.Collections;
using System.Threading;

namespace System.Xml.Schema
{
	/// <summary>Contains a cache of XML Schema definition language (XSD) and XML-Data Reduced (XDR) schemas. The <see cref="T:System.Xml.Schema.XmlSchemaCollection" /> class class is obsolete. Use <see cref="T:System.Xml.Schema.XmlSchemaSet" /> instead.</summary>
	[Obsolete("Use System.Xml.Schema.XmlSchemaSet for schema compilation and validation. https://go.microsoft.com/fwlink/?linkid=14202")]
	public sealed class XmlSchemaCollection : ICollection, IEnumerable
	{
		private Hashtable collection;

		private XmlNameTable nameTable;

		private SchemaNames schemaNames;

		private ReaderWriterLock wLock;

		private int timeout;

		private bool isThreadSafe;

		private ValidationEventHandler validationEventHandler;

		private XmlResolver xmlResolver;

		/// <summary>Gets the number of namespaces defined in this collection.</summary>
		/// <returns>The number of namespaces defined in this collection.</returns>
		public int Count => 0;

		/// <summary>Gets the default XmlNameTable used by the XmlSchemaCollection when loading new schemas.</summary>
		/// <returns>An XmlNameTable.</returns>
		public XmlNameTable NameTable => null;

		internal XmlResolver XmlResolver
		{
			set
			{
			}
		}

		/// <summary>Gets the <see cref="T:System.Xml.Schema.XmlSchema" /> associated with the given namespace URI.</summary>
		/// <returns>The XmlSchema associated with the namespace URI; null if there is no loaded schema associated with the given namespace or if the namespace is associated with an XDR schema.</returns>
		/// <param name="ns">The namespace URI associated with the schema you want to return. This will typically be the targetNamespace of the schema. </param>
		public XmlSchema this[string ns] => null;

		/// <summary>For a description of this member, see <see cref="P:System.Xml.Schema.XmlSchemaCollection.System.Collections.ICollection.IsSynchronized" />.</summary>
		/// <returns>Returns true if the collection is synchronized, otherwise false.</returns>
		bool ICollection.IsSynchronized => false;

		/// <summary>For a description of this member, see <see cref="P:System.Xml.Schema.XmlSchemaCollection.System.Collections.ICollection.SyncRoot" />.</summary>
		/// <returns>Returns a <see cref="T:System.Collections.ICollection.SyncRoot" /> object that can be used to synchronize access to the collection.</returns>
		object ICollection.SyncRoot => null;

		/// <summary>For a description of this member, see <see cref="P:System.Xml.Schema.XmlSchemaCollection.Count" />.</summary>
		/// <returns>Returns the count of the items in the collection.</returns>
		int ICollection.Count => 0;

		internal ValidationEventHandler EventHandler
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Initializes a new instance of the XmlSchemaCollection class with the specified <see cref="T:System.Xml.XmlNameTable" />. The XmlNameTable is used when loading schemas.</summary>
		/// <param name="nametable">The XmlNameTable to use. </param>
		public XmlSchemaCollection(XmlNameTable nametable)
		{
		}

		/// <summary>For a description of this member, see <see cref="M:System.Xml.Schema.XmlSchemaCollection.GetEnumerator" />.</summary>
		/// <returns>Returns the <see cref="T:System.Collections.IEnumerator" /> for the collection.</returns>
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		/// <summary>Provides support for the "for each" style iteration over the collection of schemas.</summary>
		/// <returns>An enumerator for iterating over all schemas in the current collection.</returns>
		public XmlSchemaCollectionEnumerator GetEnumerator()
		{
			return null;
		}

		/// <summary>For a description of this member, see <see cref="M:System.Xml.Schema.XmlSchemaCollection.CopyTo(System.Xml.Schema.XmlSchema[],System.Int32)" />.</summary>
		/// <param name="array">The array to copy the objects to. </param>
		/// <param name="index">The index in <paramref name="array" /> where copying will begin. </param>
		void ICollection.CopyTo(Array array, int index)
		{
		}

		internal SchemaInfo GetSchemaInfo(string ns)
		{
			return null;
		}

		internal SchemaNames GetSchemaNames(XmlNameTable nt)
		{
			return null;
		}

		internal XmlSchema Add(string ns, SchemaInfo schemaInfo, XmlSchema schema, bool compile)
		{
			return null;
		}

		private XmlSchema Add(string ns, SchemaInfo schemaInfo, XmlSchema schema, bool compile, XmlResolver resolver)
		{
			return null;
		}

		private void Add(string ns, XmlSchemaCollectionNode node)
		{
		}
	}
}
