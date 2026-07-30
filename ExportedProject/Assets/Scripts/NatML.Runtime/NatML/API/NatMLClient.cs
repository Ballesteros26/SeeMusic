using System;
using NatML.API.Graph;
using NatML.API.Services;

namespace NatML.API
{
	public sealed class NatMLClient
	{
		public const string URL = "https://api.natml.ai/graph";

		public readonly UserService Users;

		public readonly PredictorService Predictors;

		public readonly GraphService Graphs;

		public readonly StorageService Storage;

		private readonly IGraphClient client;

		[Obsolete("Deprecated in NatML 1.1.6.")]
		public readonly PredictorSessionService PredictorSessions;

		public NatMLClient(string accessKey = null, string url = null)
		{
		}

		public NatMLClient(IGraphClient client)
		{
		}
	}
}
