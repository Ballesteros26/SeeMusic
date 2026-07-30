using System.Collections.Generic;

namespace System.Net.Http.Headers
{
	/// <summary>Represents a product token value in a User-Agent header.</summary>
	public class ProductHeaderValue : ICloneable
	{
		/// <summary>Gets the name of the product token.</summary>
		/// <returns>Returns <see cref="T:System.String" />.The name of the product token.</returns>
		public string Name { get; internal set; }

		/// <summary>Gets the version of the product token.</summary>
		/// <returns>Returns <see cref="T:System.String" />.The version of the product token. </returns>
		public string Version { get; internal set; }

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Http.Headers.ProductHeaderValue" /> class.</summary>
		/// <param name="name">The product name.</param>
		public ProductHeaderValue(string name)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Http.Headers.ProductHeaderValue" /> class.</summary>
		/// <param name="name">The product name value.</param>
		/// <param name="version">The product version value.</param>
		public ProductHeaderValue(string name, string version)
		{
		}

		internal ProductHeaderValue()
		{
		}

		/// <summary>Creates a new object that is a copy of the current <see cref="T:System.Net.Http.Headers.ProductHeaderValue" /> instance.</summary>
		/// <returns>Returns <see cref="T:System.Object" />.A copy of the current instance.</returns>
		object ICloneable.Clone()
		{
			return null;
		}

		/// <summary>Determines whether the specified <see cref="T:System.Object" /> is equal to the current <see cref="T:System.Net.Http.Headers.ProductHeaderValue" /> object.</summary>
		/// <returns>Returns <see cref="T:System.Boolean" />.true if the specified <see cref="T:System.Object" /> is equal to the current object; otherwise, false.</returns>
		/// <param name="obj">The object to compare with the current object.</param>
		public override bool Equals(object obj)
		{
			return false;
		}

		/// <summary>Serves as a hash function for an <see cref="T:System.Net.Http.Headers.ProductHeaderValue" /> object.</summary>
		/// <returns>Returns <see cref="T:System.Int32" />.A hash code for the current object.</returns>
		public override int GetHashCode()
		{
			return 0;
		}

		internal static bool TryParse(string input, int minimalCount, out List<ProductHeaderValue> result)
		{
			result = null;
			return false;
		}

		private static bool TryParseElement(Lexer lexer, out ProductHeaderValue parsedValue, out Token t)
		{
			parsedValue = null;
			t = default(Token);
			return false;
		}

		/// <summary>Returns a string that represents the current <see cref="T:System.Net.Http.Headers.ProductHeaderValue" /> object.</summary>
		/// <returns>Returns <see cref="T:System.String" />.A string that represents the current object.</returns>
		public override string ToString()
		{
			return null;
		}
	}
}
