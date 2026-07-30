using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace System.Net.Http
{
	/// <summary>Represents a HTTP response message including the status code and data.</summary>
	public class HttpResponseMessage : IDisposable
	{
		private HttpResponseHeaders headers;

		private string reasonPhrase;

		private HttpStatusCode statusCode;

		private Version version;

		private bool disposed;

		[CompilerGenerated]
		private HttpRequestMessage _003CRequestMessage_003Ek__BackingField;

		/// <summary>Gets or sets the content of a HTTP response message. </summary>
		/// <returns>Returns <see cref="T:System.Net.Http.HttpContent" />.The content of the HTTP response message.</returns>
		public HttpContent Content { get; set; }

		/// <summary>Gets the collection of HTTP response headers. </summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.HttpResponseHeaders" />.The collection of HTTP response headers.</returns>
		public HttpResponseHeaders Headers => null;

		/// <summary>Gets a value that indicates if the HTTP response was successful.</summary>
		/// <returns>Returns <see cref="T:System.Boolean" />.A value that indicates if the HTTP response was successful. true if <see cref="P:System.Net.Http.HttpResponseMessage.StatusCode" /> was in the range 200-299; otherwise false.</returns>
		public bool IsSuccessStatusCode => false;

		/// <summary>Gets or sets the reason phrase which typically is sent by servers together with the status code. </summary>
		/// <returns>Returns <see cref="T:System.String" />.The reason phrase sent by the server.</returns>
		public string ReasonPhrase
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets the request message which led to this response message.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.HttpRequestMessage" />.The request message which led to this response message.</returns>
		public HttpRequestMessage RequestMessage
		{
			[CompilerGenerated]
			set
			{
				_003CRequestMessage_003Ek__BackingField = value;
			}
		}

		/// <summary>Gets or sets the status code of the HTTP response.</summary>
		/// <returns>Returns <see cref="T:System.Net.HttpStatusCode" />.The status code of the HTTP response.</returns>
		public HttpStatusCode StatusCode
		{
			get
			{
				return default(HttpStatusCode);
			}
			set
			{
			}
		}

		/// <summary>Gets or sets the HTTP message version. </summary>
		/// <returns>Returns <see cref="T:System.Version" />.The HTTP message version. The default is 1.1. </returns>
		public Version Version => null;

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Http.HttpResponseMessage" /> class with a specific <see cref="P:System.Net.Http.HttpResponseMessage.StatusCode" />.</summary>
		/// <param name="statusCode">The status code of the HTTP response.</param>
		public HttpResponseMessage(HttpStatusCode statusCode)
		{
		}

		/// <summary>Releases the unmanaged resources and disposes of unmanaged resources used by the <see cref="T:System.Net.Http.HttpResponseMessage" />.</summary>
		public void Dispose()
		{
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Net.Http.HttpResponseMessage" /> and optionally disposes of the managed resources.</summary>
		/// <param name="disposing">true to release both managed and unmanaged resources; false to releases only unmanaged resources.</param>
		protected virtual void Dispose(bool disposing)
		{
		}

		/// <summary>Throws an exception if the <see cref="P:System.Net.Http.HttpResponseMessage.IsSuccessStatusCode" /> property for the HTTP response is false.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.HttpResponseMessage" />.The HTTP response message if the call is successful.</returns>
		public HttpResponseMessage EnsureSuccessStatusCode()
		{
			return null;
		}

		/// <summary>Returns a string that represents the current object.</summary>
		/// <returns>Returns <see cref="T:System.String" />.A string representation of the current object.</returns>
		public override string ToString()
		{
			return null;
		}
	}
}
