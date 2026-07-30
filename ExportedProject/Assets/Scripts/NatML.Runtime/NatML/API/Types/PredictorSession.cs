using System;
using NatML.API.Graph;

namespace NatML.API.Types
{
	[Serializable]
	[Preserve]
	[Obsolete("Deprecated in NatML 1.1.6")]
	public sealed class PredictorSession
	{
		public string id;

		public Predictor predictor;

		public string graph;

		public GraphFormat format;

		public int flags;

		public string fingerprint;

		public string created;

		public string? secret;
	}
}
