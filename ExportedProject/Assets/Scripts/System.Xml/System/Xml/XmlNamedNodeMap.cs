using System.Collections;

namespace System.Xml
{
	/// <summary>Represents a collection of nodes that can be accessed by name or index.</summary>
	public class XmlNamedNodeMap : IEnumerable
	{
		internal struct SmallXmlNodeList
		{
			private class SingleObjectEnumerator : IEnumerator
			{
				private object loneValue;

				private int position;

				public object Current => null;

				public SingleObjectEnumerator(object value)
				{
				}

				public bool MoveNext()
				{
					return false;
				}

				public void Reset()
				{
				}
			}

			private object field;

			public int Count => 0;

			public object this[int index] => null;

			public void Add(object value)
			{
			}

			public void RemoveAt(int index)
			{
			}

			public void Insert(int index, object value)
			{
			}

			public IEnumerator GetEnumerator()
			{
				return null;
			}
		}

		internal XmlNode parent;

		internal SmallXmlNodeList nodes;

		/// <summary>Gets the number of nodes in the XmlNamedNodeMap.</summary>
		/// <returns>The number of nodes.</returns>
		public virtual int Count => 0;

		internal XmlNamedNodeMap(XmlNode parent)
		{
		}

		/// <summary>Retrieves an <see cref="T:System.Xml.XmlNode" /> specified by name.</summary>
		/// <returns>An XmlNode with the specified name or null if a matching node is not found.</returns>
		/// <param name="name">The qualified name of the node to retrieve. It is matched against the <see cref="P:System.Xml.XmlNode.Name" /> property of the matching node.</param>
		public virtual XmlNode GetNamedItem(string name)
		{
			return null;
		}

		/// <summary>Adds an <see cref="T:System.Xml.XmlNode" /> using its <see cref="P:System.Xml.XmlNode.Name" /> property.</summary>
		/// <returns>If the <paramref name="node" /> replaces an existing node with the same name, the old node is returned; otherwise, null is returned.</returns>
		/// <param name="node">An XmlNode to store in the XmlNamedNodeMap. If a node with that name is already present in the map, it is replaced by the new one.</param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="node" /> was created from a different <see cref="T:System.Xml.XmlDocument" /> than the one that created the XmlNamedNodeMap; or the XmlNamedNodeMap is read-only.</exception>
		public virtual XmlNode SetNamedItem(XmlNode node)
		{
			return null;
		}

		/// <summary>Provides support for the "foreach" style iteration over the collection of nodes in the XmlNamedNodeMap.</summary>
		/// <returns>An enumerator object.</returns>
		public virtual IEnumerator GetEnumerator()
		{
			return null;
		}

		internal int FindNodeOffset(string name)
		{
			return 0;
		}

		internal int FindNodeOffset(string localName, string namespaceURI)
		{
			return 0;
		}

		internal virtual XmlNode AddNode(XmlNode node)
		{
			return null;
		}

		internal virtual XmlNode AddNodeForLoad(XmlNode node, XmlDocument doc)
		{
			return null;
		}

		internal virtual XmlNode RemoveNodeAt(int i)
		{
			return null;
		}

		internal XmlNode ReplaceNodeAt(int i, XmlNode node)
		{
			return null;
		}

		internal virtual XmlNode InsertNodeAt(int i, XmlNode node)
		{
			return null;
		}
	}
}
