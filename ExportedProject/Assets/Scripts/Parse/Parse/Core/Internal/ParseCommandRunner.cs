using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Parse.Common.Internal;

namespace Parse.Core.Internal
{
	public class ParseCommandRunner : IParseCommandRunner
	{
		private readonly IHttpClient httpClient;

		private readonly IInstallationIdController installationIdController;

		public ParseCommandRunner(IHttpClient httpClient, IInstallationIdController installationIdController)
		{
		}

		public Task<Tuple<HttpStatusCode, IDictionary<string, object>>> RunCommandAsync(ParseCommand command, IProgress<ParseUploadProgressEventArgs> uploadProgress = null, IProgress<ParseDownloadProgressEventArgs> downloadProgress = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		private Task<ParseCommand> PrepareCommand(ParseCommand command)
		{
			return null;
		}
	}
}
