using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Parse.Common.Internal;
using Parse.Core.Internal;

namespace Parse
{
	public class ParseFile : IJsonConvertible
	{
		private FileState state;

		private readonly Stream dataStream;

		private readonly TaskQueue taskQueue;

		public bool IsDirty => false;

		[ParseFieldName("name")]
		public string Name => null;

		public string MimeType => null;

		[ParseFieldName("url")]
		public Uri Url => null;

		internal static IParseFileController FileController => null;

		internal ParseFile(string name, Uri uri, string mimeType = null)
		{
		}

		public ParseFile(string name, byte[] data, string mimeType = null)
		{
		}

		public ParseFile(string name, Stream data, string mimeType = null)
		{
		}

		IDictionary<string, object> IJsonConvertible.ToJSON()
		{
			return null;
		}

		public Task SaveAsync()
		{
			return null;
		}

		public Task SaveAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		public Task SaveAsync(IProgress<ParseUploadProgressEventArgs> progress)
		{
			return null;
		}

		public Task SaveAsync(IProgress<ParseUploadProgressEventArgs> progress, CancellationToken cancellationToken)
		{
			return null;
		}
	}
}
