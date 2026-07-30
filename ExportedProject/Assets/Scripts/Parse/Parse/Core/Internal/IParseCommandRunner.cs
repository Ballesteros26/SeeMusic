using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Parse.Core.Internal
{
	public interface IParseCommandRunner
	{
		Task<Tuple<HttpStatusCode, IDictionary<string, object>>> RunCommandAsync(ParseCommand command, IProgress<ParseUploadProgressEventArgs> uploadProgress = null, IProgress<ParseDownloadProgressEventArgs> downloadProgress = null, CancellationToken cancellationToken = default(CancellationToken));
	}
}
