using System.Collections.Generic;

namespace System.Net.Http.Headers
{
	/// <summary>Represents the value of the Content-Disposition header.</summary>
	public class ContentDispositionHeaderValue : ICloneable
	{
		private string dispositionType;

		private List<NameValueHeaderValue> parameters;

		/// <summary>A set of parameters included the Content-Disposition header.</summary>
		/// <returns>Returns <see cref="T:System.Collections.Generic.ICollection`1" />.A collection of parameters. </returns>
		public ICollection<NameValueHeaderValue> Parameters => null;

		private ContentDispositionHeaderValue()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Http.Headers.ContentDispositionHeaderValue" /> class.</summary>
		/// <param name="source">A <see cref="T:System.Net.Http.Headers.ContentDispositionHeaderValue" />. </param>
		protected ContentDispositionHeaderValue(ContentDispositionHeaderValue source)
		{
		}

		/// <summary>Creates a new object that is a copy of the current <see cref="T:System.Net.Http.Headers.ContentDispositionHeaderValue" />  instance.</summary>
		/// <returns>Returns <see cref="T:System.Object" />.A copy of the current instance.</returns>
		object ICloneable.Clone()
		{
			return null;
		}

		/// <summary>Determines whether the specified <see cref="T:System.Object" /> is equal to the current <see cref="T:System.Net.Http.Headers.ContentDispositionHeaderValue" />  object.</summary>
		/// <returns>Returns <see cref="T:System.Boolean" />.true if the specified <see cref="T:System.Object" /> is equal to the current object; otherwise, false.</returns>
		/// <param name="obj">The object to compare with the current object.</param>
		public override bool Equals(object obj)
		{
			return false;
		}

		/// <summary>Serves as a hash function for an  <see cref="T:System.Net.Http.Headers.ContentDispositionHeaderValue" /> object.</summary>
		/// <returns>Returns <see cref="T:System.Int32" />.A hash code for the current object.</returns>
		public override int GetHashCode()
		{
			return 0;
		}

		/// <summary>Returns a string that represents the current <see cref="T:System.Net.Http.Headers.ContentDispositionHeaderValue" /> object.</summary>
		/// <returns>Returns <see cref="T:System.String" />.A string that represents the current object.</returns>
		public override string ToString()
		{
			return null;
		}

		/// <summary>Determines whether a string is valid <see cref="T:System.Net.Http.Headers.ContentDispositionHeaderValue" /> information.</summary>
		/// <returns>Returns <see cref="T:System.Boolean" />.true if <paramref name="input" /> is valid <see cref="T:System.Net.Http.Headers.ContentDispositionHeaderValue" /> information; otherwise, false.</returns>
		/// <param name="input">The string to validate.</param>
		/// <param name="parsedValue">The <see cref="T:System.Net.Http.Headers.ContentDispositionHeaderValue" /> version of the string.</param>
		public static bool TryParse(string input, out ContentDispositionHeaderValue parsedValue)
		{
			parsedValue = null;
			return false;
		}
	}
}
