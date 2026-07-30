namespace System.Xml
{
	/// <summary>Specifies how white space is handled.</summary>
	public enum WhitespaceHandling
	{
		/// <summary>Return Whitespace and SignificantWhitespace nodes. This is the default.</summary>
		All = 0,
		/// <summary>Return SignificantWhitespace nodes only.</summary>
		Significant = 1,
		/// <summary>Return no Whitespace and no SignificantWhitespace nodes.</summary>
		None = 2
	}
}
