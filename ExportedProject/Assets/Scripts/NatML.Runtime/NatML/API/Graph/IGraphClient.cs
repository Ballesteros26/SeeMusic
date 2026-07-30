using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace NatML.API.Graph
{
	public interface IGraphClient
	{
		Task<T> Query<T>(string query, string key, Dictionary<string, object?>? variables = null) where T : notnull;

		Task<MemoryStream> Download(string url);

		Task Upload(MemoryStream stream, string url, string? mime = null);
	}
}
