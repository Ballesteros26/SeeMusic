namespace System.Net.Http
{
	/// <summary>A helper class for retrieving and comparing standard HTTP methods and for creating new HTTP methods.</summary>
	public class HttpMethod : IEquatable<HttpMethod>
	{
		private static readonly HttpMethod delete_method;

		private static readonly HttpMethod get_method;

		private static readonly HttpMethod head_method;

		private static readonly HttpMethod options_method;

		private static readonly HttpMethod post_method;

		private static readonly HttpMethod put_method;

		private static readonly HttpMethod trace_method;

		private readonly string method;

		/// <summary>Represents an HTTP GET protocol method.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.HttpMethod" />.</returns>
		public static HttpMethod Get => null;

		/// <summary>An HTTP method. </summary>
		/// <returns>Returns <see cref="T:System.String" />.An HTTP method represented as a <see cref="T:System.String" />.</returns>
		public string Method => null;

		/// <summary>Represents an HTTP POST protocol method that is used to post a new entity as an addition to a URI.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.HttpMethod" />.</returns>
		public static HttpMethod Post => null;

		/// <summary>Represents an HTTP PUT protocol method that is used to replace an entity identified by a URI.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.HttpMethod" />.</returns>
		public static HttpMethod Put => null;

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Http.HttpMethod" /> class with a specific HTTP method.</summary>
		/// <param name="method">The HTTP method.</param>
		public HttpMethod(string method)
		{
		}

		/// <summary>The equality operator for comparing two <see cref="T:System.Net.Http.HttpMethod" /> objects.</summary>
		/// <returns>Returns <see cref="T:System.Boolean" />.true if the specified <paramref name="left" /> and <paramref name="right" /> parameters are equal; otherwise, false.</returns>
		/// <param name="left">The left <see cref="T:System.Net.Http.HttpMethod" /> to an equality operator.</param>
		/// <param name="right">The right  <see cref="T:System.Net.Http.HttpMethod" /> to an equality operator.</param>
		public static bool operator ==(HttpMethod left, HttpMethod right)
		{
			return false;
		}

		/// <summary>Determines whether the specified <see cref="T:System.Net.Http.HttpMethod" /> is equal to the current <see cref="T:System.Object" />.</summary>
		/// <returns>Returns <see cref="T:System.Boolean" />.true if the specified object is equal to the current object; otherwise, false.</returns>
		/// <param name="other">The HTTP method to compare with the current object.</param>
		public bool Equals(HttpMethod other)
		{
			return false;
		}

		/// <summary>Determines whether the specified <see cref="T:System.Object" /> is equal to the current <see cref="T:System.Object" />.</summary>
		/// <returns>Returns <see cref="T:System.Boolean" />.true if the specified object is equal to the current object; otherwise, false.</returns>
		/// <param name="obj">The object to compare with the current object.</param>
		public override bool Equals(object obj)
		{
			return false;
		}

		/// <summary>Serves as a hash function for this type.</summary>
		/// <returns>Returns <see cref="T:System.Int32" />.A hash code for the current <see cref="T:System.Object" />.</returns>
		public override int GetHashCode()
		{
			return 0;
		}

		/// <summary>Returns a string that represents the current object.</summary>
		/// <returns>Returns <see cref="T:System.String" />.A string representing the current object.</returns>
		public override string ToString()
		{
			return null;
		}
	}
}
