using System.ComponentModel;
using System.Net.Cache;
using System.Text;

namespace System.Net
{
	/// <summary>Provides common methods for sending data to and receiving data from a resource identified by a URI.</summary>
	public class WebClient : Component
	{
		private ICredentials _credentials;

		private WebHeaderCollection _headers;

		private Encoding _encoding;

		private string _method;

		private long _contentLength;

		private IWebProxy _proxy;

		private bool _proxySet;

		private static readonly char[] s_parseContentTypeSeparators;

		private static readonly Encoding[] s_knownEncodings;

		/// <summary>Gets or sets the network credentials that are sent to the host and used to authenticate the request.</summary>
		/// <returns>An <see cref="T:System.Net.ICredentials" /> containing the authentication credentials for the request. The default is null.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		public ICredentials Credentials => null;

		/// <summary>Gets or sets the application's cache policy for any resources obtained by this WebClient instance using <see cref="T:System.Net.WebRequest" /> objects.</summary>
		/// <returns>A <see cref="T:System.Net.Cache.RequestCachePolicy" /> object that represents the application's caching requirements.</returns>
		public RequestCachePolicy CachePolicy { get; }

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.WebClient" /> class.</summary>
		public WebClient()
		{
		}

		/// <summary>Returns a <see cref="T:System.Net.WebRequest" /> object for the specified resource.</summary>
		/// <returns>A new <see cref="T:System.Net.WebRequest" /> object for the specified resource.</returns>
		/// <param name="address">A <see cref="T:System.Uri" /> that identifies the resource to request.</param>
		protected virtual WebRequest GetWebRequest(Uri address)
		{
			return null;
		}

		private void CopyHeadersTo(WebRequest request)
		{
		}
	}
}
