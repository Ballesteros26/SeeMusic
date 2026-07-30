using System.Collections.Generic;
using Function.Internal;

namespace Function.Graph
{
	[Preserve]
	public sealed class GraphRequest
	{
		public string query;

		public Dictionary<string, object?>? variables;
	}
}
