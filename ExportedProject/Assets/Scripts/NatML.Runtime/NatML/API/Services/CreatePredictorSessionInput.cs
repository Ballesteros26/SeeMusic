using NatML.API.Types;

namespace NatML.API.Services
{
	internal sealed class CreatePredictorSessionInput
	{
		public string tag;

		public GraphFormat format;

		public string? secret;

		public string? client;

		public string? device;
	}
}
