using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>Represents the choice element (compositor) from the XML Schema as specified by the World Wide Web Consortium (W3C). The choice allows only one of its children to appear in an instance. </summary>
	public class XmlSchemaChoice : XmlSchemaGroupBase
	{
		private XmlSchemaObjectCollection items;

		/// <summary>Gets the collection of the elements contained with the compositor (choice): XmlSchemaElement, XmlSchemaGroupRef, XmlSchemaChoice, XmlSchemaSequence, or XmlSchemaAny.</summary>
		/// <returns>The collection of elements contained within XmlSchemaChoice.</returns>
		[XmlElement("element", typeof(XmlSchemaElement))]
		[XmlElement("sequence", typeof(XmlSchemaSequence))]
		[XmlElement("any", typeof(XmlSchemaAny))]
		[XmlElement("choice", typeof(XmlSchemaChoice))]
		[XmlElement("group", typeof(XmlSchemaGroupRef))]
		public override XmlSchemaObjectCollection Items => null;

		internal override bool IsEmpty => false;

		internal override void SetItems(XmlSchemaObjectCollection newItems)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaChoice" /> class.</summary>
		public XmlSchemaChoice()
		{
		}
	}
}
