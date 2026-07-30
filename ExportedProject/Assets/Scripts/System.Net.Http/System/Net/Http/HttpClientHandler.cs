using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Http
{
	/// <summary>The default message handler used by <see cref="T:System.Net.Http.HttpClient" />.  </summary>
	public class HttpClientHandler : HttpMessageHandler
	{
		private readonly IMonoHttpClientHandler _delegatingHandler;

		private ClientCertificateOption _clientCertificateOptions;

		/// <summary>Gets or sets the collection of security certificates that are associated with this handler.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.ClientCertificateOption" />.The collection of security certificates associated with this handler.</returns>
		public ClientCertificateOption ClientCertificateOptions
		{
			get
			{
				return default(ClientCertificateOption);
			}
			set
			{
			}
		}

		public X509CertificateCollection ClientCertificates => null;

		private static IMonoHttpClientHandler CreateDefaultHandler()
		{
			return null;
		}

		/// <summary>Creates an instance of a <see cref="T:System.Net.Http.HttpClientHandler" /> class.</summary>
		public HttpClientHandler()
		{
		}

		internal HttpClientHandler(IMonoHttpClientHandler handler)
		{
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Net.Http.HttpClientHandler" /> and optionally disposes of the managed resources.</summary>
		/// <param name="disposing">true to release both managed and unmanaged resources; false to releases only unmanaged resources.</param>
		protected override void Dispose(bool disposing)
		{
		}

		private void ThrowForModifiedManagedSslOptionsIfStarted()
		{
		}

		internal void SetWebRequestTimeout(TimeSpan timeout)
		{
		}

		/// <summary>Creates an instance of  <see cref="T:System.Net.Http.HttpResponseMessage" /> based on the information provided in the <see cref="T:System.Net.Http.HttpRequestMessage" /> as an operation that will not block.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		/// <param name="request">The HTTP request message.</param>
		/// <param name="cancellationToken">A cancellation token to cancel the operation.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="request" /> was null.</exception>
		protected internal override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			return null;
		}
	}
}
