using NatML.API.Types;

namespace NatML.API.Services
{
	internal sealed class PredictorsInput
	{
		public bool? mine;

		public PredictorStatus? status;

		public string? query;

		public int? offset;

		public int? count;
	}
}
