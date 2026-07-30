namespace System.Net.Http.Headers
{
	/// <summary>Represents the collection of Request Headers as defined in RFC 2616.</summary>
	public sealed class HttpRequestHeaders : HttpHeaders
	{
		private bool? expectContinue;

		/// <summary>Gets or sets the value of the Authorization header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.AuthenticationHeaderValue" />.The value of the Authorization header for an HTTP request.</returns>
		public AuthenticationHeaderValue Authorization
		{
			set
			{
			}
		}

		/// <summary>Gets the value of the Connection header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" />.The value of the Connection header for an HTTP request.</returns>
		public HttpHeaderValueCollection<string> Connection => null;

		/// <summary>Gets or sets a value that indicates if the Connection header for an HTTP request contains Close.</summary>
		/// <returns>Returns <see cref="T:System.Boolean" />.true if the Connection header contains Close, otherwise false.</returns>
		public bool? ConnectionClose => null;

		/// <summary>Gets or sets a value that indicates if the Expect header for an HTTP request contains Continue.</summary>
		/// <returns>Returns <see cref="T:System.Boolean" />.true if the Expect header contains Continue, otherwise false.</returns>
		public bool? ExpectContinue => null;

		/// <summary>Gets or sets the value of the Host header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.String" />.The value of the Host header for an HTTP request.</returns>
		public string Host => null;

		/// <summary>Gets or sets the value of the If-Modified-Since header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.DateTimeOffset" />.The value of the If-Modified-Since header for an HTTP request.</returns>
		public DateTimeOffset? IfModifiedSince
		{
			set
			{
			}
		}

		/// <summary>Gets the value of the Transfer-Encoding header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" />.The value of the Transfer-Encoding header for an HTTP request.</returns>
		public HttpHeaderValueCollection<TransferCodingHeaderValue> TransferEncoding => null;

		/// <summary>Gets or sets a value that indicates if the Transfer-Encoding header for an HTTP request contains chunked.</summary>
		/// <returns>Returns <see cref="T:System.Boolean" />.true if the Transfer-Encoding header contains chunked, otherwise false.</returns>
		public bool? TransferEncodingChunked => null;

		/// <summary>Gets the value of the User-Agent header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" />.The value of the User-Agent header for an HTTP request.</returns>
		public HttpHeaderValueCollection<ProductInfoHeaderValue> UserAgent => null;

		internal HttpRequestHeaders()
		{
		}

		internal void AddHeaders(HttpRequestHeaders headers)
		{
		}
	}
}
