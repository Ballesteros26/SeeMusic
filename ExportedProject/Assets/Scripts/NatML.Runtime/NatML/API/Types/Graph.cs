using System;
using NatML.API.Graph;

namespace NatML.API.Types
{
	[Serializable]
	[Preserve]
	public sealed class Graph
	{
		public string variant;

		public GraphFormat format;

		public GraphStatus status;

		public bool encrypted;

		public string created;

		public string? error;
	}
}
