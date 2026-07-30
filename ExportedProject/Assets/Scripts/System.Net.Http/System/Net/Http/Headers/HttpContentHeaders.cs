namespace System.Net.Http.Headers
{
	/// <summary>Represents the collection of Content Headers as defined in RFC 2616.</summary>
	public sealed class HttpContentHeaders : HttpHeaders
	{
		private readonly HttpContent content;

		/// <summary>Gets or sets the value of the Content-Length content header on an HTTP response.</summary>
		/// <returns>Returns <see cref="T:System.Int64" />.The value of the Content-Length content header on an HTTP response.</returns>
		public long? ContentLength => null;

		/// <summary>Gets or sets the value of the Content-Type content header on an HTTP response.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.MediaTypeHeaderValue" />.The value of the Content-Type content header on an HTTP response.</returns>
		public MediaTypeHeaderValue ContentType
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal HttpContentHeaders(HttpContent content)
		{
		}
	}
}
