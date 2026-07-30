using System.Collections;
using System.Text;

namespace System.Xml.Serialization
{
	/// <summary>Represents a collection of <see cref="T:System.Xml.Serialization.XmlArrayItemAttribute" /> objects.</summary>
	public class XmlArrayItemAttributes : CollectionBase
	{
		/// <summary>Gets or sets the item at the specified index.</summary>
		/// <returns>The <see cref="T:System.Xml.Serialization.XmlArrayItemAttribute" /> at the specified index.</returns>
		/// <param name="index">The zero-based index of the collection member to get or set. </param>
		public XmlArrayItemAttribute this[int index] => null;

		/// <summary>Adds an <see cref="T:System.Xml.Serialization.XmlArrayItemAttribute" /> to the collection.</summary>
		/// <returns>The index of the added item.</returns>
		/// <param name="attribute">The <see cref="T:System.Xml.Serialization.XmlArrayItemAttribute" /> to add to the collection. </param>
		public int Add(XmlArrayItemAttribute attribute)
		{
			return 0;
		}

		internal void AddKeyHash(StringBuilder sb)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Serialization.XmlArrayItemAttributes" /> class. </summary>
		public XmlArrayItemAttributes()
		{
		}
	}
}
