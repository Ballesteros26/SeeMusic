namespace System.Xml
{
	/// <summary>Represents a CDATA section.</summary>
	public class XmlCDataSection : XmlCharacterData
	{
		/// <summary>Gets the qualified name of the node.</summary>
		/// <returns>For CDATA nodes, the name is #cdata-section.</returns>
		public override string Name => null;

		/// <summary>Gets the local name of the node.</summary>
		/// <returns>For CDATA nodes, the local name is #cdata-section.</returns>
		public override string LocalName => null;

		/// <summary>Gets the type of the current node.</summary>
		/// <returns>The node type. For CDATA nodes, the value is XmlNodeType.CDATA.</returns>
		public override XmlNodeType NodeType => default(XmlNodeType);

		public override XmlNode ParentNode => null;

		internal override bool IsText => false;

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlCDataSection" /> class.</summary>
		/// <param name="data">
		///   <see cref="T:System.String" /> that contains character data.</param>
		/// <param name="doc">
		///   <see cref="T:System.Xml.XmlDocument" /> object.</param>
		protected internal XmlCDataSection(string data, XmlDocument doc)
			: base(null, null)
		{
		}

		/// <summary>Creates a duplicate of this node.</summary>
		/// <returns>The cloned node.</returns>
		/// <param name="deep">true to recursively clone the subtree under the specified node; false to clone only the node itself. Because CDATA nodes do not have children, regardless of the parameter setting, the cloned node will always include the data content. </param>
		public override XmlNode CloneNode(bool deep)
		{
			return null;
		}

		/// <summary>Saves the node to the specified <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="w">The XmlWriter to which you want to save. </param>
		public override void WriteTo(XmlWriter w)
		{
		}

		/// <summary>Saves the children of the node to the specified <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="w">The XmlWriter to which you want to save. </param>
		public override void WriteContentTo(XmlWriter w)
		{
		}
	}
}
