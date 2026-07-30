using System.Collections.Generic;

namespace NatML.API.Graph
{
	[Preserve]
	public sealed class GraphResponse<T>
	{
		public sealed class Error
		{
			public string message;
		}

		public Dictionary<string, T>? data;

		public Error[]? errors;
	}
}
