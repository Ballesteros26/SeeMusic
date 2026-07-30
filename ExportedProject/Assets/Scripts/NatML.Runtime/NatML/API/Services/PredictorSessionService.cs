using System;
using System.Threading.Tasks;
using NatML.API.Graph;
using NatML.API.Types;

namespace NatML.API.Services
{
	[Obsolete("Deprecated in NatML 1.1.6")]
	public sealed class PredictorSessionService
	{
		private readonly IGraphClient client;

		public Task<PredictorSession> Create(string tag, GraphFormat format, string? secret = null, string? device = null)
		{
			return null;
		}

		internal PredictorSessionService(IGraphClient client)
		{
		}
	}
}
