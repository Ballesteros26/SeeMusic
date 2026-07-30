using System.Text;

namespace System.Xml.Linq
{
	/// <summary>Represents the abstract concept of a node (element, comment, document type, processing instruction, or text node) in the XML tree.  </summary>
	/// <filterpriority>2</filterpriority>
	public abstract class XNode : XObject
	{
		internal XNode next;

		internal XNode()
		{
		}

		/// <summary>Removes this node from its parent.</summary>
		/// <exception cref="T:System.InvalidOperationException">The parent is null.</exception>
		public void Remove()
		{
		}

		/// <summary>Replaces this node with the specified content.</summary>
		/// <param name="content">Content that replaces this node.</param>
		public void ReplaceWith(object content)
		{
		}

		/// <summary>Replaces this node with the specified content.</summary>
		/// <param name="content">A parameter list of the new content.</param>
		public void ReplaceWith(params object[] content)
		{
		}

		/// <summary>Returns the indented XML for this node.</summary>
		/// <returns>A <see cref="T:System.String" /> containing the indented XML.</returns>
		public override string ToString()
		{
			return null;
		}

		/// <summary>Writes this node to an <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="writer">An <see cref="T:System.Xml.XmlWriter" /> into which this method will write.</param>
		/// <filterpriority>2</filterpriority>
		public abstract void WriteTo(XmlWriter writer);

		internal virtual void AppendText(StringBuilder sb)
		{
		}

		internal abstract XNode CloneNode();

		internal static XmlReaderSettings GetXmlReaderSettings(LoadOptions o)
		{
			return null;
		}

		private string GetXmlString(SaveOptions o)
		{
			return null;
		}
	}
}
