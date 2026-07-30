namespace System.Xml
{
	/// <summary>Represents the text content of an element or attribute.</summary>
	public class XmlText : XmlCharacterData
	{
		/// <summary>Gets the qualified name of the node.</summary>
		/// <returns>For text nodes, this property returns #text.</returns>
		public override string Name => null;

		/// <summary>Gets the local name of the node.</summary>
		/// <returns>For text nodes, this property returns #text.</returns>
		public override string LocalName => null;

		/// <summary>Gets the type of the current node.</summary>
		/// <returns>For text nodes, this value is XmlNodeType.Text.</returns>
		public override XmlNodeType NodeType => default(XmlNodeType);

		public override XmlNode ParentNode => null;

		/// <summary>Gets or sets the value of the node.</summary>
		/// <returns>The content of the text node.</returns>
		public override string Value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal override bool IsText => false;

		internal XmlText(string strData)
			: base(null, null)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlText" /> class.</summary>
		/// <param name="strData">The content of the node; see the <see cref="P:System.Xml.XmlText.Value" /> property.</param>
		/// <param name="doc">The parent XML document.</param>
		protected internal XmlText(string strData, XmlDocument doc)
			: base(null, null)
		{
		}

		/// <summary>Creates a duplicate of this node.</summary>
		/// <returns>The cloned node.</returns>
		/// <param name="deep">true to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
		public override XmlNode CloneNode(bool deep)
		{
			return null;
		}

		/// <summary>Saves the node to the specified <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="w">The XmlWriter to which you want to save. </param>
		public override void WriteTo(XmlWriter w)
		{
		}

		/// <summary>Saves all the children of the node to the specified <see cref="T:System.Xml.XmlWriter" />. XmlText nodes do not have children, so this method has no effect.</summary>
		/// <param name="w">The XmlWriter to which you want to save. </param>
		public override void WriteContentTo(XmlWriter w)
		{
		}
	}
}
