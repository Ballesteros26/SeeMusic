using System.Collections.Generic;
using Function.Internal;

namespace Function.Graph
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
