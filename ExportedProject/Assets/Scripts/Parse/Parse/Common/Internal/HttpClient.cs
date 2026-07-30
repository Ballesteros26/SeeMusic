using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Parse.Common.Internal
{
	public class HttpClient : IHttpClient
	{
		private static HashSet<string> HttpContentHeaders;

		private System.Net.Http.HttpClient client;

		public HttpClient()
		{
		}

		public HttpClient(System.Net.Http.HttpClient client)
		{
		}

		public Task<Tuple<HttpStatusCode, string>> ExecuteAsync(HttpRequest httpRequest, IProgress<ParseUploadProgressEventArgs> uploadProgress, IProgress<ParseDownloadProgressEventArgs> downloadProgress, CancellationToken cancellationToken)
		{
			return null;
		}
	}
}
