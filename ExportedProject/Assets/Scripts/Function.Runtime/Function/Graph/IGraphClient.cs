using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Function.Graph
{
	public interface IGraphClient
	{
		string? Id { get; }

		Task<T> Query<T>(string query, string key, Dictionary<string, object?>? variables = null) where T : notnull;

		Task<MemoryStream> Download(string url);

		Task Upload(Stream stream, string url, string? mime = null);
	}
}
