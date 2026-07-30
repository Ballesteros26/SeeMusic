using System.Collections.Generic;

namespace NatML.API.Graph
{
	[Preserve]
	public sealed class GraphRequest
	{
		public string query;

		public Dictionary<string, object?>? variables;
	}
}
