namespace System.Xml.Serialization
{
	/// <summary>Establishes a <see cref="P:System.Xml.Serialization.IXmlTextParser.Normalized" /> property for use by the .NET Framework infrastructure.</summary>
	public interface IXmlTextParser
	{
		/// <summary>Gets or sets whether white space and attribute values are normalized.</summary>
		/// <returns>true if white space attributes values are normalized; otherwise, false.</returns>
		bool Normalized { get; set; }
	}
}
