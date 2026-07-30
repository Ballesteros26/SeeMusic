using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Parse.Core.Internal
{
	public class ParseFileController : IParseFileController
	{
		private readonly IParseCommandRunner commandRunner;

		public ParseFileController(IParseCommandRunner commandRunner)
		{
		}

		public Task<FileState> SaveAsync(FileState state, Stream dataStream, string sessionToken, IProgress<ParseUploadProgressEventArgs> progress, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}
